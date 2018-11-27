namespace Shopping.Domain.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Shopping.Domain.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<Shopping.Domain.Concetre.DemoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Concetre.DemoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var category = new Category[]
              {
            new Category{CategoryName ="Category 1"},
            new Category{CategoryName ="Category 2"},
            new Category{CategoryName ="Category 3"},
            new Category{CategoryName ="Category 4"},
            new Category{CategoryName ="Category 5"},


              };
            foreach (Category c in category)
            {
                context.Categories.AddOrUpdate(c);
            }
            context.SaveChanges();
        }
    }
}
