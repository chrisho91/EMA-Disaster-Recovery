﻿
namespace EMA.Disaster.Recovery.Models
{
    public class Contact
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        
        public virtual Address Address { get; set; }
    }
}