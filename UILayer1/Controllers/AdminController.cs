using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UILayer.Data.ApiServices;

namespace UILayer.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            AuthApi.Get();
            return View();
        }
    }
}
