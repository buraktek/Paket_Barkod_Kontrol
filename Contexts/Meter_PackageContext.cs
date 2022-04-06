using System;
using System.Data.Entity;
using System.Linq;

namespace Paket_Barkod_Kontrol
{
    public class Meter_PackageContext : DbContext
    {
        // Your context has been configured to use a 'Meter_Package' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Paket_Barkod_Kontrol.Meter_Package' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Meter_Package' 
        // connection string in the application configuration file.
        public Meter_PackageContext()
            : base("name=Meter_Package")
        {
        }
        
        public DbSet<Package> packages { get; set; }

    }

}