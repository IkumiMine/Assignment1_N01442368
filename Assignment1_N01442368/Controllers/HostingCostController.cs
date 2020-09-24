using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Ajax.Utilities;

namespace Assignment1_N01442368.Controllers
{
    public class HostingCostController : ApiController
    {
        //I couldn't set the decimal position

        /// <summary>
        /// This method returns 3 strings which describe the total hosting cost when receiving a GET request
        /// <example> GET api/HostingCost/{id} </example>
        /// </summary>
        /// <param name="id"></param>
        /// <returns> [x + " fortnights at $5.50/FN = " + a +" CAD ", "HST 13% = $ " + b + " CAD ", "Total = $ " + c + " CAD"] </returns>
        public IEnumerable<string> Get(int id)
        {
  
            double x = (id / 14);
            double a = (x * 5.50) + 5.50;
            double b = a * 0.13;
            double c = a + b;

            return new string[] { x + " fortnights at $5.50/FN = " + a +" CAD ",
                                  "HST 13% = $ " + b + " CAD ",
                                  "Total = $ " + c + " CAD"};

        }
    }
}
