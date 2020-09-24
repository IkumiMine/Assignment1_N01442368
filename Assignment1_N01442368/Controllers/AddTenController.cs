using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01442368.Controllers
{
   
    public class AddTenController : ApiController
    {
        /// <summary>
        /// This method returns 10 more than the integer input{id} when receiving a GET request
        /// <example> GET api/AddTen/{id} </example>
        /// </summary>
        /// <param name="id"></param>
        /// <returns> [ id + 10 ] </returns>
        public IEnumerable<int> Get(int id)
        {
            return new int[] { id + 10 };
        }
        
    }


}
