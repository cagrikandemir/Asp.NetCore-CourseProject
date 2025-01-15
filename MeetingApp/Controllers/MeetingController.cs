
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Apply(){
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo model){
            Repository.CreateUser(model);
            ViewBag.UserCount=Repository.User.Where(i=>i.WillAttend==true).Count();
            Console.Write(model);            
            return View("Thanks",model);
        }

        public IActionResult list(){
            return View();
        }
}
}