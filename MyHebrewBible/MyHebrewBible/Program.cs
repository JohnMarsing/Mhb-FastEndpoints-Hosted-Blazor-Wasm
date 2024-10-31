using MyHebrewBible.Components;
using MyHebrewBible.Database;
using FastEndpoints.ClientGen;
using NJsonSchema.CodeGeneration.CSharp;
using MyHebrewBible.Endpoints;
using Serilog;
using Blazored.Toast;
using Blazored.LocalStorage;
using MyHebrewBible.Client.State;
//using MyHebrewBible.Client.Features.Articles;

string appSettingJson;
if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == Environments.Development)
{
	appSettingJson = "appsettings.Development.json";
}
else
{
	appSettingJson = "appsettings.Production.json";
}

var configuration = new ConfigurationBuilder()
	.AddJsonFile(appSettingJson)
	.Build();

Log.Logger = new LoggerConfiguration()
	.ReadFrom.Configuration(configuration)
	.CreateLogger();

Log.Information("{Class}, {Environment}, {AppSettings}; save to Serilog console and file sinks."
			, nameof(Program), Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"), appSettingJson);

try
{
	var builder = WebApplication.CreateBuilder(args);

	builder.Services.AddBlazoredToast();  // Need this here and in the Client

	builder.Host.UseSerilog((ctx, lc) =>
	lc.ReadFrom.Configuration(configuration));

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
	builder.Services.AddBlazoredLocalStorage();
	//builder.Services.AddScoped<IBookChapterState, BookChapterState>();
	builder.Services.AddScoped<AppState>();

	builder.Services.AddRazorComponents()
			.AddInteractiveWebAssemblyComponents();

	//builder.Services.AddArticle();

	var app = builder.Build();
	//await using var app = builder.Build();

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

	#region FastEndpoints
	app.UseAuthentication()
		 .UseAuthorization()
		 .UseFastEndpoints(
				 c =>
				 {
					 c.Endpoints.ShortNames = true;
					 c.Endpoints.RoutePrefix = "api";
					 c.Serializer.Options.PropertyNamingPolicy = null;
				 });

	if (app.Environment.IsDevelopment())
		app.UseSwaggerGen();

	/* See Program, Server.md ! FN 01	*/

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

	#endregion

	app.MapRazorComponents<App>()
			.AddInteractiveWebAssemblyRenderMode()
			.AddAdditionalAssemblies(typeof(MyHebrewBible.Client._Imports).Assembly);

	app.Run();
	//await app.RunAsync();

	Log.Information("{Class}, Stopped cleanly", nameof(Program));
	return 0;
}
catch (Exception ex)
{
	Log.Fatal(ex, "{Class}, An unhandled exception occurred during bootstrapping", nameof(Program));
	return 1;
}
finally
{
	Log.CloseAndFlush();
}