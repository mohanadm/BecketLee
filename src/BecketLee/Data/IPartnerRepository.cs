using System.Collections.Generic;
using BecketLee.ViewModels;

namespace BecketLee.Data
{
    public interface IPartnerRepository
    {
        IEnumerable<PartnerViewModel> GetAllPartners();
        PartnerViewModel GetPartnerByName( string name );
        PartnerViewModel UpdatePartner( PartnerViewModel model );

    }
}