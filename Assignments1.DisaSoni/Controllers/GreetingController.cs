using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignments1.DisaSoni.Controllers
{
    public class GreetingController : ApiController
    {
		/// <summary>
		/// Returns Hellow World upon posting
		/// </summary>
		/// <return>"Hello World!"</return>
		/// POST api/Greeting -> "Hello World!"
		/// curl -d "" -X POST /api/Greeting
		[Route("api/Greeting")]
		[HttpPost]
		public string PostGreeting()
		{
			return "Hello World!";
		}
		/// <summary>
		/// Greets the input Number of people
		/// </summary>
		/// <param name = "id">The input number of people to be greeted</param>
		/// <return>The input number people greeted</return>
		/// GET api/Greeting/20 -> Greetings to 20 people!
		[Route("api/Greeting/{id}")]
		[HttpGet]
		public string GetGreeting(int id)
		{
			string res = $"Greetings to {id} people!";
			return res;
		}
	}
}
