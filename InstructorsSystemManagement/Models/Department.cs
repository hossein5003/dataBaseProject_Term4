﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Department
    {
        public Guid Id { get; set; }
        [Key]
        public string Name { get; set; }
        [Required]
        public string Building { get; set; }
    }
}
