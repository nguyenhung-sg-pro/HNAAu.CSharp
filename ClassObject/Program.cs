using System;
// 1. KHAI BÁO CLASS
class HocSinh
{
    // Thuộc tính
    public string HoTen = string.Empty;
    public int Tuoi;

    // Phương thức
    public void ChaoHoi()
    {
        Console.WriteLine("Xin chào, mình tên là " + HoTen);
    }

    public void KhaiBaoTuoi()
    {
        Console.WriteLine("Mình đã được " + Tuoi + "rồi !");
    }
}

class Animal
{
    public string name = string.Empty;

    // Constructor KHÔNG đối số (Gán giá trị mặc định)
    public Animal()
    {
        name = "Unknown Animal";
    }

    // Constructor CÓ đối số (Gán giá trị do người dùng truyền vào)
    public Animal(string tenDongVat)
    {
        name = tenDongVat;
    }
}

class SinhVien
{
    // Biến private, bên ngoài class không thể truy cập trực tiếp
    private double diemToan;

    // PROPERTY sử dụng get và set
    public double DiemToan
    {
        get
        {
            return diemToan; // Trả về giá trị
        }
        set
        {
            // Kiểm tra tính hợp lệ trước khi gán (value là từ khóa đại diện cho giá trị được truyền vào)
            if (value >= 0 && value <= 10)
            {
                diemToan = value;
            }
            else
            {
                Console.WriteLine("Điểm không hợp lệ!");
            }
        }
    }
}




class Program
{
    static void Main()
    {
        //
        // HocSinh hs = new HocSinh();
        // hs.HoTen = "Nguyễn Huyền Bảo Khanh";
        // hs.Tuoi = 25;
        // hs.ChaoHoi();
        // hs.KhaiBaoTuoi();

        //
        // Khi sử dụng:
        //Animal a1 = new(); // Name sẽ là "Unknown Animal"
        //Animal a2 = new("Chó Poodle"); // Name sẽ là "Chó Poodle"

        // Khi sử dụng:
        SinhVien sv = new SinhVien();
        sv.DiemToan = 8; // Gọi lệnh set (hợp lệ)
        sv.DiemToan = 15; // Gọi lệnh set (Báo lỗi "Điểm không hợp lệ!" và diemToan vẫn giữ nguyên)
        Console.WriteLine(sv.DiemToan); // Gọi lệnh get để in ra
    }
}