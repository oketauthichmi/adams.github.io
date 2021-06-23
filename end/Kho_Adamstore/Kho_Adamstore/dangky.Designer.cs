namespace Kho_Adamstore
{
    partial class dangky
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
            this.dtgrvdk = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttendk = new System.Windows.Forms.TextBox();
            this.txtpassdk = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.txtmadk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvdk)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrvdk
            // 
            this.dtgrvdk.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgrvdk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvdk.Location = new System.Drawing.Point(400, 121);
            this.dtgrvdk.Name = "dtgrvdk";
            this.dtgrvdk.Size = new System.Drawing.Size(375, 251);
            this.dtgrvdk.TabIndex = 0;
            this.dtgrvdk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvdk_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(64, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(64, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "password:";
            // 
            // txttendk
            // 
            this.txttendk.Location = new System.Drawing.Point(153, 196);
            this.txttendk.Name = "txttendk";
            this.txttendk.Size = new System.Drawing.Size(133, 20);
            this.txttendk.TabIndex = 6;
            // 
            // txtpassdk
            // 
            this.txtpassdk.Location = new System.Drawing.Point(153, 262);
            this.txtpassdk.Name = "txtpassdk";
            this.txtpassdk.Size = new System.Drawing.Size(133, 20);
            this.txtpassdk.TabIndex = 7;
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.Transparent;
            this.btnthem.FlatAppearance.BorderSize = 0;
            this.btnthem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.btnthem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnthem.Image = global::Kho_Adamstore.Properties.Resources.icons8_add_45px;
            this.btnthem.Location = new System.Drawing.Point(317, 121);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(45, 45);
            this.btnthem.TabIndex = 8;
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.FlatAppearance.BorderSize = 0;
            this.btnsua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.btnsua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsua.Image = global::Kho_Adamstore.Properties.Resources.icons8_wrench_32px;
            this.btnsua.Location = new System.Drawing.Point(319, 183);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(45, 45);
            this.btnsua.TabIndex = 9;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.FlatAppearance.BorderSize = 0;
            this.btnxoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnxoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Image = global::Kho_Adamstore.Properties.Resources.icons8_delete_45px_1;
            this.btnxoa.Location = new System.Drawing.Point(319, 249);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(45, 45);
            this.btnxoa.TabIndex = 10;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // txtmadk
            // 
            this.txtmadk.Location = new System.Drawing.Point(153, 134);
            this.txtmadk.Name = "txtmadk";
            this.txtmadk.Size = new System.Drawing.Size(133, 20);
            this.txtmadk.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(64, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "mã tài khoản:";
            // 
            // dangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtmadk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtpassdk);
            this.Controls.Add(this.txttendk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgrvdk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dangky";
            this.Text = "đăng ký";
            this.Load += new System.EventHandler(this.dangky_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvdk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrvdk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttendk;
        private System.Windows.Forms.TextBox txtpassdk;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.TextBox txtmadk;
        private System.Windows.Forms.Label label3;
    }
}