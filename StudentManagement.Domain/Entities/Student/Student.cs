using StudentManagement.Domain.Entities.Abstract;
using StudentManagement.Domain.Entities.CrossCutting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Domain.Entities.Student
{
   public class Student : Person
   {
      public int StudentId { get; set; }
      public string Grade { get; set; }

      public int CampusId { get; set; }
      public Campus Campus { get; set; }
      public IEnumerable<Address> Addresses { get; set; }
   }
}
