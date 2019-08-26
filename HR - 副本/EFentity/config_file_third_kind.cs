using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity
{
    public class config_file_third_kind
    {
        [Key]
        public int ftk_id { get; set; }
        public int first_kind_id { get; set; }
        public string first_kind_name { get; set; }
        public int second_kind_id { get; set; }
        public string second_kind_name { get; set; }
        public int third_kind_id { get; set; }
        public string third_kind_name { get; set; }
        public string third_kind_sale_id { get; set; }
        public int third_kind_is_retail { get; set; }
    }
}
