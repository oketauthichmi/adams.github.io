namespace Kho_Adamstore
{
    partial class NhapHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmapn = new System.Windows.Forms.TextBox();
            this.dtgrvnhap = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.cbncc = new System.Windows.Forms.ComboBox();
            this.dtngaynhap = new System.Windows.Forms.DateTimePicker();
            this.btnchitiet = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvnhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = " nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày nhập";
            // 
            // txtmapn
            // 
            this.txtmapn.Location = new System.Drawing.Point(137, 155);
            this.txtmapn.Name = "txtmapn";
            this.txtmapn.Size = new System.Drawing.Size(121, 20);
            this.txtmapn.TabIndex = 3;
            // 
            // dtgrvnhap
            // 
            this.dtgrvnhap.BackgroundColor = System.Drawing.Color.White;
            this.dtgrvnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvnhap.Location = new System.Drawing.Point(388, 130);
            this.dtgrvnhap.Name = "dtgrvnhap";
            this.dtgrvnhap.Size = new System.Drawing.Size(375, 237);
            this.dtgrvnhap.TabIndex = 7;
            this.dtgrvnhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvnhap_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(286, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phiếu nhập hàng";
            // 
            // btnsua
            // 
            this.btnsua.Image = global::Kho_Adamstore.Properties.Resources.icons8_wrench_32px;
            this.btnsua.Location = new System.Drawing.Point(320, 205);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(45, 45);
            this.btnsua.TabIndex = 9;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = global::Kho_Adamstore.Properties.Resources.icons8_delete_45px_1;
            this.btnxoa.Location = new System.Drawing.Point(320, 271);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(45, 45);
            this.btnxoa.TabIndex = 10;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Image = global::Kho_Adamstore.Properties.Resources.icons8_add_45px;
            this.btnthem.Location = new System.Drawing.Point(320, 142);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(45, 45);
            this.btnthem.TabIndex = 11;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btntim
            // 
            this.btntim.Image = global::Kho_Adamstore.Properties.Resources.icons8_search_32px;
            this.btntim.Location = new System.Drawing.Point(675, 94);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(32, 32);
            this.btntim.TabIndex = 12;
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // cbncc
            // 
            this.cbncc.FormattingEnabled = true;
            this.cbncc.Location = new System.Drawing.Point(137, 218);
            this.cbncc.Name = "cbncc";
            this.cbncc.Size = new System.Drawing.Size(121, 21);
            this.cbncc.TabIndex = 13;
            this.cbncc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbncc_MouseClick);
            // 
            // dtngaynhap
            // 
            this.dtngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaynhap.Location = new System.Drawing.Point(137, 287);
            this.dtngaynhap.Name = "dtngaynhap";
            this.dtngaynhap.Size = new System.Drawing.Size(121, 20);
            this.dtngaynhap.TabIndex = 14;
            // 
            // btnchitiet
            // 
            this.btnchitiet.Location = new System.Drawing.Point(37, 333);
            this.btnchitiet.Name = "btnchitiet";
            this.btnchitiet.Size = new System.Drawing.Size(328, 34);
            this.btnchitiet.TabIndex = 15;
            this.btnchitiet.Text = "Xem chi tiết";
            this.btnchitiet.UseVisualStyleBackColor = true;
            this.btnchitiet.Click += new System.EventHandler(this.btnchitiet_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(483, 95);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(186, 29);
            this.txttimkiem.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(480, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nhập mã phiếu nhập:";
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btnchitiet);
            this.Controls.Add(this.dtngaynhap);
            this.Controls.Add(this.cbncc);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgrvnhap);
            this.Controls.Add(this.txtmapn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhapHang";
            this.Text = "Nhập Hàng";
            this.Load += new System.EventHandler(this.NhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvnhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmapn;
        private System.Windows.Forms.DataGridView dtgrvnhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.ComboBox cbncc;
        private System.Windows.Forms.DateTimePicker dtngaynhap;
        private System.Windows.Forms.Button btnchitiet;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label5;
    }
}