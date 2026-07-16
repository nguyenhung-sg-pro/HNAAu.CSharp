using System;

class Program
{
    public static int SequentialSearch(int[] array, int value)
    {
        for (int i = 0; i < array.Length - 1; i++)
            if (array[i] == value)
                return i;
        return -1;
    }

    public static int Max(int[] array)
    {
        if (array.Length == 0) throw new Exception("Mảng truyền vào không hợp lệ");

        int max = array[0];

        for (int i = 1; i < array.Length - 1; i++)
            if (array[i] > max)
                max = array[i];
        return max;
    }
    static void Main()
    {
        int[] data = [5, 6, 7, 8, 4, -3, 0, 9];
        int value = 0;

        //int index = SequentialSearch(data, value);
        // int index = data.IndexOf(value);

        // if (index == -1)
        //     Console.WriteLine($"Không tìm thấy giá trị {value} trong mảng");
        // else
        //     Console.WriteLine($"Vị trí xuất hiện của {value} trong mảng là {index}");

        //int max = Max(data);
        int max = data.Max();
        Console.WriteLine($"Giá trị lớn nhất của mảng là {max}");
    }
}