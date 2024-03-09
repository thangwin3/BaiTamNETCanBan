using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapThucHanh
{
    // Viết chương trình tính Tổng, Tích, Thương của 2 số được nhập từ bàn phím bằng cách sử dụng Hàm.

    internal class Ham
    {
        public int Tong(int numA, int numB)
        {
            return numA + numB;
        }

        public int Tich(int numA, int numB)
        {
            return numA * numB;
        }

        public int Thuong(int numA, int numB)
        {
            return numA / numB;
        }

        public void KetQua()
        {
            Console.WriteLine("Nhap So Thu Nhat");
            int soThuNhat = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap So Thu Hai");
            int soThuHai = int.Parse(Console.ReadLine());

            Ham ham = new Ham(); // Khởi tạo class Hàm
            Console.WriteLine(ham.Tong(soThuNhat, soThuHai));
        }
    }
}
