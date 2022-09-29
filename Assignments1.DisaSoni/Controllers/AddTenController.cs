using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignments1.DisaSoni.Controllers
{
   
 
    public class AddTenController : ApiController
    {

        /// <summary>
        /// Adds Ten to the input Number
        /// </summary>
        /// GET api/AddTen/20 -> 30

        [Route("api/AddTen/{id}")]
        [HttpGet]


        public int GetAddTen(int id)
        {
            int res = id + 10;
            return res;
        }
    }
}

