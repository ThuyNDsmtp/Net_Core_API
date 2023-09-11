using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Employee:Person
    {
        public required string EmployeeId {get;set;}
        public int Age {get;set;}
    }
}