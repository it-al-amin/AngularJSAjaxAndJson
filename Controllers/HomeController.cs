using AngularJSAjaxAndJson.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AngularJSAjaxAndJson.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
       
        public JsonResult AjaxMethod([FromBody] PersonModelcs model)
        {
            var person = new PersonModelcs
            {
                Name = model.Name,
                DateTime = DateTime.Now.ToString()
            };

            return Json(person);
        }
    }
}
