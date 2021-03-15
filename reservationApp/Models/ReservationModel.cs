using reservationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reservationApp.Models
{
    public class ReservationModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public string Cause { get; set; }

        public StudentModel Student { get; set; }
        public TypeReservationModel TypeReservation { get; set; }


    }
}
