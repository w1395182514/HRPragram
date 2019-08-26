using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.Entity.ModelConfiguration;

namespace EFentity.ExeConfig
{
    public class FirstKindConfig : EntityTypeConfiguration<config_file_first_kind>
    {
        public FirstKindConfig()
        {
            this.ToTable("config_file_first_kind");
            this.Property(e => e.first_kind_id).IsRequired();
            this.Property(e => e.first_kind_name).HasMaxLength(20).IsRequired();
            this.Property(e => e.first_kind_salary_id).HasMaxLength(20).IsRequired();
            this.Property(e => e.first_kind_sale_id).HasMaxLength(20).IsRequired();

        }
    }
}
