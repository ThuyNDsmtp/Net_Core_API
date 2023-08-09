using NewApp.Models;
public class Program{
        public static void Main(){
        System.Console.OutputEncoding = System.Text.Encoding.Unicode;
        System.Console.InputEncoding = System.Text.Encoding.Unicode;

      
        //Khai báo số lượng person
        System.Console.Write("Nhập số lượng person = ");
        string? str = Console.ReadLine();
        if (!int.TryParse(str,out int n)){
                System.Console.WriteLine("Số lượng [{0}] không hợp lệ.",str);
                System.Environment.Exit(1);
        }
        //Nhập dữ liệu từng person
        Person[] p = new Person[n];
        for(int i=0;i<n;i++){
                System.Console.WriteLine($"Nhập vào người thứ {i+1}:");
                p[i]=new();
                p[i].EnterData();
        }
        //In kết quả
        System.Console.WriteLine("---------------------------------------------------------------------");
        System.Console.WriteLine("Kết quả đã nhập vào:");

        for(int i=0;i<n;i++){
                System.Console.Write($"Person {i+1}: ");
                p[i].Display();
        }
        }
}
