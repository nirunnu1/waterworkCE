using System.Data.Entity;
using waterwork.Models;

namespace waterwork
{
    public class AssetDbContext : DbContext
    {
        public AssetDbContext()
            : base()
        {
            Database.SetInitializer<AssetDbContext>(new CreateDatabaseIfNotExists<AssetDbContext>());
            Database.SetInitializer<AssetDbContext>(new MigrateDatabaseToLatestVersion<AssetDbContext, ConfigurationAssetDbContext>(true));
            //Database.Connection.ConnectionString = @"workstation id=waterwork.mssql.somee.com;packet size=4096;user id=nirunnu1_SQLLogin_1;pwd=nbu88xrhaj;data source=waterwork.mssql.somee.com;persist security info=False;initial catalog=waterwork";
           // Database.Connection.ConnectionString = @"Server=127.0.0.1;Database= waterwork ;User Id = sa ;Password=123456;";
            Database.Connection.ConnectionString = @"Server=DESKTOP-HFL5E6G;Database=waterwork;Integrated Security=yes;";

        }
        public DbSet<customers> customers { get; set; }
        public DbSet<customer_services> customer_services { get; set; }
        public DbSet<bill_Water_usage> bill_Water_usage { get; set; }
        public DbSet<Water_usage> Water_usage { get; set; }
        public DbSet<Createinvoiceperiods> Createinvoiceperiods { get; set; }
        public DbSet<place> place { get; set; }
        public DbSet<amphur> amphur { get; set; }
        public DbSet<province> province { get; set; }


    }
}