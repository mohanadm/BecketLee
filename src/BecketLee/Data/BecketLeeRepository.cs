using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using BecketLee.Models;
using BecketLee.ViewModels;

namespace BecketLee.Data
{

    public interface IBecketLeeContextRepository
    {
        IEnumerable<PartnerViewModel> GetAllPartners();
        PartnerViewModel GetPartnerByName( string name );
        PartnerViewModel UpdatePartner( PartnerViewModel model );
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
                    BiographyHtml = WebUtility.HtmlDecode( p.BiographyHtml ),
                    FileName = p.FileName,
                    FileUrl = p.FileUrl
                } );
        }

        public PartnerViewModel GetPartnerByName( string name )
        {
            var data = GetAllPartners()
                .FirstOrDefault( p => 
                    p.PartnerName.Equals(name, StringComparison.CurrentCultureIgnoreCase) 
                );
            return data;
        }

        public PartnerViewModel UpdatePartner( PartnerViewModel model )
        {
            PartnerBiography partner = new PartnerBiography();
            if( model.PartnerId > 0 )
                partner = _context.PartnerBiographies.FirstOrDefault( p => p.PartnerId == model.PartnerId );                

            partner.PartnerName = model.PartnerName;
            partner.BiographyHtml = WebUtility.HtmlEncode( model.BiographyHtml );
            partner.FileName = model.FileName;
            partner.FileUrl = model.FileUrl;

            if ( partner.PartnerId > 0 )
                _context.Update( partner );
            else
                _context.Add( partner );

            _context.SaveChanges(true);

            var newModel = new PartnerViewModel()
            {
                PartnerId = partner.PartnerId,
                PartnerName = partner.PartnerName,
                BiographyHtml = WebUtility.HtmlDecode( partner.BiographyHtml ),
                FileName = partner.FileName,
                FileUrl =  partner.FileUrl
            };
            return newModel;
        }
    }
}