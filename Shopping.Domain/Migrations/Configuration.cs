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
            //var category = new Category[]
            //  {
            //new Category{CategoryName ="Category 1"},
            //new Category{CategoryName ="Category 2"},
            //new Category{CategoryName ="Category 3"},
            //new Category{CategoryName ="Category 4"},
            //new Category{CategoryName ="Category 5"},


            //  };
            //foreach (Category c in category)
            //{
            //    context.Categories.AddOrUpdate(c);
            //}
            //context.SaveChanges();


            //var products = new Product[]
            //  {
            //new Product{ProductName ="Sach 1",Price = 10000,Amount = 3,Description ="Description 1",ProductImage="https://cdn.shopify.com/s/files/1/0686/5373/products/0_royal_LS_crew_760x.jpg?v=1461095700%27"},
            //new Product{ProductName ="Sach 2",Price = 10000,Amount = 3,Description ="Description 2",ProductImage="https://cdn.shopify.com/s/files/1/0686/5373/products/0_royal_LS_crew_760x.jpg?v=1461095700%27"},
            //new Product{ProductName ="Sach 3",Price = 10000,Amount = 3,Description ="Description 3",ProductImage="https://cdn.shopify.com/s/files/1/0686/5373/products/0_royal_LS_crew_760x.jpg?v=1461095700%27"},
            //new Product{ProductName ="Sach 4",Price = 10000,Amount = 3,Description ="Description 4",ProductImage="https://cdn.shopify.com/s/files/1/0686/5373/products/0_royal_LS_crew_760x.jpg?v=1461095700%27"},


            //  };
            //foreach (Product c in products)
            //{
            //    context.Products.AddOrUpdate(c);
            //}
            //context.SaveChanges();
        }
    }
}
