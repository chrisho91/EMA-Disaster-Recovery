using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using EMA.Disaster.Recovery.Models;

namespace EMA.Disaster.Recovery.DAL
{
    public class Context : DbContext
    {
        public Context() : base ("Context")
        {

        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<CountyMunicipality> CountyMunicipalities { get; set; }
        public DbSet<IndividualPhotos> IndividualPhotos { get; set; }
        public DbSet<IndividualWorksheet> IndividualWorksheet { get; set; }
        public DbSet<IndividualWorksheetDamage> IndividualWorksheetDamage { get; set; }
        public DbSet<SBALocationType> SBALocationType { get; set; }
        public DbSet<SBAEconInjurySurvey> SBAEconInjurySurvey { get; set; }
        public DbSet<SBAPhotos> SBAPhotos { get; set; }
        public DbSet<SBAPropertyMarketValue> SBAPropertyMarketValue { get;  set;}
        public DbSet<SBAWorksheet> SBAWorksheet { get; set; }
        public DbSet<IndividualSystemDamages> IndividualSystemDamages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); 
            //Setup one-to-many relationship between Individual Worksheet and Individual System Damages
            modelBuilder.Entity<IndividualSystemDamages>()
                .HasRequired(c => c.IndividualWorksheet)
                .WithMany(d => d.IndividualSystemDamages)
                .HasForeignKey(c => c.IndividualWorksheetID);

            // Configure the rlationship between the Individual Worksheet and the Individual Worksheet Damage
            modelBuilder.Entity<IndividualWorksheet>()
                .HasKey(t => t.IndividualWorksheetDamageID);

            modelBuilder.Entity<IndividualWorksheetDamage>()
                .HasRequired(t => t.IndividualWorksheet)
                .WithRequiredPrincipal();

            //// Configure the relationship between SBAWorksheet and SBAPropertyMarketValue
            //modelBuilder.Entity<SBAWorksheet>()
            //    .HasKey(t => t.ID);

            modelBuilder.Entity<SBAPropertyMarketValue>()
                .HasRequired(t => t.SBAWorksheet)
                .WithRequiredPrincipal();
        }

    }
}