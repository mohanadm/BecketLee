﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BecketLee.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        [Required]
        [StringLength(8000, MinimumLength = 10)]
        public string EventHtml { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;        
        public int EventTypeId { get; set; }

        [NotMapped]
        public int EventTypeDescription { get; set; }
    }
}