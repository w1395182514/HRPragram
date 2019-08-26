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
        public DbSet<LoginModel> Student { set; get; }
        public DbSet<config_public_char> public_chars { set; get; }

        public DbSet<config_file_third_kind> config_file_third_kinds { set; get; }

        public DbSet<file_first_kind> file_first_kinds { set; get; }

        public DbSet<file_second_kind> file_second_kinds { set; get; }

        public DbSet<major_change> major_changes { set; get; }
    }
}
