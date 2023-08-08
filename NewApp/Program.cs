
//Tính lương
//using System.Text; Hiển thị tiếng Việt
System.Console.OutputEncoding = System.Text.Encoding.Unicode;

//Khai báo biến
int MaNV;
double Luong,LCB,HeSo,PC;
string? str;
do {
    MaNV = 0;
    System.Console.Write("Nhập mã nhân viên: \t");
    str = System.Console.ReadLine();
    int.TryParse(str,out MaNV);
} while (MaNV < 1);

do {
    LCB = 0;
    System.Console.Write("Nhập lương cơ bản: \t");
    str = System.Console.ReadLine();
    double.TryParse(str,out LCB);
} while (LCB < 0);

do {
    HeSo = 0;
    System.Console.Write("Nhập hệ số: \t\t");
    str = System.Console.ReadLine();
    double.TryParse(str,out HeSo);
} while (HeSo < 0);

do {
    PC = 0;
    Console.Write("Nhập phụ cấp: \t\t");
    str = System.Console.ReadLine();
    double.TryParse(str,out PC);
} while (PC < 0);

Luong = LCB * HeSo + PC;
System.Console.WriteLine("Lương nhân viên có mã {0} là {1}",MaNV,Luong);
System.Console.WriteLine($"Lương nhân viên có mã {MaNV} là {Luong}");
//System.Console.WriteLine(@"Lương nhân viên có mã {0} là {1}",MaNV,Luong);
