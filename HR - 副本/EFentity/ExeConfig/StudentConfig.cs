using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.Entity.ModelConfiguration;

namespace EFentity.ExeConfig
{
    public class StudentConfig : EntityTypeConfiguration<LoginModel>
    {
        public StudentConfig()
        {
            this.ToTable("Login");
            this.Property(e => e.Name).HasMaxLength(20).IsRequired();
        }
    }
}
