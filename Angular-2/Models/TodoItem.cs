using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Angular_2.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime? DueDate { get; set; }
        public int Priority { get; set; }
    }
}