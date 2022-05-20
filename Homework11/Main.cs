using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework11
{
	public partial class Main : Form
	{
		OrderService orderService;
		BindingSource bdsFields = new BindingSource();
		public event Action<Edit> ShowEditForm;
		public String Keyword { get; set; }

		public Main()
		{
			InitializeComponent();
			orderService = new OrderService();
			bds_order.DataSource = orderService.Orders;
			cbx_select.SelectedIndex = 0;
			tb_keyword.DataBindings.Add("Text", this, "Keyword");
		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			Edit Edit = new Edit(new Order(), false, orderService);
			ShowEditForm(Edit);
		}

		public void QueryAll()
		{
			bds_order.DataSource = orderService.Orders;
			bds_order.ResetBindings(false);
		}

		private void btn_change_Click(object sender, EventArgs e)
		{
			EditOrder();
		}

		private void EditOrder()
		{
			Order order = bds_order.Current as Order;
			if (order == null)
			{
				MessageBox.Show("请选择一个订单进行修改");
				return;
			}
			Edit form2 = new Edit(order, true, orderService);
			ShowEditForm(form2);
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			Order order = bds_order.Current as Order;
			if (order == null)
			{
				MessageBox.Show("请选择一个订单进行删除");
				return;
			}
			orderService.DeleteOrder(order.OrderId);
			QueryAll();
		}

		private void btn_import_Click(object sender, EventArgs e)
		{
			DialogResult result = openFileDialog1.ShowDialog();
			if (result.Equals(DialogResult.OK))
			{
				String fileName = openFileDialog1.FileName;
				orderService.Import(fileName);
				QueryAll();
			}
		}

		private void btn_output_Click(object sender, EventArgs e)
		{
			DialogResult result = saveFileDialog1.ShowDialog();
			if (result.Equals(DialogResult.OK))
			{
				String fileName = saveFileDialog1.FileName;
				orderService.Export(fileName);
			}
		}

		private void btn_query_Click(object sender, EventArgs e)
		{
			switch (cbx_select.SelectedIndex)
			{
				case 0://所有订单
					bds_order.DataSource = orderService.Orders;
					break;
				case 1://根据ID查询
					Order order = orderService.QueryOrderId(Keyword);
					List<Order> result = new List<Order>();
					if (order != null) result.Add(order);
					bds_order.DataSource = result;
					break;
				case 2://根据客户查询
					bds_order.DataSource = orderService.QueryOrderClient(Keyword);
					break;
				case 3://根据货物查询
					bds_order.DataSource = orderService.QueryOrderGoodName(Keyword);
					break;
				case 4://根据总价格查询（大于某个总价）
					float.TryParse(Keyword, out float totalPrice);
					bds_order.DataSource =
						   orderService.QuerySumValue(totalPrice);
					break;
			}
			bds_order.ResetBindings(false);
		}

		private void dgv_order_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
