﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Model
{
    public class config_file_first_kindModel
    {
        public int ffk_id { get; set; }

        public int first_kind_id { get; set; }

        public string first_kind_name { get; set; }

        public string  first_kind_salary_id { get; set; }

        public string first_kind_sale_id { get; set; }
    }
}
