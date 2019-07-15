using HomeWork.Models.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using HomeWork.Models;
namespace HomeWork.Models
{
	public class Bill_Service
	{
		Bill_Repository res = new Bill_Repository();
		
		public List<BillViewModel> GetAllBillData()
		{
			List<string> BillList = new List<string>();

			var AllBillData = JsonConvert.DeserializeObject<List<ViewModel.BillViewModel>>(QueryAllBillData()).ToList();

			return AllBillData;
		}

		public string QueryAllBillData()
		{
			var dt =  res.QueryAllBillData();
			return dt;
		}
		




	}
}
