using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignments1.DisaSoni.Controllers
{
    public class NumberMachineController : ApiController
    {
		/// <summary>
		/// Applies four mathematical operations to the input Number
		/// </summary>
		/// <param name = "id">The input number on which the operations are to be performed.</param>
		/// <return>The output after the operations are performed.</return>
		/// GET api/NumberMachine/20 -> 0
		[Route("api/NumberMachine/{id}")]
		[HttpGet]

		public int GetNumberMachine(int id)
		{
			int res = id;
			id = id + 30;
			id = id - 20;
			id = id * 2;
			id = id % 10;
			return id;
		}

	}
}
