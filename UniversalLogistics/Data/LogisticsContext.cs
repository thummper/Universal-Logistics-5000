using Microsoft.EntityFrameworkCore;
using UniversalLogistics.Models;

namespace UniversalLogistics.Data
{
	public class LogisticsContext : DbContext
	{
		public DbSet<Material> Materials { get; set; }

		public LogisticsContext(DbContextOptions options) : base(options)
		{
		}
	}
}