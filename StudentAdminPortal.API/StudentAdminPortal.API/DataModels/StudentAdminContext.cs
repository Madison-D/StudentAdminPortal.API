using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.DataModels
{
    //importing dbcontext
    public class StudentAdminContext : DbContext
    {
        //creating a constructor and passing dbcontextoptions of type student admin context and passing options to the base class
        public StudentAdminContext(DbContextOptions<StudentAdminContext> options): base(options)
        {

        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}
