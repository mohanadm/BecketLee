using System.Linq;
using System.Threading.Tasks;
using BecketLee.Models;

namespace BecketLee.Data
{
    public class BecketLeePartnerSeedData
    {
        public static async Task EnsurePartnerData(BecketLeeDbContext context)
        {            

            if (!context.PartnerBiographies.Any() ||
                 context.PartnerBiographies.Count() < 6)
            {
                // Clear content
                foreach (var partnerBiography in context.PartnerBiographies)
                    context.Remove( partnerBiography );
                if (context.ChangeTracker.HasChanges())
                    await context.SaveChangesAsync();

                // Add partners
                var bio = new PartnerBiography()
                {
                    PartnerName = "Gilbert B Weisman",
                    FileUrl = "/image/BioImage/Weisman_Gil.png",
                    FileName = "Weisman_Gil.png",
                    BiographyHtml = GilBio()
                };
                context.PartnerBiographies.Add( bio );

                bio = new PartnerBiography()
                {
                    PartnerName = "John D Sheehan",
                    FileUrl = "/image/BioImage/Sheehan_John.jpg",
                    FileName = "Sheehan_John.jpg",
                    BiographyHtml = JohnBio()
                };
                context.PartnerBiographies.Add(bio);

                bio = new PartnerBiography()
                {
                    PartnerName = "Sandra K Curtin",
                    FileUrl = "/image/BioImage/Curtin_Sandra.jpg",
                    FileName = "Curtin_Sandra.jpg",
                    BiographyHtml = SandraBio()
                };
                context.PartnerBiographies.Add(bio);

                bio = new PartnerBiography()
                {
                    PartnerName = "William J Becket",
                    FileUrl = "/image/BioImage/Becket_William.jpg",
                    FileName = "Becket_William.jpg",
                    BiographyHtml = WilliamBio()
                };
                context.PartnerBiographies.Add(bio);

                bio = new PartnerBiography()
                {
                    PartnerName = "Thomas A Lee III",
                    FileUrl = "/image/BioImage/Lee_Thomas.jpg",
                    FileName = "Lee_Thomas.jpg",
                    BiographyHtml = TomBio()
                };
                context.PartnerBiographies.Add(bio);

                bio = new PartnerBiography()
                {
                    PartnerName = "Alane A Becket",
                    FileUrl = "/image/BioImage/Alane2_2.8.jpg",
                    FileName = "Alane2_2.8.jpg",
                    BiographyHtml = AlaneBio()
                };
                context.PartnerBiographies.Add(bio);


                // Save 
                await context.SaveChangesAsync();
            }
        }

        private static string AlaneBio()
        {
            return @"&lt;p&gt;&lt;span style=&quot;font-size:12pt&quot;&gt;&lt;strong&gt;&lt;em&gt;Education:&amp;nbsp; &lt;/em&gt;&lt;/strong&gt;&lt;br /&gt;  College:&amp;nbsp; Pennsylvania State University (1987)&lt;br /&gt;  Law School:&amp;nbsp; Widener University School of Law (1992)&lt;/span&gt;&lt;/p&gt;    &lt;p&gt;&lt;span style=&quot;font-size:12pt&quot;&gt;&lt;strong&gt;&lt;em&gt;Bar Admissions:&lt;/em&gt;&lt;/strong&gt;&lt;em&gt;&amp;nbsp; &lt;/em&gt;&lt;br /&gt;  Pennsylvania (1992); New Jersey (1992); United States Supreme Court (2008)&lt;/span&gt;&lt;/p&gt;    &lt;p&gt;&lt;span style=&quot;font-size:12pt&quot;&gt;&lt;strong&gt;&lt;em&gt;Other Professional Affiliations:&lt;/em&gt;&lt;/strong&gt;&amp;nbsp;&lt;br /&gt;  American Bankruptcy Institute (ABI); National Association of Chapter 13 Trustees (NACTT); National Creditors Bar Association (NCBA, formerly NARCA); &lt;/span&gt; &lt;span style=&quot;font-size:11.0pt&quot;&gt;Pennsylvania Creditors Bar Association (PACBA)&lt;/span&gt;&lt;/p&gt;    &lt;p&gt;&lt;span style=&quot;font-size:12pt&quot;&gt;Ms. Becket joined Becket &amp;amp; Lee in 1991.&amp;nbsp; She is AV&amp;reg; rated by Martindale-Hubbell, the highest distinction available.&amp;nbsp; In addition to being a Managing Partner at Becket &amp;amp; Lee, focusing on client and industry relations, she specializes in litigation strategy, and has been lead counsel in some of the most successful and influential decisions on claim litigation in consumer cases over the last 20&amp;nbsp;years.&amp;nbsp;&lt;/span&gt;&lt;/p&gt;    &lt;p&gt;&lt;span style=&quot;font-size:12pt&quot;&gt;In 2009, Alane was elected to the Board of Directors of the ABI, where she served as Co-Chair of its Consumer Bankruptcy Committee from 2009 through 2011.&amp;nbsp; In 2014, she was elected to serve on ABI&amp;rsquo;s Executive Committee as Vice President of Publications. &amp;nbsp;In April 2018, Alane was elected President-Elect of ABI, until she assumes the role of President in April 2019.&amp;nbsp; In 2015, Alane was appointed to NCBA&amp;rsquo;s Board of Directors.&amp;nbsp; She was reelected to the NCBA Board in 2016, serving through 2018.&amp;nbsp; She currently Co-Chairs both the Bankruptcy Section and the Professional Standards and Grievance Committee.&lt;/span&gt;&lt;/p&gt;    &lt;p&gt;&lt;span style=&quot;font-size:12pt&quot;&gt;Alane has lectured extensively on consumer bankruptcy issues for a variety of professional organizations, including the ABI, the National Conference of Bankruptcy Judges, the Federal Judicial Conference, the NACTT, the Commercial Law League of America, NCBA, and a host of local and regional creditor organizations.&amp;nbsp; She has authored articles for many of the same organizations, as well as the Norton Institute on Bankruptcy Law.&amp;nbsp; Alane co-authored the revised edition of the ABI treatise &lt;em&gt;Consumer Bankruptcy:&amp;nbsp; Fundamentals of Chapter 7 and Chapter 13 of the U.S. Bankruptcy Code &lt;/em&gt;(Third Edition) and served as Editor of the Fourth Edition published in 2017.&amp;nbsp; Alane also served as Editor for the 2011, 2012 and 2013 editions of &lt;em&gt;The Best of ABI &amp;ndash; The Year in Consumer Bankruptcy. &lt;/em&gt;In 2016, &lt;em&gt;Collection Advisor &lt;/em&gt;magazine named her as one of the &amp;ldquo;25 Most Influential Women in Collections&amp;rdquo; in its September/October cover story.&amp;nbsp; In 2018, &lt;em&gt;Collection Advisor&lt;/em&gt; once again recognized Alane among her peers, this time in its September/October cover story on the &amp;ldquo;20 Most Powerful Women in Collections&amp;rdquo;. &lt;/span&gt;&lt;/p&gt;  ";
        }

        private static string TomBio()
        {
            return @"&lt;p&gt;&lt;strong&gt;Education:&lt;/strong&gt;&lt;br /&gt;  &amp;nbsp;&amp;nbsp;&amp;nbsp;&lt;strong&gt;College:&lt;/strong&gt;&amp;nbsp;Villanova University (1983)&lt;br /&gt;  &amp;nbsp;&amp;nbsp;&amp;nbsp;&lt;strong&gt;Law School:&lt;/strong&gt;&amp;nbsp;Villanova University School of Law (1986)&lt;/p&gt;    &lt;p&gt;&lt;strong&gt;Bar Admissions:&lt;/strong&gt;&lt;br /&gt;  New Jersey (1986); Pennsylvania (1986); and Florida (1991)&lt;/p&gt;    &lt;p&gt;&lt;strong&gt;Other Professional Affiliations:&lt;/strong&gt;&lt;br /&gt;  American Bankruptcy Institute (past Vice Chair of its Consumer Bankruptcy Committee); National Association of Bankruptcy Trustees; National Association of Chapter 13 Trustees; National Conference of Bankruptcy Clerks; Pennsylvania Bar Association; &lt;span style=&quot;font-size:11.0pt&quot;&gt;Pennsylvania Creditors Bar Association (PACBA)&lt;/span&gt;&lt;/p&gt;    &lt;p&gt;After law school, Mr. Lee spent two years practicing in the area of workers&amp;rsquo; compensation and other general practice matters in New Jersey. In 1988, he joined Milton Becket &amp;amp; Associates, which later became Becket &amp;amp; Lee. As a Managing Partner, Tom focuses on client and industry relations, internal operations, and analytics. Having represented creditors for over&amp;nbsp;30&amp;nbsp;years, Tom is a frequently requested speaker at bankruptcy seminars and conferences for bankruptcy professionals, as well as for bankers and collectors. He also works extensively with trustees and other industry professionals, providing his expertise on bankruptcy related projects of national significance.&lt;/p&gt;  ";
        }

        private static string WilliamBio()
        {
            return @"&lt;p&gt;&lt;strong&gt;Education:&lt;/strong&gt;&lt;br /&gt;  &amp;nbsp;&amp;nbsp;&amp;nbsp;&lt;strong&gt;College:&lt;/strong&gt;&amp;nbsp;Temple University (1990)&lt;br /&gt;  &amp;nbsp;&amp;nbsp;&amp;nbsp;&lt;strong&gt;Law School:&lt;/strong&gt;&amp;nbsp;Widener University School of Law (1995);&lt;em&gt;&amp;nbsp;&lt;br /&gt;  &amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&amp;nbsp;&lt;/em&gt;&lt;em&gt;Certificate of Achievement in Secured Transactions&lt;/em&gt;&lt;/p&gt;    &lt;p&gt;&lt;strong&gt;Bar Admissions:&lt;/strong&gt;&lt;br /&gt;  Pennsylvania (1995)&lt;/p&gt;    &lt;p&gt;&lt;strong&gt;Other Professional Affiliations:&lt;/strong&gt;&lt;br /&gt;  American Bankruptcy Institute; National Association of Chapter 13 Trustees (NACTT); &lt;span style=&quot;font-size:11.0pt&quot;&gt;Pennsylvania Creditors Bar Association (PACBA)&lt;/span&gt;&lt;/p&gt;    &lt;p&gt;Beginning in 1995, Mr. Becket has represented Becket &amp;amp; Lee&amp;rsquo;s clients in a variety of bankruptcy related litigation. His specialties include preference defense, automatic stay violation defense, student loan discharge defense, and representation of secured creditors in all aspects of consumer bankruptcy. Some of his significant cases include:&lt;/p&gt;    &lt;p&gt;&lt;em&gt;Howe v. Creditors Interchange Receivables Mgmt., LLC (In re Howe)&lt;/em&gt;, No. 09-0010, 2009 Bankr. LEXIS 2778 (Bankr. E.D. Pa. May 27, 2009) (finding that creditor bank falls outside the ambit of the federal Fair Debt Collection Practices Act and cannot be vicariously liable for acts of a debt collector).&lt;/p&gt;    &lt;p&gt;&lt;em&gt;Armstrong v. Access Group (In re Armstrong)&lt;/em&gt;, 394 B.R. 43 (Bankr. M.D. Pa. 2008) (denying, for failure to show undue hardship, the debtor a discharge of her student loans).&lt;/p&gt;    &lt;p&gt;&lt;em&gt;Rowell v. Chase Manhattan Auto. Fin. Corp. (In re Rowell)&lt;/em&gt;, 359 F. Supp. 2d 645 (W.D. Mich. 2004) (opining that a bank&amp;rsquo;s repossession of an automobile was not a violation of the automatic stay because the lender&amp;rsquo;s conduct was neither egregious nor intentional, given the questionable notice of the bankruptcy and the prompt return of the car to the debtor who could show no damages resulting from the temporary repossession).&lt;/p&gt;    &lt;p&gt;&lt;em&gt;MBNA Am. v. Locke (In re Greene)&lt;/em&gt;, 223 F.3d 1064 (9th Cir. 2000) (determining that debtors&amp;rsquo; payment to a credit card lender could not be avoided by the trustee because it was made outside the relevant statute&amp;rsquo;s ninety day time limit which was unaffected by extensions to such limits afforded in other contexts by bankruptcy&amp;rsquo;s procedural rules).&lt;/p&gt;    &lt;p&gt;&lt;em&gt;In re Patti&lt;/em&gt;, No. 98-17719DWS, 1999 Bankr. LEXIS 400 (Bankr. E.D. Pa. Apr. 15, 1999) (affording relief from the automatic stay to creditor who showed that the collateral was not necessary for the production of the debtor&amp;rsquo;s income).&lt;/p&gt;    &lt;p&gt;&lt;em&gt;In re Gates&lt;/em&gt;, 214 B.R. 467 (Bankr. D. Md. 1997) (denying a motion to reconsider an order allowing an oversecured (based on replacement value) claim in full, rather than in the amount of the trade-in value as asserted by the debtor).&lt;/p&gt;  ";
        }


        private static string SandraBio()
        {
            return @"&lt;p&gt;&lt;strong&gt;Education:&lt;/strong&gt;&lt;br /&gt;  &amp;nbsp;&amp;nbsp;&amp;nbsp;&lt;strong&gt;College:&lt;/strong&gt;&amp;nbsp;Michigan State University (1984)&lt;br /&gt;  &amp;nbsp;&amp;nbsp;&amp;nbsp;&lt;strong&gt;Law School:&lt;/strong&gt;&amp;nbsp;Thomas M. Cooley Law School (1988)&lt;/p&gt;    &lt;p&gt;&lt;strong&gt;Bar Admissions:&lt;/strong&gt;&lt;br /&gt;  Pennsylvania (1988); New Jersey (1988)&lt;/p&gt;    &lt;p&gt;&lt;strong&gt;Other Professional Affiliations:&lt;/strong&gt;&lt;br /&gt;  American Bankruptcy Institute; National Association of Chapter 13 Trustees (NACTT); &lt;span style=&quot;font-size:11.0pt&quot;&gt;Pennsylvania Creditors Bar Association (PACBA)&lt;/span&gt;&lt;/p&gt;    &lt;p&gt;Ms. Curtin joined Becket &amp;amp; Lee in March 1989. She is AV rated by Martindale-Hubbell, the highest distinction available. After several years litigating non-dischargeability, preference, and automatic stay actions, Sandy became the lead liaison to one of Becket &amp;amp; Lee&amp;rsquo;s largest clients, overseeing all aspects of the relationship, including security, operational processes, audit and compliance, and litigation strategy. Sandy&amp;rsquo;s longstanding tenure with the firm and her thorough understanding of the minute details of both Becket &amp;amp; Lee&amp;rsquo;s process and the client&amp;rsquo;s internal systems have been instrumental in meeting the client&amp;rsquo;s expectations for highest standards of representation.&lt;/p&gt;  ";
        }

        private static string JohnBio()
        {
            return @"&lt;p&gt;&lt;strong&gt;Education:&lt;/strong&gt;&lt;br /&gt;  &amp;nbsp;&amp;nbsp;&amp;nbsp;&lt;strong&gt;College:&lt;/strong&gt;&amp;nbsp;Fairfield University (1987)&lt;br /&gt;  &amp;nbsp;&amp;nbsp;&amp;nbsp;&lt;strong&gt;Law School:&lt;/strong&gt;&amp;nbsp;Villanova University School of Law (1990)&lt;/p&gt;    &lt;p&gt;&lt;strong&gt;Bar Admissions:&lt;/strong&gt;&lt;br /&gt;  Pennsylvania (1990); New Jersey (1990)&lt;/p&gt;    &lt;p&gt;&lt;strong&gt;Other Professional Affiliations:&lt;/strong&gt;&lt;br /&gt;  Pennsylvania Bar Association; American Bankruptcy Institute (ABI); INSOL International; National Association of Chapter 13 Trustees (NACTT); &lt;span style=&quot;font-size:11.0pt&quot;&gt;Pennsylvania Creditors Bar Association (PACBA)&lt;/span&gt;&lt;/p&gt;    &lt;p&gt;Mr. Sheehan joined Becket &amp;amp; Lee in June 1990, where he spent his first years litigating all areas of consumer bankruptcy law on behalf of the firm&amp;rsquo;s creditor clients. John&amp;rsquo;s responsibilities as a lead liaison to one of Becket &amp;amp; Lee&amp;rsquo;s large national clients include managing all aspects of the relationship, including operational processes, litigation strategy, and compliance. Specializing in the claim sale and transfer process, John has overseen the implementation of new technology to streamline and automate the process while retaining the exceptional accuracy that Becket &amp;amp; Lee&amp;rsquo;s clients demand.&lt;/p&gt;    &lt;p&gt;John most recently spoke on issues related to the sale and servicing of unsecured debts in bankruptcy at the University of Texas Consumer Bankruptcy CLE (2008), the Federal Judicial Center Conference on Capital Markets (2008), and the ABI&amp;rsquo;s Annual Spring Meeting (2010).&lt;/p&gt;  ";
        }
        private static string GilBio()
        {
            return @"&lt;p&gt;&lt;strong&gt;Education:&lt;/strong&gt;&lt;br /&gt;  &amp;nbsp;&amp;nbsp;&amp;nbsp;&lt;strong&gt;College:&lt;/strong&gt;&amp;nbsp;Oberlin College (1984)&lt;br /&gt;  &amp;nbsp;&amp;nbsp;&amp;nbsp;&lt;strong&gt;Law School:&lt;/strong&gt;&amp;nbsp;University of the Pacific, McGeorge School of Law (1987)&lt;/p&gt;    &lt;p&gt;&lt;strong&gt;Bar Admissions:&lt;/strong&gt;&lt;br /&gt;  California (1987); Florida (1988); Pennsylvania (1990); New Jersey (1990); United States Supreme Court (2010); 4th Circuit Court of Appeals (2012); 8th Circuit Court of Appeals (2008); 9th Circuit Court of Appeals (2009); 10th Circuit Court of Appeals (2009)&lt;/p&gt;    &lt;p&gt;&lt;strong&gt;Other Professional Affiliations:&lt;/strong&gt;&lt;br /&gt;  American Bankruptcy Institute (ABI) and National Association of Chapter 13 Trustees (NACTT); &lt;span style=&quot;font-size:11.0pt&quot;&gt;Pennsylvania Creditors Bar Association (PACBA)&lt;/span&gt;&lt;/p&gt;    &lt;p&gt;&amp;nbsp;&lt;/p&gt;    &lt;p&gt;Mr. Weisman has specialized in non-dischargeability litigation since joining the firm in December 1990. More recently, Gil has focused his practice on litigation in Chapter 13 cases related to determination of plan payment amount after the 2005 amendments to the Bankruptcy Code. On this subject, he has also been lead counsel for parties or &lt;em&gt;amici curiae&lt;/em&gt; in several appellate level cases including at the 4th, 7th, 8th, 9th and 10th Circuit Courts of Appeal, as well as before other appellate courts throughout the country.&lt;/p&gt;    &lt;p&gt;Gil is a widely recognized leader in consumer bankruptcy litigation. He has spoken numerous times on Chapter 13 litigation and related issues to the NACTT, the ABI and state bar association groups, and has authored articles for &lt;em&gt;Norton Bankruptcy Law Adviser, NACTT Quarterly&lt;/em&gt; and the ABI&amp;rsquo;s Consumer Bankruptcy Committee newsletter.&lt;/p&gt;  ";
        }

    }
}