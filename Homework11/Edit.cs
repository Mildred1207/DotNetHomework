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
	public partial class Edit : Form
	{
		private OrderService orderService;
		public bool EditModel { get; set; }
		public Order CurrentOrder { get; set; }
		public event Action<Edit> CloseEditFrom;

		public Edit(Order order, bool model, OrderService orderService)
		{
			InitializeComponent();
			using (OrderContext ctx = new OrderContext())
			{
				bds_client.DataSource = ctx.Client.ToList();
			}
			this.orderService = orderService;
			this.EditModel = model;

			//TODO 如果想实现不点保存只关窗口后订单不变化，需要把order深克隆给CurrentOrder
			this.CurrentOrder = order;
			bds_order.DataSource = CurrentOrder;

			tb_orderId.Enabled = !model;
			if (!model)
			{
				CurrentOrder.Client = (Client)bds_client.Current;
			}
		}

		private void btn_addDetail_Click(object sender, EventArgs e)
		{
			DetailEdit formItemEdit = new DetailEdit(new OrderDetails());
			try
			{
				if (formItemEdit.ShowDialog() == DialogResult.OK)
				{
					int index = 0;
					if (CurrentOrder.OrderDetails.Count != 0)
					{
						index = CurrentOrder.OrderDetails.Max(i => i.Index) + 1;
					}
					formItemEdit.Detail.Index = index;
					CurrentOrder.AddDetails(formItemEdit.Detail);
					bds_detail.ResetBindings(false);
				}
			}
			catch (Exception e2)
			{
				MessageBox.Show(e2.Message);
			}
		}

		private void btn_changeDetail_Click(object sender, EventArgs e)
		{
			EditDetail();
		}

		private void EditDetail()
		{
			OrderDetails detail = bds_detail.Current as OrderDetails;
			if (detail == null)
			{
				MessageBox.Show("请选择一个订单项进行修改");
				return;
			}
			DetailEdit formDetailEdit = new DetailEdit(detail);
			if (formDetailEdit.ShowDialog() == DialogResult.OK)
			{
				bds_detail.ResetBindings(false);
			}
		}

		private void btn_deleteDetaiil_Click(object sender, EventArgs e)
		{
			OrderDetails detail = bds_detail.Current as OrderDetails;
			if (detail == null)
			{
				MessageBox.Show("请选择一个订单项进行删除");
				return;
			}
			CurrentOrder.DeleteDetails(detail);
			bds_detail.ResetBindings(false);
		}

		private void btn_saveOrder_Click(object sender, EventArgs e)
		{
			//TODO 加上订单合法性验证
			try
			{
				if (this.EditModel)
				{
					orderService.ChangeOrder(CurrentOrder);
				}
				else
				{
					orderService.AddOrder(CurrentOrder);
				}
				CloseEditFrom(this);
			}
			catch (Exception e3)
			{
				MessageBox.Show(e3.InnerException.Message);
			}
		}
	}
}
