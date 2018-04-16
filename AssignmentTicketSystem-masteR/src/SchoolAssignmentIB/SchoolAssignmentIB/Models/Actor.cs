using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApi.Models
{
    public class Actor
    {
        public int ActorID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string FamousMovie { get; set; }
        public int Salary { get; set; }
    }
}
