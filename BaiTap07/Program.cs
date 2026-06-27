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

    public static bool operator ==(PhanSo a, PhanSo b)
    {
        return a.TuSo * b.MauSo == a.MauSo * b.TuSo;
    }

    public static bool operator !=(PhanSo a, PhanSo b)
    {
        return !(a == b);
    }

    public override string ToString()
    {
        return $"{TuSo}/{MauSo}";
    }

    public static implicit operator PhanSo(int value)
    {
        return new PhanSo(value, 1);
    }

    public static explicit operator int(PhanSo f)
    {
        return f.TuSo / f.MauSo;
    }

}


class Program
{
    public static void Main()
    {
        // PhanSo fs1 = new PhanSo(1, 2);
        // PhanSo fs2 = new PhanSo(3, 6);

        // PhanSo fs3 = fs1 + fs2;
        // Console.WriteLine($"Kết quả cộng của {fs1} + {fs2} = {fs3}");

        // Console.WriteLine(fs1 == fs2 ? "Hai phân số bằng nhau" : "Hai phân số không bằng nhau");

        PhanSo f = 5;
        PhanSo f1 = new(4,3);
        int x = (int)f1;
        Console.WriteLine(x);
    }
}