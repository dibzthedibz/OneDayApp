using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDay.Data
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public Guid AuthorId { get; set; }

        //[ForeignKey(nameof("Post"))]
        //public int PostId { get; set; }
        //public Post Post { get; set; }
        //public virtual List<Reply> Replies { get; set; }


    }
}
