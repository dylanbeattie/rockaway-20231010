namespace Rockaway.WebApp.Hosting;

public static class WebApplicationBuilderExtensions {
	private static readonly string[] sqliteEnvironments = { "UnitTest", Environments.Development };

	public static bool UseSqlite(this IHostEnvironment env)
		=> sqliteEnvironments.Contains(env.EnvironmentName);
}
