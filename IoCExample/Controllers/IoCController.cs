using IoCExample.Interface;
using Microsoft.AspNetCore.Mvc;

namespace IoCExample.Controllers
{
    public class IoCController : Controller
    {
        INameCaller _nameCaller;
       
        public IoCController(INameCaller nameCaller)
        {
            _nameCaller = nameCaller;
           }

        public IActionResult Index()
        { 
            Console.WriteLine(_nameCaller.NameCaller());
           
            return View();
        }
    }
}
