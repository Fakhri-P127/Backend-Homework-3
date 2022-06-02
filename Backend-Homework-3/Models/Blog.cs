using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Homework_3.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Comments { get; set; }
        public DateTime PostTime  { get; set; }

        public string Title { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }
    }
}
