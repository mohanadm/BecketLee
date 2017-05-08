using System;
using System.Collections.Generic;
using System.Linq;
using BecketLee.ViewModels;

namespace BecketLee.Data
{

    public interface IBecketLeeContextRepository
    {
        IEnumerable<PartnerViewModel> GetAllPartners();
        PartnerViewModel GetPartnerByName( string name );
    }



    public class BecketLeeRepository : IBecketLeeContextRepository
    {
        private BecketLeeContext _context;

        public BecketLeeRepository(BecketLeeContext context)
        {
            _context = context;
        }

        public IEnumerable<PartnerViewModel> GetAllPartners()
        {
            var partners = _context.PartnerBiographies.ToList();
            return partners.Select( p =>
                new PartnerViewModel()
                {
                    PartnerId = p.PartnerId,
                    PartnerName = p.PartnerName,
                    BiographyHtml = p.BiographyHtml,
                    FileName = p.FileName,
                    FileUrl = p.FileUrl
                } );
        }

        public PartnerViewModel GetPartnerByName( string name )
        {
            return GetAllPartners()
                .FirstOrDefault( p => 
                    p.PartnerName.Equals(name, StringComparison.CurrentCultureIgnoreCase) 
                );
        }

        public PartnerViewModel GetPartnerById( int id )
        {
            return GetAllPartners().FirstOrDefault( p => p.PartnerId == id );
        }
    }
}