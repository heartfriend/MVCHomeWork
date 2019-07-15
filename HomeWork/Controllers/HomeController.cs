using HomeWork.Models;
using HomeWork.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace HomeWork.Controllers
{
	public class HomeController : Controller
	{
		private Bill_Service service = new Bill_Service();

		public ActionResult Index()
		{
			return View();
		}
		public ActionResult Bill()
		{
			var dt = service.GetAllBillData();
			return View(dt);
		}
		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}
		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
		public ActionResult Create()
		{
			return View();
		}

		
	}
}