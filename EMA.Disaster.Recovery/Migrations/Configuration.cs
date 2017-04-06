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

             //Seed data for address table 
            context.CountyMunicipalities.AddOrUpdate(x => x.ID,
                new CountyMunicipality { ID = 1, County = "Master", Municipality = "Master"},
                new CountyMunicipality { ID = 2, County = "Allegheny", Municipality = "Pittsburgh" },
                new CountyMunicipality { ID = 2, County = "Allegheny", Municipality = "Tarentum" }
                );           
            
            //Seed data for LocationType
            context.SBALocationType.AddOrUpdate(x => x.ID,
                new SBALocationType { ID = 1, Name = "Single Family"},
                new SBALocationType { ID = 2, Name = "Multiple Family" },
                new SBALocationType { ID = 3, Name = "Business" },
                new SBALocationType { ID = 4, Name = "NonProfit" },
                new SBALocationType { ID = 5, Name = "Other" }
                );

            //Seed data for address table 
            context.Addresses.AddOrUpdate(x => x.ID,
                new Address { ID = 1, CountyMunicipality = context.CountyMunicipalities.Find(1), StreetAddress = "2 Master Way", City = "Master", State = "Master", Zip = "123123", Longitude = 12312312, Lattitude = 12312312 }
                );

            //Seed data for contacts table 
            context.Contacts.AddOrUpdate(x => x.ID,
                new Contact { ID = 1, Address = context.Addresses.Find(1), FirstName = "Master", LastName = "Master", Phone = "1231234123", Phone2 = "1231234123", Email = "Master" }
                );



            //Seed data for IndividualSystemDamage
            context.IndividualSystemDamages.AddOrUpdate(x => x.ID,
               new IndividualSystemDamages { ID = 1, IndividualWorksheet = context.IndividualWorksheet.Find(1), IsMaster = true, System = "Foundation", PropertyType = "Home", PercentReplacementCost = 7 },
               new IndividualSystemDamages { ID = 2, IndividualWorksheet = context.IndividualWorksheet.Find(1), IsMaster = true, System = "Floor", PropertyType = "Home", PercentReplacementCost = 16 },
               new IndividualSystemDamages { ID = 3, IndividualWorksheet = context.IndividualWorksheet.Find(1), IsMaster = true, System = "Floor", PropertyType = "Mobile Home", PercentReplacementCost = 20 },
               new IndividualSystemDamages { ID = 4, IndividualWorksheet = context.IndividualWorksheet.Find(1), IsMaster = true, System = "Exterior Walls", PropertyType = "Home", PercentReplacementCost = 14 },
               new IndividualSystemDamages { ID = 5, IndividualWorksheet = context.IndividualWorksheet.Find(1), IsMaster = true, System = "Exterior Walls", PropertyType = "Mobile Home", PercentReplacementCost = 35 },
               new IndividualSystemDamages { ID = 6, IndividualWorksheet = context.IndividualWorksheet.Find(1), IsMaster = true, System = "Roof", PropertyType = "Home", PercentReplacementCost = 9 },
               new IndividualSystemDamages { ID = 7, IndividualWorksheet = context.IndividualWorksheet.Find(1), IsMaster = true, System = "Roof", PropertyType = "Mobile Home", PercentReplacementCost = 20 },
               new IndividualSystemDamages { ID = 8, IndividualWorksheet = context.IndividualWorksheet.Find(1), IsMaster = true, System = "Interior Walls", PropertyType = "Home", PercentReplacementCost = 28 },
               new IndividualSystemDamages { ID = 9, IndividualWorksheet = context.IndividualWorksheet.Find(1), IsMaster = true, System = "Interior Walls", PropertyType = "Mobile Home", PercentReplacementCost = 25 },
               new IndividualSystemDamages { ID = 10, IndividualWorksheet = context.IndividualWorksheet.Find(1), IsMaster = true, System = "Plumbing", PropertyType = "Home", PercentReplacementCost = 10 },
               new IndividualSystemDamages { ID = 11, IndividualWorksheet = context.IndividualWorksheet.Find(1), IsMaster = true, System = "Heating AC", PropertyType = "Home", PercentReplacementCost = 10 },
               new IndividualSystemDamages { ID = 12, IndividualWorksheet = context.IndividualWorksheet.Find(1), IsMaster = true, System = "Electrical", PropertyType = "Home", PercentReplacementCost = 6 }
               );

            //Seed data for IndividualWorksheet master records
            context.IndividualWorksheetDamage.AddOrUpdate(x => x.ID,
                new IndividualWorksheetDamage
                { ID = 1, IndividualWorksheet = context.IndividualWorksheet.Find(1), PropertyType = "Master", DamageCategory = "Master", Damaged = true, EstReplacementCost = 122, EstStructuralDamage = 232, EstDamageToContents = 76, EstTotalDamage = 234 }
                );

            //Seed data for IndividualWorksheet master records
            context.IndividualWorksheet.AddOrUpdate(x => x.ID,
                new IndividualWorksheet
                { ID = 1, Contact = context.Contacts.Find(1), Code = 999, LocationNotes = "MasterDependency", PrimaryHome = true, Renter = false, Comments = "Master", FloodInsurance = true, BasementWater = 3, FirstFloorWater = 2, WaterHeight = 2, AdditionalComments = "Master", AccessorName = "Master", Date = "Master", IndividualWorksheetDamage = context.IndividualWorksheetDamage.Find(1) }
                );
        }
    }
}
