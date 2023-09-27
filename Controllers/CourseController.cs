using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    // course
    public class CourseController : Controller
    {
        // course/index
        public string Index()
        {
            return "course/index";
        }
        // course/list
        public string List()
        {
            return "course/list";
        }
        //public IActionResult Index()
        //{
        //    return View(); 
        //}
    }
}
