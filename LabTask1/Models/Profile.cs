using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabTask1.Models
{
    public class Profile
    {
        public string Name { get; set; }
        public string Dob { get; set; }
        public string Nationalities { get; set; }

        public string Bgroup { get; set; }

        public string Address { get; set; }

        public string Contact { get; set; }

        public string[] Hobbies { get; set; }
    }
}