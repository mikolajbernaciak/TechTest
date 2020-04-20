using System;
using System.ComponentModel.DataAnnotations;
using TechTest.Models.Enums;

namespace TechTest.Models
{
	public class Audit
	{
		[Key]
		public int Id { get; set; }

		public CurrencyEnum From { get; set; }

		public CurrencyEnum To { get; set; }

		public double Amount { get; set; }

		public double ConvertedAmount { get; set; }

		public DateTime LogDate { get; set; }

		//Some user data e.g.
	//	public string IpAddress { get; set; }

	//	public Guid UserGuid { get; set; }

	//	public int UserId { get; set; }
	}
}