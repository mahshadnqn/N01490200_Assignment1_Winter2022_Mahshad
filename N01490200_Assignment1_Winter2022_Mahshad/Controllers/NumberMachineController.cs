using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01490200_Assignment1_Winter2022_Mahshad.Controllers
{
    public class NumberMachineController : ApiController
    {
        /*
        * Create a method which has an input {id}, and applies four mathematical operations to it
        */
        // GET api/NumberMachine/10
        public decimal Get(int id)
        {
            decimal product = (id * (id + 10)) / (5 + id);
            return product;
        }
    }
}
