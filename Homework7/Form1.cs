using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
	public partial class Form1 : Form
	{
		private Graphics graphics;
		private double th1 = 30 * Math.PI / 180;//右分支角度
		private double th2 = 20 * Math.PI / 180;//左分支角度
		private double per1 = 0.6;//右分支长度比
		private double per2 = 0.7;//左分支长度比
		private int height = 3;//递归深度
		private int length = 100;//主干长度
		private Pen penColor = Pens.Blue;//画笔颜色

		public Form1()
		{
			InitializeComponent();
		}

		void drawCayleyTree(int n, double x0, double y0, double leng, double th)
		{
			if (n == 0) return;

			double x1 = x0 + leng * Math.Cos(th);
			double y1 = y0 + leng * Math.Sin(th);

			drawLine(x0, y0, x1, y1);

			drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
			drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
		}

		void drawLine(double x0, double y0, double x1, double y1)
		{
			graphics.DrawLine(penColor, (int)x0, (int)y0, (int)x1, (int)y1);
		}

		private void btn_draw_Click(object sender, EventArgs e)
		{
			Form1 form1 = this;
			form1.Paint += new PaintEventHandler(this.panal_Caylay_Paint);
		}

		private void btn_clear_Click(object sender, EventArgs e)
		{
			panal_Caylay.Refresh();
		}

		private void cbox_pen_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (cbox_pen.SelectedIndex)
			{
				case 0:
					penColor = Pens.Blue;
					break;
				case 1:
					penColor = Pens.Red;
					break;
				case 2:
					penColor = Pens.Yellow;
					break;
				case 3:
					penColor = Pens.Green;
					break;
			}
		}

		private void panal_Caylay_Paint(object sender, PaintEventArgs e)
		{
			graphics = e.Graphics;
			per1 = Double.Parse(tb_per1.Text.ToString());
			per2 = Double.Parse(tb_per2.Text.ToString());
			th1 = Double.Parse(tb_th1.Text.ToString()) * Math.PI / 180;
			th2 = Double.Parse(tb_th2.Text.ToString()) * Math.PI / 180;
			height = Int32.Parse(tb_height.Text.ToString());
			length = Int32.Parse(tb_leng.Text.ToString());
			drawCayleyTree(height, panal_Caylay.Width/2, panal_Caylay.Height, length, -Math.PI / 2);
		}
	}
}
