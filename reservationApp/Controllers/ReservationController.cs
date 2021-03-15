using Microsoft.AspNetCore.Mvc;
using reservationApp.Data;
using reservationApp.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace online_reservation.Controllers
{
    public class ReservationController : Controller
    {
        private readonly ApplicationDbContext _adb;

        public ReservationController(ApplicationDbContext adb)
        {
            _adb = adb;
        }
        
        public IActionResult Index()
        {
            /*var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);// will give the user's userId*/

            var result = (from r in _adb.Reservations
                          join s in _adb.Students
                          on r.Student.Id equals s.Id
                          join rt in _adb.TypeReservation
                          on r.TypeReservation.Id equals rt.Id
                          /*where r.Student.Id == userId*/
                          select new ReservationViewModel
                          {
                              Id = s.Id,
                              FirstName = s.FirstName,
                              LastName = s.LastName,
                              Email = s.Email,
                              Date = r.Date,
                              Name = rt.Name,
                          }).ToList();

            return View("index", result);
        }
    }
}
