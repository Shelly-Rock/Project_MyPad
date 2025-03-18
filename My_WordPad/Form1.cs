using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Drawing.Printing;


namespace My_WordPad
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			RichTextBox richTextBox1 = new RichTextBox();
			richTextBox1.Dock = DockStyle.Fill;
			this.Controls.Add(richTextBox1);
		}

		private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Text files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";
				openFileDialog.Title = "Chọn file để mở";

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					string filePath = openFileDialog.FileName;
					LoadFileContent(filePath);
				}
			}
		}

		private void LoadFileContent(string filePath)
		{
			try
			{
				if (filePath.EndsWith(".rtf", StringComparison.OrdinalIgnoreCase))
				{
					richTextBox1.LoadFile(filePath, RichTextBoxStreamType.RichText);
				}
				else if (filePath.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
				{
					using (StreamReader reader = new StreamReader(filePath))
					{
						string content = reader.ReadToEnd();
						richTextBox1.Text = content;  // Cập nhật nội dung vào RichTextBox
					}
				}
				else
				{
					MessageBox.Show("Định dạng file không được hỗ trợ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		private void toolStripButton9_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Filter = "Text files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";
				saveFileDialog.Title = "Lưu file";

				// Thư mục cha mặc định (có thể thay đổi đường dẫn này)
				string parentFolder = @"C:\Users\Public\Documents";

				// Đặt thư mục cha làm thư mục mặc định
				saveFileDialog.InitialDirectory = parentFolder;
				saveFileDialog.FileName = "document"; // Đặt tên file mặc định

				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					string filePath = saveFileDialog.FileName;

					// Lưu vào thư mục cha nếu cần
					string directory = Path.GetDirectoryName(filePath);

					// Kiểm tra xem thư mục có tồn tại không, nếu không thì tạo mới
					if (!Directory.Exists(directory))
					{
						Directory.CreateDirectory(directory);
					}

					// Lưu file
					if (filePath.EndsWith(".rtf"))
					{
						richTextBox1.SaveFile(filePath, RichTextBoxStreamType.RichText);
					}
					else
					{
						System.IO.File.WriteAllText(filePath, richTextBox1.Text);
					}
				}
			}


		}







		// căn trái trên thanh menu
		private void leftToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
		}
		//căn giữa trên thanh menu
		private void centerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
		}
		//căn phải trên thanh menu
		private void rightToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
		}






		private void boldToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Font currentFont = richTextBox1.SelectionFont;
			FontStyle newFontStyle = currentFont.Style ^ FontStyle.Bold; // Toggle Bold
			richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);
		}

		private void italicToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Font currentFont = richTextBox1.SelectionFont;
			FontStyle newFontStyle = currentFont.Style ^ FontStyle.Italic; // Toggle Italic
			richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);
		}

		private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Font currentFont = richTextBox1.SelectionFont;
			FontStyle newFontStyle = currentFont.Style ^ FontStyle.Underline; // Toggle Underline
			richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);
		}

		//U
		private void toolStripButton4_Click(object sender, EventArgs e)
		{
			Font currentFont = richTextBox1.SelectionFont;
			FontStyle newFontStyle = currentFont.Style ^ FontStyle.Underline; // Toggle Underline
			richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);
		}
		//b
		private void toolStripButton5_Click(object sender, EventArgs e)
		{
			Font currentFont = richTextBox1.SelectionFont;
			FontStyle newFontStyle = currentFont.Style ^ FontStyle.Bold; // Toggle Bold
			richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);
		}
		//i
		private void toolStripButton6_Click(object sender, EventArgs e)
		{
			Font currentFont = richTextBox1.SelectionFont;
			FontStyle newFontStyle = currentFont.Style ^ FontStyle.Italic; // Toggle Italic
			richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);
		}


		//font chữ 
		private void selectFontToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (FontDialog fontDialog = new FontDialog())
			{
				if (fontDialog.ShowDialog() == DialogResult.OK)
				{
					richTextBox1.SelectionFont = fontDialog.Font;
				}
			}
		}


		//màu chữ
		private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (ColorDialog colorDialog = new ColorDialog())
			{
				if (colorDialog.ShowDialog() == DialogResult.OK)
				{
					richTextBox1.SelectionColor = colorDialog.Color;
				}
			}
		}



		// màu background
		private void pageColorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (ColorDialog colorDialog = new ColorDialog())
			{
				if (colorDialog.ShowDialog() == DialogResult.OK)
				{
					richTextBox1.BackColor = colorDialog.Color;
				}
			}
		}




		// cắt
		private void cutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Cut();
		}

		private void toolStripButton7_Click(object sender, EventArgs e)
		{
			richTextBox1.Cut();
		}

		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Copy();
		}

		private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Paste();
		}

		private void normalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (richTextBox1.SelectionFont != null)
			{
				richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Regular); 
			}
			richTextBox1.SelectionColor = Color.Black; 
			richTextBox1.BackColor = Color.White; 
		}

		private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Filter = "Text files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";
				saveFileDialog.Title = "Lưu file";

				// Thư mục cha mặc định (có thể thay đổi đường dẫn này)
				string parentFolder = @"C:\Users\Public\Documents";

				// Đặt thư mục cha làm thư mục mặc định
				saveFileDialog.InitialDirectory = parentFolder;
				saveFileDialog.FileName = "document"; // Đặt tên file mặc định

				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					string filePath = saveFileDialog.FileName;

					// Lưu vào thư mục cha nếu cần
					string directory = Path.GetDirectoryName(filePath);

					// Kiểm tra xem thư mục có tồn tại không, nếu không thì tạo mới
					if (!Directory.Exists(directory))
					{
						Directory.CreateDirectory(directory);
					}

					// Lưu file
					if (filePath.EndsWith(".rtf"))
					{
						richTextBox1.SaveFile(filePath, RichTextBoxStreamType.RichText);
					}
					else
					{
						System.IO.File.WriteAllText(filePath, richTextBox1.Text);
					}
				}
			}
		}
		// Bulle 
        private void addBulletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var bulletForm = new BulletSelectionForm(richTextBox1))
            {
                bulletForm.ShowDialog();
            }
        }
        public class BulletSelectionForm : Form
        {
            private RichTextBox _richTextBox;
            private ComboBox bulletStyleComboBox;
            private Button applyButton;

            public BulletSelectionForm(RichTextBox richTextBox)
            {
                _richTextBox = richTextBox;
                this.Text = "Select Bullet Style";
                this.Size = new System.Drawing.Size(250, 150);

                bulletStyleComboBox = new ComboBox()
                {
                    Dock = DockStyle.Top,
                    DropDownStyle = ComboBoxStyle.DropDownList
                };
                bulletStyleComboBox.Items.AddRange(new string[] { "•", "◦", "▪", "■", "➤" });

                applyButton = new Button()
                {
                    Text = "Apply",
                    Dock = DockStyle.Bottom
                };
                applyButton.Click += ApplyButton_Click;

                this.Controls.Add(bulletStyleComboBox);
                this.Controls.Add(applyButton);
            }

            private void ApplyButton_Click(object sender, EventArgs e)
            {
                if (bulletStyleComboBox.SelectedItem != null)
                {
                    string bulletChar = bulletStyleComboBox.SelectedItem.ToString();
                    int selectionStart = _richTextBox.SelectionStart;
                    int selectionLength = _richTextBox.SelectionLength;

                    string selectedText = _richTextBox.SelectedText;
                    if (!string.IsNullOrWhiteSpace(selectedText))
                    {
                        string[] lines = selectedText.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
                        for (int i = 0; i < lines.Length; i++)
                        {
                            lines[i] = bulletChar + " " + lines[i];
                        }
                        _richTextBox.SelectedText = string.Join("\r\n", lines);
                        _richTextBox.SelectionStart = selectionStart;
                        _richTextBox.SelectionLength = selectionLength + (lines.Length * (bulletChar.Length + 1));
                    }
                }
                this.Close();
            }
        }
        private string ShowBulletSelectionDialog(List<string> bullets)
        {
            Form form = new Form();
            form.Text = "Chọn bullet để xóa";
            form.Size = new Size(250, 200);

            ListBox listBox = new ListBox { Dock = DockStyle.Top };
            listBox.Items.AddRange(bullets.ToArray());

            Button btnOK = new Button { Text = "OK", Dock = DockStyle.Bottom };
            btnOK.Click += (sender, e) => { form.DialogResult = DialogResult.OK; form.Close(); };

            form.Controls.Add(listBox);
            form.Controls.Add(btnOK);

            return form.ShowDialog() == DialogResult.OK ? listBox.SelectedItem?.ToString() : null;
        }

        private void removeBulletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> usedBullets = new List<string>();
            string[] possibleBullets = { "•", "◦", "▪", "■", "➤" };

            foreach (string bullet in possibleBullets)
            {
                if (richTextBox1.Text.Contains(bullet))
                {
                    usedBullets.Add(bullet);
                }
            }

            if (usedBullets.Count == 0)
            {
                MessageBox.Show("Không có bullet nào để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string selectedBullet = ShowBulletSelectionDialog(usedBullets);
            if (string.IsNullOrEmpty(selectedBullet)) return;

            richTextBox1.Text = richTextBox1.Text.Replace(selectedBullet + " ", "");
        }

		private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PageSetupDialog pageSetupDialog = new PageSetupDialog();
			PrintDocument printDocument = new PrintDocument();

			// Gắn tài liệu in vào hộp thoại Page Setup
			pageSetupDialog.Document = printDocument;

			// Hiển thị hộp thoại Page Setup
			if (pageSetupDialog.ShowDialog() == DialogResult.OK)
			{
				// Lưu cài đặt sau khi người dùng chọn
				printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;

				MessageBox.Show("Cài đặt trang đã được lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void previewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Tạo tài liệu in
			PrintDocument printDocument = new PrintDocument();

			// Định nghĩa nội dung sẽ in
			printDocument.PrintPage += new PrintPageEventHandler(PrintPage);

			// Tạo hộp thoại xem trước in
			PrintPreviewDialog previewDialog = new PrintPreviewDialog
			{
				Document = printDocument
			};

			// Hiển thị hộp thoại xem trước
			previewDialog.ShowDialog();
		}

		// Hàm xử lý nội dung trang in
		private void PrintPage(object sender, PrintPageEventArgs e)
		{
			string content = "Đây là nội dung xem trước bản in!";
			Font font = new Font("Arial", 16);
			Brush brush = Brushes.Black;

			// Vẽ nội dung lên trang xem trước
			e.Graphics.DrawString(content, font, brush, 100, 100);
		}


		// Udo
		private void undoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (richTextBox1.CanUndo)
			{
				richTextBox1.Undo();
			}
		}


		// Redo
		private void redoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (richTextBox1.CanRedo)
			{
				richTextBox1.Redo();
			}
		}


		// Find
		private void findToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string searchText = Interaction.InputBox("Nhập từ cần tìm:", "Tìm kiếm", "");


			if (!string.IsNullOrEmpty(searchText))
			{
				int index = richTextBox1.Text.IndexOf(searchText, StringComparison.OrdinalIgnoreCase);

				if (index != -1)
				{
					richTextBox1.Select(index, searchText.Length);
					richTextBox1.Focus();
					MessageBox.Show("Đã tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		private void findAndReplaceToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FindReplaceForm findReplaceForm = new FindReplaceForm();

			if (findReplaceForm.ShowDialog() == DialogResult.OK)
			{
				string searchText = findReplaceForm.FindText;
				string replaceText = findReplaceForm.ReplaceText;

				if (!string.IsNullOrEmpty(searchText))
				{
					int index = richTextBox1.Text.IndexOf(searchText, StringComparison.OrdinalIgnoreCase);

					if (index != -1)
					{
						if (findReplaceForm.DialogResult == DialogResult.Yes)
						{
							// Replace All
							richTextBox1.Text = richTextBox1.Text.Replace(searchText, replaceText);
						}
						else
						{
							// Select the found text
							richTextBox1.Select(index, searchText.Length);
							richTextBox1.SelectedText = replaceText;
						}
						richTextBox1.Focus();
					}
					else
					{
						MessageBox.Show("Không tìm thấy từ cần thay thế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
			}
		}

		private void insertImageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Title = "Chọn ảnh",
				Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
			};

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					Image img = Image.FromFile(openFileDialog.FileName);
					Clipboard.SetImage(img);
					richTextBox1.Paste();
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Lỗi khi chèn ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void SetIndent(int indentSize)
		{
			if (richTextBox1.SelectionLength > 0)
			{
				richTextBox1.SelectionIndent = indentSize;
			}
			else
			{
				MessageBox.Show("Hãy chọn đoạn văn bản cần thụt lề!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			SetIndent(20); // 5pts ~ 20px
		}

		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			SetIndent(40); // 10pts ~ 40px
		}

		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
			SetIndent(60);
		}

		private void toolStripMenuItem5_Click(object sender, EventArgs e)
		{
			SetIndent(80);
		}

		private void noneToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SetIndent(0);
		}

		private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
		{

			// Kiểm tra nếu có thay đổi chưa lưu
			if (richTextBox1.Modified)
			{
				DialogResult result = MessageBox.Show("Bạn có muốn lưu lại file hiện tại không?", "Lưu file", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

				if (result == DialogResult.Yes)
				{
					SaveFile();
				}
				else if (result == DialogResult.Cancel)
				{
					return; // Hủy tạo file mới
				}
			}

			// Xóa nội dung và reset trạng thái
			richTextBox1.Clear();
			richTextBox1.Modified = false;
			this.Text = "New File - Text Editor";
		}
		private void SaveFile()
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
				Title = "Lưu file"
			};

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				System.IO.File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
				richTextBox1.Modified = false;
				this.Text = System.IO.Path.GetFileName(saveFileDialog.FileName) + " - Text Editor";
			}
		}

		private void printToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PrintDocument printDocument = new PrintDocument();
			printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

			PrintDialog printDialog = new PrintDialog
			{
				Document = printDocument
			};

			if (printDialog.ShowDialog() == DialogResult.OK)
			{
				printDocument.Print();
			}
		}
		private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
		{
			e.Graphics.DrawString(
				richTextBox1.Text,
				new Font("Arial", 12),
				Brushes.Black,
				new RectangleF(50, 50, e.PageBounds.Width - 100, e.PageBounds.Height - 100)
			);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
		{

			MessageBox.Show(
			   "Thông tin nhóm: 5TL\n" +
			   "- MSSV: 220000xxxx\n" +
			   "- Họ tên: Anh Bình Gold\n" +
			   "- Lớp: Đây Phải Không Ạ\n",
			   "About",
			   MessageBoxButtons.OK,
			   MessageBoxIcon.Information
		   );
		}
	}
}
