using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity
{
    public class config_major
    {
        [Key]
        public int mfk_id { get; set; }

        public int major_kind_id { get; set; }

        public string major_kind_name { get; set; }
    }
}
