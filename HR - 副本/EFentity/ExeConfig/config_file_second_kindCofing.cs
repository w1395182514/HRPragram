using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity.ExeConfig
{
    public class config_file_second_kindCofing: EntityTypeConfiguration<config_file_second_kind>
    {
        public config_file_second_kindCofing()
        {
            this.ToTable("config_file_second_kind");
            this.Property(e => e.first_kind_id).IsRequired();
            this.Property(e => e.first_kind_name).HasMaxLength(100).IsRequired();
            this.Property(e => e.second_kind_id).IsRequired();
            this.Property(e => e.second_salary_id).HasMaxLength(20).IsRequired();
            this.Property(e => e.second_sale_id).HasMaxLength(20).IsRequired();
            this.Property(e => e.second_kind_name).HasMaxLength(20).IsRequired();
        }
    }
}
