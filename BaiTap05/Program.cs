class DongVatCoVu
{
    public string Loai = "Động vật có vú";
    public int SoChan = 4;
    public void SinhSan()
    {
        Console.WriteLine("Nuôi con bằng sữa mẹ!");
    }
}

class Meo : DongVatCoVu
{
    public string Ten = "";
    public void BatChuot()
    {
        Console.WriteLine("Mèo đang bắt chuột");
    }
}

class NhanVien
{
    private double _luongCoBan = 50000000;
    protected string MaNhanVien = "";
}

class QuanLy : NhanVien
{
    public void HienThiThongTin()
    {
        MaNhanVien = "NV001";

        Console.WriteLine("Mã nhân viên quản lý là " + MaNhanVien);
    }
}

class Nguoi
{
    public string HoTen;

    public Nguoi(string hoTen)
    {
        HoTen = hoTen;
        Console.WriteLine("Đã khởi tạo đối tượng Nguoi: " + HoTen);
    }
}

class HocSinh : Nguoi
{
    public double Diem;
    public HocSinh(string hoTen, double diem) : base(hoTen) 
    {
        Diem = diem;
        Console.WriteLine("Đã khởi tạo đối tượng HocSinh với Diem = "+ Diem);
        Console.ForegroundColor = ConsoleColor.DarkYellow;
    }
}

class MayTinh
{
    public void KhoiDong()
    {
        Console.WriteLine("Máy tính đang khởi động...");
    }
}

class LapTop : MayTinh
{
    public void KhoiDongLapTop()
    {
        base.KhoiDong();
        Console.WriteLine("Màn hình đăng nhập kích hoạt và cần nhập mật khẩu !");
    }
}

class Program
{
    static void Main()
    {
        // Console.WriteLine("Hello bạn đến với chương trình của tôi!");
        // Meo meo = new();

        // meo.Ten = "Mèo mướp";
        // Console.WriteLine(meo.Ten.ToString());
        // meo.BatChuot();

        // Console.WriteLine(meo.Loai.ToString());
        // meo.SinhSan();

        // QuanLy ql = new();
        // ql.HienThiThongTin();
        // HocSinh hs = new("Nguyễn Văn Đại", 8.5);
        // HocSinh hs1= new("Trần Văn Bách", 7);

        LapTop lapTop = new();
        lapTop.KhoiDongLapTop();
    }
}