//Vũ Văn Nghĩa_20206205
using System;
using System.IO;
using System.Text;
namespace KiThuatLapTrinh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int luachon;
            do
            {
                Console.WriteLine("Vũ Văn Nghĩa MSSV: 20206205");
                Console.WriteLine("Bài TH2: Chương trình làm việc với file.");
                Console.WriteLine("1. Hiển thị dữ liệu từ file.");
                Console.WriteLine("2. Thêm dữ liệu vào file.");
                Console.WriteLine("3. Xóa dữ liệu từ file.");
                Console.WriteLine("4. Cập nhật dữ liệu từ file.");
                Console.WriteLine("0. Thoát chương trình.");
                do
                {
                    Console.Write("Mời bạn nhập lựa chọn từ 0 đến 4: ");
                    luachon = Convert.ToInt32(Console.ReadLine());
                } while (0 > luachon || luachon > 4);
                switch (luachon)
                {
                    case 1:
                        Console.Clear();
                        Ham1HienThiDuLieu();
                        break;
                    case 2:
                        Console.Clear();
                        Ham2ThemDuLieu();
                        break;
                    case 3:
                        Console.Clear();
                        Ham3XoaDuLieu();
                        break;
                    case 4:
                        Console.Clear();
                        Ham1HienThiDuLieu();
                        break;
                }
            } while (luachon != 0);
            Console.WriteLine("Bạn đã thoát chương trình!");
            Console.ReadKey();
        }

        public static void Ham1HienThiDuLieu()
        {
            //Chương trình hiển thị dữ liệu từ file
            Console.WriteLine("Nội dung trong file ( BaiTH2_1_1.txt ): ");
            string a = File.ReadAllText("BaiTH2_1_1.txt");
            Console.WriteLine(a);

            Console.WriteLine("Nhấn phím bất kì để tiếp tục!"); Console.ReadKey();
        }
        public static void Ham2ThemDuLieu()
        {
            //Chương trình thêm dữ liệu vào file
            Console.WriteLine("Chương trình thêm dữ liệu vào file ( BaiTH2_1_1.txt ): ");
             Console.WriteLine("Nội dung trong file ( BaiTH2_1_1.txt ): ");
            string[] a = File.ReadAllLines("BaiTH2_1_1.txt");
            for (int i = 0; i < a.Length; ++i)
            {
                Console.Write(i + ". ");
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("\nNhập dòng muốn thêm nội dung trong file: ");
             int Them = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Nhập nội dung cần thêm: ");
            string NoiDung = Console.ReadLine();
           if(Them<a.Length){ File.WriteAllText("BaiTH2_1_1.txt", "");
            for (int i = 0; i < a.Length; ++i)
             {
                if (i == Them)
                {
                      File.AppendAllText("BaiTH2_1_1.txt", "\n" + NoiDung);
                       File.AppendAllText("BaiTH2_1_1.txt","\n" + a[i]);
                }
                else
                {
                    if (i == 0)
                    {
                        File.AppendAllText("BaiTH2_1_1.txt", a[i]);
                    }
                    else
                    {
                        File.AppendAllText("BaiTH2_1_1.txt", "\n" +a[i]);
                    }
                }
            }
          
         
            Console.WriteLine("Thêm dữ liệu vào file thành công!");
            }else{
                  File.AppendAllText("BaiTH2_1_1.txt", "\n" + NoiDung);
                   Console.WriteLine("Thêm dữ liệu vào file thành công!");
            }
        }
        public static void Ham3XoaDuLieu()
        {

            //Chương trình xóa dữ liệu từ file
            Console.WriteLine("Chương trình xóa dữ liệu từ file ( BaiTH2_1_1.txt ): ");
            Console.WriteLine("Nội dung trong file ( BaiTH2_1_1.txt ): ");
            string[] a = File.ReadAllLines("BaiTH2_1_1.txt");
            for (int i = 0; i < a.Length; ++i)
            {
                Console.Write(i + ". ");
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("\nNhập dòng muốn xóa nội dung trong file: ");
            int Xoa = Convert.ToInt32(Console.ReadLine());
            if(Xoa<a.Length){
                File.WriteAllText("BaiTH2_1_1.txt", "");
            for (int i = 0; i < a.Length; ++i)
            {
                if (i == Xoa)
                {
                    continue;
                }
                else
                {
                    if (i == 0)
                    {
                        File.AppendAllText("BaiTH2_1_1.txt", a[i]);
                    }
                    else
                    {
                        File.AppendAllText("BaiTH2_1_1.txt","\n" + a[i]);
                    }
                }
            }
            Console.WriteLine("Xóa dòng {0} trong file thành công!", Xoa);
            }else{
                Console.WriteLine("Không có dòng {0} trong file để xóa", Xoa);
            }
            
        }
    }
}