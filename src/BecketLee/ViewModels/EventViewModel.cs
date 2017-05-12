using System;
using System.ComponentModel.DataAnnotations;
using BecketLee.Models;

namespace BecketLee.ViewModels
{
    public class EventViewModel
    {
        public int EventId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [StringLength(8000, MinimumLength = 10)]
        public string EventHtml { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public EventType EventType { get; set; }
    }
}