using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Domain.Entities.Abstract;

namespace StudentManagement.Domain.Entities.CrossCutting
{
   public class Campus
   {
      public int CampusId { get; set; }
      public string CampusName { get; set; }

      public Address Address { get; set; }
   }
}
