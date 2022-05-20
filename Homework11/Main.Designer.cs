
namespace Homework11
{
	partial class Main
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
			this.tlp_main_select = new System.Windows.Forms.TableLayoutPanel();
			this.btn_query = new System.Windows.Forms.Button();
			this.tb_keyword = new System.Windows.Forms.TextBox();
			this.cbx_select = new System.Windows.Forms.ComboBox();
			this.tlp_func = new System.Windows.Forms.TableLayoutPanel();
			this.btn_import = new System.Windows.Forms.Button();
			this.btn_output = new System.Windows.Forms.Button();
			this.btn_delete = new System.Windows.Forms.Button();
			this.btn_change = new System.Windows.Forms.Button();
			this.btn_add = new System.Windows.Forms.Button();
			this.pal_show = new System.Windows.Forms.Panel();
			this.dgv_detail = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.indexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.goodsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.goodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.goodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.goodNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_order = new System.Windows.Forms.DataGridView();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.bds_detail = new System.Windows.Forms.BindingSource(this.components);
			this.bds_order = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tlp_main_select.SuspendLayout();
			this.tlp_func.SuspendLayout();
			this.pal_show.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_detail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_order)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bds_detail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bds_order)).BeginInit();
			this.SuspendLayout();
			// 
			// tlp_main_select
			// 
			this.tlp_main_select.ColumnCount = 3;
			this.tlp_main_select.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlp_main_select.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlp_main_select.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tlp_main_select.Controls.Add(this.btn_query, 2, 0);
			this.tlp_main_select.Controls.Add(this.tb_keyword, 1, 0);
			this.tlp_main_select.Controls.Add(this.cbx_select, 0, 0);
			this.tlp_main_select.Dock = System.Windows.Forms.DockStyle.Top;
			this.tlp_main_select.Location = new System.Drawing.Point(0, 0);
			this.tlp_main_select.Name = "tlp_main_select";
			this.tlp_main_select.RowCount = 1;
			this.tlp_main_select.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlp_main_select.Size = new System.Drawing.Size(953, 71);
			this.tlp_main_select.TabIndex = 0;
			// 
			// btn_query
			// 
			this.btn_query.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btn_query.Location = new System.Drawing.Point(797, 12);
			this.btn_query.Margin = new System.Windows.Forms.Padding(6);
			this.btn_query.Name = "btn_query";
			this.btn_query.Size = new System.Drawing.Size(150, 46);
			this.btn_query.TabIndex = 3;
			this.btn_query.Text = "查询";
			this.btn_query.UseVisualStyleBackColor = true;
			this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
			// 
			// tb_keyword
			// 
			this.tb_keyword.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tb_keyword.Location = new System.Drawing.Point(323, 18);
			this.tb_keyword.Margin = new System.Windows.Forms.Padding(6);
			this.tb_keyword.Name = "tb_keyword";
			this.tb_keyword.Size = new System.Drawing.Size(305, 35);
			this.tb_keyword.TabIndex = 2;
			// 
			// cbx_select
			// 
			this.cbx_select.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbx_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_select.FormattingEnabled = true;
			this.cbx_select.Items.AddRange(new object[] {
            "全部订单",
            "ID",
            "客户名",
            "货物名",
            "价格大于"});
			this.cbx_select.Location = new System.Drawing.Point(39, 19);
			this.cbx_select.Margin = new System.Windows.Forms.Padding(6);
			this.cbx_select.Name = "cbx_select";
			this.cbx_select.Size = new System.Drawing.Size(238, 32);
			this.cbx_select.TabIndex = 1;
			// 
			// tlp_func
			// 
			this.tlp_func.ColumnCount = 5;
			this.tlp_func.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlp_func.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlp_func.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlp_func.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlp_func.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tlp_func.Controls.Add(this.btn_import, 0, 0);
			this.tlp_func.Controls.Add(this.btn_output, 0, 0);
			this.tlp_func.Controls.Add(this.btn_delete, 0, 0);
			this.tlp_func.Controls.Add(this.btn_change, 0, 0);
			this.tlp_func.Controls.Add(this.btn_add, 0, 0);
			this.tlp_func.Dock = System.Windows.Forms.DockStyle.Top;
			this.tlp_func.Location = new System.Drawing.Point(0, 71);
			this.tlp_func.Name = "tlp_func";
			this.tlp_func.RowCount = 1;
			this.tlp_func.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlp_func.Size = new System.Drawing.Size(953, 69);
			this.tlp_func.TabIndex = 1;
			// 
			// btn_import
			// 
			this.btn_import.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_import.Location = new System.Drawing.Point(590, 11);
			this.btn_import.Margin = new System.Windows.Forms.Padding(6);
			this.btn_import.Name = "btn_import";
			this.btn_import.Size = new System.Drawing.Size(150, 46);
			this.btn_import.TabIndex = 8;
			this.btn_import.Text = "导入订单";
			this.btn_import.UseVisualStyleBackColor = true;
			this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
			// 
			// btn_output
			// 
			this.btn_output.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_output.Location = new System.Drawing.Point(781, 11);
			this.btn_output.Margin = new System.Windows.Forms.Padding(6);
			this.btn_output.Name = "btn_output";
			this.btn_output.Size = new System.Drawing.Size(150, 46);
			this.btn_output.TabIndex = 7;
			this.btn_output.Text = "导出订单";
			this.btn_output.UseVisualStyleBackColor = true;
			this.btn_output.Click += new System.EventHandler(this.btn_output_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_delete.Location = new System.Drawing.Point(400, 11);
			this.btn_delete.Margin = new System.Windows.Forms.Padding(6);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(150, 46);
			this.btn_delete.TabIndex = 6;
			this.btn_delete.Text = "删除订单";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// btn_change
			// 
			this.btn_change.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_change.Location = new System.Drawing.Point(20, 11);
			this.btn_change.Margin = new System.Windows.Forms.Padding(6);
			this.btn_change.Name = "btn_change";
			this.btn_change.Size = new System.Drawing.Size(150, 46);
			this.btn_change.TabIndex = 5;
			this.btn_change.Text = "修改订单";
			this.btn_change.UseVisualStyleBackColor = true;
			this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
			// 
			// btn_add
			// 
			this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_add.Location = new System.Drawing.Point(210, 11);
			this.btn_add.Margin = new System.Windows.Forms.Padding(6);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(150, 46);
			this.btn_add.TabIndex = 1;
			this.btn_add.Text = "添加订单";
			this.btn_add.UseVisualStyleBackColor = true;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// pal_show
			// 
			this.pal_show.Controls.Add(this.dgv_detail);
			this.pal_show.Controls.Add(this.dgv_order);
			this.pal_show.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pal_show.Location = new System.Drawing.Point(0, 140);
			this.pal_show.Name = "pal_show";
			this.pal_show.Size = new System.Drawing.Size(953, 357);
			this.pal_show.TabIndex = 2;
			// 
			// dgv_detail
			// 
			this.dgv_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_detail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.indexDataGridViewTextBoxColumn,
            this.goodsIdDataGridViewTextBoxColumn,
            this.goodDataGridViewTextBoxColumn,
            this.goodNameDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.goodNumDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
			this.dgv_detail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_detail.Location = new System.Drawing.Point(486, 0);
			this.dgv_detail.Name = "dgv_detail";
			this.dgv_detail.RowHeadersWidth = 82;
			this.dgv_detail.RowTemplate.Height = 37;
			this.dgv_detail.Size = new System.Drawing.Size(467, 357);
			this.dgv_detail.TabIndex = 1;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.MinimumWidth = 10;
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.Width = 200;
			// 
			// indexDataGridViewTextBoxColumn
			// 
			this.indexDataGridViewTextBoxColumn.DataPropertyName = "Index";
			this.indexDataGridViewTextBoxColumn.HeaderText = "Index";
			this.indexDataGridViewTextBoxColumn.MinimumWidth = 10;
			this.indexDataGridViewTextBoxColumn.Name = "indexDataGridViewTextBoxColumn";
			this.indexDataGridViewTextBoxColumn.Width = 200;
			// 
			// goodsIdDataGridViewTextBoxColumn
			// 
			this.goodsIdDataGridViewTextBoxColumn.DataPropertyName = "GoodsId";
			this.goodsIdDataGridViewTextBoxColumn.HeaderText = "GoodsId";
			this.goodsIdDataGridViewTextBoxColumn.MinimumWidth = 10;
			this.goodsIdDataGridViewTextBoxColumn.Name = "goodsIdDataGridViewTextBoxColumn";
			this.goodsIdDataGridViewTextBoxColumn.Width = 200;
			// 
			// goodDataGridViewTextBoxColumn
			// 
			this.goodDataGridViewTextBoxColumn.DataPropertyName = "Good";
			this.goodDataGridViewTextBoxColumn.HeaderText = "Good";
			this.goodDataGridViewTextBoxColumn.MinimumWidth = 10;
			this.goodDataGridViewTextBoxColumn.Name = "goodDataGridViewTextBoxColumn";
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
			// dgv_order
			// 
			this.dgv_order.AutoGenerateColumns = false;
			this.dgv_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			this.dgv_order.DataSource = this.bds_order;
			this.dgv_order.Dock = System.Windows.Forms.DockStyle.Left;
			this.dgv_order.Location = new System.Drawing.Point(0, 0);
			this.dgv_order.Name = "dgv_order";
			this.dgv_order.RowHeadersWidth = 82;
			this.dgv_order.RowTemplate.Height = 37;
			this.dgv_order.Size = new System.Drawing.Size(486, 357);
			this.dgv_order.TabIndex = 0;
			this.dgv_order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_order_CellContentClick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Location = new System.Drawing.Point(0, 475);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
			this.statusStrip1.Size = new System.Drawing.Size(953, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "XML Files (*.xml)|*.xml";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "XML Files (*.xml)|*.xml";
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
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderId";
			this.dataGridViewTextBoxColumn1.HeaderText = "OrderId";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Width = 200;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "ClientID";
			this.dataGridViewTextBoxColumn2.HeaderText = "ClientID";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Width = 200;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Client";
			this.dataGridViewTextBoxColumn3.HeaderText = "Client";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Width = 200;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "ClientName";
			this.dataGridViewTextBoxColumn4.HeaderText = "ClientName";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Width = 200;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "OrderTime";
			this.dataGridViewTextBoxColumn5.HeaderText = "OrderTime";
			this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.Width = 200;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "SumValue";
			this.dataGridViewTextBoxColumn6.HeaderText = "SumValue";
			this.dataGridViewTextBoxColumn6.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn6.Width = 200;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(953, 497);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.pal_show);
			this.Controls.Add(this.tlp_func);
			this.Controls.Add(this.tlp_main_select);
			this.Name = "Main";
			this.Text = "主页";
			this.tlp_main_select.ResumeLayout(false);
			this.tlp_main_select.PerformLayout();
			this.tlp_func.ResumeLayout(false);
			this.pal_show.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_detail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_order)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bds_detail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bds_order)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlp_main_select;
		private System.Windows.Forms.Button btn_query;
		private System.Windows.Forms.TextBox tb_keyword;
		private System.Windows.Forms.ComboBox cbx_select;
		private System.Windows.Forms.TableLayoutPanel tlp_func;
		private System.Windows.Forms.Button btn_import;
		private System.Windows.Forms.Button btn_output;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.Button btn_change;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.Panel pal_show;
		private System.Windows.Forms.DataGridView dgv_detail;
		private System.Windows.Forms.DataGridView dgv_order;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sumValueDataGridViewTextBoxColumn;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn indexDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn goodsIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn goodDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn goodNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn goodNumDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource bds_detail;
		private System.Windows.Forms.BindingSource bds_order;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
	}
}