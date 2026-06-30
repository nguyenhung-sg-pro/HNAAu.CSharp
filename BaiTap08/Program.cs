using System;

#region Cấu trúc sinh viên
// struct SinhVien
// {
//     public int? MaSV;
//     public string? HoTen;
//     public string? CCCD;
//     public double? DiemToan;
//     public double? DiemLy;
//     public double? DiemVan;

// }
#endregion

#region Location
struct Location
{
    public int X;
    public int Y;

    public Location(int x, int y)
    {
        X = x;
        Y = y;
    }
}

#endregion
class Program
{
    public static void ModifyLocation(Location location)
    {
        location.X = 999;
        Console.WriteLine($"Bên trong hàm Modify có location.X = {location.X}");
    }

    public static void Main()
    {
        Console.WriteLine("Chào bạn đến với bài tập C# 08");
        /*
        // //Cach 2
        // SinhVien sv1;
        // sv1.HoTen = "Trần Bình Trọng";
        // sv1.MaSV = 0084;

        // //Cach 1
        // SinhVien sv2 = new();
        // sv2.HoTen = "Nguyễn Hữu Cầu";
        // sv2.MaSV = 0074;

        // Console.WriteLine($"Sinh viên thứ nhất là {sv1.HoTen} với mã sinh viên là {sv1.MaSV}");
        // Console.WriteLine($"Sinh viên thứ nhất là {sv2.HoTen} với mã sinh viên là {sv2.MaSV}");
        */

        /*
        Location vitri1 = new Location();
        Console.WriteLine($"Vị trí có tọa độ x = {vitri1.X} và y = {vitri1.Y}");

        Location vitri2 = new Location(100, 200);
        Console.WriteLine($"Vị trí có tọa độ x = {vitri2.X} và y = {vitri2.Y}");

        Location vitri3;
        vitri3.X = 30;
        vitri3.Y = 50;
        Console.WriteLine($"Vị trí có tọa độ x = {vitri3.X} và y = {vitri3.Y}");
        */

        Location myLocation = new Location();
        myLocation.X = 50;

        Console.WriteLine($"Trước khi gọi hàm Modify ta có myLocation.X = {myLocation.X}");

        ModifyLocation(myLocation);

        Console.WriteLine($"Sau khi gọi hàm Modify ta có myLocation.X = {myLocation.X}");

    }

}