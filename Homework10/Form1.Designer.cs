
namespace Homework9
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
			this.tb_url = new System.Windows.Forms.TextBox();
			this.btn_start = new System.Windows.Forms.Button();
			this.dataGrid_showUrl = new System.Windows.Forms.DataGridView();
			this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.URLbindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lab_status = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_showUrl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.URLbindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Controls.Add(this.tb_url, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btn_start, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1234, 89);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tb_url
			// 
			this.tb_url.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tb_url.Location = new System.Drawing.Point(29, 27);
			this.tb_url.Name = "tb_url";
			this.tb_url.Size = new System.Drawing.Size(928, 35);
			this.tb_url.TabIndex = 0;
			this.tb_url.Text = "http://www.cnblogs.com/dstang2000/";
			// 
			// btn_start
			// 
			this.btn_start.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_start.Location = new System.Drawing.Point(1026, 20);
			this.btn_start.Name = "btn_start";
			this.btn_start.Size = new System.Drawing.Size(169, 49);
			this.btn_start.TabIndex = 1;
			this.btn_start.Text = "开始";
			this.btn_start.UseVisualStyleBackColor = true;
			this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
			// 
			// dataGrid_showUrl
			// 
			this.dataGrid_showUrl.AutoGenerateColumns = false;
			this.dataGrid_showUrl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid_showUrl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.Column2,
            this.Column3});
			this.dataGrid_showUrl.DataSource = this.URLbindingSource;
			this.dataGrid_showUrl.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGrid_showUrl.Location = new System.Drawing.Point(0, 134);
			this.dataGrid_showUrl.Name = "dataGrid_showUrl";
			this.dataGrid_showUrl.RowHeadersWidth = 82;
			this.dataGrid_showUrl.RowTemplate.Height = 37;
			this.dataGrid_showUrl.Size = new System.Drawing.Size(1234, 576);
			this.dataGrid_showUrl.TabIndex = 1;
			// 
			// column1
			// 
			this.column1.DataPropertyName = "Index";
			this.column1.HeaderText = "序号";
			this.column1.MinimumWidth = 10;
			this.column1.Name = "column1";
			this.column1.Width = 200;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "URL";
			this.Column2.HeaderText = "URL";
			this.Column2.MinimumWidth = 10;
			this.Column2.Name = "Column2";
			this.Column2.Width = 600;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "Status";
			this.Column3.HeaderText = "是否已经爬取完成";
			this.Column3.MinimumWidth = 10;
			this.Column3.Name = "Column3";
			this.Column3.Width = 200;
			// 
			// lab_status
			// 
			this.lab_status.AutoSize = true;
			this.lab_status.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lab_status.Location = new System.Drawing.Point(0, 89);
			this.lab_status.Name = "lab_status";
			this.lab_status.Size = new System.Drawing.Size(58, 24);
			this.lab_status.TabIndex = 2;
			this.lab_status.Text = "爬虫";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1234, 710);
			this.Controls.Add(this.lab_status);
			this.Controls.Add(this.dataGrid_showUrl);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_showUrl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.URLbindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox tb_url;
		private System.Windows.Forms.Button btn_start;
		private System.Windows.Forms.DataGridView dataGrid_showUrl;
		private System.Windows.Forms.BindingSource URLbindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.Label lab_status;
	}
}

