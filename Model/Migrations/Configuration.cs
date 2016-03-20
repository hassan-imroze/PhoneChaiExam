namespace Model.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Model.BusinessDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Model.BusinessDBContext context)
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

            context.Phones.Add(new Phone
            {
                ID = Guid.NewGuid().ToString(),
                Name = "My Nokia",
                Brand = "Nokia",
                Camera = "2MP",
                Cpu = "1GHz",
                Memory = "512MB",
                Price = 20.0,
                Resolution = "640*320",
                Size = "4inch"
            });

            context.Phones.Add(new Phone
            {
                ID = Guid.NewGuid().ToString(),
                Name = "Samsung S5",
                Brand = "Samsung",
                Camera = "2MP",
                Cpu = "1GHz",
                Memory = "512MB",
                Price = 20.0,
                Resolution = "640*320",
                Size = "4inch"
            });
        }
    }
}
