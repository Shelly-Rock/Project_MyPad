namespace My_WordPad
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.File = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Edit = new System.Windows.Forms.ToolStripMenuItem();
			this.udoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.findAndReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.insertImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Font = new System.Windows.Forms.ToolStripMenuItem();
			this.selectFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.italicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.underlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pageColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.paragraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.indentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.alignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.centerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bulletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addBulletsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeBulletsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Edit,
            this.Font,
            this.paragraphToolStripMenuItem,
            this.bulletToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 28);
			this.menuStrip1.TabIndex = 7;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// File
			// 
			this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.newFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.pageSetupToolStripMenuItem,
            this.previewToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.File.Name = "File";
			this.File.Size = new System.Drawing.Size(46, 24);
			this.File.Text = "File";
			// 
			// openFileToolStripMenuItem
			// 
			this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
			this.openFileToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
			this.openFileToolStripMenuItem.Text = "Open File";
			this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
			// 
			// newFileToolStripMenuItem
			// 
			this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
			this.newFileToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
			this.newFileToolStripMenuItem.Text = "New File";
			this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
			// 
			// saveFileToolStripMenuItem
			// 
			this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
			this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
			this.saveFileToolStripMenuItem.Text = "Save File";
			this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
			// 
			// pageSetupToolStripMenuItem
			// 
			this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
			this.pageSetupToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
			this.pageSetupToolStripMenuItem.Text = "Page Setup";
			this.pageSetupToolStripMenuItem.Click += new System.EventHandler(this.pageSetupToolStripMenuItem_Click);
			// 
			// previewToolStripMenuItem
			// 
			this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
			this.previewToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
			this.previewToolStripMenuItem.Text = "Preview";
			this.previewToolStripMenuItem.Click += new System.EventHandler(this.previewToolStripMenuItem_Click);
			// 
			// printToolStripMenuItem
			// 
			this.printToolStripMenuItem.Name = "printToolStripMenuItem";
			this.printToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
			this.printToolStripMenuItem.Text = "Print";
			this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// Edit
			// 
			this.Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.udoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.findToolStripMenuItem,
            this.findAndReplaceToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.insertImageToolStripMenuItem});
			this.Edit.Name = "Edit";
			this.Edit.Size = new System.Drawing.Size(49, 24);
			this.Edit.Text = "Edit";
			// 
			// udoToolStripMenuItem
			// 
			this.udoToolStripMenuItem.Name = "udoToolStripMenuItem";
			this.udoToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
			this.udoToolStripMenuItem.Text = "Udo";
			// 
			// redoToolStripMenuItem
			// 
			this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
			this.redoToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
			this.redoToolStripMenuItem.Text = "Redo";
			this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
			// 
			// findToolStripMenuItem
			// 
			this.findToolStripMenuItem.Name = "findToolStripMenuItem";
			this.findToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
			this.findToolStripMenuItem.Text = "Find";
			this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
			// 
			// findAndReplaceToolStripMenuItem
			// 
			this.findAndReplaceToolStripMenuItem.Name = "findAndReplaceToolStripMenuItem";
			this.findAndReplaceToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
			this.findAndReplaceToolStripMenuItem.Text = "Find and Replace";
			this.findAndReplaceToolStripMenuItem.Click += new System.EventHandler(this.findAndReplaceToolStripMenuItem_Click);
			// 
			// selectAllToolStripMenuItem
			// 
			this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
			this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
			this.selectAllToolStripMenuItem.Text = "Select All";
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
			this.copyToolStripMenuItem.Text = "Copy";
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
			// 
			// cutToolStripMenuItem
			// 
			this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
			this.cutToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
			this.cutToolStripMenuItem.Text = "Cut";
			this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
			// 
			// pasteToolStripMenuItem
			// 
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
			this.pasteToolStripMenuItem.Text = "Paste";
			this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
			// 
			// insertImageToolStripMenuItem
			// 
			this.insertImageToolStripMenuItem.Name = "insertImageToolStripMenuItem";
			this.insertImageToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
			this.insertImageToolStripMenuItem.Text = "Insert Image";
			this.insertImageToolStripMenuItem.Click += new System.EventHandler(this.insertImageToolStripMenuItem_Click);
			// 
			// Font
			// 
			this.Font.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFontToolStripMenuItem,
            this.fontColorToolStripMenuItem,
            this.boldToolStripMenuItem,
            this.italicToolStripMenuItem,
            this.underlineToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.pageColorToolStripMenuItem});
			this.Font.Name = "Font";
			this.Font.Size = new System.Drawing.Size(52, 24);
			this.Font.Text = "Font";
			// 
			// selectFontToolStripMenuItem
			// 
			this.selectFontToolStripMenuItem.Name = "selectFontToolStripMenuItem";
			this.selectFontToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
			this.selectFontToolStripMenuItem.Text = "Select font";
			this.selectFontToolStripMenuItem.Click += new System.EventHandler(this.selectFontToolStripMenuItem_Click);
			// 
			// fontColorToolStripMenuItem
			// 
			this.fontColorToolStripMenuItem.Name = "fontColorToolStripMenuItem";
			this.fontColorToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
			this.fontColorToolStripMenuItem.Text = "Font color";
			this.fontColorToolStripMenuItem.Click += new System.EventHandler(this.fontColorToolStripMenuItem_Click);
			// 
			// boldToolStripMenuItem
			// 
			this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
			this.boldToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
			this.boldToolStripMenuItem.Text = "Bold";
			this.boldToolStripMenuItem.Click += new System.EventHandler(this.boldToolStripMenuItem_Click);
			// 
			// italicToolStripMenuItem
			// 
			this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
			this.italicToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
			this.italicToolStripMenuItem.Text = "Italic";
			this.italicToolStripMenuItem.Click += new System.EventHandler(this.italicToolStripMenuItem_Click);
			// 
			// underlineToolStripMenuItem
			// 
			this.underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
			this.underlineToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
			this.underlineToolStripMenuItem.Text = "Underline";
			this.underlineToolStripMenuItem.Click += new System.EventHandler(this.underlineToolStripMenuItem_Click);
			// 
			// normalToolStripMenuItem
			// 
			this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
			this.normalToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
			this.normalToolStripMenuItem.Text = "Normal";
			this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
			// 
			// pageColorToolStripMenuItem
			// 
			this.pageColorToolStripMenuItem.Name = "pageColorToolStripMenuItem";
			this.pageColorToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
			this.pageColorToolStripMenuItem.Text = "Page Color";
			this.pageColorToolStripMenuItem.Click += new System.EventHandler(this.pageColorToolStripMenuItem_Click);
			// 
			// paragraphToolStripMenuItem
			// 
			this.paragraphToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indentToolStripMenuItem,
            this.alignToolStripMenuItem});
			this.paragraphToolStripMenuItem.Name = "paragraphToolStripMenuItem";
			this.paragraphToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
			this.paragraphToolStripMenuItem.Text = "Paragraph";
			// 
			// indentToolStripMenuItem
			// 
			this.indentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
			this.indentToolStripMenuItem.Name = "indentToolStripMenuItem";
			this.indentToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
			this.indentToolStripMenuItem.Text = "Indent";
			// 
			// noneToolStripMenuItem
			// 
			this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
			this.noneToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
			this.noneToolStripMenuItem.Text = "None";
			this.noneToolStripMenuItem.Click += new System.EventHandler(this.noneToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(132, 26);
			this.toolStripMenuItem2.Text = "5  pts";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(132, 26);
			this.toolStripMenuItem3.Text = "10 pts";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(132, 26);
			this.toolStripMenuItem4.Text = "15 pts";
			this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(132, 26);
			this.toolStripMenuItem5.Text = "20 pts";
			this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
			// 
			// alignToolStripMenuItem
			// 
			this.alignToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftToolStripMenuItem,
            this.centerToolStripMenuItem,
            this.rightToolStripMenuItem});
			this.alignToolStripMenuItem.Name = "alignToolStripMenuItem";
			this.alignToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
			this.alignToolStripMenuItem.Text = "Align";
			// 
			// leftToolStripMenuItem
			// 
			this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
			this.leftToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
			this.leftToolStripMenuItem.Text = "Left";
			this.leftToolStripMenuItem.Click += new System.EventHandler(this.leftToolStripMenuItem_Click);
			// 
			// centerToolStripMenuItem
			// 
			this.centerToolStripMenuItem.Name = "centerToolStripMenuItem";
			this.centerToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
			this.centerToolStripMenuItem.Text = "Center";
			this.centerToolStripMenuItem.Click += new System.EventHandler(this.centerToolStripMenuItem_Click);
			// 
			// rightToolStripMenuItem
			// 
			this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
			this.rightToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
			this.rightToolStripMenuItem.Text = "Right";
			this.rightToolStripMenuItem.Click += new System.EventHandler(this.rightToolStripMenuItem_Click);
			// 
			// bulletToolStripMenuItem
			// 
			this.bulletToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBulletsToolStripMenuItem,
            this.removeBulletsToolStripMenuItem});
			this.bulletToolStripMenuItem.Name = "bulletToolStripMenuItem";
			this.bulletToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
			this.bulletToolStripMenuItem.Text = "Bullet";
			// 
			// addBulletsToolStripMenuItem
			// 
			this.addBulletsToolStripMenuItem.Name = "addBulletsToolStripMenuItem";
			this.addBulletsToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
			this.addBulletsToolStripMenuItem.Text = "Add Bullets";
			this.addBulletsToolStripMenuItem.Click += new System.EventHandler(this.addBulletsToolStripMenuItem_Click);
			// 
			// removeBulletsToolStripMenuItem
			// 
			this.removeBulletsToolStripMenuItem.Name = "removeBulletsToolStripMenuItem";
			this.removeBulletsToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
			this.removeBulletsToolStripMenuItem.Text = "Remove Bullets";
			this.removeBulletsToolStripMenuItem.Click += new System.EventHandler(this.removeBulletsToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
			this.helpToolStripMenuItem.Text = "Help";
			
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton9});
			this.toolStrip1.Location = new System.Drawing.Point(0, 28);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.toolStrip1.Size = new System.Drawing.Size(800, 27);
			this.toolStrip1.TabIndex = 8;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
			this.toolStripButton1.Text = "toolStripButton1";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
			this.toolStripButton2.Text = "toolStripButton2";
			this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
			this.toolStripButton3.Text = "toolStripButton3";
			this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
			this.toolStripButton4.Text = "toolStripButton4";
			this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
			// 
			// toolStripButton5
			// 
			this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
			this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton5.Name = "toolStripButton5";
			this.toolStripButton5.Size = new System.Drawing.Size(29, 24);
			this.toolStripButton5.Text = "toolStripButton5";
			this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
			// 
			// toolStripButton6
			// 
			this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton6.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
			this.toolStripButton6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton6.Name = "toolStripButton6";
			this.toolStripButton6.Size = new System.Drawing.Size(29, 24);
			this.toolStripButton6.Text = "toolStripButton6";
			this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
			// 
			// toolStripButton7
			// 
			this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
			this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton7.Name = "toolStripButton7";
			this.toolStripButton7.Size = new System.Drawing.Size(29, 24);
			this.toolStripButton7.Text = "toolStripButton7";
			this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
			// 
			// toolStripButton9
			// 
			this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
			this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton9.Name = "toolStripButton9";
			this.toolStripButton9.Size = new System.Drawing.Size(29, 24);
			this.toolStripButton9.Text = "toolStripButton9";
			this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Location = new System.Drawing.Point(7, 58);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(781, 380);
			this.richTextBox1.TabIndex = 9;
			this.richTextBox1.Text = "";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;	
		private System.Windows.Forms.ToolStripMenuItem File;
		private System.Windows.Forms.ToolStripMenuItem Edit;
		private System.Windows.Forms.ToolStripMenuItem Font;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.ToolStripButton toolStripButton5;
		private System.Windows.Forms.ToolStripButton toolStripButton6;
		private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem udoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem findAndReplaceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem insertImageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectFontToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fontColorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem underlineToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pageColorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem paragraphToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem indentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alignToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bulletToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addBulletsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem removeBulletsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem centerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton toolStripButton9;
		private System.Windows.Forms.ToolStripButton toolStripButton7;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
	}
}

