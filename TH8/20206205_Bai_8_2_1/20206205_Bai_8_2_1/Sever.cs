using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20206205_Bai_8_2_1
{
    internal class Sever
    {
        private string TenYeuCau;
        private string DiaChiIP;
        private string NoiDung;
        private string ThoiGianThucHien;
        public Sever()
        {
            TenYeuCau = null;
            DiaChiIP = null;
            NoiDung = null;
            ThoiGianThucHien = null;
        }
        MyLinkedListQueue MyQueueSever = new MyLinkedListQueue();

        public void NhapSever()
        {
            Console.Write("Nhập tên yêu cầu: ");
            TenYeuCau = Console.ReadLine();
            MyQueueSever.Enqueue(TenYeuCau);
            Console.Write("Nhập địa chỉ IP: ");
            DiaChiIP = Console.ReadLine();
            MyQueueSever.Enqueue(DiaChiIP);
            Console.Write("Nhập nội dung: ");
            NoiDung = Console.ReadLine();
            MyQueueSever.Enqueue(NoiDung);
            Console.Write("Nhập thời gian thực hiện: ");
            ThoiGianThucHien = Console.ReadLine();
            MyQueueSever.Enqueue(ThoiGianThucHien);

        }
        public void XuatSever()
        {
            Console.WriteLine("Tên yêu cầu: " + MyQueueSever.Dequeue());
            Console.WriteLine("Địa chỉ IP: " + MyQueueSever.Dequeue());
            Console.WriteLine("Nội dung: " + MyQueueSever.Dequeue());
            Console.WriteLine("Thời gian thực hiện: " + MyQueueSever.Dequeue());
        }
        public int TongYeuCau()
        {
            return MyQueueSever.Count()/4;
        }

    }
}
