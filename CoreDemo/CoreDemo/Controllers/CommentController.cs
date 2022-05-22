using BusinessLayer.Concrete;
using DataAccesslayer.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
  
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EFCommentRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult PartialAddComment(Comment p )
        {
            try
            {
                p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.CommentStatus = true;
                p.BlogID = 2;
                cm.CommentAdd(p);
                return Ok(p);
            }
           catch (Exception ex)
            {
                return BadRequest();
            }
         
        }
        public PartialViewResult PartialCommentListByBlog(int id)
        {
            return PartialView(cm.GetList(id));
        }
    }
}
