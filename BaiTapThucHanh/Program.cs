namespace BaiTapThucHanh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ham ham = new Ham();
            //ham.KetQua();
            TimSoNguyenTo timSoNguyenTo = new TimSoNguyenTo();

            Console.WriteLine("Nhap So");
            int number = int.Parse(Console.ReadLine());
            bool ketqua = timSoNguyenTo.KiemTraNguyenTo(number);
            Console.WriteLine(ketqua);
        }
    }
}
