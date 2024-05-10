using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace NganHang_PhanTan.Component
{
    public class NhanVien
    {
        public readonly static string MANV_HEADER = "MANV";
        public readonly static string HO_HEADER = "HO";
        public readonly static string TEN_HEADER = "TEN";
        public readonly static string CMND_HEADER = "CMND";
        public readonly static string DIACHI_HEADER = "DIACHI";
        public readonly static string PHAI_HEADER = "PHAI";
        public readonly static string SODT_HEADER = "SODT";
        public readonly static string DELETE_HEADER = "TrangThaiXoa";

        private string MANV;
        private string HO;
        private string TEN;
        private string CMND;
        private string DIACHI;
        private string PHAI;
        private string SODT;
        private bool trangthaixoa;

        public NhanVien() { }
        public NhanVien(string MANV, string HO, string TEN, string CMND, string DIACHI, string PHAI, string SODT)
        {
            this.MANV = MANV;
            this.HO = HO;
            this.TEN = TEN;
            this.CMND = CMND;
            this.DIACHI = DIACHI;
            this.PHAI = PHAI;
            this.SODT = SODT;
            this.trangthaixoa = false;
        }
        public NhanVien(string MANV, string HO, string TEN, string CMND, string DIACHI, string PHAI, string SODT, bool trangthaixoa)
        {
            this.MANV = MANV;
            this.HO = HO;
            this.TEN = TEN;
            this.CMND = CMND;
            this.DIACHI = DIACHI;
            this.PHAI = PHAI;
            this.SODT = SODT;
            this.trangthaixoa = trangthaixoa;
        }

        public NhanVien(DataRowView row)
        {
            MANV = (string)row[MANV_HEADER];
            HO = (string)row[HO_HEADER];
            TEN = (string)row[TEN_HEADER];
            CMND = (string)row[CMND_HEADER];
            DIACHI = (string)row[DIACHI_HEADER];
            PHAI = (string)row[PHAI_HEADER];
            SODT = (string)row[SODT_HEADER];
            trangthaixoa = Convert.ToBoolean(row[DELETE_HEADER]);
        }

        public string MaNV { get => MANV; set => MANV = value; }
        public string Ho { get => HO; set => HO = value; }
        public string Ten { get => TEN; set => TEN = value; }
        public string Cmnd { get => CMND; set => CMND = value; }
        public string DiaChi { get => DIACHI; set => DIACHI = value; }
        public string Phai { get => PHAI; set => PHAI = value; }
        public string SoDT { get => SODT; set => SODT = value; }
        public bool TrangThaiXoa { get => trangthaixoa; set => trangthaixoa = value; }


        public bool isMaNVValid(string MaNV)
        {
            // Biểu thức chính quy để kiểm tra định dạng mã nhân viên
            string pattern = @"^NV\d{4}$"; // Bắt đầu bằng "NV" và theo sau bởi 4 chữ số

            // Kiểm tra xem MaNV khớp với pattern hay không
            return Regex.IsMatch(MaNV, pattern);
        }

        public bool isNVNull()
        {
            return string.IsNullOrEmpty(MANV) && string.IsNullOrEmpty(HO) && string.IsNullOrEmpty(TEN) && string.IsNullOrEmpty(CMND) &&
                string.IsNullOrEmpty(DIACHI) && string.IsNullOrEmpty(PHAI) && string.IsNullOrEmpty(SODT);
        }

        public bool isHaveInfo()
        {
            return string.IsNullOrEmpty(MANV) || string.IsNullOrEmpty(HO) || string.IsNullOrEmpty(TEN) || string.IsNullOrEmpty(CMND) ||
                string.IsNullOrEmpty(DIACHI) || string.IsNullOrEmpty(PHAI) || string.IsNullOrEmpty(SODT);
        }

        //Nếu tất cả  các trường đều phải khác null và mã nv phải thỏa isMaNVValid
        public bool isNVValid()
        {
            return !isHaveInfo() && isMaNVValid(MANV);
        }
    }
}
