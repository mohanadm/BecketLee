using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BecketLee.Models;
using BecketLee.ViewModels;

namespace BecketLee.Data
{
    public class PartnerRepository : RepostitoryDataBase<PartnerViewModel>, IPartnerRepository
    {
        public PartnerRepository( BecketLeeContext context ) 
            : base( context )
        {
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
                } ).OrderBy( p => p.PartnerId );
        }

        public PartnerViewModel GetPartnerByName( string name )
        {
            return _context.PartnerBiographies
                .Select( p =>
                    new PartnerViewModel()
                    {
                        PartnerId = p.PartnerId,
                        PartnerName = p.PartnerName,
                        BiographyHtml = WebUtility.HtmlDecode( p.BiographyHtml ),
                        FileName = p.FileName,
                        FileUrl = p.FileUrl
                    } )
                .FirstOrDefault( p =>
                    p.PartnerName.Equals( name, StringComparison.CurrentCultureIgnoreCase ) );
        }


        public string GetPartnerNameById( int id )
        {
            return _context.PartnerBiographies
                .FirstOrDefault( p => p.PartnerId == id ).PartnerName;
        }

        public async Task<PartnerViewModel> UpdatePartnerAsync( PartnerViewModel model )
        {
            PartnerBiography partner = new PartnerBiography();
            if (model.PartnerId > 0)
                partner = _context.PartnerBiographies.FirstOrDefault( p => p.PartnerId == model.PartnerId );

            partner.PartnerName = model.PartnerName;
            partner.BiographyHtml = WebUtility.HtmlEncode( model.BiographyHtml );
            partner.FileName = model.FileName;
            partner.FileUrl = model.FileUrl;

            if (partner.PartnerId > 0)
                _context.Update( partner );
            else
                _context.Add( partner );

            await _context.SaveChangesAsync( true );

            var newModel = new PartnerViewModel()
            {
                PartnerId = partner.PartnerId,
                PartnerName = partner.PartnerName,
                BiographyHtml = WebUtility.HtmlDecode( partner.BiographyHtml ),
                FileName = partner.FileName,
                FileUrl = partner.FileUrl
            };
            return newModel;
        }

        public void DeletePartnerBio( PartnerViewModel partnerBio )
        {
            var partner = _context.PartnerBiographies.FirstOrDefault( p => p.PartnerId == partnerBio.PartnerId );
            _context.Remove( partner );
            _context.SaveChanges();
        }

        public List<string> GetPartnerNames()
        {
            return _context.PartnerBiographies.Select( p => p.PartnerName ).ToList();
        }
    }
}