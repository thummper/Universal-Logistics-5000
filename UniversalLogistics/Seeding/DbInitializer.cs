using System.Diagnostics;
using Newtonsoft.Json;
using UniversalLogistics.Data;
using UniversalLogistics.Models;

namespace UniversalLogistics.Seeding
{
	public class DbInitializer
	{
		internal static void Initialize(LogisticsContext context, IConfiguration config)
		{
			Debug.WriteLine("INIT WITH CONTEXT");
			var matJSONPath = config.GetValue<string>("JSONPaths:Materials");
			// Decompose JSON
			using (StreamReader r = new StreamReader(matJSONPath))
			{
				string json = r.ReadToEnd();
				List<Material> materials = JsonConvert.DeserializeObject<List<Material>>(json);

				foreach (var item in materials)
				{
					if (context.Materials.Any(i => i.Name == item.Name)) return;

					Debug.WriteLine($"Adding {item.Name} to the database");
					context.Materials.Add(item);
				}

				context.SaveChanges();
			}
		}
	}
}