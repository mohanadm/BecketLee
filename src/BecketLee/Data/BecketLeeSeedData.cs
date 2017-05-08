using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BecketLee.Models;

namespace BecketLee.Data
{
    public class BecketLeeSeedData
    {
        private BecketLeeContext _context;

        public BecketLeeSeedData( BecketLeeContext context )
        {
            _context = context;
        }


        public async Task EnsurePartnerData()
        {
            if( !_context.PartnerBiographies.Any() )
            {
                var bio = new PartnerBiography()
                {
                    PartnerName = "Alane A Becket",
                    FileUrl = "/image/BioImage/Alane2_2.8.jpg",
                    FileName = "Alane2_2.8.jpg",
                    BiographyHtml = AlaneBio()
                };
                _context.PartnerBiographies.Add( bio );
                await _context.SaveChangesAsync();
            }
        }
        private static string AlaneBio()
        {
            var bioHtml = new StringBuilder();
            bioHtml.Append( "<p><strong>Education:</strong><br />& nbsp;&nbsp;&nbsp;" );
            bioHtml.Append(
                "<strong>College:</strong> &nbsp;Pennsylvania State University(1987) < br />& nbsp;&nbsp;&nbsp;" );
            bioHtml.Append( "<strong>Law School:</strong> &nbsp;Widener University School of Law(1992) </p>" );
            bioHtml.Append(
                "<p><strong> Bar Admissions:</strong><br />Pennsylvania(1992);New Jersey (1992);United States Supreme Court (2008) </p>" );
            bioHtml.Append(
                "<p><strong>Other Professional Affiliations:</strong><br />American Bankruptcy Institute( ABI );" );
            bioHtml.Append( "National Association of Bankruptcy Trustees;" );
            bioHtml.Append( "National Association of Chapter 13 Trustees(NACTT);" );
            bioHtml.Append( "National Creditors Bar Association (NARCA)</ p >" );
            bioHtml.Append( "<p>Ms.Becket joined Becket & amp; Lee in 1991.She is AV & reg;" );
            bioHtml.Append(
                "rated by Martindale - Hubbell, the highest distinction available. In addition to being a Managing Partner at Becket & amp;" );
            bioHtml.Append(
                "Lee, focusing on client and industry relations, she specializes in litigation strategy, and has been lead counsel in some of the most successful and influential decisions on claim litigation in consumer cases over the last 10 years.</ p >" );
            bioHtml.Append(
                "<p>In 2009, Alane was elected to the Board of Directors of the ABI, where she served as Co - Chair of its Consumer Bankruptcy Committee from 2009 through 2011.She is currently a member of ABI&#39;s Executive Board and was elected to serve as the ABI&#39;s Vice President of Publications in 2014. In 2015, Alane was appointed to NARCA&#39;s Board of Directors.</p>" );
            bioHtml.Append(
                "<p>Alane has lectured extensively on consumer bankruptcy issues for a variety of professional organizations, including the ABI, the National Conference of Bankruptcy Judges, the NACTT, the Commercial Law League of America, NARCA, and a host of local and regional creditor organizations.She has authored articles for many of the same organizations, as well as the Norton Institute on Bankruptcy Law.Most recently, Alane co - authored the revised edition of the ABI treatise < em > Consumer Bankruptcy: Fundamentals of Chapter 7 and Chapter 13 of the U.S.Bankruptcy Code </ em > (Third Edition), and has served as Editor for the 2011, 2012 and 2013 editions of < em > The Best of ABI & ndash; The Year in Consumer Bankruptcy.</ em ></ p >" );

            return bioHtml.ToString();
        }
    }
}