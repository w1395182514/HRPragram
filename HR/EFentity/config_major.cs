using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace EFentity
{
    public class config_major
    {  
        [Key]
        public int mak_id { get; set; }  
        public String major_kind_id { get; set; }  
        public String major_kind_name { get; set; }  
        public String major_id { get; set; }  
        public String major_name { get; set; }  
        public int test_amount { get; set; } 
    }
}
