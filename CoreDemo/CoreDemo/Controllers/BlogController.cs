using BusinessLayer.Concrete;
using DataAccesslayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        public IActionResult Index()
        {

            return View(bm.GetBlogListWithCategory());
        }
        public IActionResult BlogReadAll( int id)
        {
            ViewBag.i = id;
            return View(bm.GetBlogByID(id));
        }
    }
}
