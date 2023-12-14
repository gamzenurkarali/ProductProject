using Microsoft.AspNetCore.Mvc;

namespace ProductProject.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult UserList() 
        { 
            return View();
        
        }
        public ActionResult NewUser()
        {
            return View();

        }
        public ActionResult ToDoList()
        {
            return View();

        }
    }
}
