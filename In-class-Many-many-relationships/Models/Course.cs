using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace In_class_Many_many_relationships.Models
{
    public class Courses
    {
        [Key]
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }

    }
}
