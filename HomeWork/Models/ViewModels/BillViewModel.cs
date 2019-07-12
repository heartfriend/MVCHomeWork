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
		public string ID { get; set; }

		[DisplayName("類別")]
		public string TYPE { get; set; }

		[DisplayName("日期")]
		public string DATE { get; set; }

		[DisplayName("金額")]
		public string AMT { get; set; }

	}
}