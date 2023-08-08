public class Student
{
    public string FullName;
    public string Address;
    public int Birthday;
    public Student(string fullName,string address,int birthday){
        FullName = fullName;
        Address = address;
        Birthday = birthday;
    }
    public void Rename(string newName){
        FullName = newName;
    }
    public int BirthYear(){
        return (DateTime.Now.Year - Birthday);
    }
    public void Display(){
        System.Console.WriteLine("Full name is {0}, Address is {1}, Age is {2}",FullName,Address,BirthYear());
    }
}