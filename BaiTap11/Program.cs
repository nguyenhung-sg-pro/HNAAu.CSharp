class Program
{
    public static int GiaiThua(int n)
    {
        if (n == 0) return 1;
        return n * GiaiThua(n - 1);
    }

    public static int Fibonacci(int n)
    {
        if (n == 0 || n == 1) return n;
        // Gọi lại chính nó 2 lần
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    public static bool IsEven(int n)
    {
        if (n == 0) return true;
        return IsOdd(n - 1);
    }

    public static bool IsOdd(int n)
    {
        if (n == 0) return false;
        return IsEven(n - 1);
    }

    public static void Main()
    {
        int n = 4;
        //int kq = GiaiThua(n);
        //Console.WriteLine($"Giai thừa của {n} = {kq}");

        // int kq = Fibonacci(n);
        // Console.WriteLine($"Tổng theo Fibonacci của {n} = {kq}");

        bool kq = IsOdd(n);
        Console.WriteLine($"Số {n} là số lẻ ? {kq}");

    }
}