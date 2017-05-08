﻿
using System.ComponentModel.DataAnnotations;

namespace BecketLee.Models
{
    public class PartnerBiography
    {
        [Key]
        public int PartnerId { get; set; }
        public string PartnerName { get; set; }
        public string BiographyHtml { get; set; }
        public string FileUrl { get; set; }
        public string FileName { get; set; }
    }

}