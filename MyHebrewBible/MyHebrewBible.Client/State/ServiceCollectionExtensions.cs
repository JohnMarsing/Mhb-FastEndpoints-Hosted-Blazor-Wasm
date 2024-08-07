namespace MyHebrewBible.Client.State;

public static class ServiceCollectionExtensions
{
//ToDo: this isn't being used yet.
	public static IServiceCollection AddState(this IServiceCollection services)
	{
		services
		.AddScoped<IBookChapterState, BookChapterState>();
		//.AddScoped<ISecurityClaims, SecurityClaims>();
		return services;
	}
}
