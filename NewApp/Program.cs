
using NewApp.Models;
namespace NewApp{
class Program{
    public static void Main(){
        System.Console.OutputEncoding = System.Text.Encoding.Unicode;
        System.Console.InputEncoding = System.Text.Encoding.Unicode;

        System.Console.WriteLine("Defaut properties.");
        Person p = new();
        p.Display();

        System.Console.WriteLine("Enter properties.");
        p.EnterData();
        p.Display();

        System.Console.WriteLine("With properties.");
        Student s = new ("Nguyễn Đức Thủy","Hải Dương",1970);
        s.Display();
        
    }
}
}