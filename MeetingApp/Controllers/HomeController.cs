using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController:Controller{

        public IActionResult Index(){

                int time=DateTime.Now.Hour;
                //ViewBag.Selamlama=time>12?"İyi Günler":"Günaydın";
                ViewData["Selamlama"]=time>12?"İyi Günler":"Günaydın";
                ViewData["Name"]="Çağrı";

                var meetinginfo=new MeetingInfo(){
                    id=1,
                    Location="Sivas , Cü Teknokent",
                    Time=new DateTime(2024,01,15,18,0,0),
                    User=100
                };


            return View(meetinginfo);
        }
    }
}