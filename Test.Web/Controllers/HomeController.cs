using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Business;
using Test.Common.DTOs;

namespace Test.Web.Controllers
{
    public class HomeController : Controller
    {
        private StudentBusiness studentBusiness = new StudentBusiness();
        public ActionResult Index()
        {
            var list  = studentBusiness.GetAll();
            return View(list);
        }

        public ActionResult Delete(StudentDTO dTO)
        {

            dTO.IsDelete = 1;
            string messege  = studentBusiness.Update(dTO);
            return RedirectToAction("Index");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}