using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechTest.Models.Enums
{
	public enum CurrencyEnum
	{
		USD,
		AUD,
		EUR,
		GBP
	}

	public static class CurrencyEnumExtensions
	{
		public static string Text(this CurrencyEnum currencyEnum)
		{
			switch (currencyEnum)
			{
				case CurrencyEnum.AUD:
					return "Australian dollar (AUD)";
				case CurrencyEnum.USD:
					return "American dollar (USD)";
				case CurrencyEnum.EUR:
					return "Euro (EUR)";
				case CurrencyEnum.GBP:
					return "British pound (GBP)";
			}

			return null;
		}
	}
}