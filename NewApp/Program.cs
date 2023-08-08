//Chuyển đổi kiểu dữ liệu
string str = "123";

int i = int.Parse(str);
System.Console.WriteLine("1. {0}",i);

int.TryParse(str,out i);
System.Console.WriteLine("2. {0}",i);
System.Console.WriteLine("2.1 {0}",int.TryParse(str,out i));
System.Console.WriteLine("2.2 {0}",int.TryParse("la so 123",out i));

i=Convert.ToInt32(str);
System.Console.WriteLine("3. {0}",i);

float f = 123;

System.Console.WriteLine("4. {0}",(int)f);
