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
    public partial class Nhanvien : Form
    {
        public Nhanvien()
        {
            InitializeComponent();
        }

        public bool kiemtra(string manv)
        {
            string query = "select * from NhanVien where MaNV = ('" + manv + "')";
            DataTable ketqua = DataProvider.Instance.ExecuteQuery(query);
            return ketqua.Rows.Count > 0;
        }
        public void clear()
        {
            txtmanv.Text = "";
            txttennv.Text = "";
            txtgioitinh.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
          


        }
        public void load()
        {
            string query = "select * from NhanVien ";//vi su dung split cat theo khoang trang suy ra viet phaii cach dau phay,


            dtgrvnhanvien.DataSource = DataProvider.Instance.ExecuteQuery(query);//thuc hien cau truy van voi tham so @tenhang, su dung new ojcect de lay 2 doi tuong Xoai vaff Nho
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string manv = txtmanv.Text;
            string tennv = txttennv.Text;
            string ngaysinh =dtngaysinh.Value.ToString("MM/dd/yyyy") ;
            string gioitinh = txtgioitinh.Text;
            string diachi = txtdiachi.Text;
            string sdt = txtsdt.Text;
         
           
            if (kiemtra(manv) == true || manv == "")
            {
                MessageBox.Show("Mã trùng hoặc lỗi ");
            }
            else
            {
                string query = "INSERT INTO NhanVien (MaNV,TenNV,ngaysinh,gioitinh,diachi,dienthoai)VALUES ('" + manv + "','" + tennv + "','" + ngaysinh + "','" + gioitinh + "', '" + diachi + "','" + sdt + "') ";
                dtgrvnhanvien.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            load();
            clear();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string manv = txtmanv.Text;
            string tennv = txttennv.Text;
            string ngaysinh = dtngaysinh.Value.ToString("MM/dd/yyyy");
            string gioitinh = txtgioitinh.Text;
            string diachi = txtdiachi.Text;
            string sdt = txtsdt.Text;
            if (kiemtra(manv) == true)
            {
                string query = " UPDATE NhanVien SET TenNV = N'" + tennv + "', ngaysinh = N'" + ngaysinh + "',gioitinh = '" + gioitinh + "',diachi = N'" + diachi + "',dienthoai = N'" + sdt + "' Where MaNV = '" + manv + "' ";

                dtgrvnhanvien.DataSource = DataProvider.Instance.ExecuteQuery(query);
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
            string manv = txtmanv.Text;
            string tennv = txttennv.Text;
            string ngaysinh = dtngaysinh.Value.ToString("MM/dd/yyyy");
            string gioitinh = txtgioitinh.Text;
            string diachi = txtdiachi.Text;
            string sdt = txtsdt.Text;

            if (kiemtra(manv) == false)
            {
                MessageBox.Show("Mã không tồn tại");
            }
            else
            {
                string query = " DELETE  FROM NhanVien WHERE MaNV = '" + manv + "' ";
                dtgrvnhanvien.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            load();
            clear();
        }

        private void dtgrvnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                txtmanv.Text = dtgrvnhanvien.Rows[idx].Cells["MaNV"].Value.ToString();
                txttennv.Text = dtgrvnhanvien.Rows[idx].Cells["TenNV"].Value.ToString();
                dtngaysinh.Text = dtgrvnhanvien.Rows[idx].Cells["NgaySinh"].Value.ToString();
                txtgioitinh.Text = dtgrvnhanvien.Rows[idx].Cells["gioitinh"].Value.ToString();
                txtdiachi.Text = dtgrvnhanvien.Rows[idx].Cells["diachi"].Value.ToString();
                txtsdt.Text = dtgrvnhanvien.Rows[idx].Cells["dienthoai"].Value.ToString();


            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string timkiem = txttimkiem.Text;
            string query = "select*from NhanVien WHERE TenNV like '%" + timkiem + "%'";
            dtgrvnhanvien.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
