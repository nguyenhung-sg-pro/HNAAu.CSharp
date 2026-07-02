using System;

public class TuoiKhongHopLeException : Exception
{
    public TuoiKhongHopLeException(string thongbao) : base(thongbao)
    {

    }
}

public class Program
{
    static void KiemTraTuoi(int tuoi)
    {
        if (tuoi < 18)
            throw new TuoiKhongHopLeException("Quay lại sau nhé");
        Console.WriteLine("Chao mừng bạn đến với chương trình");
    }
    public static void Main()
    {
        /*
        Console.WriteLine("____________ Chương trình Chia 2 số ____________");

        try
        {
            Console.Write("*** Bạn vui lòng nhập tử số = ");
            int tuSo = int.Parse(Console.ReadLine());

            Console.Write("*** Bạn vui lòng nhập mẫu số = ");
            int mauSo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Kết quả tử số chia cho mẫu số = {tuSo / mauSo}");

        }
        catch (System.Exception e)
        {
            Console.WriteLine("Đã phát lỗi: " + e.Message);
            Console.WriteLine("Vị trí phát sinh lỗi: " + e.StackTrace);
        }
        finally
        {
            Console.WriteLine("Kết thúc chương trình - Hẹn gặp lại");
            // Xóa file tạm, đóng kết nối CSDL, đóng phiên giao dịch, hay dọn dẹp vùng nhớ...
        }
        */

        try
        {
            Console.Write("Nhập vào tuổi của bạn:");
            int tuoi = 0;
            tuoi = int.Parse(Console.ReadLine());
            KiemTraTuoi(tuoi);
        }
        catch (TuoiKhongHopLeException e)
        {
            Console.WriteLine("Nghiệp vụ bị lỗi! " + e.Message);
        }

    }
}