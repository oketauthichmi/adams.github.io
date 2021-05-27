using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kho_Adamstore
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void Clear_panel()
        {
            main.Controls.Clear();
        }

        private void btnhang_Click(object sender, EventArgs e)
        {
            Clear_panel();
            Hang form = new Hang() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            main.Controls.Add(form);
            form.Show();

        }

        private void btnloai_Click(object sender, EventArgs e)
        {
            Clear_panel();
            LoaiHang form = new LoaiHang() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            main.Controls.Add(form);
            form.Show();
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            Clear_panel();
            Nhanvien form = new Nhanvien() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            main.Controls.Add(form);
            form.Show();
        }

        private void btnnhacc_Click(object sender, EventArgs e)
        {
            Clear_panel();
            NhaCungCap form = new NhaCungCap() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            main.Controls.Add(form);
            form.Show();
        }

        private void btnphieunhap_Click(object sender, EventArgs e)
        {
            Clear_panel();
            NhapHang form = new NhapHang() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            main.Controls.Add(form);
            form.Show();
        }

        private void btnphieuxuat_Click(object sender, EventArgs e)
        {
            Clear_panel();
            XuatHang form = new XuatHang() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            main.Controls.Add(form);
            form.Show();
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            Clear_panel();
             ThongKe form = new ThongKe() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            main.Controls.Add(form);
            form.Show();
        }

        private void btnbaocao_Click(object sender, EventArgs e)
        {
            Clear_panel();
            thongkehangton form = new thongkehangton() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            main.Controls.Add(form);
            form.Show();
        }

        

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có Muốn thoát!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                login dn = new login();
                this.Visible=false;
                dn.ShowDialog();
               
                
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Clear_panel();
            dangky form = new dangky() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            main.Controls.Add(form);
            form.Show();
        }
    }
}
