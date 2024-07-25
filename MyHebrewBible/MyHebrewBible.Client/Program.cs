using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyHebrewBible.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSingleton(
		new ApiClient(
				builder.HostEnvironment.BaseAddress,
				new() { BaseAddress = new(builder.HostEnvironment.BaseAddress) }));

await builder.Build().RunAsync();
