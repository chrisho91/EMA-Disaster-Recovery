using System.ComponentModel.DataAnnotations;

namespace EMA.Disaster.Recovery.Models
{
    public class Address
    {
        [Key]
        public int ID { get; set; }
        public string StreetAddress { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public float Longitude { get; set; }
        public float Lattitude { get; set; }
        
        public virtual CountyMunicipality CountyMunicipality { get; set; }
    }
}