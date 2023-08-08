using NewApp.Models;
public class Program{
        public static void Main(){
        System.Console.OutputEncoding = System.Text.Encoding.Unicode;
        System.Console.InputEncoding = System.Text.Encoding.Unicode;

        Student std = new ();
        std.EnterData();
        std.Display();
        }
}
