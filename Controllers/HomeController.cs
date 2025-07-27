using System.Diagnostics;
using System.Runtime.Intrinsics;
using Microsoft.AspNetCore.Mvc;
using PRELIM_LAB3_BSIT_31Section_Cherry_Quiño.Models;

namespace PRELIM_LAB3_BSIT_31Section_Cherry_Quiño.Controllers
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
            var customers = new List <Customer>();

            //Regular customer
            Customer c1 = new Customer();
            c1.FirstName = " LingLing";
            c1.MiddleName = "C.";
            c1.LastName = "Kwon";
            c1.Birthday = new DateTime(1996, 7, 7);
            c1.CustomerId = 1001;

            //VIP customer
            VIPCustomer v1 = new VIPCustomer();
            v1.FirstName = " Jay";
            v1.MiddleName = "B.";
            v1.LastName = "Asher";
            v1.Birthday = new DateTime(1998, 7, 12);
            v1.CustomerId = 2001;
            v1.IsVip = true;

            customers.Add (c1);
            customers.Add(v1);

            ViewBag.CustomerList = customers;
            return View();
        }   

        
    }
}
