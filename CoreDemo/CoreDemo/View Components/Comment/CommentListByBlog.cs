using BusinessLayer.Concrete;
using DataAccesslayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.View_Components.CommentList
{
    public class CommentListByBlog:ViewComponent
    {
        CommentManager cm = new CommentManager(new EFCommentRepository());
        public IViewComponentResult Invoke(int id)
        {
            var value = cm.GetList(id);
            return View(value);  
        }
    }
}
