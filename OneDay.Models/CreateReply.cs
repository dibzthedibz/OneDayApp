using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDay.Models
{
    public class CreateReply
    {
        [Required]
        [MinLength(1, ErrorMessage = "Please enter at least one character")]
        [MaxLength(150, ErrorMessage = "Max 150 Characters")]
        public string Text { get; set; }

    }
}
