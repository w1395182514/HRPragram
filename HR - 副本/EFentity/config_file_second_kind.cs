﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFentity
{
    public class config_file_second_kind
    {
        [Key]
        public int fsk_id { get; set; }

        public int first_kind_id { get; set; }

        public string first_kind_name { get; set; }

        public int second_kind_id { get; set; }

        public string second_kind_name { get; set; }

        public string second_salary_id { get; set; }

        public string second_sale_id { get; set; }
    }
}
