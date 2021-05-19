namespace Kho_Adamstore
{
    partial class chitietxuat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chitietxuat));
            this.label9 = new System.Windows.Forms.Label();
            this.cbmanv = new System.Windows.Forms.ComboBox();
            this.cbmahang = new System.Windows.Forms.ComboBox();
            this.cbmapx = new System.Windows.Forms.ComboBox();
            this.dtgrvctpx = new System.Windows.Forms.DataGridView();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btntim = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.txtsize = new System.Windows.Forms.TextBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txtmact = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvctpx)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(489, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "nhập mã phiếu xuất cần tìm";
            // 
            // cbmanv
            // 
            this.cbmanv.FormattingEnabled = true;
            this.cbmanv.Location = new System.Drawing.Point(126, 223);
            this.cbmanv.Name = "cbmanv";
            this.cbmanv.Size = new System.Drawing.Size(135, 21);
            this.cbmanv.TabIndex = 45;
            this.cbmanv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbmanv_MouseClick);
            // 
            // cbmahang
            // 
            this.cbmahang.FormattingEnabled = true;
            this.cbmahang.Location = new System.Drawing.Point(126, 172);
            this.cbmahang.Name = "cbmahang";
            this.cbmahang.Size = new System.Drawing.Size(135, 21);
            this.cbmahang.TabIndex = 44;
            this.cbmahang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbmahang_MouseClick);
            // 
            // cbmapx
            // 
            this.cbmapx.FormattingEnabled = true;
            this.cbmapx.Location = new System.Drawing.Point(126, 120);
            this.cbmapx.Name = "cbmapx";
            this.cbmapx.Size = new System.Drawing.Size(135, 21);
            this.cbmapx.TabIndex = 43;
            this.cbmapx.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbmapx_MouseClick);
            // 
            // dtgrvctpx
            // 
            this.dtgrvctpx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvctpx.Location = new System.Drawing.Point(77, 260);
            this.dtgrvctpx.Name = "dtgrvctpx";
            this.dtgrvctpx.Size = new System.Drawing.Size(694, 166);
            this.dtgrvctpx.TabIndex = 42;
            this.dtgrvctpx.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvctpn_CellClick);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(490, 234);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(185, 20);
            this.txttimkiem.TabIndex = 41;
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(681, 231);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(75, 23);
            this.btntim.TabIndex = 40;
            this.btntim.Text = "TÌm kiếm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(429, 172);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 39;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(308, 172);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 38;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(545, 172);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 37;
            this.btnxoa.Text = "xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // txtsize
            // 
            this.txtsize.Location = new System.Drawing.Point(379, 76);
            this.txtsize.Name = "txtsize";
            this.txtsize.Size = new System.Drawing.Size(135, 20);
            this.txtsize.TabIndex = 36;
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(379, 123);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(135, 20);
            this.txtsl.TabIndex = 35;
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(636, 73);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(135, 20);
            this.txtdongia.TabIndex = 34;
            // 
            // txtmact
            // 
            this.txtmact.Location = new System.Drawing.Point(126, 79);
            this.txtmact.Name = "txtmact";
            this.txtmact.Size = new System.Drawing.Size(135, 20);
            this.txtmact.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(37, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Tên hàng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(29, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Tên nhân viên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(304, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Size:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(304, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Số lượng xuất:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(556, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Đơn giá xuat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(29, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "mã phiếu xuất:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(301, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 31);
            this.label2.TabIndex = 26;
            this.label2.Text = "Chi tiết phiếu xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(37, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "mã chi tiết:";
            // 
            // chitietxuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbmanv);
            this.Controls.Add(this.cbmahang);
            this.Controls.Add(this.cbmapx);
            this.Controls.Add(this.dtgrvctpx);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.txtsize);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.txtdongia);
            this.Controls.Add(this.txtmact);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "chitietxuat";
            this.Text = "chitietxuat";
            this.Load += new System.EventHandler(this.chitietxuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvctpx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbmanv;
        private System.Windows.Forms.ComboBox cbmahang;
        private System.Windows.Forms.ComboBox cbmapx;
        private System.Windows.Forms.DataGridView dtgrvctpx;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.TextBox txtsize;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txtmact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}