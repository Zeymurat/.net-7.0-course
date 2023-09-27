using Basics.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Basics.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "home/index";
        }

        public string Contact()
        {
            return "home/contact";
        }
    }
}