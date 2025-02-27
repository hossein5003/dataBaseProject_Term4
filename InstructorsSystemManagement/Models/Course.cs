﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Course
    {
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Credits { get; set; }
        public string DeptName { get; set; }

        [ForeignKey("DeptName")]
        public Department? Department { get; set; }

        public IList<Instructor>? Instructors { get; set; } = new List<Instructor>();
    }
}
