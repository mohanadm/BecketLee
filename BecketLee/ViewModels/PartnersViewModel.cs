using System.Collections.Generic;
using BecketLee.Models;

namespace BecketLee.ViewModels
{
    public class PartnersViewModel
    {
        public IEnumerable<PartnerViewModel> Partners { get; set; }
        public DeletionModel DeletionModel { get; set; } = new DeletionModel();
    }
}