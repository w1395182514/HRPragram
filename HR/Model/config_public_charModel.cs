using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class config_public_charModel
    {
        [Key]
        public int pbc_id { get; set; }
        public string attribute_kind { get; set; }
        public string attribute_name { get; set; }
    }
}
