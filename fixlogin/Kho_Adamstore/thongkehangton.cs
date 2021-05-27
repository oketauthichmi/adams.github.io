using Kho_Adamstore.DAO;
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
    public partial class thongkehangton : Form
    {
        public thongkehangton()
        {
            InitializeComponent();
        }
        public void load()
        {
            string query = "select MaHang,TenHang,MaLoai,SoLuong from Hang ";//vi su dung split cat theo khoang trang suy ra viet phaii cach dau phay,


            dtgrvthongke.DataSource = DataProvider.Instance.ExecuteQuery(query);//thuc hien cau truy van voi tham so @tenhang, su dung new ojcect de lay 2 doi tuong Xoai vaff Nho
            dtgrvthongke.Columns[0].HeaderText = "Mã Hàng";
            dtgrvthongke.Columns[0].Width = 50;
            dtgrvthongke.Columns[1].HeaderText = "Tên Hàng";
            dtgrvthongke.Columns[1].Width = 200;
            dtgrvthongke.Columns[2].HeaderText = "Loại Hàng";
            dtgrvthongke.Columns[2].Width = 50;
            dtgrvthongke.Columns[3].HeaderText = "hàng tồn";
            dtgrvthongke.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string timkiem = txttimkiem.Text;
            string query = "select Mahang,TenHang,MaLoai,SoLuong from Hang WHERE TenHang like '%" + timkiem + "%'";
            dtgrvthongke.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
