public abstract class DongVat
{
    public string? Ten { get; set; }

    public abstract void Speak();
}

public class Cho : DongVat
{
    public override void Speak()
    {
        Console.WriteLine("Gâu Gâu !");
    }
}

public class Meo : DongVat
{
    public override void Speak()
    {
        Console.WriteLine("Meo meo !");
    }
}
class Program
{
    public static void Main()
    {
        DongVat dv1 = new Meo();
        dv1.Speak();

        DongVat dv2 = new Cho();
        dv2.Speak();
    }
}