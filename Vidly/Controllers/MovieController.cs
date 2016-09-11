using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movie() { name = "thuy" };
            return View(movie);
            // return Content("Hello");
            //return HttpNotFound();
            // return new EmptyResult();
            //  return RedirectToAction("Index", "Home",new { page = 1, sorby = "name" });
        }
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);

        }
        //public ActionResult Index(int? pageIndex,string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (string.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "name";



        //}
    }
}