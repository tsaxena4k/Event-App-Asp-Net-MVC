using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TSEventApp.Web.Models
{
    public class CommentViewModel
    {
        [ForeignKey("Event")]
        public int EventId { get; set; }

        [Required(ErrorMessage = "Please write a comment before posting")]
        public string comment { get; set; }

        public DateTime timeStamp { get; set; }

        public EventViewModel _Event { get; set; }

        public CommentViewModel()
        {
            timeStamp = DateTime.Now;
        }
    }
}
