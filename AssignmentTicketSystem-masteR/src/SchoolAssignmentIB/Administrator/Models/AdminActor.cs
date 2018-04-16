using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Administrator.Models
{
    public class AdminActor
    {
        public int ActorID { get; set; }
        [Required(ErrorMessage = "This Field is required")]
        public string Name { get; set; }
        public int Age { get; set; }
        public string FamousMovie { get; set; }
        public int Salary { get; set; }
    }
}
