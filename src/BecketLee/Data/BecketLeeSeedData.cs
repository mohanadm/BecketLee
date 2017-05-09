using System.Linq;
using System.Net;
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


        public async Task EnsureBecketLeeSeedData()
        {
            await EnsurePartnerData();
            await EnsureEventTypeData();
        }

        public async Task EnsureEventTypeData()
        {
            if( !_context.EventTypes.Any() || _context.EventTypes.Count() < 3 )
            {
                // delete
                foreach (var eventType in _context.EventTypes)
                    _context.Remove( eventType );
                if(_context.ChangeTracker.HasChanges())
                    await _context.SaveChangesAsync();

                var eventTypeObject = new EventType() {EventTypeDescription = "News"};
                _context.EventTypes.Add( eventTypeObject );
                eventTypeObject = new EventType() { EventTypeDescription = "Events" };
                _context.EventTypes.Add( eventTypeObject );
                eventTypeObject = new EventType() { EventTypeDescription = "Pubs" };
                _context.EventTypes.Add( eventTypeObject );

                await _context.SaveChangesAsync();

            }
        }

        public async Task EnsurePartnerData()
        {
            if( !_context.PartnerBiographies.Any() ||
                 _context.PartnerBiographies.Count() < 2 )
            {
                // Clear content
                foreach (var partnerBiography in _context.PartnerBiographies)
                    _context.Remove( partnerBiography );
                if (_context.ChangeTracker.HasChanges())
                    await _context.SaveChangesAsync();

                // Add partners
                var bio = new PartnerBiography()
                {
                    PartnerName = "Alane A Becket",
                    FileUrl = "/image/BioImage/Alane2_2.8.jpg",
                    FileName = "Alane2_2.8.jpg",
                    BiographyHtml = WebUtility.HtmlEncode( AlaneBio() )
                };
                _context.PartnerBiographies.Add( bio );

                bio = new PartnerBiography()
                {
                    PartnerName = "Thomas Lee",
                    FileUrl = "/image/BioImage/Lee_Thomas.jpg",
                    FileName = "Lee_Thomas.jpg",
                    BiographyHtml = WebUtility.HtmlEncode( TomBio() )
                };
                _context.PartnerBiographies.Add( bio );

                // Save 
                await _context.SaveChangesAsync();
            }
        }

        private static string AlaneBio()
        {
            return
                "&lt;p&gt;&lt;strong&gt;Education:&lt;/strong&gt;&lt;br /&gt; &lt;strong&gt;&amp;nbsp;&amp;nbsp; College:&lt;/strong&gt; &amp;nbsp;Pennsylvania State University(1987)&lt;br /&gt; &amp;nbsp;&amp;nbsp; &lt;strong&gt;Law School:&lt;/strong&gt; &amp;nbsp;Widener University School of Law(1992)&lt;/p&gt; &lt;p&gt;&lt;strong&gt;Bar Admissions:&lt;/strong&gt;&lt;br /&gt; Pennsylvania(1992); &amp;nbsp;New Jersey (1992); &amp;nbsp;United States Supreme Court (2008)&lt;/p&gt; &lt;p&gt;&lt;strong&gt;Other Professional Affiliations:&lt;/strong&gt;&lt;br /&gt; American Bankruptcy Institute( ABI );National Association of Bankruptcy Trustees;National Association of Chapter 13 Trustees(NACTT);National Creditors Bar Association (NARCA)&lt;/p&gt; &lt;p&gt;Ms.Becket joined Becket &amp;amp; amp; Lee in 1991.She is AV &amp;amp; reg;rated by Martindale - Hubbell, the highest distinction available. In addition to being a Managing Partner at Becket &amp;amp; amp;Lee, focusing on client and industry relations, she specializes in litigation strategy, and has been lead counsel in some of the most successful and influential decisions on claim litigation in consumer cases over the last 10 years.&lt;/p&gt; &lt;p&gt;In 2009, Alane was elected to the Board of Directors of the ABI, where she served as Co - Chair of its Consumer Bankruptcy Committee from 2009 through 2011.She is currently a member of ABI&amp;#39;s Executive Board and was elected to serve as the ABI&amp;#39;s Vice President of Publications in 2014. In 2015, Alane was appointed to NARCA&amp;#39;s Board of Directors.&lt;/p&gt;  &lt;p&gt;Alane has lectured extensively on consumer bankruptcy issues for a variety of professional organizations, including the ABI, the National Conference of Bankruptcy Judges, the NACTT, the Commercial Law League of America, NARCA, and a host of local and regional creditor organizations.She has authored articles for many of the same organizations, as well as the Norton Institute on Bankruptcy Law.Most recently, Alane co - authored the revised edition of the ABI treatise Consumer Bankruptcy: Fundamentals of Chapter 7 and Chapter 13 of the U.S.Bankruptcy Code (Third Edition), and has served as Editor for the 2011, 2012 and 2013 editions of&amp;nbsp;&lt;em&gt;The Best of ABI&amp;nbsp;- The Year in Consumer Bankruptcy&lt;/em&gt;.&lt;/p&gt;"
                ;

        }

        private static string TomBio()
        {
            return string.Empty;
        }
    }
}