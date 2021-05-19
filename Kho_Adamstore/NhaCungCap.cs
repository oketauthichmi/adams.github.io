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
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }



        public bool kiemtra(string mancc)
        {
            string query = "select * from NhaCC where MaNhaCC = ('" + mancc + "')";
            DataTable ketqua = DataProvider.Instance.ExecuteQuery(query);
            return ketqua.Rows.Count > 0;
        }
        public void clear()
        {
            txtmancc.Text = "";
            txttenncc.Text = "";
            txtdiachi.Text = "";
            txtdienthoai.Text = "";
            


        }
        public void load()
        {
            string query = "select * from NhaCC ";//vi su dung split cat theo khoang trang suy ra viet phaii cach dau phay,


            dtgrvncc.DataSource = DataProvider.Instance.ExecuteQuery(query);//thuc hien cau truy van voi tham so @tenhang, su dung new ojcect de lay 2 doi tuong Xoai vaff Nho
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            load();

        }




        private void btnthem_Click(object sender, EventArgs e)
        {
            string mancc = txtmancc.Text;
            string tenncc = txttenncc.Text;
            string diachi = txtdiachi.Text;
            string dienthoai = txtdienthoai.Text;
            
            if (kiemtra(mancc) == true || mancc == "")
            {
                MessageBox.Show("Mã trùng hoặc lỗi ");
            }
            else
            {
                string query = "INSERT INTO NhaCC (MaNhaCC,TenNCC,DiaChi,DienThoai)VALUES ('" + mancc + "','" + tenncc + "','" + diachi + "','" + dienthoai + "') ";
                dtgrvncc.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            load();
            clear();

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string mancc = txtmancc.Text;
            string tenncc = txttenncc.Text;
            string diachi = txtdiachi.Text;
            string dienthoai = txtdienthoai.Text;

            if (kiemtra(mancc) == true)
            {
                string query = " UPDATE NhaCC SET TenNCC = N'" + tenncc + "', DiaChi = N'" + diachi + "',DienThoai = '" + dienthoai + "' Where MaNhaCC = '" + mancc + "' ";

                dtgrvncc.DataSource = DataProvider.Instance.ExecuteQuery(query);
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
            string mancc = txtmancc.Text;
            string tenncc = txttenncc.Text;
            string diachi = txtdiachi.Text;
            string dienthoai = txtdienthoai.Text;
            if (kiemtra(mancc) == false)
            {
                MessageBox.Show("Mã không tồn tại");
            }
            else
            {
                string query = " DELETE  FROM NhaCC WHERE MaNhaCC = '" + mancc + "' ";
                dtgrvncc.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            load();
            clear();
        }

        private void dtgrvncc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                txtmancc.Text = dtgrvncc.Rows[idx].Cells["MaNhaCC"].Value.ToString();
                txttenncc.Text = dtgrvncc.Rows[idx].Cells["TenNCC"].Value.ToString();
                txtdiachi.Text = dtgrvncc.Rows[idx].Cells["DiaChi"].Value.ToString();
                txtdienthoai.Text = dtgrvncc.Rows[idx].Cells["DienThoai"].Value.ToString();
               
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string timkiem = txttimkiem.Text;
            string query = "select*from NhaCC WHERE TenNCC like '%" + timkiem + "%'";
            dtgrvncc.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
