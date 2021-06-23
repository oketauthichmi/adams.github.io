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
    public partial class Hang : Form
    {
        public Hang()
        {
            InitializeComponent();
        }

        public bool kiemtra(string mahang)
        {
            string query = "select * from Hang where MaHang = ('" + mahang + "')";
            DataTable ketqua = DataProvider.Instance.ExecuteQuery(query);
            return ketqua.Rows.Count > 0;
        }
        public void clear()
        {
            txtmahang.Text = "";
            txttenhang.Text = "";
            txtsize.Text = "";
            txtsoluong.Text = "";
            txtdongia.Text = "";


        }
        public void load()
        {
            string query = "select * from Hang ";//vi su dung split cat theo khoang trang suy ra viet phaii cach dau phay,


            dtgrvhang.DataSource = DataProvider.Instance.ExecuteQuery(query);//thuc hien cau truy van voi tham so @tenhang, su dung new ojcect de lay 2 doi tuong Xoai vaff Nho
        }

        private void Hang_Load(object sender, EventArgs e)
        {
            load();
            showcbmanhacc();
            showxbmaloai();
           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string mahang = txtmahang.Text;
            string manhacc = cbmanhacc.Text;
            string maloai = cbmaloai.Text;
            string tenhang = txttenhang.Text;
            string size = txtsize.Text;
            string soluong = txtsoluong.Text;
            string dongia = txtdongia.Text;
            if (kiemtra(mahang) == true || mahang == "")
            {
                MessageBox.Show("Mã trùng hoặc lỗi ");
            }
            else
            {
                string query = "INSERT INTO Hang (MaHang,MaNhaCC,MaLoai,TenHang,Size,SoLuong,DonGia)VALUES ('" + mahang + "','" + manhacc + "','" + maloai + "','" + tenhang + "', '" + size + "','" + soluong + "','" + dongia + "') ";
                dtgrvhang.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            load();
            clear();

        }

        private void btnsua_Click(object sender, EventArgs e)
            {
            string mahang = txtmahang.Text;
            string manhacc = cbmanhacc.Text;
            string maloai = cbmaloai.Text;
            string tenhang = txttenhang.Text;
            string size = txtsize.Text;
            string soluong = txtsoluong.Text;
            string dongia = txtdongia.Text;
            if (kiemtra(mahang) == true)
            {
                string query = " UPDATE Hang SET MaNhaCC = N'" + manhacc + "', MaLoai = N'" + maloai + "',TenHang = '" + tenhang + "',Size = N'" + size + "',SoLuong = N'" + soluong + "',DonGia = N'" + dongia + "' Where MaHang = '" + mahang + "' ";

                dtgrvhang.DataSource = DataProvider.Instance.ExecuteQuery(query);
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
            string mahang = txtmahang.Text;
            string manhacc = cbmanhacc.Text;
            string maloai = cbmaloai.Text;
            string tenhang = txttenhang.Text;
            string size = txtsize.Text;
            string soluong = txtsoluong.Text;
            string dongia = txtdongia.Text;
            if (kiemtra(mahang) == false)
            {
                MessageBox.Show("Mã không tồn tại");
            }
            else
            {
                string query = " DELETE  FROM Hang WHERE Mahang = '" + mahang + "' ";
                dtgrvhang.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            load();
            clear();
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void cbmaloai_MouseClick(object sender, MouseEventArgs e)
        {


           
           
        }
        public void showxbmaloai()
        {
            DataTable dat = DataProvider.Instance.ExecuteQuery(@"select * from LoaiSanPham");
            cbmaloai.DataSource = dat;
            cbmaloai.DisplayMember = "TenLoai";
            cbmaloai.ValueMember = "MaLoai";
        }
    

        private void cbmanhacc_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
        public void showcbmanhacc()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(@"select * from NhaCC");
            cbmanhacc.DataSource = data;
            cbmanhacc.DisplayMember = "TenNCC";
            cbmanhacc.ValueMember = "MaNhaCC";
        }

       

        

        private void dtgrvhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                txtmahang.Text = dtgrvhang.Rows[idx].Cells["MaHang"].Value.ToString();
                cbmanhacc.Text = dtgrvhang.Rows[idx].Cells["MaNhaCC"].Value.ToString();
                cbmaloai.Text = dtgrvhang.Rows[idx].Cells["MaLoai"].Value.ToString();
                txttenhang.Text = dtgrvhang.Rows[idx].Cells["TenHang"].Value.ToString();
                txtsize.Text = dtgrvhang.Rows[idx].Cells["Size"].Value.ToString();
                txtsoluong.Text = dtgrvhang.Rows[idx].Cells["SoLuong"].Value.ToString();
                txtdongia.Text = dtgrvhang.Rows[idx].Cells["DonGia"].Value.ToString();
            }
        }

        private void txtdongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbmanhacc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbmaloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string timkiem = txttim.Text;
            string query = "select*from Hang WHERE TenHang like '%" + timkiem + "%'";
            dtgrvhang.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
