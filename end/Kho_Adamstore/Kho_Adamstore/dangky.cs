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
    public partial class dangky : Form
    {
        public dangky()
        {
            InitializeComponent();
        }

        public bool kiemtra(string madk)
        {
            string query = "select * from DangNhap where MaTK = ('" + madk + "')";
            DataTable ketqua = DataProvider.Instance.ExecuteQuery(query);
            return ketqua.Rows.Count > 0;
        }
        public void clear()
        {
            txtmadk.Text = "";
            txtpassdk.Text = "";
            txttendk.Text = "";

        }
        public void load()
        {
            string query = "select * from DangNhap ";//vi su dung split cat theo khoang trang suy ra viet phaii cach dau phay,


            dtgrvdk.DataSource = DataProvider.Instance.ExecuteQuery(query);//thuc hien cau truy van voi tham so @tenhang, su dung new ojcect de lay 2 doi tuong Xoai vaff Nho
        }
        private void dangky_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string madk = txtmadk.Text;
            string tendk = txttendk.Text;
            string pass = txtpassdk.Text;

            if (kiemtra(madk) == true || madk == "" || tendk=="" || pass=="")
            {
                MessageBox.Show("Mã đã tồn tại hoặc tài khoản đang trống");
            }
            else
            {
                string query = "INSERT INTO DangNhap (MaTK,TaiKhoan,password)VALUES ('" + madk + "','" + tendk + "','"+pass+"') ";
                dtgrvdk.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            load();
            clear();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string madk = txtmadk.Text;
            string tendk = txttendk.Text;
            string pass = txtpassdk.Text;

            if (kiemtra(madk) == true)
            {
                string query = " UPDATE DangNhap SET TaiKhoan = N'" + tendk + "', password=N'"+pass+"'  Where MaTK = '" + madk + "' ";

                dtgrvdk.DataSource = DataProvider.Instance.ExecuteQuery(query);
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
            string madk = txtmadk.Text;
            string tendk = txttendk.Text;
            string pass = txtpassdk.Text;
            if (kiemtra(madk) == true)
            {
                string query = " DELETE  FROM DangNhap WHERE MaTK = '" + madk + "' ";
                dtgrvdk.DataSource = DataProvider.Instance.ExecuteQuery(query);   
            }
            else
            {
                MessageBox.Show("Mã không tồn tại");
            }
            load();
            clear();
        }

        private void dtgrvdk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                txtmadk.Text = dtgrvdk.Rows[idx].Cells["MaTK"].Value.ToString();
                txttendk.Text = dtgrvdk.Rows[idx].Cells["TaiKhoan"].Value.ToString();
                txtpassdk.Text = dtgrvdk.Rows[idx].Cells["password"].Value.ToString();

            }
        }
    }
}
