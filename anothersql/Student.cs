using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace anothersql
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    public class StudentDBContext : DbContext
    {
        public StudentDBContext() : base("name=MyDBConnectionString")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}