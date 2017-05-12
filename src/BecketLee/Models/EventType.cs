using System.ComponentModel.DataAnnotations;

namespace BecketLee.Models
{
    public class EventType
    {
        public int EventTypeId { get; set; }
        [Required]
        public string EventTypeDescription { get; set; }
    }
}