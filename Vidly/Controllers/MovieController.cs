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
        }
    }
}