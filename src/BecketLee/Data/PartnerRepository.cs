using System.Collections.Generic;
using System.Linq;
using BecketLee.Models;

namespace BecketLee.Data
{
    public class PartnerRepository : RepositoryBase<PartnerBiography>
    {
        public PartnerRepository( BecketLeeContext context ) 
            : base( context )
        {
        }

        public override IEnumerable<PartnerBiography> Get()
        {
            return _context.PartnerBiographies.ToList();
        }


    }
}