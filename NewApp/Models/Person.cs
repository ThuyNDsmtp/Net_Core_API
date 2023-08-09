using System.Collections;

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
    public void AddNewPerson(ArrayList psList)
    {
        Person ps = new Person();
        ps.EnterData();
        psList.Add(ps);
    }
    public void EditPerson(ArrayList pList,string fullName){
        foreach(Person ps in pList){
            if (ps.FullName == fullName){
                 
            System.Console.WriteLine("Edit person: "+ps.FullName);
            System.Console.Write("Enter new [full name] of the person: ");
            ps.FullName=Console.ReadLine();
            
            System.Console.Write("Eneter new [Address] of the person: ");
            ps.Address=Console.ReadLine();
            
            System.Console.Write("Enter new [Age] of the person: ");
            sbyte.TryParse(Console.ReadLine(),out sbyte age);
            ps.Age=age;
            }
        }
       
    }
    public void DeletePerson(ArrayList pList,string fullName){
        int count = 0;
        foreach(Person p in pList){
            if(p.FullName == fullName){
                pList.Remove(p);
                count++;
            }
        }
        System.Console.WriteLine($"Deleted {count} persons with name is {fullName}.");
    }
}