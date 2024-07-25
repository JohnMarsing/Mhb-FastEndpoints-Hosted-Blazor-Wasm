using MyHebrewBible.Components;
using MyHebrewBible.Database;
using FastEndpoints.ClientGen;
using NJsonSchema.CodeGeneration.CSharp;
using Microsoft.AspNetCore.Connections;
using MyHebrewBible.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services
	 .AddAuthenticationJwtBearer(s => s.SigningKey = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx")
	 .AddAuthorization()
	 .AddFastEndpoints();

if (builder.Environment.IsDevelopment())
{
	builder.Services.SwaggerDocument(
			o =>
			{
				o.DocumentSettings = d => d.DocumentName = "MyHebrewBibleApi";
				o.ShortSchemaNames = true;
				o.RemoveEmptyRequestSchema = true;
			});
}

builder.Services.AddSingleton<IDbConnectionFactory>(_ =>
		new SqliteConnectionFactory(connectionString: builder.Configuration.GetConnectionString("Database")!));

builder.Services.AddTransient<Repository>();

builder.Services.AddRazorComponents()
		.AddInteractiveWebAssemblyComponents();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseWebAssemblyDebugging();
}
else
{
	app.UseExceptionHandler("/Error", createScopeForErrors: true);
	app.UseHsts();
}

app.UseHttpsRedirection(); // Not in FastEndpoints e.g.

app.UseStaticFiles();

//app.MapFallbackToFile("index.html"); in FastEndpoints

app.UseAntiforgery(); // Not in FastEndpoints e.g.

// FastEndpoints Begin
app.UseAuthentication()
	 .UseAuthorization()
	 .UseFastEndpoints(
			 c =>
			 {
				 c.Endpoints.ShortNames = true;
				 c.Serializer.Options.PropertyNamingPolicy = null;
			 });

if (app.Environment.IsDevelopment())
	app.UseSwaggerGen();

/*
From the server project MyHebrewBible (NOT MyHebrewBible.Client).
  To update the HttpClient/ApiClient.cs file run the following...

dotnet run --generateclients true

Note, for the first time, create MyHebrewBible.Client/HttpClient folder 
  and an empty ApiClient.cs file
*/

await app.GenerateClientsAndExitAsync(
		documentName: "MyHebrewBibleApi",
		destinationPath: "../MyHebrewBible.Client/HttpClient",
		csSettings: c =>
		{
			c.ClassName = "ApiClient";
			c.CSharpGeneratorSettings.Namespace = "MyHebrewBible.Client";
			c.CSharpGeneratorSettings.JsonLibrary = CSharpJsonLibrary.SystemTextJson;
		},
		tsSettings: null);

// FastEndpoints End

app.MapRazorComponents<App>()
		.AddInteractiveWebAssemblyRenderMode()
		.AddAdditionalAssemblies(typeof(MyHebrewBible.Client._Imports).Assembly);

app.Run();
