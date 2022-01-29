using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01490200_Assignment1_Winter2022_Mahshad.Controllers
{
    public class GreetingsController : ApiController
    {
        /*
        * this method returns the string “Hello World!”
        * as it is a post request it is tested throgh command prompt using:
        * curl -d "" http://localhost:51394/api/Greetings
        */
        // POST api/Greetings
        public string Post()
        {
            return "Hello World!";
        }


        /*
         * this method returns the string “Greetings to {id} people!” where id is an integer value.
         * input = id
         * output = Greetings to {id} people!
         */
        // GET api/Greetings/7
        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }
}
