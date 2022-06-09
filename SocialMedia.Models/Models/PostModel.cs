using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class PostModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public virtual List<Comment> Comments {get; set;}
        public virtual List<Like> Likes {get; set;}
    }