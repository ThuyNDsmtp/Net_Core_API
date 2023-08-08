
using NewApp.Models;
namespace NewApp;
class Program{
    public static void Main(){
        System.Console.OutputEncoding = System.Text.Encoding.Unicode;

        Person p = new();
        p.Display();

        p.EnterData();
        p.Display();

        p.FullName ="Nguyễn Đức Thủy";
        p.Address = "Hải Dương";
        p.Age = 54;
        p.Display();

        Student s = new Student("Nguyễn Đức Thủy","Hải Dương",1970);
        s.Display();

    }
}

