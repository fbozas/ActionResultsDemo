using ActionResultsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionResultsDemo.Controllers
{
    public class ActionResultsController : Controller
    {
        // GET: ActionResults
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult ViewResultMethod()
        {
            return View();
        }

        public ContentResult ContentMethod()
        {
            return Content("Hello from MVC 5");
        }

        public ActionResult ConditionalMethod()
        {
            var a = false;
            if (a)
            {
                return Content("Variable is true");
            }
            return View();
        }

        public RedirectResult GoToUrl()
        {
            return Redirect("http://www.google.com");
        }

        public RedirectToRouteResult GoToIndexAction()
        {
            return RedirectToAction("Index");
        }

        public RedirectToRouteResult GotoContactAction()
        {
            return RedirectToAction("Contact", "Home");
        }

        public RedirectToRouteResult GoToAspecificRoute()
        {
            return RedirectToRoute("AboutUs");
        }

        public FileResult ShowCSSContent()
        {
            return File(Server.MapPath("~/Content/Site.css"), "text/css");
        }

        public FileResult GetImage()
        {
            return File(Server.MapPath("~/Images/beach.jpg"), "images/jpg");
        }

        public JsonResult ShowNewCustomer()
        {
            Customer customer = new Customer()
            {
                ID = 101,
                FullName = "Nikolas Bekas"
            };

            return Json(customer, JsonRequestBehavior.AllowGet);
        }

        public PartialViewResult ShowChildViewResult()
        {
            return PartialView();
        }
    }
}