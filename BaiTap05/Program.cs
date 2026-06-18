class DongVatCoVu
{
    public string Loai = "Động vật có vú";
    public int SoChan = 4;
    public void SinhSan()
    {
        Console.WriteLine("Nuôi con bằng sữa mẹ!");
    }
}

class Meo : DongVatCoVu
{
    public string Ten = "";
    public void BatChuot()
    {
        Console.WriteLine("Mèo đang bắt chuột");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello bạn đến với chương trình của tôi!");
        Meo meo = new();

        meo.Ten = "Mèo mướp";
        Console.WriteLine(meo.Ten.ToString());
        meo.BatChuot();

        Console.WriteLine(meo.Loai.ToString());
        meo.SinhSan();

    }
}