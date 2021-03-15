using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reservationApp.Models
{
    public class ReservationViewModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Cause { get; set; }
    }
}
