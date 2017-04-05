namespace EMA.Disaster.Recovery.Migrations
{
    using Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<EMA.Disaster.Recovery.DAL.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EMA.Disaster.Recovery.DAL.Context context)
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

            context.SBALocationType.AddOrUpdate(
                x => x.Name,
                new SBALocationType { ID = 1, Name = "Single Family"},
                new SBALocationType { ID = 2, Name = "Multiple Family" },
                new SBALocationType { ID = 3, Name = "Business" },
                new SBALocationType { ID = 4, Name = "NonProfit" },
                new SBALocationType { ID = 5, Name = "Other" }
                );
        }
    }
}
