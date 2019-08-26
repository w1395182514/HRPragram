﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity.ExeConfig
{
   public class config_file_third_kindConfig : EntityTypeConfiguration<config_file_third_kind>
    {
        public config_file_third_kindConfig()
        {
            this.ToTable(nameof(config_file_third_kind));
            this.Property(e => e.first_kind_id).HasMaxLength(2).IsRequired();
            this.Property(e => e.first_kind_name).HasMaxLength(60).IsRequired();
            this.Property(e => e.second_kind_id).HasMaxLength(2).IsRequired();
            this.Property(e => e.second_kind_name).HasMaxLength(60).IsRequired();
            this.Property(e => e.third_kind_id).HasMaxLength(2).IsRequired();
            this.Property(e => e.third_kind_name).HasMaxLength(60).IsRequired();
            this.Property(e => e.third_kind_sale_id).HasMaxLength(60).IsRequired();
            this.Property(e => e.third_kind_is_retail).HasMaxLength(2).IsRequired();
        }
    }
}
