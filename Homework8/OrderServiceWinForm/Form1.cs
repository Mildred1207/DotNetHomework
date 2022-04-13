using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homework6;

namespace OrderServiceWinForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			cobox_search.SelectedIndex = 0;
			orderBindingSource.DataSource = orderService.OrderList;
		}

		OrderService orderService = new OrderService();
		public OrderService OrderService { get => orderService; }

		public List<Order> Orders { get; set; }

		private void btn_search_Click(object sender, EventArgs e)
		{
			List<Order> newOrders = new List<Order>();
			switch (cobox_search.SelectedIndex)
			{
				case 0:
					newOrders = new List<Order>(orderService.OrderList);
					orderBindingSource.DataSource = newOrders;
					break;
				case 1:
					Order order = orderService.QueryOrderId(Convert.ToInt32(tb_search.Text));
					newOrders.Add(order);
					orderBindingSource.DataSource = newOrders;
					break;
				case 2:
					newOrders = orderService.QueryOrderClient(tb_search.Text);
					orderBindingSource.DataSource = newOrders;
					break;
				case 3:
					newOrders = orderService.QueryOrderSumValue(Convert.ToInt32(tb_search.Text));
					orderBindingSource.DataSource = newOrders;
					break;
			}
		}

		public int Id1 { get; set; }
		public string ClientName1 { get; set; }

		public int SumValue1 { get; set; }

		private void Form1_Load(object sender, EventArgs e)
		{
			//tb_search.DataBindings.Add(tb_search.Text, this, Id1.ToString());
			//tb_search.DataBindings.Add(tb_search.Text, this, ClientName1);
			//tb_search.DataBindings.Add(tb_search.Text, this, SumValue1.ToString());
		}

		private void btn_export_Click(object sender, EventArgs e)
		{
			if (openFile_port.ShowDialog() == DialogResult.OK)
			{
				orderService.Export(openFile_port.FileName);
				MessageBox.Show("已成功导出");
			}
		}

		private void btn_import_Click(object sender, EventArgs e)
		{
			if (openFile_port.ShowDialog() == DialogResult.OK)
			{
				orderService.Import(openFile_port.FileName);
				orderBindingSource.DataSource = new List<Order>(orderService.OrderList);
				MessageBox.Show("已成功导入");
			}
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			Order DeleteOrder = (Order)orderBindingSource.Current;
			orderService.DeleteOrder(DeleteOrder.OrderId);
			orderBindingSource.RemoveCurrent();
		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			form2.ShowDialog();
			orderService.AddOrder(form2.NewOrder);
		}

		private void btn_change_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			form2.ShowDialog();
			int i = Convert.ToInt32(form2.Id1);
			if (orderService.QueryOrderId(i) != null)
			{
				orderService.DeleteOrder(i);
				orderService.AddOrder(form2.NewOrder);
			}
			else
			{
				orderService.AddOrder(form2.NewOrder);
			}
		}
	}
}
