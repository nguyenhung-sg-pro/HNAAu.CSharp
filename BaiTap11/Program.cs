class Program
{
    public static int GiaiThua(int n)
    {
        if (n == 0) return 1;
        return n * GiaiThua(n - 1);
    }
    public static void Main()
    {
        int n = 4;
        int kq = GiaiThua(n);
        Console.WriteLine($"Giai thừa của {n} = {kq}");
    }
}