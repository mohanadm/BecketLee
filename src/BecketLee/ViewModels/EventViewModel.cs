using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BecketLee.Models;
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

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
       
        [Display(Name = "Event Type")]
        public EventType EventType { get; set; }

        [Required]
        public List<SelectListItem> EventTypes { get; set; }

        public string Action
        {
            get
            {
                switch (EventType.EventTypeId)
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
                switch (EventType.EventTypeId)
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