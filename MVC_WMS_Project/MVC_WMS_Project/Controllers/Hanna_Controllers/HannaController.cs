using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC_WMS_Project.Controllers.Hanna_Controllers
{
    public class HannaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WarehouseShow()
        {
            return View();
        }
    }
}
