using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01490200_Assignment1_Winter2022_Mahshad.Controllers
{
    public class SquareController : ApiController
    {
        /*
         * this methos returns the square of the integer input {id}.
         * input = id
         * output = squared
         * E.g. id=2 -> squared=4
        */
        // GET api/Square/4
        public int Get(int id)
        {
            int squared = id * id;
            return squared;
        }
    }
}
