using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity
{
   public class file_first_kindConfig : EntityTypeConfiguration<file_first_kind>
    {
        public file_first_kindConfig()
        {
            this.ToTable(nameof(file_first_kind));
            this.Property(e => e.first_kind_id).IsRequired();
            this.Property(e => e.first_kind_name).HasMaxLength(60).IsRequired();
            this.Property(e => e.first_kind_salary_id).HasMaxLength(2).IsRequired();
            this.Property(e => e.first_kind_sale_id).HasMaxLength(60).IsRequired();
        }
    }
}
