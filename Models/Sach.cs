using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYTHUVIENC3.Models
{
    public class Sach
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public int NamXB { get; set; }
        public string NhaXB { get; set; }
        public string TinhTrang { get; set; }
        public Decimal Gia { get; set; }
        public string? HinhAnh { get; set; }
        public string MoTa { get; set; }
    }
}
