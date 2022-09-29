using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignments1.DisaSoni.Controllers
{

    public class SquareController : ApiController
    {
		/// <summary>
		/// Squares to the input Number
		/// </summary>
		/// <param name = "id">The input number to be Squared</param>
		/// <return>The input number Squared</return>
		/// GET api/Square/2 -> 4
		[Route("api/GetSquare/{id}")]
		[HttpGet]

		public int GetSquare(int id)
		{
			int res = id * id;
			return res;
		}

	}
}
