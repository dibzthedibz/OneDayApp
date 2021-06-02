using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDay.Models
{
    public class CommentCreate
    {
        [Required]
        [MinLength(1, ErrorMessage = "Please enter at least one character in your comment.")]
        [MaxLength(160, ErrorMessage = "Your comment was too long, please keep comments under 160 chars.")]
        public string Text { get; set; }
    }
}
