using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02_DanhSach
{
    internal class Program
    {
        class Node
        {
            public int data;
            public Node next;
            public Node(int val)
            {
                data = val;
                next = null;
            }
        }
        static Node pHead = null;
        static Node l = null;
        struct NhanVien
        {
            public string MaNV;
            public string Hoten;
            public int Namsinh;
            public string Phongban;
            public int LuongCB;
            public int Thuong;
            public int Thuclinh;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Bài 1 ===");
            Bai1();
            Console.WriteLine("=== Bài 2 ===");
            Bai2();
            Console.WriteLine("=== Bài 3 ===");
            Bai3();
            Console.WriteLine("=== Bài 4 ===");
            Bai4();
            Console.WriteLine("=== Bài 5 ===");
            Bai5();
            Console.WriteLine("=== Bài 7 ===");
            Bai7();
            Console.WriteLine("=== Bài 8 ===");
            Bai8();
            Console.WriteLine("=== Bài 9 ===");
            Bai9();
            Console.WriteLine("=== Bài 10 ===");
            Bai10();
            Console.WriteLine("=== Bài 11 ===");
            Bai11();
            Console.WriteLine("=== Bài 12 ===");
            Bai12();
            Console.WriteLine("=== Bài 13 ===");
            Bai13();
            Console.WriteLine("=== Bài 14 ===");
            Bai14();
            Console.WriteLine("=== Bài 15 ===");
            Bai15();
            Console.WriteLine("=== Bài 16 ===");
            Bai16();
            Console.WriteLine("=== Bài 17 ===");
            Bai17();
            Console.WriteLine("=== Bài 18 ===");
            Bai18();
            Console.ReadKey();
        }
        static void Bai1()
        {
            int[] a = NhapMang();
            Console.Write("\n Danh sách vừa nhập: ");
            HienThiMang(a);
            Console.Write("\n Nhập giá trị x cần chèn: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write($"Nhập vị trí k cần chèn (từ 0 đến {a.Length}): ");
            int k = int.Parse(Console.ReadLine());
            ChenPhanTu(ref a, x, k);
            Console.Write("Danh sách sau khi chèn: ");
            HienThiMang(a);
        }
        static int[] NhapMang()
        {
            int n;
            do
            {
                Console.Write("Nhập số lượng phần tử n : ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.Write($"  Nhập phần tử nguyên dương a[{i}]: ");
                    a[i] = int.Parse(Console.ReadLine());
                } while (a[i] <= 0);
            }
            return a;
        }
        static void HienThiMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
        static void ChenPhanTu(ref int[] a, int x, int k)
        {
            if (k < 0 || k > a.Length)
            {
                Console.WriteLine("Vị trí k không hợp lệ");
                return;
            }
            int[] tmp = new int[a.Length + 1];
            for (int i = 0; i < k; i++)
            {
                tmp[i] = a[i];
            }
            tmp[k] = x;
            for (int i = k; i < a.Length; i++)
            {
                tmp[i + 1] = a[i];
            }
            a = tmp;
        }
        static void Bai2()
        {
            NhanVien[] ds = NhapDanhSachNhanVien();
            Console.WriteLine("\n Tổng thực lĩnh tháng của tất cả nhân viên");
            long tongThucLinh = 0;
            for (int i = 0; i < ds.Length; i++)
            {
                tongThucLinh += TinhThucLinh(i, ds);
            }
            Console.WriteLine($" Tổng thực lĩnh tháng của toàn công ty: {tongThucLinh}");
            Console.WriteLine("\n Danh sách nhân viên có mức lương cơ bản thấp nhất");
            InNhanVienLuongThapNhat(ds);
            Console.WriteLine("\n Số lượng nhân viên có mức thưởng >= 1.200.000");
            int demThuong = 0;
            for (int i = 0; i < ds.Length; i++)
            {
                if (ds[i].Thuong >= 1200000)
                {
                    demThuong++;
                }
            }
            Console.WriteLine($" Số lượng nhân viên đạt điều kiện: {demThuong}");
            Console.WriteLine("\n Danh sách sắp xếp ");
            SapXepNhanVien(ds);
            HienThiDanhSachNhanVien(ds);
            Console.WriteLine("\n Danh sách nhân viên sau khi tăng lương cơ bản lên 5%");
            TangLuong(ds);
            HienThiDanhSachNhanVien(ds);
        }

        static NhanVien[] NhapDanhSachNhanVien()
        {
            int n;
            do
            {
                Console.Write("Nhập số lượng nhân viên n: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            NhanVien[] ds = new NhanVien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin nhân viên thứ {i + 1}:");
                Console.Write("  - Mã nhân viên: ");
                ds[i].MaNV = Console.ReadLine();
                Console.Write("  - Họ và tên: ");
                ds[i].Hoten = Console.ReadLine();
                Console.Write("  - Năm sinh: ");
                ds[i].Namsinh = int.Parse(Console.ReadLine());
                Console.Write("  - Phòng ban: ");
                ds[i].Phongban = Console.ReadLine();
                Console.Write("  - Lương cơ bản: ");
                ds[i].LuongCB = int.Parse(Console.ReadLine());
                Console.Write("  - Thưởng: ");
                ds[i].Thuong = int.Parse(Console.ReadLine());
                ds[i].Thuclinh = ds[i].LuongCB + ds[i].Thuong;
            }
            return ds;
        }

        static int TinhThucLinh(int x, NhanVien[] ds)
        {
            ds[x].Thuclinh = ds[x].LuongCB + ds[x].Thuong;
            return ds[x].Thuclinh;
        }

        static void InNhanVienLuongThapNhat(NhanVien[] ds)
        {
            int min = int.MaxValue;
            for (int i = 0; i < ds.Length; i++)
            {
                if (ds[i].LuongCB < min)
                {
                    min = ds[i].LuongCB;
                }
            }
            Console.WriteLine($"Các nhân viên có lương cơ bản thấp nhất ({min}):");
            for (int i = 0; i < ds.Length; i++)
            {
                if (ds[i].LuongCB == min)
                {
                    InMotNhanVien(ds[i]);
                }
            }
        }

        static void SapXepNhanVien(NhanVien[] ds)
        {
            for (int i = 0; i < ds.Length - 1; i++)
            {
                for (int j = i + 1; j < ds.Length; j++)
                {
                    int kqSoSanhPhong = string.Compare(ds[i].Phongban, ds[j].Phongban, StringComparison.Ordinal);
                    if (kqSoSanhPhong > 0 || (kqSoSanhPhong == 0 && string.Compare(ds[i].MaNV, ds[j].MaNV, StringComparison.Ordinal) < 0))
                    {
                        NhanVien temp = ds[i];
                        ds[i] = ds[j];
                        ds[j] = temp;
                    }
                }
            }
        }

        static void TangLuong(NhanVien[] ds)
        {
            for (int i = 0; i < ds.Length; i++)
            {
                ds[i].LuongCB = (int)(ds[i].LuongCB * 1.05);
                ds[i].Thuclinh = ds[i].LuongCB + ds[i].Thuong;
            }
        }

        static void InMotNhanVien(NhanVien nv)
        {
            Console.WriteLine($"  [Mã NV: {nv.MaNV} | Họ tên: {nv.Hoten} | Năm sinh: {nv.Namsinh} | Phòng ban: {nv.Phongban} | Lương CB: {nv.LuongCB} | Thưởng: {nv.Thuong} | Thực lĩnh: {nv.Thuclinh}]");
        }

        static void HienThiDanhSachNhanVien(NhanVien[] ds)
        {
            for (int i = 0; i < ds.Length; i++)
            {
                InMotNhanVien(ds[i]);
            }
        }
        static void Bai3()
        {
            int[,] a = NhapMaTran();
            Console.WriteLine("\n Ma trận vừa nhập:");
            HienThiMaTrận(a);
            int tong = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    tong += a[i, j];
                }
            }
            Console.WriteLine($"\n Tổng tất cả các phần tử của ma trận: {tong} ");
            int minDuong = int.MaxValue;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > 0 && a[i, j] < minDuong)
                    {
                        minDuong = a[i, j];
                    }
                }
            }
            if (minDuong == int.MaxValue)
                Console.WriteLine("\n Không có phần tử dương nào trong ma trận ");
            else
                Console.WriteLine($"\n Giá trị dương nhỏ nhất của ma trận: {minDuong} ");
            int tongCheoPhu = 0;
            int n = a.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                tongCheoPhu += a[i, n - 1 - i];
            }
            Console.WriteLine($"\n Tổng các phần tử nằm trên đường chéo phụ: {tongCheoPhu} ");
            bool tangDan = true;
            for (int i = 0; i < n - 1; i++)
            {
                if (a[i, i] >= a[i + 1, i + 1])
                {
                    tangDan = false;
                    break;
                }
            }
            Console.WriteLine($"\n Kiểm tra đường chéo chính có tăng dần không ");
            if (tangDan)
                Console.WriteLine(" Các phần tử trên đường chéo chính có tăng dần.");
            else
                Console.WriteLine(" Các phần tử trên đường chéo chính không tăng dần.");
        }

        static int[,] NhapMaTran()
        {
            int n;
            do
            {
                Console.Write("Nhập cấp n của ma trận vuông (0 < n < 100): ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0 || n >= 100);
            int[,] a = new int[n, n];
            Console.WriteLine("Nhập các phần tử của ma trận:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"  a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return a;
        }

        static void HienThiMaTrận(int[,] a)
        {
            int n = a.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{a[i, j],5} ");
                }
                Console.WriteLine();
            }
        }
        static void Bai4()
        {
            TaoDanhSachLienKet();
            Console.WriteLine("\nDanh sách liên kết đơn hiện tại:");
            HienThiDanhSachLienKet();
            Console.Write("\n Nhập giá trị x cần đếm: ");
            int xDem = int.Parse(Console.ReadLine());
            int dem = 0;
            Node p = pHead;
            while (p != null)
            {
                if (p.data == xDem)
                {
                    dem++;
                }
                p = p.next;
            }
            Console.WriteLine($"Số lượng phần tử bằng {xDem} trong danh sách là: {dem}");
            int minDuong = int.MaxValue;
            p = pHead;
            while (p != null)
            {
                if (p.data > 0 && p.data < minDuong)
                {
                    minDuong = p.data;
                }
                p = p.next;
            }
            Console.WriteLine("\n Tìm phần tử dương nhỏ nhất trong danh sách ");
            if (minDuong == int.MaxValue)
                Console.WriteLine(" Không có phần tử dương nào trong danh sách.");
            else
                Console.WriteLine($" Phần tử dương nhỏ nhất là: {minDuong}");
            Console.Write("\n Nhập giá trị x cần xóa (xuất hiện đầu tiên): ");
            int xXoa = int.Parse(Console.ReadLine());
            XoaPhanTuDauTien(xXoa);
            Console.WriteLine("Danh sách sau khi xóa:");
            HienThiDanhSachLienKet();
        }
        static void ThemCuoi(int val)
        {
            Node newNode = new Node(val);
            if (pHead == null)
            {
                pHead = newNode;
            }
            else
            {
                Node p = pHead;
                while (p.next != null)
                {
                    p = p.next;
                }
                p.next = newNode;
            }
        }

        static void TaoDanhSachLienKet()
        {
            pHead = null;
            int n;
            do
            {
                Console.Write("Nhập số lượng phần tử của danh sách liên kết n (n > 0): ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            for (int i = 0; i < n; i++)
            {
                Console.Write($"  Nhập phần tử thứ {i + 1} : ");
                int val = int.Parse(Console.ReadLine());
                ThemCuoi(val);
            }
        }

        static void HienThiDanhSachLienKet()
        {
            if (pHead == null)
            {
                Console.WriteLine("Danh sách rỗng");
                return;
            }
            Node p = pHead;
            while (p != null)
            {
                Console.Write(p.data + "  ");
                p = p.next;
            }
            Console.WriteLine("null");
        }

        static void XoaPhanTuDauTien(int x)
        {
            if (pHead == null)
            {
                Console.WriteLine("Danh sách rỗng, không thể xóa");
                return;
            }
            if (pHead.data == x)
            {
                pHead = pHead.next;
                Console.WriteLine($"Đã xóa phần tử {x} ở đầu danh sách.");
                return;
            }
            Node t = null;
            Node p = pHead;
            while (p != null && p.data != x)
            {
                t = p;
                p = p.next;
            }
            if (p == null)
            {
                Console.WriteLine($"Không tìm thấy phần tử có giá trị {x} trong danh sách.");
            }
            else
            {
                t.next = p.next;
                Console.WriteLine($"Đã xóa phần tử {x} xuất hiện đầu tiên.");
            }
        }
        static void Bai5()
        {
            TaoDanhSachL();
            Console.WriteLine("\n Danh sách liên kết l hiện tại:");
            HienThiDanhSachL();
            int maxVal = int.MinValue;
            Node p = l;
            while (p != null)
            {
                if (p.data > maxVal)
                {
                    maxVal = p.data;
                }
                p = p.next;
            }
            Console.WriteLine($"\n Phần tử lớn nhất trong danh sách l là: {maxVal} ");
            int tongL = 0;
            p = l;
            while (p != null)
            {
                tongL += p.data;
                p = p.next;
            }
            Console.WriteLine($"\n Tổng các phần tử của danh sách l là: {tongL}");
            int demSNT = 0;
            p = l;
            while (p != null)
            {
                if (KTNT(p.data))
                {
                    demSNT++;
                }
                p = p.next;
            }
            Console.WriteLine($"\n Số lượng số nguyên tố trong danh sách l là: {demSNT}");
            int demAm = 0, demKhong = 0, demDuong = 0;
            p = l;
            while (p != null)
            {
                if (p.data < 0) demAm++;
                else if (p.data == 0) demKhong++;
                else demDuong++;
                p = p.next;
            }
            Console.WriteLine($"\n Thống kê số âm, bằng 0, số dương ");
            Console.WriteLine($" Số lượng số âm: {demAm}");
            Console.WriteLine($" Số lượng số bằng 0: {demKhong}");
            Console.WriteLine($" Số lượng số dương: {demDuong}");
            Console.Write("\n Nhập giá trị x cần đếm trong danh sách l: ");
            int xDem = int.Parse(Console.ReadLine());
            int demX = 0;
            p = l;
            while (p != null)
            {
                if (p.data == xDem)
                {
                    demX++;
                }
                p = p.next;
            }
            Console.WriteLine($" Số lượng phần tử bằng {xDem} là: {demX}");
            int minDuongL = int.MaxValue;
            p = l;
            while (p != null)
            {
                if (p.data > 0 && p.data < minDuongL)
                {
                    minDuongL = p.data;
                }
                p = p.next;
            }
            Console.WriteLine("\n Tìm phần tử dương nhỏ nhất trong danh sách l");
            if (minDuongL == int.MaxValue)
                Console.WriteLine("Không có phần tử dương nào trong danh sách.");
            else
                Console.WriteLine($"Phần tử dương nhỏ nhất là: {minDuongL}");
        }
        static bool KTNT(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i * i <= x; i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }

        static void ThemCuoiL(int val)
        {
            Node newNode = new Node(val);
            if (l == null)
            {
                l = newNode;
            }
            else
            {
                Node p = l;
                while (p.next != null)
                {
                    p = p.next;
                }
                p.next = newNode;
            }
        }

        static void TaoDanhSachL()
        {
            l = null;
            int n;
            do
            {
                Console.Write("Nhập số lượng phần tử cho danh sách l (n > 0): ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            for (int i = 0; i < n; i++)
            {
                Console.Write($"  Nhập phần tử thứ {i + 1}: ");
                int val = int.Parse(Console.ReadLine());
                ThemCuoiL(val);
            }
        }

        static void HienThiDanhSachL()
        {
            if (l == null)
            {
                Console.WriteLine("Danh sách rỗng");
                return;
            }
            Node p = l;
            while (p != null)
            {
                Console.Write(p.data + "  ");
                p = p.next;
            }
            Console.WriteLine("null");
        }
        static void Bai7()
        {
            int n;
            do
            {
                Console.Write("Nhập số ngày n (n > 0): ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            double[] nhietDo = new double[n];
            double tongNhietDo = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"  Nhập nhiệt độ ngày thứ {i + 1}: ");
                nhietDo[i] = double.Parse(Console.ReadLine());
                tongNhietDo += nhietDo[i];
            }
            Console.Write("\nDanh sách nhiệt độ các ngày: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{nhietDo[i]} ");
            }
            Console.WriteLine();
            double maxNhietDo = nhietDo[0];
            double minNhietDo = nhietDo[0];
            int ngayMax = 1;
            int ngayMin = 1;
            for (int i = 1; i < n; i++)
            {
                if (nhietDo[i] > maxNhietDo)
                {
                    maxNhietDo = nhietDo[i];
                    ngayMax = i + 1;
                }
                if (nhietDo[i] < minNhietDo)
                {
                    minNhietDo = nhietDo[i];
                    ngayMin = i + 1;
                }
            }
            double trungBinh = tongNhietDo / n;
            Console.WriteLine($"\n Kết quả Quản lý nhiệt độ ");
            Console.WriteLine($" Ngày có nhiệt độ cao nhất là Ngày {ngayMax} với {maxNhietDo}°C");
            Console.WriteLine($" Ngày có nhiệt độ thấp nhất là Ngày {ngayMin} với {minNhietDo}°C");
            Console.WriteLine($" Nhiệt độ trung bình tuần (của {n} ngày): {trungBinh:F2}°C");
        }
        static void Bai8()
        {
            Console.Write("Nhập một chuỗi văn bản: ");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Chuỗi rỗng, không có từ nào để thống kê");
                return;
            }
            string chuanHoa = "";
            foreach (char c in input.ToLower())
            {
                if (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c))
                {
                    chuanHoa += c;
                }
                else
                {
                    chuanHoa += ' '; 
                }
            }
            string[] cacTu = chuanHoa.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> tanSuat = new Dictionary<string, int>();
            foreach (string tu in cacTu)
            {
                if (tanSuat.ContainsKey(tu))
                {
                    tanSuat[tu]++;
                }
                else
                {
                    tanSuat[tu] = 1;
                }
            }
            var ketQuaSapXep = tanSuat.OrderByDescending(item => item.Value)
                                       .ThenBy(item => item.Key);
            Console.WriteLine("\n Kết quả thống kê tần suất từ ");
            foreach (var item in ketQuaSapXep)
            {
                Console.WriteLine($"  Từ \"{item.Key}\": xuất hiện {item.Value} lần");
            }
        }
        static void Bai9()
        {
            int n;
            do
            {
                Console.Write("Nhập số lượng phần tử n (n > 0): ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"  Nhập phần tử thứ {i + 1}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nDãy số vừa nhập: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            List<int> dsSoNguyenTo = new List<int>();
            List<int> dsSoChan = new List<int>();
            List<int> dsSoHoanHao = new List<int>();
            foreach (int x in a)
            {
                if (KTNT(x))
                {
                    dsSoNguyenTo.Add(x);
                }
                if (x % 2 == 0)
                {
                    dsSoChan.Add(x);
                }
                if (KiemTraSoHoanHao(x))
                {
                    dsSoHoanHao.Add(x);
                }
            }
            Console.WriteLine("\n Kết quả phân loại và thống kê ");
            Console.Write($" Các số nguyên tố ({dsSoNguyenTo.Count} số): ");
            Console.WriteLine(dsSoNguyenTo.Count > 0 ? string.Join(" ", dsSoNguyenTo) : "Không có");
            Console.Write($" Các số chẵn ({dsSoChan.Count} số): ");
            Console.WriteLine(dsSoChan.Count > 0 ? string.Join(" ", dsSoChan) : "Không có");
            Console.Write($" Các số hoàn hảo ({dsSoHoanHao.Count} số): ");
            Console.WriteLine(dsSoHoanHao.Count > 0 ? string.Join(" ", dsSoHoanHao) : "Không có");
        }

        static bool KiemTraSoHoanHao(int x)
        {
            if (x <= 1) return false;
            int tongUoc = 0;
            for (int i = 1; i <= x / 2; i++)
            {
                if (x % i == 0)
                {
                    tongUoc += i;
                }
            }
            return tongUoc == x;
        }
        static void Bai10()
        {
            int m, n;
            do
            {
                Console.Write("Nhập số dòng m (m > 0): ");
                m = int.Parse(Console.ReadLine());
            } while (m <= 0);
            do
            {
                Console.Write("Nhập số cột n (n > 0): ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            int[,] matrix = new int[m, n];
            Console.WriteLine("Nhập các phần tử của ma trận:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"  matrix[{i},{j}] = ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\nMa trận vừa nhập:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j],5} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n Kết quả duyệt ma trận theo thứ tự xoắn ốc ");
            InMaTranXoanOc(matrix, m, n);
        }

        static void InMaTranXoanOc(int[,] matrix, int m, int n)
        {
            int top = 0;
            int bottom = m - 1;
            int left = 0;
            int right = n - 1;

            while (top <= bottom && left <= right)
            {
                for (int j = left; j <= right; j++)
                {
                    Console.Write(matrix[top, j] + " ");
                }
                top++; 
                for (int i = top; i <= bottom; i++)
                {
                    Console.Write(matrix[i, right] + " ");
                }
                right--;
                if (top <= bottom)
                {
                    for (int j = right; j >= left; j--)
                    {
                        Console.Write(matrix[bottom, j] + " ");
                    }
                    bottom--; 
                }
                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        Console.Write(matrix[i, left] + " ");
                    }
                    left++;
                }
            }
            Console.WriteLine();
        }
        static void Bai11()
        {
            int n;
            do
            {
                Console.Write("Nhập cấp n của ma trận vuông (n > 0): ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            int[,] matrix = new int[n, n];
            Console.WriteLine("Nhập các phần tử của ma trận:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"  matrix[{i},{j}] = ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\n Ma trận vừa nhập:");
            HienThiMaTrận(matrix);
            Console.WriteLine("\n Kiểm tra ma trận đơn vị ");
            if (KiemTraMaTranDonVi(matrix, n))
                Console.WriteLine(" Đây là ma trận đơn vị.");
            else
                Console.WriteLine(" Đây không phải là ma trận đơn vị.");
            Console.WriteLine("\n Kiểm tra ma trận đối xứng ");
            if (KiemTraMaTranDoiXung(matrix, n))
                Console.WriteLine(" Đây là ma trận đối xứng.");
            else
                Console.WriteLine(" Đây không phải là ma trận đối xứng.");
        }

        static bool KiemTraMaTranDonVi(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j && matrix[i, j] != 1)
                        return false;
                    if (i != j && matrix[i, j] != 0)
                        return false;
                }
            }
            return true;
        }

        static bool KiemTraMaTranDoiXung(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++) 
                {
                    if (matrix[i, j] != matrix[j, i])
                        return false;
                }
            }
            return true;
        }
        static void Bai12()
        {
            Console.Write("Nhập số dòng m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write($"Nhập số lượng mìn (tối đa {m * n - 1}): ");
            int soMin = int.Parse(Console.ReadLine());
            int[,] board = new int[m, n];
            Random rand = new Random();
            int daDat = 0;
            while (daDat < soMin && daDat < m * n)
            {
                int r = rand.Next(0, m);
                int c = rand.Next(0, n);
                if (board[r, c] != -1)
                {
                    board[r, c] = -1;
                    daDat++;
                }
            }
            int[] dx = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] dy = { -1, 0, 1, -1, 1, -1, 0, 1 };
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i, j] == -1) continue;
                    int dem = 0;
                    for (int k = 0; k < 8; k++)
                    {
                        int ni = i + dx[k];
                        int nj = j + dy[k];
                        if (ni >= 0 && ni < m && nj >= 0 && nj < n && board[ni, nj] == -1)
                        {
                            dem++;
                        }
                    }
                    board[i, j] = dem;
                }
            }
            Console.WriteLine("\nBảng Minesweeper :");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i, j] == -1)
                        Console.Write("  * ");
                    else
                        Console.Write($"{board[i, j],3} ");
                }
                Console.WriteLine();
            }
        }

        static void Bai13()
        {
            Node head = NhapDSLKDon("danh sách cần đảo ngược");
            Console.Write("Danh sách ban đầu: ");
            InDSLKDon(head);
            Node previous = null;
            Node current = head;
            Node next = null;
            while (current != null)
            {
                next = current.next;     
                current.next = previous; 
                previous = current;      
                current = next;          
            }
            head = previous;
            Console.Write("Danh sách sau khi đảo ngược: ");
            InDSLKDon(head);
        }

        static void Bai14()
        {
            Console.WriteLine("Nhập danh sách 1 (nhập các số theo thứ tự tăng dần):");
            Node l1 = NhapDSLKDon("danh sách 1");
            Console.WriteLine("Nhập danh sách 2 (nhập các số theo thứ tự tăng dần):");
            Node l2 = NhapDSLKDon("danh sách 2");
            Console.Write("Danh sách 1: ");
            InDSLKDon(l1);
            Console.Write("Danh sách 2: ");
            InDSLKDon(l2);
            Node mergedHead = GopHaiDanhSachSapXep(l1, l2);
            Console.Write("Danh sách sau khi gộp (tăng dần): ");
            InDSLKDon(mergedHead);
        }

        static Node GopHaiDanhSachSapXep(Node l1, Node l2)
        {
            Node dummy = new Node(0); 
            Node tail = dummy;
            while (l1 != null && l2 != null)
            {
                if (l1.data <= l2.data)
                {
                    tail.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    tail.next = l2;
                    l2 = l2.next;
                }
                tail = tail.next;
            }
            if (l1 != null) tail.next = l1;
            if (l2 != null) tail.next = l2;
            return dummy.next;
        }

        static void Bai15()
        {
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            n2.next = n3;
            n3.next = n4;
            n4.next = n5;
            n5.next = n6;
            n6.next = n2;
            Console.WriteLine("Kiểm tra danh sách mẫu có chu trình :");
            Console.WriteLine(CoChuTrinh(n2) ? " Danh sách có chứa chu trình." : " Danh sách không chứa chu trình.");
            Node a1 = new Node(10);
            a1.next = new Node(20);
            a1.next.next = new Node(30);
            Console.WriteLine("\nKiểm tra danh sách thẳng :");
            Console.WriteLine(CoChuTrinh(a1) ? " Danh sách có chứa chu trình." : " Danh sách không chứa chu trình.");
        }

        static bool CoChuTrinh(Node head)
        {
            Node rua = head;
            Node tho = head;
            while (tho != null && tho.next != null)
            {
                rua = rua.next;         
                tho = tho.next.next;     
                if (rua == tho)         
                {
                    return true;
                }
            }
            return false;
        }
        static Node NhapDSLKDon(string tenDS)
        {
            Console.Write($"Nhập số lượng phần tử cho {tenDS}: ");
            int n = int.Parse(Console.ReadLine());
            Node head = null, tail = null;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"  Phần tử thứ {i + 1}: ");
                int val = int.Parse(Console.ReadLine());
                Node newNode = new Node(val);
                if (head == null)
                {
                    head = tail = newNode;
                }
                else
                {
                    tail.next = newNode;
                    tail = newNode;
                }
            }
            return head;
        }

        static void InDSLKDon(Node head)
        {
            Node p = head;
            while (p != null)
            {
                Console.Write(p.data + "  ");
                p = p.next;
            }
            Console.WriteLine("null");
        }

        class WebNode
        {
            public string Url;
            public WebNode Prev;
            public WebNode Next;
            public WebNode(string url)
            {
                Url = url;
            }
        }

        static void Bai16()
        {
            WebNode current = new WebNode("google.com");
            Console.WriteLine($"Mở trình duyệt tại: {current.Url}");
            current = TruyCapTrangMoi(current, "utehy.edu.vn");
            current = TruyCapTrangMoi(current, "github.com");
            current = TruyCapTrangMoi(current, "stackoverflow.com");
            Console.WriteLine("\n Thao tác Back ");
            if (current.Prev != null)
            {
                current = current.Prev;
                Console.WriteLine($"Đã Back về trang: {current.Url}");
            }
            if (current.Prev != null)
            {
                current = current.Prev;
                Console.WriteLine($"Đã Back về trang: {current.Url}");
            }
            Console.WriteLine("\n Thao tác Forward ");
            if (current.Next != null)
            {
                current = current.Next;
                Console.WriteLine($"Đã Forward tới trang: {current.Url}");
            }
        }

        static WebNode TruyCapTrangMoi(WebNode current, string url)
        {
            WebNode newPage = new WebNode(url);
            current.Next = newPage;
            newPage.Prev = current;
            Console.WriteLine($"Truy cập trang: {newPage.Url}");
            return newPage;
        }

        class SongNode
        {
            public string TenBaiHat;
            public SongNode Prev;
            public SongNode Next;
            public SongNode(string ten)
            {
                TenBaiHat = ten;
            }
        }

        static void Bai17()
        {
            SongNode head = null;
            SongNode current = null;
            ThemBaiHat(ref head, ref current, "Lạc Trôi");
            ThemBaiHat(ref head, ref current, "Nơi Này Có Anh");
            ThemBaiHat(ref head, ref current, "Chúng Ta Của Hiện Tại");
            Console.WriteLine($"Đang phát bài đầu tiên: {current?.TenBaiHat}");
            if (current?.Next != null)
            {
                current = current.Next;
                Console.WriteLine($"[Next] Đang phát: {current.TenBaiHat}");
            }
            if (current?.Prev != null)
            {
                current = current.Prev;
                Console.WriteLine($"[Previous] Đang phát: {current.TenBaiHat}");
            }
            XoaBaiHat(ref head, ref current, "Nơi Này Có Anh");
            Console.Write("Playlist còn lại: ");
            SongNode p = head;
            while (p != null)
            {
                Console.Write($"[{p.TenBaiHat}]  ");
                p = p.Next;
            }
            Console.WriteLine("null");
        }

        static void ThemBaiHat(ref SongNode head, ref SongNode current, string ten)
        {
            SongNode newSong = new SongNode(ten);
            if (head == null)
            {
                head = current = newSong;
            }
            else
            {
                SongNode p = head;
                while (p.Next != null) p = p.Next;
                p.Next = newSong;
                newSong.Prev = p;
            }
            Console.WriteLine($"Đã thêm bài hát: {ten}");
        }

        static void XoaBaiHat(ref SongNode head, ref SongNode current, string ten)
        {
            SongNode p = head;
            while (p != null && p.TenBaiHat != ten)
            {
                p = p.Next;
            }
            if (p == null) return;
            if (p == current)
                current = p.Next ?? p.Prev;
            if (p.Prev != null) p.Prev.Next = p.Next;
            else head = p.Next;
            if (p.Next != null) p.Next.Prev = p.Prev;
            Console.WriteLine($"Đã xóa bài hát: {ten}");
        }

        class TrangThaiNode
        {
            public string TenTrangThai;
            public TrangThaiNode Prev;
            public TrangThaiNode Next;
            public TrangThaiNode(string ten)
            {
                TenTrangThai = ten;
            }
        }

        class DonHang
        {
            public string MaDon;
            public TrangThaiNode TrangThaiHienTai;
            public DonHang(string maDon)
            {
                MaDon = maDon;
                TrangThaiNode choXuLy = new TrangThaiNode("Chờ xử lý");
                TrangThaiNode dangGiao = new TrangThaiNode("Đang giao");
                TrangThaiNode hoanThanh = new TrangThaiNode("Hoàn thành");
                choXuLy.Next = dangGiao;
                dangGiao.Prev = choXuLy;
                dangGiao.Next = hoanThanh;
                hoanThanh.Prev = dangGiao;
                TrangThaiHienTai = choXuLy;
            }

            public void TienTrangThai()
            {
                if (TrangThaiHienTai.Next != null)
                {
                    TrangThaiHienTai = TrangThaiHienTai.Next;
                    Console.WriteLine($"Đơn [{MaDon}] chuyển sang trạng thái: {TrangThaiHienTai.TenTrangThai}");
                }
                else
                {
                    Console.WriteLine($"Đơn [{MaDon}] đã ở trạng thái cuối ({TrangThaiHienTai.TenTrangThai}).");
                }
            }

            public void LuiTrangThai()
            {
                if (TrangThaiHienTai.Prev != null)
                {
                    TrangThaiHienTai = TrangThaiHienTai.Prev;
                    Console.WriteLine($"Đơn [{MaDon}] quay lại trạng thái: {TrangThaiHienTai.TenTrangThai}");
                }
                else
                {
                    Console.WriteLine($"Đơn [{MaDon}] đang ở trạng thái ban đầu ({TrangThaiHienTai.TenTrangThai}).");
                }
            }
        }

        static void Bai18()
        {
            DonHang dh = new DonHang("DH001");
            Console.WriteLine($"Tạo đơn hàng [{dh.MaDon}] - Trạng thái ban đầu: {dh.TrangThaiHienTai.TenTrangThai}");
            dh.TienTrangThai(); 
            dh.TienTrangThai(); 
            dh.TienTrangThai(); 
            dh.LuiTrangThai();  
        }
    }
}
    
    

    

    

