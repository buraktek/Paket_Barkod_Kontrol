namespace Paket_Barkod_Kontrol.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Paket_Barkod_Kontrol.Meter_PackageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Paket_Barkod_Kontrol.Meter_PackageContext";
        }

        protected override void Seed(Paket_Barkod_Kontrol.Meter_PackageContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
