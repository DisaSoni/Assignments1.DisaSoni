using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignments1.DisaSoni.Controllers
{
    public class HostingCostController : ApiController
    {
		/// <summary>
		/// Calculates the number of fornights, Hosting charge without HST, HST cost, and the total Hosting Cost whith the number of inputted days.
		/// </summary>
		/// <param name = "id">The input number of days the hosting was done.</param>
		/// <return>Outputs Three Strings</return>
		/// GET api/HostingCost/21 -> "2 fortnights at $5.50/FN = $11.00 CAD"
		///                             "HST 13% = $1.43 CAD"
		///								"Total = 12.43 CAD"
		[Route("api/HostingCost/{id}")]
		[HttpGet]
		public string[] GetHostingCost(int id)
		{
			double Charge = 5.50D;
			int numFortNight = (int)Math.Ceiling(Decimal.Divide(id + 1, 14));
			double HostingCharge = Charge * numFortNight;
			double HST = 0.13D * HostingCharge;
			double FinalCost = HST + HostingCharge;
			string[] res = { $"{numFortNight} fortnights at $5.50/FN = ${HostingCharge.ToString("F")} CAD", $"HST 13% = ${HST.ToString("F")} CAD", $"Total = ${FinalCost.ToString("F")} CAD" };
			return res;
		}
	}
}
