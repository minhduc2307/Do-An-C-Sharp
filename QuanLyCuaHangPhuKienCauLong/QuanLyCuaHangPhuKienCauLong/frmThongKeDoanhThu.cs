using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCuaHangPhuKienCauLong
{
    public partial class frmThongKeDoanhThu : Form
    {
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();

        static string [] mNumText = "không;một;hai;ba;bốn;năm;sáu;bảy;tám;chín".Split(';');
        //Viết hàm chuyển số hàng chục, giá trị truyền vào là số cần chuyển và một biến đọc phần lẻ hay không ví dụ 101 => một trăm lẻ một
        private static string DocHangChuc(double so,bool daydu)
        {
            string chuoi = "";
            //Hàm để lấy số hàng chục ví dụ 21/10 = 2
            Int64 chuc = Convert.ToInt64(Math.Floor((double)(so / 10)));
            //Lấy số hàng đơn vị bằng phép chia 21 % 10 = 1
            Int64 donvi = (Int64)so%10;
            //Nếu số hàng chục tồn tại tức >=20
            if (chuc>1) {
                chuoi = " " + mNumText[chuc] + " mươi";
                if (donvi==1) {
                    chuoi += " mốt";
                }
            } else if (chuc==1) {//Số hàng chục từ 10-19
                chuoi = " mười";
                if (donvi==1) {
                    chuoi += " một";
                }
            } else if (daydu && donvi>0) {//Nếu hàng đơn vị khác 0 và có các số hàng trăm ví dụ 101 => thì biến daydu = true => và sẽ đọc một trăm lẻ một
                    chuoi = " lẻ";
            }
            if (donvi==5 && chuc>=1) {//Nếu đơn vị là số 5 và có hàng chục thì chuỗi sẽ là " lăm" chứ không phải là " năm"
                chuoi += " lăm";
            } else if (donvi>1||(donvi==1&&chuc==0)) {
                chuoi += " " + mNumText[ donvi ];
            }
            return chuoi;
        }

        private static string DocHangTram(double so,bool daydu)
        {
            string chuoi = "";
            //Lấy số hàng trăm ví du 434 / 100 = 4 (hàm Floor sẽ làm tròn số nguyên bé nhất)
            Int64 tram = Convert.ToInt64(Math.Floor((double)so/100));
            //Lấy phần còn lại của hàng trăm 434 % 100 = 34 (dư 34)
            so = so%100;
            if (daydu || tram>0) {
                chuoi = " " + mNumText[tram] + " trăm";
                chuoi += DocHangChuc(so,true);
            } else {
                chuoi = DocHangChuc(so,false);
            }
            return chuoi;
        }

        private static string DocHangTrieu(double so,bool daydu)
        {
            string chuoi = "";
            //Lấy số hàng triệu
            Int64 trieu = Convert.ToInt64(Math.Floor((double)so/1000000));
            //Lấy phần dư sau số hàng triệu ví dụ 2,123,000 => so = 123,000
            so = so%1000000;
            if (trieu>0) {
                chuoi = DocHangTram(trieu,daydu) + " triệu";
                daydu = true;
            }
            //Lấy số hàng nghìn
            Int64 nghin = Convert.ToInt64(Math.Floor((double)so / 1000));
            //Lấy phần dư sau số hàng nghin 
            so = so%1000;
            if (nghin>0) {
                chuoi += DocHangTram(nghin,daydu) + " nghìn";
                daydu = true;
            }
            if (so>0) {
                chuoi += DocHangTram(so,daydu);
            }
            return chuoi;
        }

        public static string ChuyenSoSangChuoi(double so)
        {
            if (so == 0)
                return mNumText[0];
            string chuoi = "", hauto = "";
            Int64 ty;
            do
            {
                //Lấy số hàng tỷ
                ty = Convert.ToInt64(Math.Floor((double)so / 1000000000));
                //Lấy phần dư sau số hàng tỷ
                so = so % 1000000000;
                if (ty > 0)
                {
                    chuoi = DocHangTrieu(so, true) + hauto + chuoi;
                }
                else
                {
                    chuoi = DocHangTrieu(so, false) + hauto + chuoi;
                }
                hauto = " tỷ";
            } while (ty > 0);
            return chuoi + " đồng";
        }  

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (rdbHoaDon.Checked)
            {
                //btnLamMoi.PerformClick();
                string query = string.Format("select MaHD, NgayBan, TongTien from HoaDon where TongTien > 0 and NgayBan between '{0}' and '{1} '", dtpNgayBD.Value.ToString("yyyy-MM-dd"), dtpNgayKT.Value.ToString("yyyy-MM-dd"));
                DataSet ds = kn.LayDuLieu(query);
                dgvThongKe.DataSource = ds.Tables[0];
                dgvThongKe.Columns[0].HeaderText = "Mã hóa đơn";
                dgvThongKe.Columns[1].HeaderText = "Ngày bán";
                dgvThongKe.Columns[2].HeaderText = "Tổng tiền";

                dgvThongKe.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvThongKe.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvThongKe.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                

                string query2 = string.Format("SELECT SUM(TongTien) FROM HoaDon WHERE NgayBan BETWEEN '{0}' AND '{1}'", dtpNgayBD.Value.ToString("yyyy-MM-dd"), dtpNgayKT.Value.ToString("yyyy-MM-dd"));
                DataSet ds2 = kn.LayDuLieu(query2);
                object tongTienObj = ds2.Tables[0].Rows[0][0];
                string tongTienStr = tongTienObj.ToString();
                double tongTien;
                if (double.TryParse(tongTienStr, out tongTien))
                {
                    txtTong.Text = tongTienStr;
                    lbBangChu1.Text = "Bằng chữ: " + ChuyenSoSangChuoi(tongTien);
                    lbBangChu1.ForeColor = Color.DodgerBlue;
                }
                else
                {
                    txtTong.Text = "";
                    lbBangChu1.Text = "";
                }
            }

            else if (rdbPhieuNhap.Checked)
            {
                //btnLamMoi.PerformClick();
                string query = string.Format("select PHieuNhap.MaPN, NgayNhap, TongTien from PhieuNhap inner join ChiTietPN on PhieuNhap.MaPN = ChiTietPN.MaPN where NgayNhap BETWEEN '{0}' AND '{1}' group by PhieuNhap.MaPN, NgayNhap, TongTien", dtpNgayBD.Value.ToString("yyyy-MM-dd"), dtpNgayKT.Value.ToString("yyyy-MM-dd"));
                DataSet ds = kn.LayDuLieu(query);
                dgvThongKe.DataSource = ds.Tables[0];
                dgvThongKe.Columns[0].HeaderText = "Mã phiếu nhập";
                dgvThongKe.Columns[1].HeaderText = "Ngày nhập";
                dgvThongKe.Columns[2].HeaderText = "Tổng tiền";

                dgvThongKe.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvThongKe.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvThongKe.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                string query2 = string.Format("select  sum (distinct (TongTien)) FROM PhieuNhap inner join ChiTietPN on PhieuNhap.MaPN = ChiTietPN.MaPN where NgayNhap BETWEEN '{0}' AND '{1}'", dtpNgayBD.Value.ToString("yyyy-MM-dd"), dtpNgayKT.Value.ToString("yyyy-MM-dd"));
                DataSet ds2 = kn.LayDuLieu(query2);
                object tongTienObj = ds2.Tables[0].Rows[0][0];
                string tongTienStr = tongTienObj.ToString();
                double tongTien;
                if (double.TryParse(tongTienStr, out tongTien))
                {
                    txtTong.Text = tongTienStr;
                    lbBangChu1.Text = "Bằng chữ: " + ChuyenSoSangChuoi(tongTien);
                }
                else
                {
                    txtTong.Text = "";
                    lbBangChu1.Text = "";
                }
            }

            else if (rdbHoaDon.Checked == false && rdbPhieuNhap.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn thống kê theo hóa đơn hoặc phiếu nhập!!!");
            }
        }

        public void LamMoi()
        {
            dgvThongKe.DataSource = null;
            rdbHoaDon.Checked = false;
            rdbPhieuNhap.Checked = false;
            txtTong.Text = "";
            lbBangChu1.Text = "";

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
