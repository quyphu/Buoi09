namespace Bai7
{
    partial class QLKhoa
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnMK = new System.Windows.Forms.Button();
            this.btnTenKhoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMK = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Chuyển Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMK
            // 
            this.btnMK.Location = new System.Drawing.Point(81, 25);
            this.btnMK.Name = "btnMK";
            this.btnMK.Size = new System.Drawing.Size(90, 23);
            this.btnMK.TabIndex = 1;
            this.btnMK.Text = "Tìm Mã Khoa";
            this.btnMK.UseVisualStyleBackColor = true;
            this.btnMK.Click += new System.EventHandler(this.btnMK_Click);
            // 
            // btnTenKhoa
            // 
            this.btnTenKhoa.Location = new System.Drawing.Point(403, 26);
            this.btnTenKhoa.Name = "btnTenKhoa";
            this.btnTenKhoa.Size = new System.Drawing.Size(75, 23);
            this.btnTenKhoa.TabIndex = 2;
            this.btnTenKhoa.Text = "Tên Khoa";
            this.btnTenKhoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(359, 114);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMK
            // 
            this.txtMK.AutoSize = true;
            this.txtMK.Location = new System.Drawing.Point(223, 7);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(50, 13);
            this.txtMK.TabIndex = 4;
            this.txtMK.Text = "Mã Khoa";
            // 
            // txtTK
            // 
            this.txtTK.AutoSize = true;
            this.txtTK.Location = new System.Drawing.Point(523, 7);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(54, 13);
            this.txtTK.TabIndex = 5;
            this.txtTK.Text = "Tên Khoa";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(194, 27);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(100, 20);
            this.txtMaKhoa.TabIndex = 6;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(504, 25);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(100, 20);
            this.txtTenKhoa.TabIndex = 7;
            // 
            // QLKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 261);
            this.Controls.Add(this.txtTenKhoa);
            this.Controls.Add(this.txtMaKhoa);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTenKhoa);
            this.Controls.Add(this.btnMK);
            this.Controls.Add(this.button1);
            this.Name = "QLKhoa";
            this.Text = "QLKhoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMK;
        private System.Windows.Forms.Button btnTenKhoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label txtMK;
        private System.Windows.Forms.Label txtTK;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.TextBox txtTenKhoa;
    }
}

