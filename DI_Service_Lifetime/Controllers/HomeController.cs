using DI_Service_Lifetime.Models;
using DI_Service_Lifetime.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;

namespace DI_Service_Lifetime.Controllers
{
    public class HomeController : Controller
    {
        private readonly IScoppedGuidService _Scopped1;
        private readonly IScoppedGuidService _Scopped2;


        private readonly ISingletonGuidService _Singleton1;
        private readonly ISingletonGuidService _Singleton2;


        private readonly ITransientGuidService _transient1;
        private readonly ITransientGuidService _transient2;

        public HomeController(IScoppedGuidService Scopped1, IScoppedGuidService Scopped2, ISingletonGuidService Singleton1, ISingletonGuidService Singleton2, ITransientGuidService transient1, ITransientGuidService transient2)
        {
            _Scopped1=Scopped1;
            _Scopped2=Scopped2;
            _Singleton1=Singleton1;
            _Singleton2=Singleton2;
            _transient1 = transient1;
            _transient2=transient2;
        }




        public IActionResult Index()
        {
            StringBuilder message = new StringBuilder();
            message.Append($"Transient 1:{_transient1.GetGuid()}\n");
            message.Append($"Transient 2 :{_transient2.GetGuid()}\n\n\n");
            message.Append($"Scopped 1 :{_Scopped1.GetGuid()}\n ");
            message.Append($"Scopped 2 :{_Scopped2.GetGuid()}\n\n\n");
            message.Append($"Singleton 1 :{_Singleton1.GetGuid()}\n");
            message.Append($"Singleton 2 :{_Singleton2.GetGuid()}\n\n\n");

            return Ok(message.ToString());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
