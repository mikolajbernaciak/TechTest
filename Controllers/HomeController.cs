using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TechTest.Models;
using TechTest.Models.Enums;
using TechTest.Services;

namespace TechTest.Controllers
{
	public class HomeController : Controller
	{
		private readonly ICurrencyService currencyService;

		public HomeController(ICurrencyService currencyService)
		{
			this.currencyService = currencyService;
		}

		[HttpGet]
		public ActionResult Index(double? amount = null, double? convertedAmount = null, CurrencyEnum? from = null, CurrencyEnum? to = null)
		{
			var currencies = Enum.GetValues(typeof(CurrencyEnum)).Cast<CurrencyEnum>();

			var currencyList = new List<SelectListItem>
			{
				new SelectListItem { Selected = true, Value = "", Text = "Please select..." }
			};

			var viewModel = new IndexViewModel
			{
				FromCurrencies = currencyList.Concat(currencies.Select(x => new SelectListItem
				{
					Selected = x == from, 
					Text = x.Text(),
					Value = x.ToString()
				})),
				ToCurrencies = currencyList.Concat(currencies.Select(x => new SelectListItem
				{
					Selected = x == to,
					Text = x.Text(),
					Value = x.ToString()
				})),
				To = to,
				From = from,
				Amount = amount,
				ConvertedAmount = convertedAmount ?? 0
			};

			return View(viewModel);
		}

		[HttpPost]
		public ActionResult Convert(IndexViewModel viewModel)
		{
			if (!ModelState.IsValid)
			{
				return View(viewModel);
			}

			var result = currencyService.Convert(viewModel.From.Value, viewModel.To.Value, viewModel.Amount.Value);

			return RedirectToAction("Index", new { amount = viewModel.Amount, convertedAmount = result, from = viewModel.From, to = viewModel.To});
		}
	}

	

	
}