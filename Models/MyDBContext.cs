using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace TechTest.Models
{
	public class MyDBContext : DbContext
	{
		public MyDBContext() : base("DbConnection")
		{

		}

		public DbSet<ExchangeRates> ExchangeRates { get; set; }
	}
}