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
    public partial class LoaiHang : Form
    {
        public LoaiHang()
        {
            InitializeComponent();
        }

        public bool kiemtra(string maloai)
        {
            string query = "select * from LoaiSanPham where MaLoai = ('" + maloai + "')";
            DataTable ketqua = DataProvider.Instance.ExecuteQuery(query);
            return ketqua.Rows.Count > 0;
        }
        public void clear()
        {
            txtmaloai.Text = "";
            txttenloai.Text = "";

        }
        public void load()
        {
            string query = "select * from LoaiSanPham ";//vi su dung split cat theo khoang trang suy ra viet phaii cach dau phay,


            dtgrvloaihang.DataSource = DataProvider.Instance.ExecuteQuery(query);//thuc hien cau truy van voi tham so @tenhang, su dung new ojcect de lay 2 doi tuong Xoai vaff Nho
        }



        private void LoaiHang_Load(object sender, EventArgs e)
        {
            load();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string maloai = txtmaloai.Text;
            string tenloai = txttenloai.Text;
            
            if (kiemtra(maloai) == true || maloai == "")
            {
                MessageBox.Show("Mã trùng hoặc lỗi ");
            }
            else
            {
                string query = "INSERT INTO LoaiSanPham (MaLoai,TenLoai)VALUES ('" + maloai + "','" + tenloai + "') ";
                dtgrvloaihang.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            load();
            clear();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string maloai = txtmaloai.Text;
            string tenloai = txttenloai.Text;

            if (kiemtra(maloai) == true)
            {
                string query = " UPDATE LoaiSanPham SET TenLoai = N'" + tenloai + "'  Where MaLoai = '" + maloai + "' ";

                dtgrvloaihang.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            else
            {
                MessageBox.Show("Mã Hàng không tồn tại");
            }


            load();
            clear();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string maloai = txtmaloai.Text;
            string tenloai = txttenloai.Text;
            if (kiemtra(maloai) == false)
            {
                MessageBox.Show("Mã không tồn tại");
            }
            else
            {
                string query = " DELETE  FROM LoaiSanPham WHERE MaLoai = '" + maloai + "' ";
                dtgrvloaihang.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            load();
            clear();
        }

        private void dtgrvloaihang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                txtmaloai.Text = dtgrvloaihang.Rows[idx].Cells["MaLoai"].Value.ToString();
                txttenloai.Text = dtgrvloaihang.Rows[idx].Cells["TenLoai"].Value.ToString();
                
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string timkiem = txttimkiem.Text;
            string query = "select*from LoaiSanPham WHERE TenLoai like '%" + timkiem + "%'";
            dtgrvloaihang.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
