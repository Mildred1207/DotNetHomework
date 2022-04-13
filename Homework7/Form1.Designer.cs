
namespace Homework7
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
			this.panal_Caylay = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_clear = new System.Windows.Forms.Button();
			this.tb_th2 = new System.Windows.Forms.TextBox();
			this.tb_th1 = new System.Windows.Forms.TextBox();
			this.tb_per2 = new System.Windows.Forms.TextBox();
			this.tb_per1 = new System.Windows.Forms.TextBox();
			this.tb_leng = new System.Windows.Forms.TextBox();
			this.lab_leng = new System.Windows.Forms.Label();
			this.lab_height = new System.Windows.Forms.Label();
			this.tb_height = new System.Windows.Forms.TextBox();
			this.lab_per1 = new System.Windows.Forms.Label();
			this.lab_per2 = new System.Windows.Forms.Label();
			this.lab_th2 = new System.Windows.Forms.Label();
			this.lab_th1 = new System.Windows.Forms.Label();
			this.lab_pen = new System.Windows.Forms.Label();
			this.cbox_pen = new System.Windows.Forms.ComboBox();
			this.btn_draw = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panal_Caylay
			// 
			this.panal_Caylay.Dock = System.Windows.Forms.DockStyle.Left;
			this.panal_Caylay.Location = new System.Drawing.Point(0, 0);
			this.panal_Caylay.Name = "panal_Caylay";
			this.panal_Caylay.Size = new System.Drawing.Size(873, 751);
			this.panal_Caylay.TabIndex = 0;
			this.panal_Caylay.Paint += new System.Windows.Forms.PaintEventHandler(this.panal_Caylay_Paint);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.btn_clear, 1, 7);
			this.tableLayoutPanel1.Controls.Add(this.tb_th2, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.tb_th1, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.tb_per2, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.tb_per1, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.tb_leng, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.lab_leng, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lab_height, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tb_height, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.lab_per1, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.lab_per2, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.lab_th2, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.lab_th1, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.lab_pen, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.cbox_pen, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.btn_draw, 0, 7);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(873, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 8;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(416, 751);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// btn_clear
			// 
			this.btn_clear.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_clear.Location = new System.Drawing.Point(245, 681);
			this.btn_clear.Name = "btn_clear";
			this.btn_clear.Size = new System.Drawing.Size(133, 40);
			this.btn_clear.TabIndex = 15;
			this.btn_clear.Text = "清空";
			this.btn_clear.UseVisualStyleBackColor = true;
			this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
			// 
			// tb_th2
			// 
			this.tb_th2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tb_th2.Location = new System.Drawing.Point(223, 494);
			this.tb_th2.Name = "tb_th2";
			this.tb_th2.Size = new System.Drawing.Size(177, 35);
			this.tb_th2.TabIndex = 12;
			this.tb_th2.Text = "0.44";
			// 
			// tb_th1
			// 
			this.tb_th1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tb_th1.Location = new System.Drawing.Point(223, 401);
			this.tb_th1.Name = "tb_th1";
			this.tb_th1.Size = new System.Drawing.Size(177, 35);
			this.tb_th1.TabIndex = 11;
			this.tb_th1.Text = "0.52";
			// 
			// tb_per2
			// 
			this.tb_per2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tb_per2.Location = new System.Drawing.Point(223, 308);
			this.tb_per2.Name = "tb_per2";
			this.tb_per2.Size = new System.Drawing.Size(177, 35);
			this.tb_per2.TabIndex = 10;
			this.tb_per2.Text = "0.7";
			// 
			// tb_per1
			// 
			this.tb_per1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tb_per1.Location = new System.Drawing.Point(223, 215);
			this.tb_per1.Name = "tb_per1";
			this.tb_per1.Size = new System.Drawing.Size(177, 35);
			this.tb_per1.TabIndex = 9;
			this.tb_per1.Text = "0.6";
			// 
			// tb_leng
			// 
			this.tb_leng.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tb_leng.Location = new System.Drawing.Point(223, 122);
			this.tb_leng.Name = "tb_leng";
			this.tb_leng.Size = new System.Drawing.Size(177, 35);
			this.tb_leng.TabIndex = 8;
			this.tb_leng.Text = "100";
			// 
			// lab_leng
			// 
			this.lab_leng.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lab_leng.AutoSize = true;
			this.lab_leng.Location = new System.Drawing.Point(51, 127);
			this.lab_leng.Name = "lab_leng";
			this.lab_leng.Size = new System.Drawing.Size(106, 24);
			this.lab_leng.TabIndex = 2;
			this.lab_leng.Text = "主干长度";
			// 
			// lab_height
			// 
			this.lab_height.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lab_height.AutoSize = true;
			this.lab_height.Location = new System.Drawing.Point(51, 34);
			this.lab_height.Name = "lab_height";
			this.lab_height.Size = new System.Drawing.Size(106, 24);
			this.lab_height.TabIndex = 0;
			this.lab_height.Text = "递归深度";
			// 
			// tb_height
			// 
			this.tb_height.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.tb_height.Location = new System.Drawing.Point(223, 29);
			this.tb_height.Name = "tb_height";
			this.tb_height.Size = new System.Drawing.Size(177, 35);
			this.tb_height.TabIndex = 1;
			this.tb_height.Text = "3";
			// 
			// lab_per1
			// 
			this.lab_per1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lab_per1.AutoSize = true;
			this.lab_per1.Location = new System.Drawing.Point(27, 220);
			this.lab_per1.Name = "lab_per1";
			this.lab_per1.Size = new System.Drawing.Size(154, 24);
			this.lab_per1.TabIndex = 3;
			this.lab_per1.Text = "右分支长度比";
			// 
			// lab_per2
			// 
			this.lab_per2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lab_per2.AutoSize = true;
			this.lab_per2.Location = new System.Drawing.Point(27, 313);
			this.lab_per2.Name = "lab_per2";
			this.lab_per2.Size = new System.Drawing.Size(154, 24);
			this.lab_per2.TabIndex = 4;
			this.lab_per2.Text = "左分支长度比";
			// 
			// lab_th2
			// 
			this.lab_th2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lab_th2.AutoSize = true;
			this.lab_th2.Location = new System.Drawing.Point(39, 499);
			this.lab_th2.Name = "lab_th2";
			this.lab_th2.Size = new System.Drawing.Size(130, 24);
			this.lab_th2.TabIndex = 5;
			this.lab_th2.Text = "左分支角度";
			// 
			// lab_th1
			// 
			this.lab_th1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lab_th1.AutoSize = true;
			this.lab_th1.Location = new System.Drawing.Point(39, 406);
			this.lab_th1.Name = "lab_th1";
			this.lab_th1.Size = new System.Drawing.Size(130, 24);
			this.lab_th1.TabIndex = 6;
			this.lab_th1.Text = "右分支角度";
			// 
			// lab_pen
			// 
			this.lab_pen.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lab_pen.AutoSize = true;
			this.lab_pen.Location = new System.Drawing.Point(51, 592);
			this.lab_pen.Name = "lab_pen";
			this.lab_pen.Size = new System.Drawing.Size(106, 24);
			this.lab_pen.TabIndex = 7;
			this.lab_pen.Text = "画笔颜色";
			// 
			// cbox_pen
			// 
			this.cbox_pen.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbox_pen.FormattingEnabled = true;
			this.cbox_pen.Items.AddRange(new object[] {
            "蓝色",
            "红色",
            "黄色",
            "绿色"});
			this.cbox_pen.Location = new System.Drawing.Point(225, 588);
			this.cbox_pen.Name = "cbox_pen";
			this.cbox_pen.Size = new System.Drawing.Size(174, 32);
			this.cbox_pen.TabIndex = 13;
			this.cbox_pen.Text = "蓝色";
			this.cbox_pen.SelectedIndexChanged += new System.EventHandler(this.cbox_pen_SelectedIndexChanged);
			// 
			// btn_draw
			// 
			this.btn_draw.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_draw.Location = new System.Drawing.Point(37, 681);
			this.btn_draw.Name = "btn_draw";
			this.btn_draw.Size = new System.Drawing.Size(133, 40);
			this.btn_draw.TabIndex = 14;
			this.btn_draw.Text = "绘图";
			this.btn_draw.UseVisualStyleBackColor = true;
			this.btn_draw.Click += new System.EventHandler(this.btn_draw_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1289, 751);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.panal_Caylay);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panal_Caylay;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btn_clear;
		private System.Windows.Forms.TextBox tb_th2;
		private System.Windows.Forms.TextBox tb_th1;
		private System.Windows.Forms.TextBox tb_per2;
		private System.Windows.Forms.TextBox tb_per1;
		private System.Windows.Forms.TextBox tb_leng;
		private System.Windows.Forms.Label lab_leng;
		private System.Windows.Forms.Label lab_height;
		private System.Windows.Forms.TextBox tb_height;
		private System.Windows.Forms.Label lab_per1;
		private System.Windows.Forms.Label lab_per2;
		private System.Windows.Forms.Label lab_th2;
		private System.Windows.Forms.Label lab_th1;
		private System.Windows.Forms.Label lab_pen;
		private System.Windows.Forms.ComboBox cbox_pen;
		private System.Windows.Forms.Button btn_draw;
	}
}

