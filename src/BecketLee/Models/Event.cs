using System;
using System.ComponentModel.DataAnnotations;

namespace BecketLee.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        public string Title { get; set; }
        public string EventHtml { get; set; }
        public DateTime CreatedDate { get; set; }
        public int EventType { get; set; }
    }
}