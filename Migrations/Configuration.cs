using TechTest.Models;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using TechTest.Models.Enums;

namespace TechTest.Migrations
{
	internal sealed class Configuration : DbMigrationsConfiguration<MyDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.ExchangeRates.Add(new ExchangeRates { Id = 1, Currency = CurrencyEnum.AUD, ExchangeRateFromGBP = 2});
            context.ExchangeRates.Add(new ExchangeRates { Id = 2, Currency = CurrencyEnum.USD, ExchangeRateFromGBP = 1.5 });
            context.ExchangeRates.Add(new ExchangeRates { Id = 3, Currency = CurrencyEnum.EUR, ExchangeRateFromGBP = 1.05 });

            context.SaveChanges();
        }
    }
}
