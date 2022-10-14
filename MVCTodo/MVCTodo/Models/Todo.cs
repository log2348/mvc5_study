using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTodo.Models
{
    public class Todo
    {
        public int Id { get; set; }

        public string Date { get; set; }

        public string Content { get; set; }

        public bool IsCompleted { get; set; } 

    }
}