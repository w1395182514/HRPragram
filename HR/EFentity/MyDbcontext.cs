using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace EFentity
{
    public class MyDbcontext : DbContext
    {
        public MyDbcontext(): base("name=sql")
        {
            Database.SetInitializer<MyDbcontext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<config_public_char> config_public_chars { set; get; }
        public DbSet<config_major_kind> config_major_kinds { set; get; }
        public DbSet<config_major> config_majors { set; get; }
    }
}
