using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab3_2
{
    public partial class ThemSinhVien : Form
    {    
        public ThemSinhVien()
        {
            InitializeComponent();
            cmbKhoa.SelectedIndex = 1;
        }

        public string Mssv { get; set; }
        public string Tensv { get; set; }       
        public string Khoa { get; set; }
        public string Dtb { get; set; }
        private void btnThoat_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn thoát!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void frmThem_Load(object sender, EventArgs e)
        {
            cmbKhoa.SelectedItem = "Công nghệ thông tin";
           

        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            Mssv = txtMSSV.Text;
            Tensv = txtHoTen.Text;         
            if (cmbKhoa.SelectedItem != null)
            {
                Khoa = cmbKhoa.SelectedItem.ToString();
            }
            else
            {

                MessageBox.Show("Vui lòng chọn khoa.");
            }
            Dtb = txtDTB.Text;
            this.DialogResult = DialogResult.OK;
           
            this.Close();
        }
    }
}
