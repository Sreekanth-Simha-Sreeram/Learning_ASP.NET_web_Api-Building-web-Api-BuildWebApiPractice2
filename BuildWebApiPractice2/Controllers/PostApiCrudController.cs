using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BuildWebApiPractice2.Controllers
{
    public class PostApiCrudController : ApiController
    {
        

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            //create a resource and return URL of the resource. 


        }


    }
}
