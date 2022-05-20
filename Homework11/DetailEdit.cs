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
	public partial class DetailEdit : Form
	{
		public OrderDetails Detail { get; set; }

		public DetailEdit()
		{
			InitializeComponent();
		}
		public DetailEdit(OrderDetails detail) : this()
		{
			this.Detail = detail;
			this.bds_detail.DataSource = detail;
			using (OrderContext ctx = new OrderContext())
			{
				bds_good.DataSource = ctx.Goods.ToList();
			}
		}
	}
}
