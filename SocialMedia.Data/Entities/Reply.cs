using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

    public class Reply
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Comment))]
        public Comment CommentId { get; set; }
        [Required]
        public string Text { get; set; }
        
    }
