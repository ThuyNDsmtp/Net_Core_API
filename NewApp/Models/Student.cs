using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewApp.Models
{
    public class Student:Person
    {
        public string StudentCode { get; set; }
        public Student(){
            base.MemberwiseClone();
            StudentCode="";
        }
        public new void EnterData(){
            System.Console.Write("Nhập mã sinh viên: ");
            string? str = Console.ReadLine();
            if (str==null) StudentCode="";else StudentCode=str;
            base.EnterData();
        }
        public new void Display(){
            System.Console.WriteLine("Mã SV {0}, họ và tên SV {1}, địa chỉ SV {2}, tuổi SV {3}.",StudentCode,base.FullName,base.Address,base.Age);
        }
    }
}