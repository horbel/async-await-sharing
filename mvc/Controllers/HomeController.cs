using mvc.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        AsyncService _service = new AsyncService();

        public async Task<ActionResult> Index()
        {
            return View();
        }

        
    }
}
