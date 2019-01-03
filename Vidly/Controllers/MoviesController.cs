using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private MyDbContext _context;

        public MoviesController()
        {
            _context = new MyDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movies/
        public ActionResult Index()
        {
            var movies =_context.Movies.Include("Genre");
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                //Vidly is famous for thriller/action/horror movies 
                new Movie { Name = "The Machinist" , Id = 1},
                new Movie { Name = "Kill Bill V.01" ,Id = 2},
                new Movie { Name = "Kill Bill V.02" ,Id = 3 },
                new Movie { Name = "Shawshank Redemption ", Id = 4},
                new Movie { Name = "The Machinist" ,Id = 5 },
                new Movie { Name = "Interstellar" , Id = 6},
                new Movie { Name = "Dark Knight" , Id = 7},
                new Movie { Name = "Dark Knight Rises" , Id = 8},
                new Movie { Name = "Insidious" , Id = 9},
                new Movie { Name = "The Ring" , Id = 10}
            };
        }


        public ActionResult Details(int Id=0)
        {
            if (Id > 0)
            {
                //var movie = GetMovies().FirstOrDefault(x=>x.Id==Id);
                var movie = _context.Movies.Include("Genre").FirstOrDefault(x => x.Id == Id); 
                return View(movie);
            }
            else
            {
                return HttpNotFound();
            }
        }

        public ActionResult Random()
        {
            var movies = new Movie() { Name = "Shrek !" };

            var customers = new List<Customer>
            {
                new Customer {Id=1,Name="Jack Sparrow"},
                new Customer { Id=2 ,Name="Johnny Bravo"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movies,
                Customers = customers
            };
            //return viewresult
            return View(viewModel);
            #region ContentResult
            //Return Simple Text content
            //return Content("Thank you for learning with us.");
            #endregion
            #region FileResult
            // convert the file into byte array . 
            //byte[] filebytes = System.IO.File.ReadAllBytes(@"C:\Users\Chinmay Moghe\Desktop\Fluer-de-Lis.txt");
            //File can be downloaded by the user
            //return File(filebytes, System.Net.Mime.MediaTypeNames.Application.Octet,"Fluer-de-Lis-Art.txt");
            #endregion
            #region RedirectToActionResult
            // Redirects to ActionResult (Action , Controller , anon obj as parameters)
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
            #endregion
            #region Sends a JSON object 
            //object jsobject = new{ Success = "True"}; 
            //return Json(jsobject,JsonRequestBehavior.AllowGet);
            #endregion
            #region HttpNotFound()
            //return HttpNotFound();
            #endregion
            #region Redirect To a URL
            //return Redirect("https://www.google.com/");
            #endregion
        }
        
        //Movies/Edit/
        public ActionResult Edit(int? movieid, string sortBy)
        {
            if (!movieid.HasValue)
                movieid = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(string.Format("movieid={0}&sortBy={1}", movieid, sortBy));
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year+"/"+month);
        }
    }
}