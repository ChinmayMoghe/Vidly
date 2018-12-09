using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Name="Murdoch", Id=1},
                new Customer { Name="Kenny" , Id=2}
            };
        }

        public ActionResult Details(int Id=0)
        {
            if (Id > 0)
            {
                var customer = GetCustomers().First(x => x.Id == Id);
                return View(customer);
            }
            else
            {
                return HttpNotFound();
            }
        }
    }
}