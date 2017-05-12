
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BecketLee.Models
{
    public class PartnerBiography
    {
        [Key]
        public int PartnerId { get; set; }
        [DisplayName("Partner Name")]
        [Required]
        public string PartnerName { get; set; }
        [DisplayName( "Bio Information" )]
        [Required]
        public string BiographyHtml { get; set; }
        public string FileUrl { get; set; }
        public string FileName { get; set; }
    }

}