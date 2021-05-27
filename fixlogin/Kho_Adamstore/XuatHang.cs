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
    public partial class XuatHang : Form
    {
        public XuatHang()
        {
            InitializeComponent();
        }

        public bool kiemtra(string mapx)
        {
            string query = "select * from PhieuXuat where MaPX= ('" + mapx + "')";
            DataTable ketqua = DataProvider.Instance.ExecuteQuery(query);
            return ketqua.Rows.Count > 0;
        }
        public void clear()
        {
            txtmaxuat.Text = "";
          
            
        


        }
        public void load()
        {
            string query = "select * from PhieuXuat ";//vi su dung split cat theo khoang trang suy ra viet phaii cach dau phay,


            dtgrvxuat.DataSource = DataProvider.Instance.ExecuteQuery(query);//thuc hien cau truy van voi tham so @tenhang, su dung new ojcect de lay 2 doi tuong Xoai vaff Nho
        }
        private void XuatHang_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string mapx = txtmaxuat.Text;
            string ngayxuat = dtngayxuat.Value.ToString("MM/dd/yyyy");
            if (kiemtra(mapx) == true || mapx == "")
            {
                MessageBox.Show("Mã trùng hoặc lỗi ");
            }
            else
            {
                string query = "INSERT INTO PhieuXuat (MaPX,NgayXuat)VALUES ('" + mapx + "','" + ngayxuat + "') ";
                dtgrvxuat.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            load();
            clear();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string mapx = txtmaxuat.Text;
            string ngayxuat = dtngayxuat.Value.ToString("MM/dd/yyyy");
            if (kiemtra(mapx) == true)
            {
                string query = " UPDATE PhieuXuat SET NgayXuat = N'" +ngayxuat  + "'Where MaPX = '" + mapx + "' ";

                dtgrvxuat.DataSource = DataProvider.Instance.ExecuteQuery(query);
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
            string mapx = txtmaxuat.Text;
            string ngayxuat = dtngayxuat.Value.ToString("MM/dd/yyyy");
            if (kiemtra(mapx) == false)
            {
                MessageBox.Show("Mã không tồn tại");
            }
            else
            {
                string query = " DELETE  FROM PhieuXuat WHERE MaPX = '" + mapx + "' ";
                dtgrvxuat.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            load();
            clear();
        }

        

        private void dtgrvxuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                txtmaxuat.Text = dtgrvxuat.Rows[idx].Cells["MaPX"].Value.ToString();
                dtngayxuat.Text = dtgrvxuat.Rows[idx].Cells["NgayXuat"].Value.ToString();
                
            }
        }

        private void btnchitiet_Click(object sender, EventArgs e)
        {
            chitietxuat ct = new chitietxuat();
            ct.ShowDialog();
        }
    }
}
