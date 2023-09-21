namespace QuanLyCuaHangPhuKienCauLong
{
    partial class frmThongKeDoanhThu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbHoaDon = new System.Windows.Forms.RadioButton();
            this.rdbPhieuNhap = new System.Windows.Forms.RadioButton();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.lbDoanhThu = new System.Windows.Forms.Label();
            this.txtTongDoanhThu = new System.Windows.Forms.TextBox();
            this.lbBangChu1 = new System.Windows.Forms.Label();
            this.lbBangChu2 = new System.Windows.Forms.Label();
            this.txtTongTienNhap = new System.Windows.Forms.TextBox();
            this.lbTienNhap = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.rdbPhieuNhap);
            this.panel1.Controls.Add(this.rdbHoaDon);
            this.panel1.Controls.Add(this.dtpNgayKT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpNgayBD);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1368, 203);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbBangChu2);
            this.panel2.Controls.Add(this.txtTongTienNhap);
            this.panel2.Controls.Add(this.lbTienNhap);
            this.panel2.Controls.Add(this.lbBangChu1);
            this.panel2.Controls.Add(this.txtTongDoanhThu);
            this.panel2.Controls.Add(this.lbDoanhThu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 633);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1368, 115);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "THỐNG KÊ DOANH THU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Từ ngày";
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBD.Location = new System.Drawing.Point(197, 52);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(200, 28);
            this.dtpNgayBD.TabIndex = 4;
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKT.Location = new System.Drawing.Point(197, 122);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(200, 28);
            this.dtpNgayKT.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tới ngày";
            // 
            // rdbHoaDon
            // 
            this.rdbHoaDon.AutoSize = true;
            this.rdbHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHoaDon.Location = new System.Drawing.Point(485, 89);
            this.rdbHoaDon.Name = "rdbHoaDon";
            this.rdbHoaDon.Size = new System.Drawing.Size(105, 28);
            this.rdbHoaDon.TabIndex = 8;
            this.rdbHoaDon.TabStop = true;
            this.rdbHoaDon.Text = "Hóa đơn";
            this.rdbHoaDon.UseVisualStyleBackColor = true;
            // 
            // rdbPhieuNhap
            // 
            this.rdbPhieuNhap.AutoSize = true;
            this.rdbPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPhieuNhap.Location = new System.Drawing.Point(610, 89);
            this.rdbPhieuNhap.Name = "rdbPhieuNhap";
            this.rdbPhieuNhap.Size = new System.Drawing.Size(128, 28);
            this.rdbPhieuNhap.TabIndex = 9;
            this.rdbPhieuNhap.TabStop = true;
            this.rdbPhieuNhap.Text = "Phiếu nhập";
            this.rdbPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(782, 82);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(137, 35);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKe.Location = new System.Drawing.Point(0, 203);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(1368, 430);
            this.dgvThongKe.TabIndex = 2;
            // 
            // lbDoanhThu
            // 
            this.lbDoanhThu.AutoSize = true;
            this.lbDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoanhThu.Location = new System.Drawing.Point(73, 29);
            this.lbDoanhThu.Name = "lbDoanhThu";
            this.lbDoanhThu.Size = new System.Drawing.Size(145, 24);
            this.lbDoanhThu.TabIndex = 0;
            this.lbDoanhThu.Text = "Tổng doanh thu";
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongDoanhThu.Location = new System.Drawing.Point(262, 29);
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.Size = new System.Drawing.Size(151, 27);
            this.txtTongDoanhThu.TabIndex = 1;
            // 
            // lbBangChu1
            // 
            this.lbBangChu1.AutoSize = true;
            this.lbBangChu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBangChu1.Location = new System.Drawing.Point(73, 82);
            this.lbBangChu1.Name = "lbBangChu1";
            this.lbBangChu1.Size = new System.Drawing.Size(0, 24);
            this.lbBangChu1.TabIndex = 2;
            // 
            // lbBangChu2
            // 
            this.lbBangChu2.AutoSize = true;
            this.lbBangChu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBangChu2.Location = new System.Drawing.Point(639, 82);
            this.lbBangChu2.Name = "lbBangChu2";
            this.lbBangChu2.Size = new System.Drawing.Size(91, 24);
            this.lbBangChu2.TabIndex = 5;
            this.lbBangChu2.Text = "Bằng chữ";
            // 
            // txtTongTienNhap
            // 
            this.txtTongTienNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTienNhap.Location = new System.Drawing.Point(828, 29);
            this.txtTongTienNhap.Name = "txtTongTienNhap";
            this.txtTongTienNhap.Size = new System.Drawing.Size(151, 27);
            this.txtTongTienNhap.TabIndex = 4;
            // 
            // lbTienNhap
            // 
            this.lbTienNhap.AutoSize = true;
            this.lbTienNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienNhap.Location = new System.Drawing.Point(639, 29);
            this.lbTienNhap.Name = "lbTienNhap";
            this.lbTienNhap.Size = new System.Drawing.Size(138, 24);
            this.lbTienNhap.TabIndex = 3;
            this.lbTienNhap.Text = "Tổng tiền nhập";
            // 
            // frmThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 748);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmThongKeDoanhThu";
            this.Text = "frmThongKeDoanhThu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.RadioButton rdbPhieuNhap;
        private System.Windows.Forms.RadioButton rdbHoaDon;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Label lbBangChu2;
        private System.Windows.Forms.TextBox txtTongTienNhap;
        private System.Windows.Forms.Label lbTienNhap;
        private System.Windows.Forms.Label lbBangChu1;
        private System.Windows.Forms.TextBox txtTongDoanhThu;
        private System.Windows.Forms.Label lbDoanhThu;
    }
}