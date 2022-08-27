using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TSEventApp.Web.Models
{
    public class EventViewModel:BaseViewModel
    {
        [Display(Name = "Book Title")]
        [Required(ErrorMessage = "Please enter book title.")]
        public string Title { get; set; }

        [Display(Name = "Book Title")]
        [Required(ErrorMessage = "Please enter book title.")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name = "Book location")]
        [Required(ErrorMessage = "Please enter book location.")]
        [StringLength(50)]
        public string Location { get; set; }

        [Display(Name = "Book start time")]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        [Display(Name = "Book Type")]
        [Required(ErrorMessage = "Please enter book type.")]
        [StringLength(50)]
        public string Type { get; set; }

        [Display(Name = "Duration In Hours")]
        [Range(1, 4, ErrorMessage = " Duration should be 1-4 hours only")]
        public int? DurationInHours { get; set; }

        [Display(Name = "Book Description")]
        [StringLength(50)]
        public string Description { get; set; }

        [Display(Name = "Book Details")]
        [StringLength(500)]
        public string OtherDetails { get; set; }

        [Display(Name = "Invitees by email")]
        public string InviteByEmail { get; set; }

        [Display(Name = "Organiser")]
        [Required(ErrorMessage = "Please Enter your name")]
        public string Organiser { get; set; }

        [ForeignKey("EventId")]
        public ICollection<CommentViewModel> Comments { get; set; }
    }
}
