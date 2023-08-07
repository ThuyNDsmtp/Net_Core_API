// See https://aka.ms/new-console-template for more information
System.Console.WriteLine("Chào anh Thủy. Mời nhập chuỗi...");
string str = Console.ReadLine();//Đọc chuỗi ký tự
//Console.WriteLine($"Dữ liệu vừa nhập vào là: {str}");
Console.WriteLine("Dữ liệu vừa nhập vào là: {0}",str);
int a=9;
int b=3;
Console.WriteLine($"{0} + {1} = {2}",a,b,a+b);

System.Console.Write("Nhập ký tự: ");
a = Console.Read();//Đọc ký tự, chuyển về kiểu nguyên
Console.WriteLine($"Ký tự có mã là: {a}");

