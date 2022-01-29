using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01490200_Assignment1_Winter2022_Mahshad.Controllers
{
    public class AddTenController : ApiController
    {
        /*
         * this method returns 10 more than the integer input
         * input = id
         * output = sum
         * E.g. id=10 -> sum=20 
         */
        // GET api/AddTen/5
        public int Get(int id)
        {
            int sum = id + 10;
            return sum;
        }
    }
}
