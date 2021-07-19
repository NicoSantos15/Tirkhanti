using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Tirkhanti_R12.Data;
using Tirkhanti_R12.Models;

namespace Tirkhanti_R12.Data
{
    public class Tirkhanti_R12Context : IdentityDbContext<Tirkhanti_R12Users>
    {
        public Tirkhanti_R12Context(DbContextOptions<Tirkhanti_R12Context> options)
            : base(options)
        {
        }

        public DbSet<Emotions> Emotion { get; set; }
        public DbSet<StudentReport> StudentReport { get; set; }
        public DbSet<Tirkhanti_R12Users> R12Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Emotions>().ToTable("Emotion");
            builder.Entity<StudentReport>().ToTable("StudentReport");
            builder.Entity<EmergencyContact>().ToTable("EmergencyContact");
        }
    }
}
