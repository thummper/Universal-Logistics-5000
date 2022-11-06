using UniversalLogistics.Data;
using UniversalLogistics.Seeding;

namespace UniversalLogistics.Extensions
{
	internal static class DbInitializerExtension
	{
		public static IApplicationBuilder SeedSQLDatabase(this IApplicationBuilder app)
		{
			ArgumentNullException.ThrowIfNull(app, nameof(app));
			using var scope = app.ApplicationServices.CreateScope();
			var services = scope.ServiceProvider;
			try
			{
				var context = services.GetRequiredService<LogisticsContext>();
				var config = services.GetRequiredService<IConfiguration>();
				DbInitializer.Initialize(context, config);
			}
			catch (Exception ex)
			{
			}

			return app;
		}
	}
}