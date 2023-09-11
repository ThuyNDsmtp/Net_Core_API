using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Person
    {
        [Key]
        public required string PersonId {get;set;}
        [Required]
        [MaxLength(60)]
        public string? FullName {get;set;}
        [MaxLength(100)]
        public string? Address {get;set;}
    }
}