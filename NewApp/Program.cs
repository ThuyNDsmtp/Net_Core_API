
using NewApp.Models;
namespace NewApp;
class Program{
    public static void Main(){
        System.Console.OutputEncoding = System.Text.Encoding.Unicode;
        System.Console.InputEncoding = System.Text.Encoding.Unicode;

        Person p = new();
        p.Display();

        p.EnterData();
        p.Display();

        Student s = new Student("Nguyễn Đức Thủy","Hải Dương",1970);
        s.Display();

    }
}

