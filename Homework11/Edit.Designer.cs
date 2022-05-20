
namespace Homework11
{
	partial class Edit
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
			this.tlp_edit = new System.Windows.Forms.TableLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_orderId = new System.Windows.Forms.TextBox();
			this.cbx_Client = new System.Windows.Forms.ComboBox();
			this.bds_client = new System.Windows.Forms.BindingSource(this.components);
			this.lb_createTime = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dgv_details = new System.Windows.Forms.DataGridView();
			this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Goods = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bds_detail = new System.Windows.Forms.BindingSource(this.components);
			this.bds_order = new System.Windows.Forms.BindingSource(this.components);
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_saveOrder = new System.Windows.Forms.Button();
			this.btn_addDetail = new System.Windows.Forms.Button();
			this.btn_changeDetail = new System.Windows.Forms.Button();
			this.btn_deleteDetaiil = new System.Windows.Forms.Button();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.indexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.goodsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.goodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.goodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.goodNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tlp_edit.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bds_client)).BeginInit();
			this.panel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_details)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bds_detail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bds_order)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlp_edit
			// 
			this.tlp_edit.ColumnCount = 2;
			this.tlp_edit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlp_edit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlp_edit.Controls.Add(this.label3, 0, 2);
			this.tlp_edit.Controls.Add(this.label2, 0, 0);
			this.tlp_edit.Controls.Add(this.tb_orderId, 1, 0);
			this.tlp_edit.Controls.Add(this.cbx_Client, 1, 1);
			this.tlp_edit.Controls.Add(this.lb_createTime, 1, 2);
			this.tlp_edit.Controls.Add(this.label1, 0, 1);
			this.tlp_edit.Location = new System.Drawing.Point(18, 9);
			this.tlp_edit.Name = "tlp_edit";
			this.tlp_edit.RowCount = 3;
			this.tlp_edit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlp_edit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlp_edit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlp_edit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlp_edit.Size = new System.Drawing.Size(818, 204);
			this.tlp_edit.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(151, 158);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(106, 24);
			this.label3.TabIndex = 14;
			this.label3.Text = "下单时间";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(163, 22);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 24);
			this.label2.TabIndex = 8;
			this.label2.Text = "订单号";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tb_orderId
			// 
			this.tb_orderId.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tb_orderId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_orderId.Location = new System.Drawing.Point(415, 16);
			this.tb_orderId.Margin = new System.Windows.Forms.Padding(6);
			this.tb_orderId.Name = "tb_orderId";
			this.tb_orderId.Size = new System.Drawing.Size(397, 35);
			this.tb_orderId.TabIndex = 10;
			// 
			// cbx_Client
			// 
			this.cbx_Client.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbx_Client.DataSource = this.bds_client;
			this.cbx_Client.DisplayMember = "ClientName";
			this.cbx_Client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_Client.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbx_Client.FormattingEnabled = true;
			this.cbx_Client.Location = new System.Drawing.Point(415, 86);
			this.cbx_Client.Margin = new System.Windows.Forms.Padding(6);
			this.cbx_Client.Name = "cbx_Client";
			this.cbx_Client.Size = new System.Drawing.Size(397, 32);
			this.cbx_Client.TabIndex = 11;
			// 
			// bds_client
			// 
			this.bds_client.DataSource = typeof(Homework11.Client);
			// 
			// lb_createTime
			// 
			this.lb_createTime.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lb_createTime.AutoSize = true;
			this.lb_createTime.Location = new System.Drawing.Point(554, 158);
			this.lb_createTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lb_createTime.Name = "lb_createTime";
			this.lb_createTime.Size = new System.Drawing.Size(118, 24);
			this.lb_createTime.TabIndex = 13;
			this.lb_createTime.Text = "2020-4-10";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(175, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 24);
			this.label1.TabIndex = 15;
			this.label1.Text = "客户";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Location = new System.Drawing.Point(20, 221);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(647, 350);
			this.panel1.TabIndex = 1;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgv_details);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
			this.groupBox2.Size = new System.Drawing.Size(647, 350);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "订单明细";
			// 
			// dgv_details
			// 
			this.dgv_details.AllowUserToAddRows = false;
			this.dgv_details.AutoGenerateColumns = false;
			this.dgv_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Goods,
            this.UnitPrice,
            this.Amount,
            this.idDataGridViewTextBoxColumn,
            this.indexDataGridViewTextBoxColumn,
            this.goodsIdDataGridViewTextBoxColumn,
            this.goodDataGridViewTextBoxColumn,
            this.goodNameDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.goodNumDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
			this.dgv_details.DataSource = this.bds_detail;
			this.dgv_details.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_details.Location = new System.Drawing.Point(6, 34);
			this.dgv_details.Margin = new System.Windows.Forms.Padding(6);
			this.dgv_details.Name = "dgv_details";
			this.dgv_details.ReadOnly = true;
			this.dgv_details.RowHeadersWidth = 82;
			this.dgv_details.RowTemplate.Height = 23;
			this.dgv_details.Size = new System.Drawing.Size(635, 310);
			this.dgv_details.TabIndex = 0;
			// 
			// Index
			// 
			this.Index.DataPropertyName = "Index";
			this.Index.HeaderText = "序号";
			this.Index.MinimumWidth = 10;
			this.Index.Name = "Index";
			this.Index.ReadOnly = true;
			this.Index.Width = 200;
			// 
			// Goods
			// 
			this.Goods.DataPropertyName = "GoodsName";
			this.Goods.HeaderText = "货物";
			this.Goods.MinimumWidth = 10;
			this.Goods.Name = "Goods";
			this.Goods.ReadOnly = true;
			this.Goods.Width = 200;
			// 
			// UnitPrice
			// 
			this.UnitPrice.DataPropertyName = "UnitPrice";
			this.UnitPrice.HeaderText = "单价";
			this.UnitPrice.MinimumWidth = 10;
			this.UnitPrice.Name = "UnitPrice";
			this.UnitPrice.ReadOnly = true;
			this.UnitPrice.Width = 200;
			// 
			// Amount
			// 
			this.Amount.DataPropertyName = "TotalPrice";
			this.Amount.HeaderText = "总价";
			this.Amount.MinimumWidth = 10;
			this.Amount.Name = "Amount";
			this.Amount.ReadOnly = true;
			this.Amount.Width = 200;
			// 
			// bds_detail
			// 
			this.bds_detail.DataMember = "OrderDetails";
			this.bds_detail.DataSource = this.bds_order;
			// 
			// bds_order
			// 
			this.bds_order.DataSource = typeof(Homework11.Order);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.btn_saveOrder, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.btn_addDetail, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btn_changeDetail, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btn_deleteDetaiil, 0, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(677, 258);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(158, 306);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// btn_saveOrder
			// 
			this.btn_saveOrder.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btn_saveOrder.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btn_saveOrder.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btn_saveOrder.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btn_saveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_saveOrder.Location = new System.Drawing.Point(6, 244);
			this.btn_saveOrder.Margin = new System.Windows.Forms.Padding(6);
			this.btn_saveOrder.Name = "btn_saveOrder";
			this.btn_saveOrder.Size = new System.Drawing.Size(146, 46);
			this.btn_saveOrder.TabIndex = 9;
			this.btn_saveOrder.Text = "保存订单";
			this.btn_saveOrder.UseVisualStyleBackColor = false;
			this.btn_saveOrder.Click += new System.EventHandler(this.btn_saveOrder_Click);
			// 
			// btn_addDetail
			// 
			this.btn_addDetail.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btn_addDetail.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btn_addDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_addDetail.Location = new System.Drawing.Point(6, 15);
			this.btn_addDetail.Margin = new System.Windows.Forms.Padding(6);
			this.btn_addDetail.Name = "btn_addDetail";
			this.btn_addDetail.Size = new System.Drawing.Size(146, 46);
			this.btn_addDetail.TabIndex = 6;
			this.btn_addDetail.Text = "添加明细";
			this.btn_addDetail.UseVisualStyleBackColor = true;
			this.btn_addDetail.Click += new System.EventHandler(this.btn_addDetail_Click);
			// 
			// btn_changeDetail
			// 
			this.btn_changeDetail.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btn_changeDetail.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btn_changeDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_changeDetail.Location = new System.Drawing.Point(6, 91);
			this.btn_changeDetail.Margin = new System.Windows.Forms.Padding(6);
			this.btn_changeDetail.Name = "btn_changeDetail";
			this.btn_changeDetail.Size = new System.Drawing.Size(146, 46);
			this.btn_changeDetail.TabIndex = 7;
			this.btn_changeDetail.Text = "修改明细";
			this.btn_changeDetail.UseVisualStyleBackColor = true;
			this.btn_changeDetail.Click += new System.EventHandler(this.btn_changeDetail_Click);
			// 
			// btn_deleteDetaiil
			// 
			this.btn_deleteDetaiil.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btn_deleteDetaiil.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btn_deleteDetaiil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_deleteDetaiil.Location = new System.Drawing.Point(6, 167);
			this.btn_deleteDetaiil.Margin = new System.Windows.Forms.Padding(6);
			this.btn_deleteDetaiil.Name = "btn_deleteDetaiil";
			this.btn_deleteDetaiil.Size = new System.Drawing.Size(146, 46);
			this.btn_deleteDetaiil.TabIndex = 8;
			this.btn_deleteDetaiil.Text = "删除明细";
			this.btn_deleteDetaiil.UseVisualStyleBackColor = true;
			this.btn_deleteDetaiil.Click += new System.EventHandler(this.btn_deleteDetaiil_Click);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.MinimumWidth = 10;
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Width = 200;
			// 
			// indexDataGridViewTextBoxColumn
			// 
			this.indexDataGridViewTextBoxColumn.DataPropertyName = "Index";
			this.indexDataGridViewTextBoxColumn.HeaderText = "Index";
			this.indexDataGridViewTextBoxColumn.MinimumWidth = 10;
			this.indexDataGridViewTextBoxColumn.Name = "indexDataGridViewTextBoxColumn";
			this.indexDataGridViewTextBoxColumn.ReadOnly = true;
			this.indexDataGridViewTextBoxColumn.Width = 200;
			// 
			// goodsIdDataGridViewTextBoxColumn
			// 
			this.goodsIdDataGridViewTextBoxColumn.DataPropertyName = "GoodsId";
			this.goodsIdDataGridViewTextBoxColumn.HeaderText = "GoodsId";
			this.goodsIdDataGridViewTextBoxColumn.MinimumWidth = 10;
			this.goodsIdDataGridViewTextBoxColumn.Name = "goodsIdDataGridViewTextBoxColumn";
			this.goodsIdDataGridViewTextBoxColumn.ReadOnly = true;
			this.goodsIdDataGridViewTextBoxColumn.Width = 200;
			// 
			// goodDataGridViewTextBoxColumn
			// 
			this.goodDataGridViewTextBoxColumn.DataPropertyName = "Good";
			this.goodDataGridViewTextBoxColumn.HeaderText = "Good";
			this.goodDataGridViewTextBoxColumn.MinimumWidth = 10;
			this.goodDataGridViewTextBoxColumn.Name = "goodDataGridViewTextBoxColumn";
			this.goodDataGridViewTextBoxColumn.ReadOnly = true;
			this.goodDataGridViewTextBoxColumn.Width = 200;
			// 
			// goodNameDataGridViewTextBoxColumn
			// 
			this.goodNameDataGridViewTextBoxColumn.DataPropertyName = "GoodName";
			this.goodNameDataGridViewTextBoxColumn.HeaderText = "GoodName";
			this.goodNameDataGridViewTextBoxColumn.MinimumWidth = 10;
			this.goodNameDataGridViewTextBoxColumn.Name = "goodNameDataGridViewTextBoxColumn";
			this.goodNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.goodNameDataGridViewTextBoxColumn.Width = 200;
			// 
			// unitPriceDataGridViewTextBoxColumn
			// 
			this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
			this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
			this.unitPriceDataGridViewTextBoxColumn.MinimumWidth = 10;
			this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
			this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
			this.unitPriceDataGridViewTextBoxColumn.Width = 200;
			// 
			// goodNumDataGridViewTextBoxColumn
			// 
			this.goodNumDataGridViewTextBoxColumn.DataPropertyName = "GoodNum";
			this.goodNumDataGridViewTextBoxColumn.HeaderText = "GoodNum";
			this.goodNumDataGridViewTextBoxColumn.MinimumWidth = 10;
			this.goodNumDataGridViewTextBoxColumn.Name = "goodNumDataGridViewTextBoxColumn";
			this.goodNumDataGridViewTextBoxColumn.ReadOnly = true;
			this.goodNumDataGridViewTextBoxColumn.Width = 200;
			// 
			// amountDataGridViewTextBoxColumn
			// 
			this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
			this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
			this.amountDataGridViewTextBoxColumn.MinimumWidth = 10;
			this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
			this.amountDataGridViewTextBoxColumn.ReadOnly = true;
			this.amountDataGridViewTextBoxColumn.Width = 200;
			// 
			// Edit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(852, 580);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tlp_edit);
			this.Name = "Edit";
			this.Text = "Edit";
			this.tlp_edit.ResumeLayout(false);
			this.tlp_edit.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bds_client)).EndInit();
			this.panel1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_details)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bds_detail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bds_order)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlp_edit;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_orderId;
		private System.Windows.Forms.ComboBox cbx_Client;
		private System.Windows.Forms.Label lb_createTime;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dgv_details;
		private System.Windows.Forms.DataGridViewTextBoxColumn Index;
		private System.Windows.Forms.DataGridViewTextBoxColumn Goods;
		private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
		private System.Windows.Forms.BindingSource bds_detail;
		private System.Windows.Forms.BindingSource bds_order;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btn_saveOrder;
		private System.Windows.Forms.Button btn_addDetail;
		private System.Windows.Forms.Button btn_changeDetail;
		private System.Windows.Forms.Button btn_deleteDetaiil;
		private System.Windows.Forms.BindingSource bds_client;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn indexDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn goodsIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn goodDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn goodNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn goodNumDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
	}
}