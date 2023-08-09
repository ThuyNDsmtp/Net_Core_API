using NewApp.Models;
public class Program{
        public static void Main(){
        System.Console.OutputEncoding = System.Text.Encoding.Unicode;
        System.Console.InputEncoding = System.Text.Encoding.Unicode;

      
        //Khai báo số lượng person
        int n=0;
        while(n <= 0){
                try{
                        System.Console.Write("Nhập số lượng person = ");
                        string? str = Console.ReadLine();
                        n=int.Parse(str);
                }catch{
                        System.Console.WriteLine("Cần nhập vào số hợp lệ là số nguyên dương.");
                }
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
        System.Console.WriteLine($"Kết quả đã nhập vào {n} Person:");

        for(int i=0;i<n;i++){
                System.Console.Write($"Person {i+1}: ");
                p[i].Display();
        }
        }
}
