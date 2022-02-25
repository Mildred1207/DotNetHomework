
namespace Homework1_2
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
			this.firstn = new System.Windows.Forms.TextBox();
			this.secondn = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.res = new System.Windows.Forms.Label();
			this.op = new System.Windows.Forms.ComboBox();
			this.cal = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// firstn
			// 
			this.firstn.Location = new System.Drawing.Point(24, 101);
			this.firstn.Name = "firstn";
			this.firstn.Size = new System.Drawing.Size(100, 35);
			this.firstn.TabIndex = 0;
			this.firstn.Text = "0";
			this.firstn.TextChanged += new System.EventHandler(this.firstn_TextChanged);
			// 
			// secondn
			// 
			this.secondn.Location = new System.Drawing.Point(339, 101);
			this.secondn.Name = "secondn";
			this.secondn.Size = new System.Drawing.Size(100, 35);
			this.secondn.TabIndex = 1;
			this.secondn.Text = "0";
			this.secondn.TextChanged += new System.EventHandler(this.secondn_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(486, 112);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(22, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "=";
			// 
			// res
			// 
			this.res.AutoSize = true;
			this.res.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.res.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.res.Location = new System.Drawing.Point(557, 112);
			this.res.Name = "res";
			this.res.Size = new System.Drawing.Size(84, 26);
			this.res.TabIndex = 3;
			this.res.Text = "      ";
			this.res.Click += new System.EventHandler(this.res_Click);
			// 
			// op
			// 
			this.op.DisplayMember = "+";
			this.op.FormattingEnabled = true;
			this.op.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
			this.op.Location = new System.Drawing.Point(173, 104);
			this.op.Name = "op";
			this.op.Size = new System.Drawing.Size(121, 32);
			this.op.TabIndex = 4;
			this.op.Text = "运算符";
			this.op.SelectedIndexChanged += new System.EventHandler(this.op_SelectedIndexChanged);
			// 
			// cal
			// 
			this.cal.Location = new System.Drawing.Point(157, 219);
			this.cal.Name = "cal";
			this.cal.Size = new System.Drawing.Size(95, 47);
			this.cal.TabIndex = 5;
			this.cal.Text = "计算";
			this.cal.UseVisualStyleBackColor = true;
			this.cal.Click += new System.EventHandler(this.cal_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cal);
			this.Controls.Add(this.op);
			this.Controls.Add(this.res);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.secondn);
			this.Controls.Add(this.firstn);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox firstn;
		private System.Windows.Forms.TextBox secondn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label res;
		private System.Windows.Forms.ComboBox op;
		private System.Windows.Forms.Button cal;
	}
}

