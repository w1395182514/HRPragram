using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity.ExeConfig
{
    public class config_majorConfig : EntityTypeConfiguration<config_major>
    {
        public config_majorConfig()
        {
            this.ToTable("config_major");
        }
    }
}
