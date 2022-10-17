using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMiniBoard.Models
{
    public class Reply
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public int BoardId { get; set; }

        public string Writer { get; set; }

        public string CreatedDate { get; set; }
    }
}