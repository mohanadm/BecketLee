using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BecketLee.ViewModels
{
    public class EventViewModel
    {
        public int EventId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [StringLength(8000, MinimumLength = 10)]
        [Display(Name = "Event (formatted)")]
        public string EventHtml { get; set; }

        [Required]
        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
       
        public List<SelectListItem> EventTypes { get; set; }

        [Required]
        [Range( 1, 4, ErrorMessage = "You must select a valid Event Type.")]
        public int EventTypeId { get; set; }
        public string EventTypeDescription { get; set; }

        public string Action
        {
            get
            {
                switch (EventTypeId)
                {
                    case 1:
                        return "News";
                    case 2:
                        return "Events";
                    case 3:
                        return "Pubs";
                    case 4:
                        return "Cases";
                    default:
                        return "Index";
                }
            }
        }

        public string Controller
        {
            get
            {
                switch (EventTypeId)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        return "Events";
                    default:
                        return "App";
                }
            }
        }
    }
}