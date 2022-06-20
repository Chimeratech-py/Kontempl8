using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class BlogPost
    {
        public int Id { get; set; }
        public int Title { get; set; }
        public string content { get; set; }
    }
}