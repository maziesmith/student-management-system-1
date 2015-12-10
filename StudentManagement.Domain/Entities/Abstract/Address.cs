using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Domain.Entities.Abstract
{
   public enum AddressType
   {
      Mailing,
      Physical
   }

   public class Address
   {
      public AddressType AddressType { get; set; }
      public string AddressLine1 { get; set; }
      public string AddressLine2 { get; set; }
      public string City { get; set; }
      public string County { get; set; }
      public string State { get; set; }
      public string ZipCode { get; set; }
   }
}
