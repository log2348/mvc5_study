using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCStudy.Models
{
    public class IndexModel
    {
        public int Id { get; set; }

        public string Name { get; set; }    

        /// <summary>
        /// 과일목록
        /// </summary>
        public List<string> FruitList { get; set; }


    }
}