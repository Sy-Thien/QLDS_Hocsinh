using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDS_Hocsinh
{
    class ChuongTrinh
    {
        static void Main(string[] args)
        {
           
            List<HocSinh> danhSachHocSinh = new List<HocSinh>
            {
                new HocSinh { MaSo = 1, Ten = "An", Tuoi = 16 },
                new HocSinh { MaSo = 2, Ten = "Bảo", Tuoi = 15 },
                new HocSinh { MaSo = 3, Ten = "Cường", Tuoi = 19 },
                new HocSinh { MaSo = 4, Ten = "Đức", Tuoi = 17 },
                new HocSinh { MaSo = 5, Ten = "Anh", Tuoi = 18 }
            };

            // a. In toàn bộ danh sách học sinh
            Console.WriteLine("Danh sách học sinh:");
            foreach (var hs in danhSachHocSinh)
            {
                Console.WriteLine($"Mã số: {hs.MaSo}, Tên: {hs.Ten}, Tuổi: {hs.Tuoi}");
            }

            // b. Tìm và in học sinh có tuổi từ 15 đến 18
            var hocSinhTu15Den18 = danhSachHocSinh.Where(hs => hs.Tuoi >= 15 && hs.Tuoi <= 18).ToList();
            Console.WriteLine("\nHọc sinh có tuổi từ 15 đến 18:");
            foreach (var hs in hocSinhTu15Den18)
            {
                Console.WriteLine($"Mã số: {hs.MaSo}, Tên: {hs.Ten}, Tuổi: {hs.Tuoi}");
            }

            // c. Tìm và in học sinh có tên bắt đầu bằng chữ "A"
            var hocSinhTenBatDauA = danhSachHocSinh.Where(hs => hs.Ten.StartsWith("A")).ToList();
            Console.WriteLine("\nHọc sinh có tên bắt đầu bằng chữ 'A':");
            foreach (var hs in hocSinhTenBatDauA)
            {
                Console.WriteLine($"Mã số: {hs.MaSo}, Tên: {hs.Ten}, Tuổi: {hs.Tuoi}");
            }

            // d. Tính tổng tuổi của tất cả học sinh
            int tongTuoi = danhSachHocSinh.Sum(hs => hs.Tuoi);
            Console.WriteLine($"\nTổng tuổi của tất cả học sinh: {tongTuoi}");

            // e. Tìm học sinh có tuổi lớn nhất
            var hocSinhLonTuoiNhat = danhSachHocSinh.OrderByDescending(hs => hs.Tuoi).First();
            Console.WriteLine($"\nHọc sinh lớn tuổi nhất: Mã số: {hocSinhLonTuoiNhat.MaSo}, Tên: {hocSinhLonTuoiNhat.Ten}, Tuổi: {hocSinhLonTuoiNhat.Tuoi}");


            // f. Sắp xếp danh sách học sinh theo tuổi tăng dần
            var hocSinhSapXepTheoTuoi = danhSachHocSinh.OrderBy(hs => hs.Tuoi).ToList();
            Console.WriteLine("\nDanh sách học sinh sắp xếp theo tuổi tăng dần:");
            foreach (var hs in hocSinhSapXepTheoTuoi)
            {
                Console.WriteLine($"Mã số: {hs.MaSo}, Tên: {hs.Ten}, Tuổi: {hs.Tuoi}");
            }
        }
    }
}
