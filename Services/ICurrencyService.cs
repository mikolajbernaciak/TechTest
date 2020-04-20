using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechTest.Models.Enums;

namespace TechTest.Services
{
	public interface ICurrencyService
	{
		/// <summary>
		/// Converts given amount from one currency to another
		/// </summary>
		/// <param name="from">Currency of the amount given</param>
		/// <param name="to">Currency to be converted into</param>
		/// <param name="amount">Amount to convert</param>
		/// <returns></returns>
		double Convert(CurrencyEnum from, CurrencyEnum to, double amount);
	}
}