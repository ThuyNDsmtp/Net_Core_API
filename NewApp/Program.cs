using System.Collections;
using NewApp.Models;
public class Program{
        public static void Main(){
                System.Console.OutputEncoding = System.Text.Encoding.Unicode;
                System.Console.InputEncoding = System.Text.Encoding.Unicode;

                System.Console.Write("Nhập số lượng person = ");
                string? str=Console.ReadLine();
                int.TryParse(str,out int n);
                if (n <= 0) {
                        System.Console.WriteLine("Cần nhập một số nguyên dương.");
                        System.Environment.Exit(1);
                }

                ArrayList pList = new ArrayList(n);
                for (int i = 0; i < n; i++){
                        Person p = new();
                        p.AddNewPerson(pList);
                }
            System.Console.WriteLine("-------------------------------------------------------------");
                System.Console.WriteLine("List of persons entered:");
                for(int i=0; i<n;i++){
                        (pList[i] as Person).Display();
                }
        System.Console.WriteLine("-------------------------------------------------------------");
                //Thêm
                System.Console.WriteLine("Enter new person:");
                    (pList[0] as Person).AddNewPerson(pList);
System.Console.WriteLine("List of persons:");
                for(int i=0; i<n;i++){
                        (pList[i] as Person).Display();
                }

                //Sửa
                System.Console.Write("Enter person name for edit: ");
                string pName=Console.ReadLine();
                foreach(Person pe in pList){
                        if(pe.FullName==pName){
                                pe.EditPerson(pList,pName);
                        }
                }
                System.Console.WriteLine("List of persons:");
                for(int i=0; i<n;i++){
                        (pList[i] as Person).Display();
                }


                
        }
}
