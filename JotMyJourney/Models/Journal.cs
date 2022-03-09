using System;
using System.ComponentModel.DataAnnotations;

namespace JotMyJourney.Models
{
    public class Journal: BaseModel
    {
        [Display(Name = "Date")]
        [Required]
        public DateTime Date { get; set; }
        [Display(Name = "Title")]
        [Required]
        public string Title { get; set; }
        [Display(Name = "Content")]
        public string Content { get; set; }
    }
}
