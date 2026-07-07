using System;
using System.Diagnostics;

class Program
{
    static void ThuatToan()
    {
        for (double i = 1; i < 10000000000; i++) { }
    }
    public static void Main()
    {
        /*
        int n = 10;

        //Thuật toán O(n)
        Console.WriteLine("Thuật toán O(n)");
        for (int i = 0; i < n; i++)
            Console.Write(i + " ");
        Console.WriteLine();

        // Thuật toán O(n^2)
        Console.WriteLine("Thuật toán O(n^2)");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write("* ");
            Console.WriteLine();
        }*/

        // //1. Đo bằng dateTime
        // var start = DateTime.Now;
        // ThuatToan();
        // var duration = DateTime.Now - start;
        // Console.WriteLine("Thời gian thực thi: " + duration.TotalMilliseconds);

        //2. Stopwatch
        var stopWatch = Stopwatch.StartNew();
        ThuatToan();
        stopWatch.Stop();
        Console.WriteLine("Thời gian thực thi tính bằng stopWatch : " + stopWatch.ElapsedMilliseconds + " ms");
    }
}