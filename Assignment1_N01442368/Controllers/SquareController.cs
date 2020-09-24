using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01442368.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// This method returns the square of the integer input{id} when receiving a GET request
        /// <example> GET api/Square/{id} </example>
        /// </summary>
        /// <param name="id">cat</param>
        /// <returns> [ id*id ] </returns>
        public IEnumerable<int> Get(int id)
        {
            return new int[] { id*id };
        }
    }
}
