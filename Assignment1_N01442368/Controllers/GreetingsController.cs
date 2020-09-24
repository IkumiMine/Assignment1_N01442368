using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01442368.Controllers
{
    public class GreetingsController : ApiController
    {
        /// <summary>
        /// This method returns the string "Greetings to {id} people!" when receiving a GET request
        /// <example> GET api/Greetings/{id} </example>
        /// </summary>
        /// <param name="id"></param>
        /// <returns> [Greetings to " + id + " people!] </returns>
        public string Get(int id)
        {
            return "Greetings to " + id + " people!";

        }
        
    }
}
