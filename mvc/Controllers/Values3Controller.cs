using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace mvc.Controllers
{
    public class Values3Controller : ApiController
    {
        [HttpGet]
        public int Get()
        {
            return 1;
        }
    }
}