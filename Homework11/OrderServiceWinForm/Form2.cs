using Homework6;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderServiceWinForm
{
	public partial class Form2 : Form
	{
		public int Id1 { get => Convert.ToInt32(tb_id.Text); }
		public int ClientTime1 { get=> Convert.ToInt32(tb_time.Text); }
		public string ClientName1 { get => tb_clientname.Text; }

		public int GoodSum1 { get => Convert.ToInt32(tb_goodSum.Text); }

		Good good1 = new Good(1, 100);
		Good good2 = new Good(2, 200);
		Good good3 = new Good(3, 300);
		Good selectedGood;
		public Good Good1 { get => selectedGood; }
		Order newOrder = new Order();
		public Order NewOrder { get => newOrder; }

		public Form2()
		{
			InitializeComponent();
			cobox_good.SelectedIndex = 0;
		}

		//private void button1_Click(object sender, EventArgs e)
		//{
		//	Form1 form1 = new Form1();
		//	form1.OrderService.AddOrder(newOrder);
		//	this.Close();
		//}

		private void btn_AddGood_Click(object sender, EventArgs e)
		{
			Client clientAdd = new Client(tb_clientname.Text);
			Order newOrder = new Order(Id1, ClientTime1, clientAdd);
			switch (cobox_good.SelectedIndex)
			{
				case 0:
					selectedGood = good1;
					break;
				case 1:
					selectedGood = good2;
					break;
				case 2:
					selectedGood = good3;
					break;
			}
			OrderDetails newOrderDetails = new OrderDetails(Good1,GoodSum1);
			newOrder.AddDetails(newOrderDetails);
		}

		//通过事件的机制达到主次窗体间的切换
		private void btn_addOrder_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
