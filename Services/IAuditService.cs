using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechTest.Models;

namespace TechTest.Services
{
	public interface IAuditService
	{
		/// <summary>
		/// Get audits within specified date range
		/// </summary>
		/// <param name="fromDate">Audits from given date, if null, audits from the start</param>
		/// <param name="toDate">Audit up until the given date, if null, audits until present</param>
		/// <returns></returns>
		IEnumerable<Audit> GetAudits(DateTime? fromDate, DateTime? toDate);
	}
}