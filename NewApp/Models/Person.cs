namespace NewApp.Models;
public class Person
{
    public Person(string fullName,string address, sbyte age) 
    {
        FullName = fullName;
        Address = address;
        Age = age;
    }
    public string FullName { get; set; }
    public string Address { get; set; }
    public sbyte Age { get; set; }
    public Person(){
        FullName = "Họ và tên";
        Address = "Địa chỉ";
        Age = 0;
    }
    public void EnterData(){
        string? str;
        System.Console.Write("Full name = ");
        str = Console.ReadLine();
        if (str is null) FullName ="";
        else FullName = str;

        System.Console.Write("Address = ");
        str = Console.ReadLine();
        if (str is null) Address = "";
        else Address = str;
        
        System.Console.Write("Age = ");
        string? age = Console.ReadLine();
        if (sbyte.TryParse(age, out sbyte i)) Age = i;
        else Age=0;
    }
    public void Display(){
        System.Console.WriteLine("{0} - {1} - {2}",FullName,Address,Age);
    }
}