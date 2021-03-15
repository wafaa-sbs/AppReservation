using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using reservationApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace reservationApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        private readonly DbContextOptions _options;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            _options = options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<ReservationModel> Reservations { get; set; }
        public DbSet<StudentModel> Students { get; set; }
        public DbSet<TypeReservationModel> TypeReservation { get; set; }
        public DbSet<reservationApp.Models.ReservationViewModel> ReservationViewModel { get; set; }
    }
}
