namespace Kho_Adamstore
{
    partial class XuatHang
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
            this.btnchitiet = new System.Windows.Forms.Button();
            this.dtngayxuat = new System.Windows.Forms.DateTimePicker();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgrvxuat = new System.Windows.Forms.DataGridView();
            this.txtmaxuat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvxuat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnchitiet
            // 
            this.btnchitiet.Location = new System.Drawing.Point(39, 284);
            this.btnchitiet.Name = "btnchitiet";
            this.btnchitiet.Size = new System.Drawing.Size(221, 23);
            this.btnchitiet.TabIndex = 29;
            this.btnchitiet.Text = "Xem chi tiết";
            this.btnchitiet.UseVisualStyleBackColor = true;
            this.btnchitiet.Click += new System.EventHandler(this.btnchitiet_Click);
            // 
            // dtngayxuat
            // 
            this.dtngayxuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngayxuat.Location = new System.Drawing.Point(139, 241);
            this.dtngayxuat.Name = "dtngayxuat";
            this.dtngayxuat.Size = new System.Drawing.Size(121, 20);
            this.dtngayxuat.TabIndex = 28;
            // 
            // btnthem
            // 
            this.btnthem.Image = global::Kho_Adamstore.Properties.Resources.icons8_add_45px;
            this.btnthem.Location = new System.Drawing.Point(307, 184);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(45, 45);
            this.btnthem.TabIndex = 25;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = global::Kho_Adamstore.Properties.Resources.icons8_delete_45px_1;
            this.btnxoa.Location = new System.Drawing.Point(307, 305);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(45, 45);
            this.btnxoa.TabIndex = 24;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = global::Kho_Adamstore.Properties.Resources.icons8_wrench_32px;
            this.btnsua.Location = new System.Drawing.Point(307, 243);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(45, 45);
            this.btnsua.TabIndex = 23;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(332, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 31);
            this.label4.TabIndex = 22;
            this.label4.Text = "phiếu xuất hàng";
            // 
            // dtgrvxuat
            // 
            this.dtgrvxuat.BackgroundColor = System.Drawing.Color.White;
            this.dtgrvxuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvxuat.Location = new System.Drawing.Point(390, 174);
            this.dtgrvxuat.Name = "dtgrvxuat";
            this.dtgrvxuat.Size = new System.Drawing.Size(375, 195);
            this.dtgrvxuat.TabIndex = 21;
            this.dtgrvxuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvxuat_CellClick);
            // 
            // txtmaxuat
            // 
            this.txtmaxuat.Location = new System.Drawing.Point(139, 197);
            this.txtmaxuat.Name = "txtmaxuat";
            this.txtmaxuat.Size = new System.Drawing.Size(121, 20);
            this.txtmaxuat.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ngày nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã phiếu xuất";
            // 
            // XuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnchitiet);
            this.Controls.Add(this.dtngayxuat);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgrvxuat);
            this.Controls.Add(this.txtmaxuat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "XuatHang";
            this.Text = "XuatHang";
            this.Load += new System.EventHandler(this.XuatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvxuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnchitiet;
        private System.Windows.Forms.DateTimePicker dtngayxuat;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgrvxuat;
        private System.Windows.Forms.TextBox txtmaxuat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}