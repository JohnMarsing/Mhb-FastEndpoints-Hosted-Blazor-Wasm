using Blazored.LocalStorage;
using Blazored.Toast;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyHebrewBible.Client;
using MyHebrewBible.Client.State;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSingleton(
		new ApiClient(
				builder.HostEnvironment.BaseAddress,
				new() { BaseAddress = new(builder.HostEnvironment.BaseAddress) }));

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<AppState>();

builder.Services.AddBlazoredToast();  // Need this here and in the Server
await builder.Build().RunAsync();
