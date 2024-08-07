using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyHebrewBible.Client;
using MyHebrewBible.Client.State;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSingleton(
		new ApiClient(
				builder.HostEnvironment.BaseAddress,
				new() { BaseAddress = new(builder.HostEnvironment.BaseAddress) }));

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<IBookChapterState, BookChapterState>();

await builder.Build().RunAsync();
