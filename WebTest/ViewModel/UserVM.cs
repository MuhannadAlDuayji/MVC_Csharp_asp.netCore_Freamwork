using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest.ViewModel
{
    public class UserVM
    {
        public string Name { get; set; }

        [StringLength(10), MinLength(10)]
        public string Phone { get; set; }
    }
}
