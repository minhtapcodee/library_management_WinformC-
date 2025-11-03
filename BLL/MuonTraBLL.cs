// MuonTraBLL.cs
using System.Data;
using QUANLYTHUVIENC3.DAL;

namespace QUANLYTHUVIENC3.BLL
{
    public class MuonTraBLL
    {
        private MuonTraDAL muonTraDAL = new MuonTraDAL();

        public DataTable LayTatCaMuonTra()
        {
            return muonTraDAL.LayTatCaMuonTra();
        }
        public DataTable TimKiemMuonTra(string keyword)
        {
            MuonTraDAL dal = new MuonTraDAL();
            return dal.TimKiemMuonTra(keyword);
        }
        public DataTable LayMuonTraTheoTrangThai(string trangThai)
        {
            return muonTraDAL.LayMuonTraTheoTrangThai(trangThai);
        }
        public bool XoaMuonTra(string maMT)
        {
            return muonTraDAL.XoaMuonTra(maMT);
        }
        public DataTable LayDanhSachTuBang(string tableName, string columns)
        {
            return muonTraDAL.LayDanhSachTuBang(tableName, columns);
        }
        public DataTable LayDocGia()
        {
            return muonTraDAL.LayDocGia();
        }
        public DataTable LayNhanVien()
        {
            return muonTraDAL.LayNhanVien();
        }

        public bool ThemMuonTra(string maSach, string maNguoiMuon, string maNhanVien, DateTime ngayMuon, DateTime ngayTraDuKien)
        {
            return muonTraDAL.ThemMuonTra(maSach, maNguoiMuon, maNhanVien, ngayMuon, ngayTraDuKien);
        }
        public DataTable LayThongTinMuonTra(string maMT)
        {
            return muonTraDAL.LayThongTinMuonTra(maMT);
        }
        public bool CapNhatMuonTra(string maMT, string trangThai, DateTime ngayTraThucTe, decimal tienPhat)
        {
            return muonTraDAL.CapNhatMuonTra(maMT, trangThai, ngayTraThucTe, tienPhat);
        }

        public int KiemTraSoLuongConLai(string maSach)
        {
            return muonTraDAL.KiemTraSoLuongConLai(maSach);
        }
        public DataTable LaySachCon() { return muonTraDAL.LaySachCon(); }
        public DataTable GetMuonTraByMaDocGia(string maDocGia)
        {
            return muonTraDAL.GetMuonTraByMaDocGia(maDocGia);
        }
        public int DemSachDangMuon()
        {
            return muonTraDAL.DemSachDangMuon();
        }

        public Dictionary<string, int> ThongKeSachMuonNhieuNhat()
        {
            return muonTraDAL.ThongKeSoLanMuonCuaSach();
        }

        public Dictionary<string, int> ThongKeSachItMuon()
        {
            return muonTraDAL.ThongKeSachItMuon();
        }

        public DataTable GetSachChuaMuon()
        {
            return muonTraDAL.GetSachChuaMuon();
        }

        public Dictionary<string, double> ThongKeTyLeMuonTheoTheLoai()
        {
            return muonTraDAL.ThongKeTyLeMuonTheoTheLoai();
        }

        public DataTable LayDanhSachNguoiMuonTheoNgay(DateTime ngay)
        {
            return muonTraDAL.LayDanhSachNguoiMuonTheoNgay(ngay);
        }

        public int DemSoNguoiMuonTheoNgay(DateTime ngay)
        {
            return muonTraDAL.DemSoNguoiMuonTheoNgay(ngay);
        }

        public int DemTongSoLanMuon()
        {
            return muonTraDAL.DemTongSoLanMuon();
        }
        public Dictionary<string, int> ThongKeTrangThai() => muonTraDAL.ThongKeTrangThai();
        public DataTable LayDanhSachSachMuonTheoNgay(DateTime ngay)
        {
            return muonTraDAL.LayDanhSachSachMuonTheoNgay(ngay);
        }
        public DataTable TimKiemVaLocSachMuonTheoNgay(string keyword, DateTime? ngay)
        {
            return muonTraDAL.TimKiemVaLocSachMuonTheoNgay(keyword, ngay);
        }
    }
}
