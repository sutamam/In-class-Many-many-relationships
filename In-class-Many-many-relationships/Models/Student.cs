using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace In_class_Many_many_relationships.Models
{
    public class Students
    {   
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }


    }
}
