using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Letter { get; set; }
        public int UserId { get; set; }

        public User Person { get; set; }
    }
}
