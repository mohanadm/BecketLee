using System.Collections.Generic;
using System.Threading.Tasks;
using BecketLee.ViewModels;

namespace BecketLee.Data
{
    public interface IPartnerRepository
    {
        IEnumerable<PartnerViewModel> GetAllPartners();
        PartnerViewModel GetPartnerByName( string name );
        string GetPartnerNameById( int id );
        Task<PartnerViewModel> UpdatePartnerAsync( PartnerViewModel model );

        void DeletePartnerBio( PartnerViewModel partnerBio );
        List<string> GetPartnerNames();
    }
}