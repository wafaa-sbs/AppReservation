using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reservationApp.Models
{
    public class StudentModel :IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Class { get; set; }
        public int RestCount { get; set; }

        
    }
}
