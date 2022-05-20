
namespace Homework11
{
	partial class DetailEdit
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lb_good = new System.Windows.Forms.Label();
			this.cbx_good = new System.Windows.Forms.ComboBox();
			this.bds_good = new System.Windows.Forms.BindingSource(this.components);
			this.lb_account = new System.Windows.Forms.Label();
			this.tb_amount = new System.Windows.Forms.TextBox();
			this.btn_ok = new System.Windows.Forms.Button();
			this.bds_detail = new System.Windows.Forms.BindingSource(this.components);
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bds_good)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bds_detail)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.63662F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.36338F));
			this.tableLayoutPanel1.Controls.Add(this.lb_good, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.cbx_good, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.lb_account, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tb_amount, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 214);
			this.tableLayoutPanel1.TabIndex = 11;
			// 
			// lb_good
			// 
			this.lb_good.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lb_good.AutoSize = true;
			this.lb_good.Location = new System.Drawing.Point(57, 41);
			this.lb_good.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lb_good.Name = "lb_good";
			this.lb_good.Size = new System.Drawing.Size(58, 24);
			this.lb_good.TabIndex = 1;
			this.lb_good.Text = "货物";
			this.lb_good.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbx_good
			// 
			this.cbx_good.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cbx_good.DataSource = this.bds_good;
			this.cbx_good.DisplayMember = "GoodName";
			this.cbx_good.FormattingEnabled = true;
			this.cbx_good.Location = new System.Drawing.Point(177, 37);
			this.cbx_good.Margin = new System.Windows.Forms.Padding(4);
			this.cbx_good.Name = "cbx_good";
			this.cbx_good.Size = new System.Drawing.Size(619, 32);
			this.cbx_good.TabIndex = 2;
			// 
			// bds_good
			// 
			this.bds_good.DataSource = typeof(Homework11.Good);
			// 
			// lb_account
			// 
			this.lb_account.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lb_account.AutoSize = true;
			this.lb_account.Location = new System.Drawing.Point(57, 148);
			this.lb_account.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lb_account.Name = "lb_account";
			this.lb_account.Size = new System.Drawing.Size(58, 24);
			this.lb_account.TabIndex = 13;
			this.lb_account.Text = "数量";
			// 
			// tb_amount
			// 
			this.tb_amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_amount.Location = new System.Drawing.Point(177, 143);
			this.tb_amount.Margin = new System.Windows.Forms.Padding(4);
			this.tb_amount.Name = "tb_amount";
			this.tb_amount.Size = new System.Drawing.Size(619, 35);
			this.tb_amount.TabIndex = 10;
			// 
			// btn_ok
			// 
			this.btn_ok.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btn_ok.Location = new System.Drawing.Point(299, 310);
			this.btn_ok.Margin = new System.Windows.Forms.Padding(6);
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.Size = new System.Drawing.Size(228, 46);
			this.btn_ok.TabIndex = 12;
			this.btn_ok.Text = "确定";
			this.btn_ok.UseVisualStyleBackColor = true;
			// 
			// bds_detail
			// 
			this.bds_detail.DataSource = typeof(Homework11.OrderDetails);
			// 
			// DetailEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_ok);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "DetailEdit";
			this.Text = "DetailEdit";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bds_good)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bds_detail)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lb_good;
		private System.Windows.Forms.ComboBox cbx_good;
		private System.Windows.Forms.Label lb_account;
		private System.Windows.Forms.TextBox tb_amount;
		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.BindingSource bds_good;
		private System.Windows.Forms.BindingSource bds_detail;
	}
}