using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuDinhDang_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            fontDialog.ShowApply = true;
            fontDialog.ShowEffects = true;
            fontDialog.ShowHelp = true;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richText.SelectionFont = fontDialog.Font;
            }
        }

        private void initialCmb()
        {
            int[] array = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (var item in array)
            {
                toolStripCmb2.Items.Add(item);
            }
        }
        private void initialFont()
        {
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                toolStripCmb1.Items.Add(font.Name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initialCmb();
            initialFont();
            toolStripCmb1.SelectedItem = "Tahoma";
            toolStripCmb2.SelectedItem = 14;
        }

        private void toolStripMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuNew_Click(object sender, EventArgs e)
        {
            richText.Clear();
            toolStripCmb1.SelectedItem = "Tahoma";
            toolStripCmb2.SelectedItem = 14;
        }


        private void toolStripNew_Click(object sender, EventArgs e)
        {
            richText.Clear();
            toolStripCmb1.SelectedItem = "Tahoma";
            toolStripCmb2.SelectedItem = 14;
        }


        private void toolStripSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richText.Text))
            {
                MessageBox.Show("Không có nội dung văn bản để lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Tập tin RTF (*.rtf)|*.rtf";
            saveFileDialog.Title = "Lưu tập tin văn bản";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                try
                {
                    richText.SaveFile(filePath, RichTextBoxStreamType.RichText);
                    MessageBox.Show("Lưu văn bản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu tập tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripMenuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Tập tin văn bản (*.txt;*.rtf)|*.txt;*.rtf|Tất cả tập tin (*.*)|*.*";
            openFileDialog.Title = "Chọn tập tin để mở";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    if (filePath.EndsWith(".txt"))
                    {
                        richText.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                    }
                    else if (filePath.EndsWith(".rtf"))
                    {
                        richText.LoadFile(filePath, RichTextBoxStreamType.RichText);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi mở tập tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        

        private void toolStripB_Click_1(object sender, EventArgs e)
        {
            if (richText.SelectionFont != null)
            {
                Font currentFont = richText.SelectionFont;
                FontStyle newFontStyle = FontStyle.Bold ^ currentFont.Style;
                richText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void toolStripI_Click(object sender, EventArgs e)
        {
            if (richText.SelectionFont != null)
            {
                Font currentFont = richText.SelectionFont;
                FontStyle newFontStyle = FontStyle.Italic ^ currentFont.Style;
                richText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void toolStripU_Click(object sender, EventArgs e)
        {
            if (richText.SelectionFont != null)
            {
                Font currentFont = richText.SelectionFont;
                FontStyle newFontStyle = FontStyle.Underline ^ currentFont.Style;
                richText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        
    }

}
