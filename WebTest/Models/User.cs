using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest.Models
{
    public class User 
    {
        [Key]
        
        public int Id { get; set; }



        //[StringLength(10), MinLength(10)]

        public string Phone { get; set; }
        [Required]
        public string Name { get; set; }
        //public List<Message> Messages { get; set; } = new List<Message>();


    }
}
