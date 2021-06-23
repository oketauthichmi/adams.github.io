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
    public partial class NhapHang : Form
    {
        public NhapHang()
        {
            InitializeComponent();
        }



        public bool kiemtra(string mapn)
        {
            string query = "select * from PhieuNhap where MaPN = ('" + mapn + "')";
            DataTable ketqua = DataProvider.Instance.ExecuteQuery(query);
            return ketqua.Rows.Count > 0;
        }
        public void clear()
        {
            txtmapn.Text = "";
            
            
            


        }
        public void load()
        {
            string query = "select * from PhieuNhap ";//vi su dung split cat theo khoang trang suy ra viet phaii cach dau phay,


            dtgrvnhap.DataSource = DataProvider.Instance.ExecuteQuery(query);//thuc hien cau truy van voi tham so @tenhang, su dung new ojcect de lay 2 doi tuong Xoai vaff Nho
        }

        public void showcbx()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(@"select * from NhaCC");
            cbncc.DataSource = data;
            cbncc.DisplayMember = "TenNCC";
            cbncc.ValueMember = "MaNhaCC";
        }
        private void NhapHang_Load(object sender, EventArgs e)
        {
            load();
            this.showcbx();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string mapn = txtmapn.Text;
            string mancc = cbncc.SelectedValue.ToString();
            string ngaynhap = dtngaynhap.Value.ToString("MM/dd/yyyy");
    
            if (kiemtra(mapn) == true || mapn == "" || cbncc.SelectedItem== null )
            {
                MessageBox.Show("Mã trùng hoặc lỗi ");
            }
            else
            {
                string query = "INSERT INTO PhieuNhap (MaPN,MaNhaCC,NgayNhap)VALUES ('" + mapn + "','" + mancc + "','" + ngaynhap + "') ";
                dtgrvnhap.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            load();
            clear();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string mapn = txtmapn.Text;
            string mancc = cbncc.SelectedValue.ToString();
            string ngaynhap = dtngaynhap.Value.ToString("MM/dd/yyyy");
            if (kiemtra(mapn) == true)
            {
                string query = " UPDATE PhieuNhap SET MaNhaCC = N'" + mancc + "', NgayNhap = N'" + ngaynhap + "'Where MaPN = '" + mapn + "' ";

                dtgrvnhap.DataSource = DataProvider.Instance.ExecuteQuery(query);
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
            string mapn = txtmapn.Text;
            string mancc = cbncc.SelectedValue.ToString();
            string ngaynhap = dtngaynhap.Value.ToString("MM/dd/yyyy");

            if (kiemtra(mapn) == false)
            {
                MessageBox.Show("Mã không tồn tại");
            }
            else
            {
                string query = " DELETE  FROM PhieuNhap WHERE MaPN = '" + mapn + "' ";
                dtgrvnhap.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            load();
            clear();
        }

        private void dtgrvnhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                txtmapn.Text = dtgrvnhap.Rows[idx].Cells["MaPN"].Value.ToString();
                cbncc.Text = dtgrvnhap.Rows[idx].Cells["MaNhaCC"].Value.ToString();
                dtngaynhap.Text = dtgrvnhap.Rows[idx].Cells["NgayNhap"].Value.ToString();
               
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string timkiem = txttimkiem.Text;
            string query = "select*from PhieuNhap WHERE MaPN like '%" + timkiem + "%'";
            dtgrvnhap.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void cbncc_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnchitiet_Click(object sender, EventArgs e)
        {
            chitietpn chitiet = new chitietpn();
            chitiet.ShowDialog();
        }
    }
}
