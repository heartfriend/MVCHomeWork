using HomeWork.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
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

		public ActionResult Bill()
		{
			List<BillViewModel> BillList = new List<BillViewModel>();
			BillList.Add(new BillViewModel { ID = "1", TYPE = "收入", DATE = "2019-07-01", AMT = "3,100", });
			BillList.Add(new BillViewModel { ID = "2", TYPE = "支出", DATE = "2019-07-05", AMT = "150", });
			BillList.Add(new BillViewModel { ID = "3", TYPE = "支出", DATE = "2019-07-05", AMT = "200", });
			BillList.Add(new BillViewModel { ID = "4", TYPE = "收入", DATE = "2019-07-12", AMT = "1,000", });

			return View(BillList.ToList());

		}
	}
}