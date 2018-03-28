using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logic.Entity;
using Logic.Abstract;
using Logic.Concreate;

namespace AjaxCall.Controllers
{
	public class HomeController : Controller
	{
		private IEMP iemp;
		public HomeController()
		{
			iemp = new EFEMp();
		}

		[HttpGet]
		public ActionResult save()
		{
			return View();
		}

		[HttpPost]
		public JsonResult save(EMP emp)
		{
			try
			{
				iemp.save(emp);
				return Json("success", JsonRequestBehavior.AllowGet);
			}
			catch (Exception ex)
			{
				return Json("fail", JsonRequestBehavior.AllowGet);
			}
		}


		public ActionResult Index()
		{
			ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your app description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}
