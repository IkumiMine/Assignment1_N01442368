using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01442368.Controllers
{
    public class GreetingController : ApiController
    {
        // POST api/Greeting
        /// <summary>
        /// This method returns the string "Hello world!" when receiving a POST request
        /// <example> POST api/Greeting </example>
        /// </summary>
        /// <param name="Greeting"></param>
        /// <returns> [Hello world!] </returns>
        public string Post(string Greeting="Hello world!")
        {
            return Greeting;
        }

        }

}
