namespace StudentManagement.Domain.Migrations
{
   using System;
   using System.Data.Entity;
   using System.Data.Entity.Migrations;
   using System.Linq;
   using StudentManagement.Domain.DataAccess.Contexts;

   internal sealed class Configuration : DbMigrationsConfiguration<SmsContext>
   {
      public Configuration()
      {
         AutomaticMigrationsEnabled = true;
         AutomaticMigrationDataLossAllowed = true;
      }

      protected override void Seed(SmsContext context)
      {
         //  This method will be called after migrating to the latest version.

         //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
         //  to avoid creating duplicate seed data. E.g.
         //
         //    context.People.AddOrUpdate(
         //      p => p.FullName,
         //      new Person { FullName = "Andrew Peters" },
         //      new Person { FullName = "Brice Lambson" },
         //      new Person { FullName = "Rowan Miller" }
         //    );
         //
      }
   }
}
