using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Person
    {
        public required string PersonId {get;set;}
        [MaxLength(60)]
        
        public string? FullName {get;set;}
        public string? Address {get;set;}
    }
}