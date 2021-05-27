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
    public partial class chitietxuat : Form
    {
        public chitietxuat()
        {
            InitializeComponent();
        }

        private string maphieux;

        public string abc
        {
            get { return maphieux; }
            set { maphieux = value; }
        }

        public bool kiemtra(string mactpx)
        {
            string query = "select * from ChiTietPhieuXuat where MaCTPX = ('" + mactpx + "')";
            DataTable ketqua = DataProvider.Instance.ExecuteQuery(query);
            return ketqua.Rows.Count > 0;
        }
        public void clear()
        {
            txtmact.Text = "";
            
            txtsize.Text = "";
            txtsl.Text = "";
            txtdongia.Text = "";


        }
        public void load()
        {
            string query = "select * from ChiTietPhieuXuat where MaPX ='"+maphieux+"' ";//vi su dung split cat theo khoang trang suy ra viet phaii cach dau phay,


            dtgrvctpx.DataSource = DataProvider.Instance.ExecuteQuery(query);//thuc hien cau truy van voi tham so @tenhang, su dung new ojcect de lay 2 doi tuong Xoai vaff Nho
        }




        private void chitietxuat_Load(object sender, EventArgs e)
        {
            load();
            showcbmahang();
            showcbmanv();
            showtxtmapx();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string mactpx = txtmact.Text;
            string mapx = txtmapx.Text;
            string mahang = cbmahang.SelectedValue.ToString();
            string manv = cbmanv.SelectedValue.ToString();
            string size = txtsize.Text;
            string soluong = txtsl.Text;
            string dongia = txtdongia.Text;
            if (kiemtra(mactpx) == true || mactpx == "")
            {
                MessageBox.Show("Mã trùng hoặc lỗi ");
            }
            else
            {
                string query = "INSERT INTO ChiTietPhieuXuat (MaCTPX,MaPX,MaHang,MaNV,Size,SoLuongXuat,DonGiaXuat)VALUES ('" + mactpx + "','" + mapx + "','" + mahang + "','" + manv + "', '" + size + "','" + soluong + "','" + dongia + "') ";
                dtgrvctpx.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            load();
            clear();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string mactpx = txtmact.Text;
            string mapx = txtmapx.Text;
            string mahang = cbmahang.SelectedValue.ToString();
            string manv = cbmanv.SelectedValue.ToString();
            string size = txtsize.Text;
            string soluong = txtsl.Text;
            string dongia = txtdongia.Text;
            if (kiemtra(mactpx) == true)
            {
                string query = " UPDATE ChiTietPhieuXuat SET MaPX = N'" + mapx + "', MaHang = N'" + mahang + "',MaNV = '" + manv + "',Size = N'" + size + "',SoLuongXuat = N'" + soluong + "',DonGiaXuat = N'" + dongia + "' Where MaCTPX = '" + mactpx + "' ";

                dtgrvctpx.DataSource = DataProvider.Instance.ExecuteQuery(query);
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
            string mactpx = txtmact.Text;
            string mapx = txtmapx.Text;
            string mahang = cbmahang.SelectedValue.ToString();
            string manv = cbmanv.SelectedValue.ToString();
            string size = txtsize.Text;
            string soluong = txtsl.Text;
            string dongia = txtdongia.Text;
            if (kiemtra(mactpx) == false)
            {
                MessageBox.Show("Mã không tồn tại");
            }
            else
            {
                string query = " DELETE  FROM ChiTietPhieuXuat WHERE MaCTPX = '" + mactpx + "' ";
                dtgrvctpx.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            load();
            clear();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            
        }

        private void dtgrvctpn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                txtmact.Text = dtgrvctpx.Rows[idx].Cells["MaCTPX"].Value.ToString();
                txtmapx.Text = dtgrvctpx.Rows[idx].Cells["MaPX"].Value.ToString();
                cbmahang.Text = dtgrvctpx.Rows[idx].Cells["MaHang"].Value.ToString();
                cbmanv.Text = dtgrvctpx.Rows[idx].Cells["MaNV"].Value.ToString();
                txtsize.Text = dtgrvctpx.Rows[idx].Cells["Size"].Value.ToString();
                txtsl.Text = dtgrvctpx.Rows[idx].Cells["SoLuongXuat"].Value.ToString();
                txtdongia.Text = dtgrvctpx.Rows[idx].Cells["DonGiaXuat"].Value.ToString();

            }
        }

        private void cbmapx_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        public void showtxtmapx()
        {
            txtmapx.Text = maphieux;
            lbmapx.Text = maphieux;
        }

        private void cbmahang_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
        public void showcbmahang()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(@"select * from Hang");
            cbmahang.DataSource = data;
            cbmahang.DisplayMember = "TenHang";
            cbmahang.ValueMember = "MaHang";
        }

        private void cbmanv_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
        public void showcbmanv()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(@"select * from NhanVien");
            cbmanv.DataSource = data;
            cbmanv.DisplayMember = "TenNV";
            cbmanv.ValueMember = "MaNV";
        }
    }
}
