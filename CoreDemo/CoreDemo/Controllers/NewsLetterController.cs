using BusinessLayer.Concrete;
using DataAccesslayer.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManager nlm = new NewsLetterManager(new EFNewsLetterRepository());
        [HttpGet]
        public PartialViewResult SubScribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SubScribeMail(string mail)
        {
            NewsLetter p = new NewsLetter();
            p.Mail = mail;
            p.MailStatus = true;
            nlm.AddNewsLetter(p);
            return PartialView();
        }
    }
}
