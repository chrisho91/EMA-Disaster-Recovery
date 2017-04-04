using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EMA.Disaster.Recovery.Models;

namespace EMA.Disaster.Recovery.DAL
{
    public class DBInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            var addresses = new List<Address>
            {
                new Address { }
            };
            base.Seed(context);
        }
    }
}