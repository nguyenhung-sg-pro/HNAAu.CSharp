
class Program
{
    public static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            int last = arr[i];// Lấy phần tử hiện tại để tìm chỗ chèn
            int j = i; // Bắt đầu duyệt ngược từ vị trí i

            // Dịch chuyển các phần tử lớn hơn last sang phải để nhường chỗ
            while (j > 0 && arr[j - 1] > last)
            {
                arr[j] = arr[j - 1];
                j--;
            }
            arr[j] = last;
        }
    }

    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i; // Giả sử phần tử hiện tại là nhỏ nhất

            // Tìm phần tử nhỏ nhất trong mảng chưa sắp xếp còn lại
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j; // Cập nhật lại vị trí nhỏ nhất
                }
            }
            // Đổi chỗ phần tử nhỏ nhất tìm được về đầu đoạn chưa sắp xếp
            Swap(ref arr[i], ref arr[minIndex]);
        }
    }

    public static void Show(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            Console.Write($"{arr[i]} ");
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a; // Lưu tạm giá trị của a
        a = b;        // Gán giá trị b cho a
        b = temp;     // Gán giá trị tạm (của a ban đầu) cho b
    }
    public static void Main()
    {

        int[] mang = [3, 2, 0, 5, -1];

        Console.WriteLine("Mảng trước khi được sắp xếp là: ");
        Show(mang);

        //InsertionSort(mang);
        SelectionSort(mang);
        Console.WriteLine("Mảng sau khi được sắp xếp là: ");
        Show(mang);
    }
}