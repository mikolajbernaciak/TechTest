using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechTest.Models;

namespace TechTest.Services
{
	public class AuditService : IAuditService
	{
		public IEnumerable<Audit> GetAudits(DateTime? fromDate, DateTime? toDate)
		{
			throw new NotImplementedException("Not implemented");
		}
	}
}