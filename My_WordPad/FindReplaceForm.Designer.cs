namespace My_WordPad
{
	partial class FindReplaceForm
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
			this.btn_Tim = new System.Windows.Forms.Button();
			this.txtFind = new System.Windows.Forms.TextBox();
			this.btn_ThayThe = new System.Windows.Forms.Button();
			this.txtReplace = new System.Windows.Forms.TextBox();
			this.chkReplaceAll = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// btn_Tim
			// 
			this.btn_Tim.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
			this.btn_Tim.Location = new System.Drawing.Point(332, 199);
			this.btn_Tim.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.btn_Tim.Name = "btn_Tim";
			this.btn_Tim.Size = new System.Drawing.Size(141, 42);
			this.btn_Tim.TabIndex = 0;
			this.btn_Tim.Text = "Tìm";
			this.btn_Tim.UseVisualStyleBackColor = true;
			this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
			// 
			// txtFind
			// 
			this.txtFind.Location = new System.Drawing.Point(540, 199);
			this.txtFind.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.txtFind.Name = "txtFind";
			this.txtFind.Size = new System.Drawing.Size(184, 36);
			this.txtFind.TabIndex = 1;
			// 
			// btn_ThayThe
			// 
			this.btn_ThayThe.Location = new System.Drawing.Point(332, 306);
			this.btn_ThayThe.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.btn_ThayThe.Name = "btn_ThayThe";
			this.btn_ThayThe.Size = new System.Drawing.Size(141, 42);
			this.btn_ThayThe.TabIndex = 2;
			this.btn_ThayThe.Text = "Thay Thế";
			this.btn_ThayThe.UseVisualStyleBackColor = true;
			this.btn_ThayThe.Click += new System.EventHandler(this.btn_ThayThe_Click);
			// 
			// txtReplace
			// 
			this.txtReplace.Location = new System.Drawing.Point(540, 308);
			this.txtReplace.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.txtReplace.Name = "txtReplace";
			this.txtReplace.Size = new System.Drawing.Size(184, 36);
			this.txtReplace.TabIndex = 3;
			// 
			// chkReplaceAll
			// 
			this.chkReplaceAll.AutoSize = true;
			this.chkReplaceAll.Location = new System.Drawing.Point(332, 394);
			this.chkReplaceAll.Name = "chkReplaceAll";
			this.chkReplaceAll.Size = new System.Drawing.Size(202, 33);
			this.chkReplaceAll.TabIndex = 4;
			this.chkReplaceAll.Text = "Thay thế tất cả";
			this.chkReplaceAll.UseVisualStyleBackColor = true;
			// 
			// FindReplaceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1500, 816);
			this.Controls.Add(this.chkReplaceAll);
			this.Controls.Add(this.txtReplace);
			this.Controls.Add(this.btn_ThayThe);
			this.Controls.Add(this.txtFind);
			this.Controls.Add(this.btn_Tim);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.Name = "FindReplaceForm";
			this.Text = "FindReplaceForm";
			this.Load += new System.EventHandler(this.FindReplaceForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Tim;
		private System.Windows.Forms.TextBox txtFind;
		private System.Windows.Forms.Button btn_ThayThe;
		private System.Windows.Forms.TextBox txtReplace;
		private System.Windows.Forms.CheckBox chkReplaceAll;
	}
}