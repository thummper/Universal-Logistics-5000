using System.ComponentModel.DataAnnotations;

namespace UniversalLogistics.Models
{
	public class Material
	{
		[Key] public int ID { get; set; }


		public string Ticker { get; set; } = null!;
		public string Name { get; set; } = null!;
		public string Category { get; set; } = null!;
		public float Weight { get; set; }
		public float Volume { get; set; }
	}
}