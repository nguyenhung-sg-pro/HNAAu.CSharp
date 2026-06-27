using System;

public class PhanSo
{
    public int MauSo { get; set; }
    public int TuSo { get; set; }

    public PhanSo(int tu, int mau)
    {
        TuSo = tu;
        MauSo = mau == 0 ? 1 : mau; //Nếu mẫu số = 0, 
        //thì trả về giá trị 1, ngược lại thì giữ nguyên
    }

    public static PhanSo operator +(PhanSo a, PhanSo b)
    {
        int tuMoi = a.TuSo * b.MauSo + a.MauSo * b.TuSo;
        int mauMoi = a.MauSo * b.MauSo;

        return new PhanSo(tuMoi, mauMoi);
    }

    public override string ToString()
    {
        return $"{TuSo}/{MauSo}";
    }
}

class Program
{
    public static void Main()
    {
        PhanSo fs1 = new PhanSo(1,2);
        PhanSo fs2 = new PhanSo(1,0);

        PhanSo fs3 = fs1 + fs2;
        Console.WriteLine($"Kết quả cộng của {fs1} + {fs2} = {fs3}");
    }
}