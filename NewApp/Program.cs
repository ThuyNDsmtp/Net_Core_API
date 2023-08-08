
//Tính lương
//using System.Text; Hiển thị tiếng Việt
System.Console.OutputEncoding = System.Text.Encoding.Unicode;

//Khai báo biến
int MaNV;
double Luong,LCB,HeSo,PC;

System.Console.Write("Nhập mã nhân viên: \t");
MaNV = Convert.ToInt32(System.Console.ReadLine());

System.Console.Write("Nhập lương cơ bản: \t");
LCB = Convert.ToDouble(System.Console.ReadLine());

System.Console.Write("Nhập hệ số: \t\t");
HeSo = Convert.ToDouble(System.Console.ReadLine());

Console.Write("Nhập phụ cấp: \t\t");
PC = Convert.ToDouble(System.Console.ReadLine());

Luong = LCB * HeSo + PC;
System.Console.WriteLine("Lương nhân viên có mã {0} là {1}",MaNV,Luong);

