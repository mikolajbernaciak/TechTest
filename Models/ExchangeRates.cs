using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;
using TechTest.Models.Enums;

namespace TechTest.Models
{
	public class ExchangeRates
	{
		[Key]
		public int Id { get; set; }

		public CurrencyEnum Currency { get; set; }

		public double ExchangeRateFromGBP { get; set; }
		
	}
}