using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMiniBoard.Models
{
    public class Board
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string State { get; set; }

        public string Writer { get; set; }

        public DateTime CreatedDate { get; set; }

        public string Content { get; set; }

        public int Views { get; set; }  

    }
}