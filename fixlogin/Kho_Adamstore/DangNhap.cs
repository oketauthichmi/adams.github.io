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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string usename = txtname.Text;//ten se lay gia tri tu o ten minh nhap tu ban phim
            string password = txtpass.Text;
            string[] list= {"'",":"};
            if (usename == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (password == "")
                {
                    MessageBox.Show("Mật khẩu không chính xác hoặc có các kí tự đặc biệt","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (DN(usename, password))
                    {

                        TrangChu trangchu = new TrangChu();
                        trangchu.ShowDialog();
                        this.Close();


                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }

        bool DN(string usename, string password)
        {
            return Acount.Instance.DN(usename, password);

        }


        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có Muốn thoát!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
