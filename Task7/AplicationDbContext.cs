using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class AplicationDbContext : DbContext
    {

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Pupil> Pupils { get; set; }

        public DbSet<TeacherPupils> TeacherPupils { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=Task7;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=false");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher()
                {
                    TeacherId = 1,
                    FirstName = "nika",
                    LastName = "kaxadze",
                    Gender = "M",
                    Subject = "Math"
                },
                new Teacher()
                {
                    TeacherId = 2,
                    FirstName = "luka",
                    LastName = "maxadze",
                    Gender = "M",
                    Subject = "Historic"
                });
            modelBuilder.Entity<Pupil>().HasData(
                new Pupil()
                {
                    PupilId = 1,
                    FirstName = "giorgi",
                    LastName = "nikolaishvili",
                    Gender = "M",
                    Class = "10 Grade"
                },
                new Pupil()
                {
                    PupilId = 2,
                    FirstName = "mariam",
                    LastName = "vasadze",
                    Gender = "F",
                    Class = "9 Grade"
                });
            modelBuilder.Entity<TeacherPupils>().HasData(
               new TeacherPupils()
               {
                   Id = 1,
                   PupilId = 1,
                   TeacherId = 2,
               },
               new TeacherPupils()
               {
                   Id = 2,
                   PupilId = 1,
                   TeacherId = 1,
               });
               

        }
    }

}
