
namespace OrderServiceWinForm
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.cobox_search = new System.Windows.Forms.ComboBox();
			this.tb_search = new System.Windows.Forms.TextBox();
			this.btn_search = new System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_import = new System.Windows.Forms.Button();
			this.btn_export = new System.Windows.Forms.Button();
			this.btn_change = new System.Windows.Forms.Button();
			this.btn_delete = new System.Windows.Forms.Button();
			this.btn_add = new System.Windows.Forms.Button();
			this.daGri_order = new System.Windows.Forms.DataGridView();
			this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sumValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.daGri_details = new System.Windows.Forms.DataGridView();
			this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
			this.bindSour_order = new System.Windows.Forms.BindingSource(this.components);
			this.bindSour_details = new System.Windows.Forms.BindingSource(this.components);
			this.openFile_port = new System.Windows.Forms.OpenFileDialog();
			this.goodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.goodNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.daGri_order)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.daGri_details)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindSour_order)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindSour_details)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.cobox_search, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tb_search, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btn_search, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1171, 93);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// cobox_search
			// 
			this.cobox_search.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cobox_search.FormattingEnabled = true;
			this.cobox_search.Items.AddRange(new object[] {
            "ALL",
            "ID",
            "Client",
            "SumValue"});
			this.cobox_search.Location = new System.Drawing.Point(20, 30);
			this.cobox_search.Name = "cobox_search";
			this.cobox_search.Size = new System.Drawing.Size(350, 32);
			this.cobox_search.TabIndex = 0;
			this.cobox_search.Text = "ALL";
			// 
			// tb_search
			// 
			this.tb_search.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tb_search.Location = new System.Drawing.Point(420, 29);
			this.tb_search.Name = "tb_search";
			this.tb_search.Size = new System.Drawing.Size(330, 35);
			this.tb_search.TabIndex = 1;
			this.tb_search.Text = "1";
			// 
			// btn_search
			// 
			this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btn_search.Location = new System.Drawing.Point(783, 19);
			this.btn_search.Name = "btn_search";
			this.btn_search.Size = new System.Drawing.Size(200, 54);
			this.btn_search.TabIndex = 2;
			this.btn_search.Text = "查询";
			this.btn_search.UseVisualStyleBackColor = true;
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 5;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.Controls.Add(this.btn_import, 4, 0);
			this.tableLayoutPanel2.Controls.Add(this.btn_export, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.btn_change, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.btn_delete, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.btn_add, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 93);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1171, 93);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// btn_import
			// 
			this.btn_import.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_import.Location = new System.Drawing.Point(959, 17);
			this.btn_import.Name = "btn_import";
			this.btn_import.Size = new System.Drawing.Size(189, 58);
			this.btn_import.TabIndex = 4;
			this.btn_import.Text = "导入订单";
			this.btn_import.UseVisualStyleBackColor = true;
			this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
			// 
			// btn_export
			// 
			this.btn_export.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_export.Location = new System.Drawing.Point(724, 17);
			this.btn_export.Name = "btn_export";
			this.btn_export.Size = new System.Drawing.Size(189, 58);
			this.btn_export.TabIndex = 3;
			this.btn_export.Text = "导出订单";
			this.btn_export.UseVisualStyleBackColor = true;
			this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
			// 
			// btn_change
			// 
			this.btn_change.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_change.Location = new System.Drawing.Point(490, 17);
			this.btn_change.Name = "btn_change";
			this.btn_change.Size = new System.Drawing.Size(189, 58);
			this.btn_change.TabIndex = 2;
			this.btn_change.Text = "修改订单";
			this.btn_change.UseVisualStyleBackColor = true;
			this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_delete.Location = new System.Drawing.Point(256, 17);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(189, 58);
			this.btn_delete.TabIndex = 1;
			this.btn_delete.Text = "删除订单";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// btn_add
			// 
			this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_add.Location = new System.Drawing.Point(22, 17);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(189, 58);
			this.btn_add.TabIndex = 0;
			this.btn_add.Text = "添加订单";
			this.btn_add.UseVisualStyleBackColor = true;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// daGri_order
			// 
			this.daGri_order.AutoGenerateColumns = false;
			this.daGri_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.daGri_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.orderTimeDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.sumValueDataGridViewTextBoxColumn});
			this.daGri_order.DataSource = this.orderBindingSource;
			this.daGri_order.Dock = System.Windows.Forms.DockStyle.Left;
			this.daGri_order.Location = new System.Drawing.Point(0, 186);
			this.daGri_order.Name = "daGri_order";
			this.daGri_order.RowHeadersWidth = 82;
			this.daGri_order.RowTemplate.Height = 37;
			this.daGri_order.Size = new System.Drawing.Size(585, 561);
			this.daGri_order.TabIndex = 2;
			// 
			// orderIdDataGridViewTextBoxColumn
			// 
			this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
			this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
			this.orderIdDataGridViewTextBoxColumn.MinimumWidth = 10;
			this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
			this.orderIdDataGridViewTextBoxColumn.Width = 200;
			// 
			// orderTimeDataGridViewTextBoxColumn
			// 
			this.orderTimeDataGridViewTextBoxColumn.DataPropertyName = "OrderTime";
			this.orderTimeDataGridViewTextBoxColumn.HeaderText = "OrderTime";
			this.orderTimeDataGridViewTextBoxColumn.MinimumWidth = 10;
			this.orderTimeDataGridViewTextBoxColumn.Name = "orderTimeDataGridViewTextBoxColumn";
			this.orderTimeDataGridViewTextBoxColumn.Width = 200;
			// 
			// clientDataGridViewTextBoxColumn
			// 
			this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
			this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
			this.clientDataGridViewTextBoxColumn.MinimumWidth = 10;
			this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
			this.clientDataGridViewTextBoxColumn.Width = 200;
			// 
			// sumValueDataGridViewTextBoxColumn
			// 
			this.sumValueDataGridViewTextBoxColumn.DataPropertyName = "SumValue";
			this.sumValueDataGridViewTextBoxColumn.HeaderText = "SumValue";
			this.sumValueDataGridViewTextBoxColumn.MinimumWidth = 10;
			this.sumValueDataGridViewTextBoxColumn.Name = "sumValueDataGridViewTextBoxColumn";
			this.sumValueDataGridViewTextBoxColumn.ReadOnly = true;
			this.sumValueDataGridViewTextBoxColumn.Width = 200;
			// 
			// orderBindingSource
			// 
			this.orderBindingSource.DataSource = typeof(Homework6.Order);
			// 
			// daGri_details
			// 
			this.daGri_details.AutoGenerateColumns = false;
			this.daGri_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.daGri_details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodDataGridViewTextBoxColumn,
            this.goodNumDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
			this.daGri_details.DataSource = this.orderDetailsBindingSource;
			this.daGri_details.Dock = System.Windows.Forms.DockStyle.Fill;
			this.daGri_details.Location = new System.Drawing.Point(585, 186);
			this.daGri_details.Name = "daGri_details";
			this.daGri_details.RowHeadersWidth = 82;
			this.daGri_details.RowTemplate.Height = 37;
			this.daGri_details.Size = new System.Drawing.Size(586, 561);
			this.daGri_details.TabIndex = 3;
			// 
			// orderDetailsBindingSource
			// 
			this.orderDetailsBindingSource.DataMember = "OrderDetails";
			this.orderDetailsBindingSource.DataSource = this.orderBindingSource;
			// 
			// fileSystemWatcher1
			// 
			this.fileSystemWatcher1.EnableRaisingEvents = true;
			this.fileSystemWatcher1.SynchronizingObject = this;
			// 
			// bindSour_order
			// 
			this.bindSour_order.DataSource = typeof(Homework6.Order);
			// 
			// bindSour_details
			// 
			this.bindSour_details.DataSource = typeof(Homework6.OrderDetails);
			// 
			// openFile_port
			// 
			this.openFile_port.DereferenceLinks = false;
			this.openFile_port.Filter = "XML 文件|*.xml";
			// 
			// goodDataGridViewTextBoxColumn
			// 
			this.goodDataGridViewTextBoxColumn.DataPropertyName = "Good";
			this.goodDataGridViewTextBoxColumn.HeaderText = "Good";
			this.goodDataGridViewTextBoxColumn.MinimumWidth = 10;
			this.goodDataGridViewTextBoxColumn.Name = "goodDataGridViewTextBoxColumn";
			this.goodDataGridViewTextBoxColumn.Width = 200;
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1171, 747);
			this.Controls.Add(this.daGri_details);
			this.Controls.Add(this.daGri_order);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.daGri_order)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.daGri_details)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindSour_order)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindSour_details)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ComboBox cobox_search;
		private System.Windows.Forms.TextBox tb_search;
		private System.Windows.Forms.Button btn_search;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button btn_import;
		private System.Windows.Forms.Button btn_export;
		private System.Windows.Forms.Button btn_change;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.DataGridView daGri_order;
		private System.Windows.Forms.DataGridView daGri_details;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sumValueDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource orderBindingSource;
		private System.Windows.Forms.BindingSource orderDetailsBindingSource;
		private System.Windows.Forms.BindingSource bindSour_order;
		private System.Windows.Forms.BindingSource bindSour_details;
		private System.IO.FileSystemWatcher fileSystemWatcher1;
		private System.Windows.Forms.OpenFileDialog openFile_port;
		private System.Windows.Forms.DataGridViewTextBoxColumn goodDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn goodNumDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
	}
}

