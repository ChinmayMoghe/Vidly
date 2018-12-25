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
        private MyDbContext _context;

        public CustomersController()
        {
            _context = new MyDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customers

        public ActionResult Index()
        {
            //Deferred Execution > Just .Include()
            //Eager Loading > .ToList()
            var customers = _context.Customers.Include("MemberShipType").ToList();
            //var customers = GetCustomers();
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
                var customer = _context.Customers.FirstOrDefault(x => x.Id == Id);
                //var customer = GetCustomers().First(x => x.Id == Id);
                return View(customer);
            }
            else
            {
                return HttpNotFound();
            }
        }
    }
}