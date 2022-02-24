using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thefirst2
{
	public partial class Form1 : Form
	{
		string s2 = "";
		double d1, d2;
		double result;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void op_SelectedIndexChanged(object sender, EventArgs e)
		{
			s2 = op.Text;
		}

		private void firstn_TextChanged(object sender, EventArgs e)
		{
			if (!double.TryParse(firstn.Text, out d1) && firstn.Text != "")
			{
				MessageBox.Show("Please input a valid number!");
				firstn.Text = ""; //textbox 重置
			}
		    //d1 = Double.Parse(firstn.Text);
			//double.TryParse(firstn.Text, out d1);
		}

		private void secondn_TextChanged(object sender, EventArgs e)
		{
			if (!double.TryParse(secondn.Text, out d2) && secondn.Text != "")
			{
				MessageBox.Show("Please input a valid number!");
				secondn.Text = ""; //textbox 重置
			}
			//d2 = Double.Parse(secondn.Text);
			//如果用parse则会当无输入的时候，出现字符串输入错误的问题
			//double.TryParse(secondn.Text, out d2);
		}

		private void cal_Click(object sender, EventArgs e)
		{
			//secondn_TextChanged(sender, e);
			//firstn_TextChanged(sender, e);
			//op_SelectedIndexChanged(sender, e);
			res_Click(sender, e);
			res.Text = Convert.ToString(result);
		}

		private void res_Click(object sender, EventArgs e)
		{
			switch (s2)
			{
				case "+":
					result = d1 + d2;
					break;
				case "-":
					result = d1 - d2;
					break;
				case "*":
					result = d1 * d2;
					break;
				case "/":
					if (d2 == 0)
						res.Text = "Error";
					result = d1 / d2;
					break;
				default:
					res.Text = "Error";
					break;
			}
		}
	}
}
