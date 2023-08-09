using System.Collections;
using NewApp.Models;
public class Program{
        public static void Main(){
                System.Console.OutputEncoding = System.Text.Encoding.Unicode;
                System.Console.InputEncoding = System.Text.Encoding.Unicode;

                System.Console.Write("Nhập số lượng student = ");
                string? str=Console.ReadLine();
                int.TryParse(str,out int n);
                if (n <= 0) {
                        System.Console.WriteLine("Cần nhập một số nguyên dương.");
                        System.Environment.Exit(1);
                }

                ArrayList arrList = new(n);
                for (int i = 0; i < n; i++){
                        Student std = new();
                        std.EnterData();
                        arrList.Add(std);
                }
                System.Console.WriteLine("Thông tin sinh viên đã nhập vào như sau:");
                foreach(Student std in arrList){
                        std.Display();
                }
                for(int i = 0; i < arrList.Count; i++){
                        (arrList[i] as Student).Display();
                }
                
        }
}
