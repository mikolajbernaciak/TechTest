using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechTest.Models;
using TechTest.Models.Enums;

namespace TechTest.Services
{
	public class CurrencyService : ICurrencyService
	{

		private readonly MyDBContext context;

		public CurrencyService(MyDBContext context)
		{
			this.context = context;
		}

		public double Convert(CurrencyEnum from, CurrencyEnum to, double amount)
		{
			//Audit here

			if (from == to)
				return amount;

			var exchangeRates = context.Set<ExchangeRates>().Where(x => x.Currency == from || x.Currency == to).ToList();

			double result;

			if (from == CurrencyEnum.GBP)
			{
				result = FromPound(amount, exchangeRates.Single(x => x.Currency == to).ExchangeRateFromGBP);
			}
			else if (to == CurrencyEnum.GBP)
			{
				result = ToPound(amount, exchangeRates.Single(x => x.Currency == from).ExchangeRateFromGBP);
			}
			else
			{
				var cur1InPound = ToPound(amount, exchangeRates.Single(x => x.Currency == from).ExchangeRateFromGBP);
				result = Convert(CurrencyEnum.GBP, to, cur1InPound);
			}

			return Math.Round(result, 2);
		}

		private double FromPound(double amount, double exchangeRate)
		{
			return amount * exchangeRate;
		}

		private double ToPound(double amount, double exchangeRate)
		{
			return amount / exchangeRate;
		}
	}
}