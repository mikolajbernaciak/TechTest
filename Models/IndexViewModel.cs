using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechTest.Models.Enums;

namespace TechTest.Models
{
	public class IndexViewModel
	{
		public IEnumerable<SelectListItem> FromCurrencies { get; set; }

		public IEnumerable<SelectListItem> ToCurrencies { get; set; }

		[Required(ErrorMessage = "Test")]
		public CurrencyEnum? From { get; set; }

		[Required(ErrorMessage = "Test")]
		public CurrencyEnum? To { get; set; }

		public double? Amount { get; set; }

		public double? ConvertedAmount { get; set; }
	}
}