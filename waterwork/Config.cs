using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace waterwork
{
    internal sealed class ConfigurationAssetDbContext : DbMigrationsConfiguration<AssetDbContext>
    {
        public ConfigurationAssetDbContext()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(AssetDbContext context)
        {
        }
    }
}