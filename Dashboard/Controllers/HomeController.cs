using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dashboard.Models;
using SeasNve.Common.Model.PersistData;
using Dashboard.ViewModel;

namespace Dashboard.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<CRMPersistData> list = new List<CRMPersistData>();
           
            for (int i = 0; i < 1000; i++)
            {
                CRMPersistData data = new CRMPersistData();
                int randomNumber = 0;
                Random random = new Random();
                randomNumber = random.Next(-40, -1);
                data.CreatedDate = DateTime.Now.AddMinutes(randomNumber);
                data.TransferOk = false;
                list.Add(data);
            }
            HomeModel model = new HomeModel();
            model.data = list;
            model.Count = list.Count();
            model.YellowCount = list.Where(x => x.CreatedDate > DateTime.Now.AddMinutes(-10)).Count();
            model.RedCount = list.Where(x => x.CreatedDate > DateTime.Now.AddMinutes(-30)).Count();

            return View(model);
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
