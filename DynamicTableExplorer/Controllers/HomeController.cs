using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DynamicTableExplorer.Models;
using Newtonsoft.Json.Linq;

namespace DynamicTableExplorer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            //DataTableModel dtm = new DataTableModel(2);
            ViewData["Message"] = "Your application description page.";

            //Pass data from controller:
            var vm = new AboutModel();
            //vm.data = new JObject
            //    {
            //        new JProperty("id", 2),
            //        new JProperty("name", "stub"),
            //        new JProperty("age", 2)
            //    };

            string json = @"
            [ 
                { ""id"" : ""2"", ""name"" : ""stub"", ""age"" : ""2"" },
                { ""id"" : ""3"", ""name"" : ""stub1"", ""age"" : ""3""},
                { ""id"" : ""4"", ""name"" : ""stub2"", ""age"" : ""4""}
            ]";
            vm.arrOfData = JArray.Parse(json);

            return View(vm);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
