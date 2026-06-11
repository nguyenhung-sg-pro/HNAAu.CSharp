using System;
// Ví dụ kiểu dữ liệu Int


// int namSinh = 1996;
// string gioiTinh = "Nam";
// if (!(namSinh < 1996 || gioiTinh == "Nam"))
//     //True
//     Console.WriteLine("Bạn là thế hệ gen Z");
// else
//     //False
//     Console.WriteLine("Bạn là thế hệ gen Y");

// Console.WriteLine((1 != 2, 1 > 0) ? ((3 < 4)? 2: 3) : 0);

int a, b, c;
a = b = (c = 9) + 1; // khởi tạo giá trị: a = 10, b = 10, c = 9
a += b; // tương đương a = a + b 
b = c++; // thực hiện gán giá trị c cho biến b sau đó thực hiện c = c + 1 
--c; // thực hiện c = c - 1 
Console.WriteLine(" a = {0}, b = {1}, c = {2}", a, b, c);
Console.ReadKey();

