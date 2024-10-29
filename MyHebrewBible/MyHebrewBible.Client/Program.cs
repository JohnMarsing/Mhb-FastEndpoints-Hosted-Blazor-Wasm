using Blazored.LocalStorage;
using Blazored.Toast;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyHebrewBible.Client;
//using MyHebrewBible.Client.Features.Parasha.State;
using MyHebrewBible.Client.State;
//using MyHebrewBible.Client.State.VerseList;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSingleton(
		new ApiClient(
				builder.HostEnvironment.BaseAddress,
				new() { BaseAddress = new(builder.HostEnvironment.BaseAddress) }));


builder.Services.AddBlazoredLocalStorage();
//builder.Services.AddScoped<IBookChapterState, BookChapterState>();
builder.Services.AddScoped<AppState>();

//builder.Services.AddScoped<IAppState, AppState>();
/*
builder.Services.AddScoped<IBookChapterState, BookChapterState>();
builder.Services.AddScoped<IVerseListState, VerseListState>();
builder.Services.AddParasha();
*/


builder.Services.AddBlazoredToast();  // Need this here and in the Server
await builder.Build().RunAsync();
