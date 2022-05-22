using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.View_Components
{
    public class Comment:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var values = new List<UserComment>();
            return View();
        }
    }
}
