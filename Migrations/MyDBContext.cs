using Migrations.DomainModels;
using Migrations.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() :base("name=myDBConStr")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MyDBContext, Configuration>("myDBConStr"));
        }

        public DbSet<User> Users { get; set; }
    }
}
