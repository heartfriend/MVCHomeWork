using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;

namespace HomeWork.Models
{
	public class Bill_Repository
	{
		private string ConnectionString { get; set; }

		public Bill_Repository()
		{
			this.ConnectionString = WebConfigurationManager.ConnectionStrings["HomeWorkModel"].ConnectionString;
		}

		public string QueryAllBillData()
		{
			const string sqlStatement = "Select CONVERT(varchar(100), Id) as Id, Case Categoryyy when 0 then N'收入' when 1 then N'支出' else '' end as Categoryyy, CONVERT(varchar(10),Dateee, 120) as Dateee, Replace(Convert(Varchar(100),CONVERT(money, CONVERT(varchar(100), Amounttt)),1),'.00','') as Amounttt From AccountBook";

			using (var conn = new SqlConnection(this.ConnectionString))
			using (var command = new SqlCommand(sqlStatement, conn))
			{
				command.CommandType = CommandType.Text;
				command.CommandTimeout = 180;
				
				var ds = new DataTable();
				var da = new SqlDataAdapter(command);
				da.Fill(ds);
				var result = JsonConvert.SerializeObject(ds);
				return result;
			}
		}
	}
}