using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace HomeWork.Models.ViewModel
{
	public class BillViewModel
	{
		[DisplayName("#")]
		public string Id { get; set; }

		[DisplayName("類別")]
		public string Categoryyy { get; set; }

		[DisplayName("日期")]
		public string Dateee { get; set; }

		[DisplayName("金額")]
		public string Amounttt { get; set; }

	}





	
}