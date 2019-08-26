using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity.ExeConfig
{
  public  class file_second_kindConfig : EntityTypeConfiguration<file_second_kind>
    {
        public file_second_kindConfig()
        {
            this.ToTable(nameof(file_second_kind));
            this.Property(e => e.first_kind_id).IsRequired();
            this.Property(e => e.first_kind_name).HasMaxLength(60).IsRequired();
            this.Property(e => e.second_kind_id).IsRequired();
            this.Property(e => e.second_kind_name).HasMaxLength(60).IsRequired();
            this.Property(e => e.second_salary_id).HasMaxLength(60).IsRequired();
            this.Property(e => e.second_sale_id).HasMaxLength(60).IsRequired();
        }
    }
}
