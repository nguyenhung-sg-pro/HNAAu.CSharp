class CuaHang
{
    // Biến tĩnh: Lưu tổng số khách hàng của TẤT CẢ các cửa hàng
    public static int TongSoKhach = 0;

    public string TenCuaHang;

    public CuaHang(string ten, int tongSoKhach)
    {
        TenCuaHang = ten;
        // Mỗi khi có 1 cửa hàng mở, tổng số khách có thể tăng lên
        TongSoKhach += tongSoKhach;
    }

    // Phương thức tĩnh: Được gọi thông qua tên lớp
    public static void InTongSoKhach()
    {
        Console.WriteLine("Tổng số khách hiện tại: " + TongSoKhach);
    }
}

class MayTinh
{
    // Cùng tên phương thức là "TinhTong" nhưng tham số khác nhau

    // Phiên bản 1: Cộng 2 số nguyên
    public int TinhTong(int a, int b)
    {
        return a + b;
    }

    // Phiên bản 2: Cộng 3 số nguyên
    public int TinhTong(int a, int b, int c)
    {
        return a + b + c;
    }

    // Phiên bản 3: Cộng 2 số thập phân
    public double TinhTong(double a, double b)
    {
        return a + b;
    }
}

class TaiKhoanNganHang
{
    // Dữ liệu nội bộ bị giấu kín (private)
    private double _soDu;

    // Thuộc tính chỉ đọc (Read-Only Property): Chỉ có get, không có set
    public string SoTaiKhoan { get; }

    // Constructor để gán giá trị ban đầu cho thuộc tính chỉ đọc
    public TaiKhoanNganHang(string soTaiKhoan)
    {
        SoTaiKhoan = soTaiKhoan;
        _soDu = 0;
    }

    // Đóng gói bằng Property với cả get và set
    public double SoDu
    {
        get { return _soDu; }
        set
        {
            // Kiểm tra tính hợp lệ của dữ liệu trước khi gán
            if (value >= 0)
                _soDu = value;
            else
                Console.WriteLine("Lỗi: Số dư không thể là số âm.");
        }
    }
}

class Program
{
    // // Ví dụ về ref
    // static void TangGiaTri(ref int x)
    // {
    //     x += 10;
    // }

    // // Ví dụ về out
    // static void LayThongTin(out int namSinh)
    // {
    //     namSinh = 2000; // Bắt buộc phải gán giá trị bên trong hàm
    // }

    // // Ví dụ về params
    // static void InDanhSachSo(params int[] danhSach)
    // {
    //     foreach (int item in danhSach)
    //     {
    //         Console.Write(item + " ");
    //     }
    // }

    // static void InTinhThanh(params string[] danhSach)
    // {
    //     foreach (string item in danhSach)
    //     {
    //         Console.Write(item + " ");
    //     }
    // }



    static void Main()
    {
        // CuaHang ch1 = new CuaHang("Cơ sở 1", 100);
        // CuaHang ch2 = new CuaHang("Cơ sở 2", 150);
        // CuaHang ch3 = new CuaHang("Cơ sở 3", 100);

        // // Gọi phương thức tĩnh thông qua tên lớp (không gọi qua ch1 hay ch2)
        // CuaHang.InTongSoKhach(); // Kết quả in ra: 3

        // Sử dụng ref
        // int diem = 5; // Bắt buộc khởi tạo
        // TangGiaTri(ref diem);
        // Console.WriteLine(diem); // Kết quả: 15

        // // Sử dụng out
        // int nam; // Không cần khởi tạo
        // LayThongTin(out nam);
        // Console.WriteLine(nam); // Kết quả: 2000

        // // Sử dụng params
        // InTinhThanh("Hà Nội", "Huế", "Sài Gòn", "Đà Lạt"); // Có thể truyền bao nhiêu tham số tùy ý
        // InDanhSachSo(10, 20, 30, 40, 50);
        // MayTinh mt = new MayTinh();
        // Console.WriteLine(mt.TinhTong(5, 10));       // Gọi phiên bản 1
        // Console.WriteLine(mt.TinhTong(5, 10, 15));   // Gọi phiên bản 2
        // Console.WriteLine(mt.TinhTong(2.5, 3.5));    // Gọi phiên bản 3
        // Console.WriteLine(mt.TinhTong(2.5, 3, 4));   // Code phiên bản mới  

        TaiKhoanNganHang tk = new TaiKhoanNganHang("123456789");

        //tk.SoTaiKhoan = "987654321"; // LỖI: Không thể gán vì là thuộc tính chỉ đọc
        Console.WriteLine("Số TK: " + tk.SoTaiKhoan);

        // Gán và đọc số dư thông qua Property
        tk.SoDu = 50000; // Gọi set
        Console.WriteLine("Số dư: " + tk.SoDu); // Gọi get

        tk.SoDu = -1000; // Gọi set nhưng sẽ bị báo lỗi do giá trị âm
    }


}