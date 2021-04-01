using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
   public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [Display(Name = "Your Category")]
        public string Name { get; set; }
        [Required]
        public DateTimeOffset CreateUtc { get; set; }
        [Required]
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
