using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20206205_Bai_8_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            BinaryTree binaryTree = new BinaryTree();
            int luachon;
            do
            {
                Console.WriteLine("Vũ Văn Nghĩa MSSV: 20206205");
                Console.WriteLine("Chương trình mô phỏng một cây nhị phân tìm kiếm.");
                Console.WriteLine("Lựa chọn:");
                Console.WriteLine("1. Thêm một phần tử.");
                Console.WriteLine("2. Xóa một phần tử.");
                Console.WriteLine("3. Kiểm tra một phần tử.");
                Console.WriteLine("4. Đếm số phần tử của cây.");
                Console.WriteLine("0. Thoát chương trình.");
                do
                {
                    bool kt = false;
                    do
                    {
                        Console.Write("Mời bạn nhập lựa chọn từ 0 đến 4: ");
                        string nNhap = Console.ReadLine();
                        kt = int.TryParse(nNhap, out luachon);
                    } while (!kt);
                } while (0 > luachon || luachon > 4);
                switch (luachon)
                {
                    case 1:
                        // Thêm một phần tử.
                        BinaryTree p = new BinaryTree();
                        bool kt = false; int them;
                        do
                        {
                            Console.Write("Nhập phần tử cần thêm (số nguyên): ");
                            string nNhap = Console.ReadLine();
                            kt = int.TryParse(nNhap, out them);
                        } while (!kt);
                        binaryTree.Them(them);
                        Console.WriteLine("Thêm một phần tử thành công!");
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        // Xóa một phần tử.
                        kt = false; int xoa;
                        do
                        {
                            Console.Write("Nhập phần tử cần xóa (số nguyên): ");
                            string nNhap = Console.ReadLine();
                            kt = int.TryParse(nNhap, out xoa);
                        } while (!kt);
                        binaryTree.Xoa(xoa);
                        Console.WriteLine("Xóa một phần tử {0} thành công!", xoa);
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        // Kiểm tra một phần tử.
                        kt = false; int tim;
                        do
                        {
                            Console.Write("Nhập phần tử cần tìm (số nguyên): ");
                            string nNhap = Console.ReadLine();
                            kt = int.TryParse(nNhap, out tim);
                        } while (!kt);
                        Node TimDuoc = binaryTree.Tim(tim);
                        if (TimDuoc == null)
                        {
                            Console.WriteLine("Không tồn tại phần tử {0} cần tìm!", tim);

                        }
                        else
                        {

                            Console.WriteLine("Có tồn tại phần tử {0} cần tìm!", TimDuoc.data);
                            try
                            {
                                Console.WriteLine("Có con trái là: " + TimDuoc.left.data);
                            }
                            catch
                            {
                                Console.WriteLine("Không có con trái!");
                            }
                            try
                            {
                                Console.WriteLine("Có con phải là: " + TimDuoc.right.data);
                            }
                            catch
                            {
                                Console.WriteLine("Không có con phải!");
                            }

                        }
                        Console.WriteLine("Nhấn phím bất kì để tiếp tục!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        // Đếm số phần tử của cây.
                        Console.WriteLine("Tổng số phần tử hiện tại của cây là: " + binaryTree.TongSoPhanTuCuaCay());

                        Console.WriteLine("Nhấn phím bất kì để tiếp tục!");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }
            } while (luachon != 0);
            // Thoát chương trình.
            Console.WriteLine("Bạn đã thoát chương trình!");
            Console.WriteLine("Nhấn phím bất kì kết thúc chương trình.");
            Console.ReadKey();

        }

    }
}