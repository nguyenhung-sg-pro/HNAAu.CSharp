// public abstract class DongVat
// {
//     public string? Ten { get; set; }

//     public abstract void Speak();
// }

// public class Cho : DongVat
// {
//     public override void Speak()
//     {
//         Console.WriteLine("Gâu Gâu !");
//     }
//     public override string ToString()
//     {
//         return "Con chó sẽ kêu";
//     }
// }

// public class Meo : DongVat
// {
//     public override void Speak()
//     {
//         Console.WriteLine("Meo meo !");
//     }
// }

public class SinhVien
{
    public string? HoTen { get; set; }
    public int Tuoi { get; set; }

    public override string ToString()
    {
        return $"Sinh viên: {HoTen}, tuổi :{Tuoi}";
    }
}
class Program
{
    public static void Main()
    {
        // DongVat dv1 = new Meo();
        // dv1.Speak();

        // DongVat dv2 = new Cho();
        // dv2.Speak();

        SinhVien sv1 = new SinhVien { HoTen = "Hai Lúa", Tuoi = 23 };

        SinhVien sv2 = new SinhVien();
        sv2.HoTen = "Hai Lúa";
        sv2.Tuoi = 23;

        Console.WriteLine(sv1.ToString());
        Console.WriteLine(sv1.Tuoi.GetType());
        string checkEqual = sv1.Equals(sv2) ? "Trùng nhau" : "Không trùng";
        Console.WriteLine(checkEqual);

    }
}