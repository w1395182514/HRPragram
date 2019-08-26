using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity.ExeConfig
{
   public class major_changeConfig : EntityTypeConfiguration<major_change>
    {
        public major_changeConfig()
        {
            this.ToTable(nameof(major_change));
        }
    }
}
