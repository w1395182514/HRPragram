using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.Entity.ModelConfiguration;

namespace EFentity.ExeConfig
{
   public class public_charConfig:EntityTypeConfiguration<config_public_char>
    {
        public public_charConfig() {
            this.ToTable(nameof(config_public_char));
            this.Property(e => e.attribute_name).HasMaxLength(20).IsRequired();
            this.Property(e => e.attribute_kind).HasMaxLength(20).IsRequired();
        }
    }
}
