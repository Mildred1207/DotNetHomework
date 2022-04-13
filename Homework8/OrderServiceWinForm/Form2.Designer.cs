
namespace OrderServiceWinForm
{
	partial class Form2
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
			this.lab_clientname = new System.Windows.Forms.Label();
			this.tb_time = new System.Windows.Forms.TextBox();
			this.lab_time = new System.Windows.Forms.Label();
			this.lab_id = new System.Windows.Forms.Label();
			this.tb_id = new System.Windows.Forms.TextBox();
			this.tb_clientname = new System.Windows.Forms.TextBox();
			this.bindSour_cdetails = new System.Windows.Forms.BindingSource(this.components);
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.cobox_good = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.lab_goodSum = new System.Windows.Forms.Label();
			this.tb_goodSum = new System.Windows.Forms.TextBox();
			this.btn_AddGood = new System.Windows.Forms.Button();
			this.btn_addOrder = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindSour_cdetails)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.lab_clientname, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.tb_time, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.lab_time, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lab_id, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tb_id, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.tb_clientname, 1, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1402, 147);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// lab_clientname
			// 
			this.lab_clientname.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lab_clientname.AutoSize = true;
			this.lab_clientname.Location = new System.Drawing.Point(297, 110);
			this.lab_clientname.Name = "lab_clientname";
			this.lab_clientname.Size = new System.Drawing.Size(106, 24);
			this.lab_clientname.TabIndex = 5;
			this.lab_clientname.Text = "用户名称";
			// 
			// tb_time
			// 
			this.tb_time.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tb_time.Location = new System.Drawing.Point(704, 56);
			this.tb_time.Name = "tb_time";
			this.tb_time.Size = new System.Drawing.Size(281, 35);
			this.tb_time.TabIndex = 4;
			this.tb_time.Text = "20220113";
			// 
			// lab_time
			// 
			this.lab_time.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lab_time.AutoSize = true;
			this.lab_time.Location = new System.Drawing.Point(297, 61);
			this.lab_time.Name = "lab_time";
			this.lab_time.Size = new System.Drawing.Size(106, 24);
			this.lab_time.TabIndex = 2;
			this.lab_time.Text = "下单时间";
			// 
			// lab_id
			// 
			this.lab_id.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lab_id.AutoSize = true;
			this.lab_id.Location = new System.Drawing.Point(309, 12);
			this.lab_id.Name = "lab_id";
			this.lab_id.Size = new System.Drawing.Size(82, 24);
			this.lab_id.TabIndex = 0;
			this.lab_id.Text = "订单ID";
			// 
			// tb_id
			// 
			this.tb_id.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tb_id.Location = new System.Drawing.Point(704, 7);
			this.tb_id.Name = "tb_id";
			this.tb_id.Size = new System.Drawing.Size(281, 35);
			this.tb_id.TabIndex = 3;
			this.tb_id.Text = "1";
			// 
			// tb_clientname
			// 
			this.tb_clientname.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tb_clientname.Location = new System.Drawing.Point(704, 105);
			this.tb_clientname.Name = "tb_clientname";
			this.tb_clientname.Size = new System.Drawing.Size(281, 35);
			this.tb_clientname.TabIndex = 6;
			this.tb_clientname.Text = "wyy";
			// 
			// bindSour_cdetails
			// 
			this.bindSour_cdetails.DataSource = typeof(Homework6.OrderDetails);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.cobox_good, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.btn_AddGood, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.btn_addOrder, 0, 3);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 147);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 4;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1402, 583);
			this.tableLayoutPanel2.TabIndex = 3;
			// 
			// cobox_good
			// 
			this.cobox_good.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cobox_good.FormattingEnabled = true;
			this.cobox_good.Items.AddRange(new object[] {
            "good1",
            "good2",
            "good3"});
			this.cobox_good.Location = new System.Drawing.Point(578, 69);
			this.cobox_good.Name = "cobox_good";
			this.cobox_good.Size = new System.Drawing.Size(246, 32);
			this.cobox_good.TabIndex = 0;
			this.cobox_good.Text = "good1";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Controls.Add(this.lab_goodSum, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.tb_goodSum, 1, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 173);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(1396, 164);
			this.tableLayoutPanel3.TabIndex = 1;
			// 
			// lab_goodSum
			// 
			this.lab_goodSum.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lab_goodSum.AutoSize = true;
			this.lab_goodSum.Location = new System.Drawing.Point(296, 70);
			this.lab_goodSum.Name = "lab_goodSum";
			this.lab_goodSum.Size = new System.Drawing.Size(106, 24);
			this.lab_goodSum.TabIndex = 0;
			this.lab_goodSum.Text = "货物数量";
			// 
			// tb_goodSum
			// 
			this.tb_goodSum.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tb_goodSum.Location = new System.Drawing.Point(976, 64);
			this.tb_goodSum.Name = "tb_goodSum";
			this.tb_goodSum.Size = new System.Drawing.Size(141, 35);
			this.tb_goodSum.TabIndex = 1;
			this.tb_goodSum.Text = "10";
			// 
			// btn_AddGood
			// 
			this.btn_AddGood.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_AddGood.Location = new System.Drawing.Point(586, 390);
			this.btn_AddGood.Name = "btn_AddGood";
			this.btn_AddGood.Size = new System.Drawing.Size(229, 70);
			this.btn_AddGood.TabIndex = 2;
			this.btn_AddGood.Text = "添加货物";
			this.btn_AddGood.UseVisualStyleBackColor = true;
			this.btn_AddGood.Click += new System.EventHandler(this.btn_AddGood_Click);
			// 
			// btn_addOrder
			// 
			this.btn_addOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btn_addOrder.Location = new System.Drawing.Point(3, 513);
			this.btn_addOrder.Name = "btn_addOrder";
			this.btn_addOrder.Size = new System.Drawing.Size(1396, 67);
			this.btn_addOrder.TabIndex = 3;
			this.btn_addOrder.Text = "完成";
			this.btn_addOrder.UseVisualStyleBackColor = true;
			this.btn_addOrder.Click += new System.EventHandler(this.btn_addOrder_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1402, 730);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Form2";
			this.Text = "新建订单或修改订单";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindSour_cdetails)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox tb_time;
		private System.Windows.Forms.Label lab_time;
		private System.Windows.Forms.Label lab_id;
		private System.Windows.Forms.TextBox tb_id;
		private System.Windows.Forms.Label lab_clientname;
		private System.Windows.Forms.TextBox tb_clientname;
		private System.Windows.Forms.BindingSource bindSour_cdetails;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.ComboBox cobox_good;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label lab_goodSum;
		private System.Windows.Forms.TextBox tb_goodSum;
		private System.Windows.Forms.Button btn_AddGood;
		private System.Windows.Forms.Button btn_addOrder;
	}
}