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
    static void Main()
    {
        int[] data = [5, 6, 7, 8, 4, -3, 0, 6];
        int value = 0;

        //int index = SequentialSearch(data, value);
        int index = data.IndexOf(value);
        
        if (index == -1)
            Console.WriteLine($"Không tìm thấy giá trị {value} trong mảng");
        else
            Console.WriteLine($"Vị trí xuất hiện của {value} trong mảng là {index}");
    }
}