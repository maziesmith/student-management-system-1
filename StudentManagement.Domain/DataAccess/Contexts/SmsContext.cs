using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Domain.Entities.Student;
using StudentManagement.Domain.Entities.CrossCutting;
//using StudentManagement.Domain.Migrations;

namespace StudentManagement.Domain.DataAccess.Contexts
{
   public class SmsContext : DbContext
   {
      public SmsContext() : base("StudentManagement")
      {
         
      }
      public DbSet<Student> Students { get; set; }
      public DbSet<Campus> Campuses { get; set; }
   }
}
