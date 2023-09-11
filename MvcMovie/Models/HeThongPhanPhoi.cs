using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace MvcMovie.Models
{
    public class HeThongPhanPhoi
    {
        [Key]
        public required string MaHTPP {get;set;}
        [Required]
        [MaxLength(60)]
        [MinLength(3)]
        public string? TenHTPP {get;set;}
    }
}