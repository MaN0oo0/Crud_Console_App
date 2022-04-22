using Demo.DAL.Etinties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Database
{
    public class ApplicationContext : DbContext
    {

        //public ApplicationContext()
        //{
        //    Student student = new Student();
        //    student.DateCreation = DateTime.Now;
        //}
        public DbSet<Student> std { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MOHAMMED\\SQLEXPRESS; database=Demo1; Integrated Security=true");
        }





    }
}
