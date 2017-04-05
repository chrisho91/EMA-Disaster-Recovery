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

            //Seed data for LocationType
            context.SBALocationType.AddOrUpdate(
                x => x.Name,
                new SBALocationType { ID = 1, Name = "Single Family"},
                new SBALocationType { ID = 2, Name = "Multiple Family" },
                new SBALocationType { ID = 3, Name = "Business" },
                new SBALocationType { ID = 4, Name = "NonProfit" },
                new SBALocationType { ID = 5, Name = "Other" }
                );

            //Seed data for IndividualSystemDamage
            context.IndividualSystemDamages.AddOrUpdate(
               new IndividualSystemDamages { ID = 1, IndividualWorksheetID = 1, IsMaster = true, System = "Foundation", PropertyType = "Home", PercentReplacementCost = 7 },
               new IndividualSystemDamages { ID = 2, IndividualWorksheetID = 1, IsMaster = true, System = "Floor", PropertyType = "Home", PercentReplacementCost = 16 },
               new IndividualSystemDamages { ID = 3, IndividualWorksheetID = 1, IsMaster = true, System = "Floor", PropertyType = "Mobile Home", PercentReplacementCost = 20 },
               new IndividualSystemDamages { ID = 4, IndividualWorksheetID = 1, IsMaster = true, System = "Exterior Walls", PropertyType = "Home", PercentReplacementCost = 14 },
               new IndividualSystemDamages { ID = 5, IndividualWorksheetID = 1, IsMaster = true, System = "Exterior Walls", PropertyType = "Mobile Home", PercentReplacementCost = 35 },
               new IndividualSystemDamages { ID = 6, IndividualWorksheetID = 1, IsMaster = true, System = "Roof", PropertyType = "Home", PercentReplacementCost = 9 },
               new IndividualSystemDamages { ID = 7, IndividualWorksheetID = 1, IsMaster = true, System = "Roof", PropertyType = "Mobile Home", PercentReplacementCost = 20 },
               new IndividualSystemDamages { ID = 8, IndividualWorksheetID = 1, IsMaster = true, System = "Interior Walls", PropertyType = "Home", PercentReplacementCost = 28 },
               new IndividualSystemDamages { ID = 9, IndividualWorksheetID = 1, IsMaster = true, System = "Interior Walls", PropertyType = "Mobile Home", PercentReplacementCost = 25 },
               new IndividualSystemDamages { ID = 10, IndividualWorksheetID = 1, IsMaster = true, System = "Plumbing", PropertyType = "Home", PercentReplacementCost = 10 },
               new IndividualSystemDamages { ID = 11, IndividualWorksheetID = 1, IsMaster = true, System = "Heating AC", PropertyType = "Home", PercentReplacementCost = 10 },
               new IndividualSystemDamages { ID = 12, IndividualWorksheetID = 1, IsMaster = true, System = "Electrical", PropertyType = "Home", PercentReplacementCost = 6 }
               );
        }
    }
}
