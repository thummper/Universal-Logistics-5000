using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UniversalLogistics.Models;
using Microsoft.Extensions.DependencyInjection;

namespace UniversalLogistics.Data
{
	public class CategorySeeding : IDBInitialiser
	{
		/// <summary>
		/// Reads a json file and seeds the database
		/// </summary>
		/// <param name="jsonPath"></param>
		///
		///
		LogisticsContext _context;

		public CategorySeeding(LogisticsContext context)
		{
			_context = context;
		}


		public void SeedData(string jsonPath)
		{
			//using (StreamReader r = new StreamReader(jsonPath))
			//{


			//    string jsonString = r.ReadToEnd();
			//    dynamic obj = JsonConvert.DeserializeObject(jsonString);


			//    foreach(var item in obj)
			//    {
			//        // Load all materials into the database.
			//        var newMat = new Material()
			//        {
			//            matName = item.Name,
			//            matVolume = item.Volume,
			//            matWeight = item.Weight,
			//            matTicker = item.Ticker,
			//            matCategory = item.Category
			//        };


			//    }


			//}
		}
	}
}