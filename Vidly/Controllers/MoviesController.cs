using System.Linq;
using System.Data.Entity;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        
        public ActionResult Index()
        {
            return View(new MoviesViewModel { Movies = _context.Movies.ToList() });
        }
        

        [Route("movies/details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
    }
}