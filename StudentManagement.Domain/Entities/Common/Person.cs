using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Domain.Entities.Common
{
   public enum PersonTitle
   {
      Mr,
      Ms,
      Mrs
   }

   public enum PersonGender
   {
      Male,
      Female
   }

   public abstract class Person
   {
      public PersonTitle Title { get; set; }
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public DateTime DateOfBirth { get; set; }
      public PersonGender Gender { get; set; }
   }
}
