using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMA.Disaster.Recovery.Models
{
    public class Address
    {
        public int ID { get; set; }
        public int CountyMunicipalityID { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int Longitude { get; set; }
        public int Lattitude { get; set; }
        
        public virtual CountyMunicipality CountyMunicipality { get; set; }
    }
}