using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccesslayer.EntityFramework;
using EntityLayer;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EFWriterRepository());
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer p )
        {
            WriterValidatior wv = new WriterValidatior();
            ValidationResult validationResult = wv.Validate(p);
            if (validationResult.IsValid)
            {
                p.WriterStatus = true;
                p.WriterAbout = "deneme test";
                wm.WriterAdd(p);
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError( item.PropertyName, item.ErrorMessage);
                }
            }          
            return RedirectToAction("Index","Blog");

        }
        
    }
}
