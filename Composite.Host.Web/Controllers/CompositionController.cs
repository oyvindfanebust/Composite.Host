using System;
using System.Web.Mvc;

namespace Composite.Host.Web.Controllers
{
    public class CompositionController : Controller
    {
         public ActionResult Index()
         {
             return View(Guid.NewGuid());
         }
    }
}