using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApplication.Data
{
    public class ToDoItem
    {
        [Key]
        public string ID { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Boolean Done { get; set; }
        public DateTime EntryDate { get; set; }
       
    }
}
