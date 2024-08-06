using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyHebrewBible.Client;
using Blazored.LocalStorage;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSingleton(
		new ApiClient(
				builder.HostEnvironment.BaseAddress,
				new() { BaseAddress = new(builder.HostEnvironment.BaseAddress) }));

builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();
