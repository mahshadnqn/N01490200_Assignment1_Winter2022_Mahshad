using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01490200_Assignment1_Winter2022_Mahshad.Controllers
{
    public class HostingCostController : ApiController
    {
        // GET api/HostingCost/15
        public IEnumerable<string> Get(int id)
        {
            // specifying the number of fornights 
            // q is the number of fornights
            int q = id / 14;
            q++;

            // calculating the price of fornights 
            // sum is total price of hosting without the hst
            double sum = q * 5.50;
            string NoHST = q + "fortnights at $5.50/FN = $" + sum + "CAD";

            // calculating the HST
            double HSTSum = sum * 0.13;
            string HST = "HST 13% = $" + HSTSum + " CAD";

            // adding the HST to the price
            double t = sum + HSTSum;
            string Total = "Total = $" + t + " CAD";

            return new string[] { NoHST, HST, Total };
        }
    }
}
