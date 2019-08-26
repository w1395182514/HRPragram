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
        public MyDbcontext()
            : base("name=sql")
        {
            Database.SetInitializer<MyDbcontext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<LoginModel> Student { set; get; }
        public DbSet<config_file_first_kind> FristKinds { set; get; }
        public DbSet<config_file_second_kind> SecondKinds { set; get; }
        public DbSet<config_file_third_kind> ThirdKinds { set; get; }
    }
}
