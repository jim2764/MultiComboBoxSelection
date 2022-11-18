using Ispan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		StudentVM[] students = null;
		public Form1()
		{
			InitializeComponent();
			DataBind();
		}

		private void DataBind()
		{
			// table的操作
			string sql = "SELECT * FROM Student";

			SqlDbHelper sqlDbHelper = new SqlDbHelper("default");
			DataTable table = sqlDbHelper.Select(sql, null);

			students = table.AsEnumerable().Select(x => ConvertToVM(x)).ToArray();
			dataGridView1.DataSource = students;

			// 
			sql = "SELECT Distinct Name FROM Student";

			sqlDbHelper = new SqlDbHelper("default");
			table = sqlDbHelper.Select(sql, null);

			string[] values = table.AsEnumerable().Select(x => x.Field<string>("Name")).Prepend(string.Empty).ToArray();
			comboBox1.DataSource = values;

			//
			sql = "SELECT Distinct Teacher FROM Student";

			sqlDbHelper = new SqlDbHelper("default");
			table = sqlDbHelper.Select(sql, null);

			values = table.AsEnumerable().Select(x => x.Field<string>("Teacher")).Prepend(string.Empty).ToArray();
			comboBox2.DataSource = values;

			//
			sql = "SELECT Distinct Grade FROM Student";

			sqlDbHelper = new SqlDbHelper("default");
			table = sqlDbHelper.Select(sql, null);

			int[] results = table.AsEnumerable().Select(x => x.Field<int>("Grade")).Prepend(-1).ToArray();
			comboBox3.DataSource = results;
		}

		private StudentVM ConvertToVM(DataRow row)
		{
			return new StudentVM()
			{
				Sid = row.Field<string>("Sid"),
				Name = row.Field<string>("Name"),
				Teacher = row.Field<string>("Teacher"),
				Grade = row.Field<int>("Grade")
			};
		}

		public class StudentVM
		{
			public string Sid { get; set; }
			public string Name { get; set; }
			public string Teacher { get; set; }
			public int Grade { get; set; }
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			string sql = "SELECT * FROM Student";

			//if (comboBox1.SelectedIndex != 0 || comboBox2.SelectedIndex != 0 || comboBox3.SelectedIndex != 0)
			//{
				//sql += " WHERE";
				bool isFirst = true;
				if (comboBox1.SelectedIndex != 0) 
				{
					if (isFirst) sql += " WHERE";
					else sql += " AND";

					sql += $" Name = '{comboBox1.Text}'";
					isFirst = false;
				}

				if (comboBox2.SelectedIndex != 0)
				{
					if (isFirst) sql += " WHERE";
					else sql += " AND";

					sql += $" Teacher = '{comboBox2.Text}'";
					isFirst = false;
				}

				if (comboBox3.SelectedIndex != 0)
				{
					if (isFirst) sql += " WHERE";
					else sql += " AND"; ;

					sql += $" Grade = {Convert.ToInt32(comboBox3.Text)}";
					isFirst = false;
				}
			//}

			SqlDbHelper sqlDbHelper = new SqlDbHelper("default");
			DataTable table = sqlDbHelper.Select(sql, null);

			students = table.AsEnumerable().Select(x => ConvertToVM(x)).ToArray();
			dataGridView1.DataSource = students;
		}
	}
}
