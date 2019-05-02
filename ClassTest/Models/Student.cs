using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassTest.Models
{
    public class Student
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string Highest_Qualification { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Hobbies { get; set; }
    
    }
}
