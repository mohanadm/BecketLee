using System;
using System.Linq;
using System.Threading.Tasks;
using BecketLee.Models;

namespace BecketLee.Data
{
    public class BecketLeeEventSeedData 
    {
        public static async Task EnsureEventData( BecketLeeContext context )
        {
            
            if (!context.Events.Any() || context.Events.Count() != 124)
            {
                // delete
                context.RemoveRange( context.Events );
                await context.SaveChangesAsync();

                var eventObj = new Event()
                {
                    Title = @"Alane Becket Chair of NARCA 2016 Fall Conference; Elected to Board of Directors",
                    CreatedDate = Convert.ToDateTime( "2016-11-04 07:58:37.3770000" ),
                    StartDate = Convert.ToDateTime( "2016-10-26 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2016-10-29 00:00:00.0000000" ),
                    EventTypeId = 1,
                    EventHtml = @"&lt;p&gt;Alane Becket was the conference Chair at the National Creditors Bar Association (NARCA) Fall Conference in Las Vegas from October 26-29, 2016. At the conference, Alane was elected to the Board of Directors for a two-year term.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = "Alane Becket Named Among \"25 Most Influential Women in Collections\"",
                    CreatedDate = Convert.ToDateTime( "2016-11-04 07:58:00.5970000" ),
                    StartDate = Convert.ToDateTime( "2016-11-04 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 1,
                    EventHtml = @"&lt;p&gt;The firm is pleased to report that Partner Alane Becket was named one of the &amp;quot;25 Most Influential Women in Collections&amp;quot; by Collection Advisor magazine and was featured on its September/October 2016 cover. The issue is available via Collection Advisor&amp;#39;s website at: &lt;a href=&quot;http://issuu.com/collectionadvisor/docs/collection_advisor_september_octobe?e=23956006/38860619&quot;&gt;http://issuu.com/collectionadvisor/docs/collection_advisor_september_octobe?e=23956006/38860619&lt;/a&gt;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Appointed to NARCA Board of Directors",
                    CreatedDate = Convert.ToDateTime( "2016-01-04 10:18:47.5730000" ),
                    StartDate = Convert.ToDateTime( "2016-01-04 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 1,
                    EventHtml = @"&lt;p&gt;Becket &amp;amp; Lee is pleased to announce Managing Partner Alane Becket was recently appointed to the Board of Directors of the National Creditor&amp;#39;s Bar Association (NARCA), formerly the National Association of Retail Collection Attorneys. Normally an elected position, Alane was selected by President Harvey Moore, to fill a vacant position. Alane has been named Co-Chair of the Professional Standards and Grievance Committee and Co-Chair of the Attorney Practicum Sub-Committee of the Education Committee. As a member of the Education Committee, Alane will focus on NARCA&amp;#39;s law practice educational content.&lt;/p&gt;

&lt;p&gt;Alane also serves on the Executive Committee of the American Bankruptcy Institute, where she is the Vice President of Publications, overseeing the monthly ABI Journal and the ABI&amp;#39;s roster of other bankruptcy books, available at &lt;a href=&quot;http://www.abi.org/bookstore&quot; target=&quot;bookstore&quot;&gt;http://www.abi.org/bookstore&lt;/a&gt;.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Named Executive Editor of ABI Journal",
                    CreatedDate = Convert.ToDateTime( "2012-10-11 16:34:03.8500000" ),
                    StartDate = Convert.ToDateTime( "2012-10-11 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 1,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket was recently appointed as Executive Editor of the American Bankruptcy Institute&amp;#39;s flagship publication, &lt;em&gt;ABI Journal.&lt;/em&gt; The &lt;em&gt;Journal&lt;/em&gt; is published 11 times annually and covers the entire range of insolvency issues, with articles written by some of the most knowledgeable professionals in the industry.&lt;/p&gt;

&lt;p&gt;Becket &amp;amp; Lee has been active in the ABI for over 20 years. Alane has served on the ABI&amp;#39;s Board of Directors since 2009. She has lectured at numerous ABI events and writes extensively for its publications. Her work has been featured in &lt;em&gt;ABI Journal&lt;/em&gt; and she most recently served as co-editor of the book &lt;em&gt;&amp;quot;ABI 2011: The Year in Consumer Bankruptcy&amp;quot;&lt;/em&gt; and authored &lt;em&gt;&amp;quot;Consumer Bankruptcy (Third Edition): Fundamentals of Chapter 7 and Chapter 13 of the U.S. Bankruptcy Code&amp;quot;.&lt;/em&gt;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L PCI Compliant",
                    CreatedDate = Convert.ToDateTime( "2011-11-16 18:26:49.7370000" ),
                    StartDate = Convert.ToDateTime( "2011-11-16 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 1,
                    EventHtml = @"&lt;p&gt;We are pleased to announce that Becket &amp;amp; Lee LLP is certified as compliant with the Payment Card Industry Data Security Standard. By achieving this important benchmark, we reaffirm our ongoing commitment to the security and integrity of all client data.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L Attorneys Receive Publication Award from ABI",
                    CreatedDate = Convert.ToDateTime( "2011-11-10 16:07:31.8100000" ),
                    StartDate = Convert.ToDateTime( "2011-10-14 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 1,
                    EventHtml = @"&lt;p&gt;On Friday, October 14, 2011, Partner Alane Becket and Associate William McNeal received special publication awards from the American Bankruptcy Institute at a luncheon held during the 85th Annual National Conference of Bankruptcy Judges. The awards were given in recognition of their extensive efforts on the recently revised edition of the ABI treatise Consumer Bankruptcy: &lt;em&gt;Fundamentals of Chapter 7 and Chapter 13 of the U.S. Bankruptcy Code &lt;/em&gt;(3d. Edition).&lt;/p&gt;

&lt;p&gt;Among other things, this revised edition covers the fundamentals of consumer bankruptcy proceedings under chapters 7 and 13 of the Code, including updated information on the changes in the law since BAPCPA. Moreover, it includes important information on today&amp;#39;s most litigated questions, such as issues surrounding applicable commitment periods in chapter 13 plans, projected disposable income, case conversion and exemptions. Finally, the book provides critical analyses of several new U.S. Supreme Court decisions, including &lt;em&gt;Lanning, Ransom, Espinosa and Milavetz.&lt;/em&gt;&lt;/p&gt;

&lt;p&gt;For more information on the publication, please visit &lt;a href=&quot;http://bookstore.abi.org/&quot;&gt;http://bookstore.abi.org/&lt;/a&gt;.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee Speaks to Visa Members",
                    CreatedDate = Convert.ToDateTime( "2011-11-08 18:28:13.5930000" ),
                    StartDate = Convert.ToDateTime( "2011-11-08 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 1,
                    EventHtml = @"&lt;p&gt;On March 22, 2011, Tom shared his expertise on the recent Supreme Court decisions impacting creditor recoveries in a bankruptcy webinar presented by Visa for its members.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Partner Alane Becket to Speak at the 18th Biennial Judge Joe Lee Bankruptcy Institute ",
                    CreatedDate = Convert.ToDateTime( "2017-06-07 18:43:12.8142057" ),
                    StartDate = Convert.ToDateTime( "2017-06-08 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2017-06-09 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;The 18th Biennial Judge Joe Lee Bankruptcy Institute will be held Thursday and Friday, June 8 &amp;amp; 9, 2017, in Lexington, Kentucky. Alane&amp;#39;s topic: &lt;em&gt;The CFPB Then and Now: What Bankruptcy Practitioners Need to Know.&lt;/em&gt;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Partner Alane Becket Attended NARCA 2017 Spring Conference ",
                    CreatedDate = Convert.ToDateTime( "2017-05-24 22:14:49.8591016" ),
                    StartDate = Convert.ToDateTime( "2017-05-17 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2017-05-20 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Alane Becket attended and spoke at the National Creditor&amp;#39;s Bar Association&amp;#39;s Spring Conference in Orlando, FL, May 17-20, 2017. Alane&amp;#39;s topic: &lt;em&gt;Bankruptcy 2017: Beyond the Basics&lt;/em&gt;, highlighting what&amp;#39;s new regarding bankruptcy. Alane discussed filing statistics, regulatory influences, major rule changes, and some of the hottest topics in bankruptcy litigation, including one of the most influential issues of the last 5 years: the intersection of the Bankruptcy Code and the FDCPA.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee to Attend the CRS Conference",
                    CreatedDate = Convert.ToDateTime( "2017-05-08 10:09:27.8000000" ),
                    StartDate = Convert.ToDateTime( "2017-05-10 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2017-05-12 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer will attend and exhibit at the annual Collections and Recovery Solutions Conference in Las Vegas, May 10-12, 2017. The conference offers B &amp;amp; L the opportunity to network at an exclusive gathering of industry professionals. This year Tom will lead a roundtable discussion, the topic: &lt;em&gt;Bankruptcy - Issues and Updates&lt;/em&gt;. This year, there are new bankruptcy rules scheduled to go into place December 1, 2017, making various changes to consumer bankruptcy practice, including shortening the time frame to file a proof of claim. On January 17, 2017, the Supreme Court of the United States heard arguments in &lt;em&gt;Midland Funding v. Aleida Johnson&lt;/em&gt; the ultimate disposition of this case will resolve the question of the treatment of out of statute debt in bankruptcy and, if ever, the FDCPA applies in bankruptcy matters. The roundtable will be an open discussion regarding these items and any other consumer bankruptcy issues.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Partner Alane Becket attended the ABI Spring Meeting",
                    CreatedDate = Convert.ToDateTime( "2017-05-08 10:06:44.2700000" ),
                    StartDate = Convert.ToDateTime( "2014-04-20 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2014-04-23 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Alane Becket attended the American Bankruptcy Institute&amp;#39;s Spring Meeting in Washington, DC April 20-23, 2017. ABI&amp;#39;s Annual Spring Meeting serves as the bankruptcy industry&amp;#39;s one-stop resource for premier networking and quality education. The Annual Spring Meeting includes inspiring keynote sessions, important networking events, and a variety of targeted education sessions. Alane is Vice President of Publications for the ABI.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L Represented at Tech Conferences",
                    CreatedDate = Convert.ToDateTime( "2017-05-05 09:54:08.1670000" ),
                    StartDate = Convert.ToDateTime( "2017-04-25 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2017-04-27 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Stu Cramer attended the EPIQ Systems User Conference in Kansas City, MO, April 18-21, 2017. The annual event enables Becket &amp;amp; Lee to stay abreast of various technological developments and tools accessible to bankruptcy practitioners.&lt;/p&gt;

&lt;p&gt;Stu also attended the Bankruptcy Software Specialists 33rd Annual Chapter 13 Bankruptcy Seminar in Orlando, FL, April 25-27, 2017.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Presented at the 43rd Annual SBLI Seminar",
                    CreatedDate = Convert.ToDateTime( "2017-04-05 10:48:46.4900000" ),
                    StartDate = Convert.ToDateTime( "2017-03-30 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2017-04-01 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;The 43rd Annual Southeastern Bankruptcy Law Institute Seminar was held in Atlanta, GA, March 30 - April 1, 2017. As in prior years, Partner Alane Becket spoke at the event, this time on the topic of the Consumer Financial Protection Bureau (&amp;quot;CFPB&amp;quot;). The CFPB is in the headlines almost every week. Its activities touch every aspect of consumer finance, from regulating consumer lenders, industry participants and even lawyers, to rulemaking, enforcement actions, consumer protection initiatives and education. This session covered what one needs to know about the CFPB as a bankruptcy practitioner, a lawyer, a consumer financial service provider, and a consumer.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"CBA Live 2017",
                    CreatedDate = Convert.ToDateTime( "2017-03-24 10:47:34.1830000" ),
                    StartDate = Convert.ToDateTime( "2017-04-02 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2017-04-05 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer will attend CBA LIVE 2017 in Grapevine, TX from April 2-5. CBA LIVE is an annual conference organized by the Consumer Bankers Association, which provides information across nine areas of retail banking. Becket &amp;amp; Lee will also exhibit at the conference.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee Represented Firm at Marketplace Lending Conference",
                    CreatedDate = Convert.ToDateTime( "2017-03-24 10:47:13.9130000" ),
                    StartDate = Convert.ToDateTime( "2017-03-06 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2017-03-07 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;On March 6 and 7, 2017, Tom Lee attended LendIt 2017 in New York City. The conference provided opportunities to meet decision-makers in the growing marketplace lending community, as Becket &amp;amp; Lee continues to expand in providing services to this sector.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Exhibited at DBA International 2017 Annual Conference",
                    CreatedDate = Convert.ToDateTime( "2017-02-20 10:59:47.1600000" ),
                    StartDate = Convert.ToDateTime( "2017-02-07 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2017-02-09 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer represented the firm at the 20th Annual DBA International Conference. The conference was held at the Aria Resort in Las Vegas from February 7-9, 2017. In addition to attending the conference, Becket &amp;amp; Lee also exhibited at the event.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Attended ABI Winter Leadership Conference",
                    CreatedDate = Convert.ToDateTime( "2017-01-06 12:04:34.5800000" ),
                    StartDate = Convert.ToDateTime( "2016-12-01 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2016-12-03 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket attended the American Bankruptcy Institute&amp;#39;s Winter Leadership Conference in Rancho Palos Verdes, CA, December 1-3, 2016.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Partners Alane Becket & Tom Lee Represented B&L at Annual Judges’ Conference",
                    CreatedDate = Convert.ToDateTime( "2016-11-04 07:54:09.9670000" ),
                    StartDate = Convert.ToDateTime( "2016-10-26 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2016-10-29 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Alane Becket and Tom Lee attended the National Conference of Bankruptcy Judges in San Francisco, CA from October 26-29, 2016. The innovative education program offered excellent networking opportunities; NCBJ typically attracts in excess of 1,500 bankruptcy professionals.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Attended the 36th Annual ABI Midwestern Bankruptcy Institute Conference",
                    CreatedDate = Convert.ToDateTime( "2016-11-04 07:52:26.5500000" ),
                    StartDate = Convert.ToDateTime( "2016-09-29 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2016-09-30 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket attended this annual conference held in Kansas City, Missouri, September 29-30, 2016. Alane participated in the Consumer Debate: &amp;quot;Resolved: An out-of-statute proof of claim violates the FDCPA,&amp;quot; along with Thad O. Bartholow of Kellett &amp;amp; Bartholow PLLC; Dallas.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Attended ABI Southwest Conference",
                    CreatedDate = Convert.ToDateTime( "2016-09-21 16:37:55.8830000" ),
                    StartDate = Convert.ToDateTime( "2016-09-12 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2016-09-12 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Alane Becket joined the American Bankruptcy Institute for the 23rd Annual Southwest Bankruptcy Conference in Las Vegas, September 10-12, 2016. Experienced practitioners and regional judges presented workshops on a variety of topics relating to both business and consumer bankruptcy. At the conference, Alane participated in the ABI&amp;#39;s &amp;quot;Great Debate&amp;quot; on the topic: &amp;quot;The filing of a Proof of Claim, for a debt on which the statute of limitations has run, is a violation of the FDCPA.&amp;quot;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended the 2016 Debt Connection Symposium and Expo",
                    CreatedDate = Convert.ToDateTime( "2016-09-21 16:37:36.0730000" ),
                    StartDate = Convert.ToDateTime( "2016-09-13 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2016-09-15 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer attended the 2016 Debt Connection Symposium &amp;amp; Expo in Tucson, AZ, September 13-15, 2016. The firm exhibited at this conference geared for collections, recovery, and debt sales professionals.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended the NABT 2016 Annual Convention",
                    CreatedDate = Convert.ToDateTime( "2016-09-21 16:37:14.1030000" ),
                    StartDate = Convert.ToDateTime( "2016-09-07 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2016-09-11 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee attended the annual meeting of the National Association of Bankruptcy Trustees in San Diego, September 7-11, 2016. This annual event enables Becket &amp;amp; Lee to interact with the Chapter 7 bankruptcy trustees, while staying current on bankruptcy developments.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended NACTT's Annual Conference Philadelphia",
                    CreatedDate = Convert.ToDateTime( "2016-08-03 15:36:35.3370000" ),
                    StartDate = Convert.ToDateTime( "2016-07-20 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2016-07-23 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partners Tom Lee, Alane Becket and Gil Weisman along with Operations Manager Stu Cramer attended the annual meeting of the National Association of Chapter 13 Trustees in Philadelphia, PA from July 20-23, 2016. On July 21, Gil participated in a panel discussion along with the Chapter 13 Standing Trustee for the District of Kansas, Jan M. Hamilton and Honorable Michael B. Kaplan, US Bankruptcy Judge for the District of New Jersey. Their topic: &lt;em&gt;Dischargeability Litigation: Defining fraud and examining discharge exceptions (other than student loans.)&lt;/em&gt;&lt;/p&gt;

&lt;p&gt;On July 22, Alane joined Chapter 13 Standing Trustee for the District of Nevada, Kathleen A. Leavitt along with attorneys Joann Needleman and Barbara A. Sinsley in a panel discussion, What does the CFPB have to do with bankruptcy? On July 23, Alane participated in a question and answer follow-up discussion, CFPB- Ask the Experts. Joining Alane in this session was Chapter 13 Standing Trustee for the Central District of California, Amrane Cohen, Joanne Needleman and Barbara A. Sinsley. Once again, Becket &amp;amp; Lee was a proud sponsor of the NACTT&amp;#39;s educational program.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended the 2015 Annual Ch. 7 Trustees’ Conference ",
                    CreatedDate = Convert.ToDateTime( "2016-08-03 15:30:11.8800000" ),
                    StartDate = Convert.ToDateTime( "2015-08-27 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2015-08-29 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee attended the annual meeting of the National Association of Bankruptcy Trustees in Chicago from August 27-29. The event is always a great occasion for Becket &amp;amp; Lee to interact with the trustees, while keeping informed on current bankruptcy issues.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Partner Alane Becket Chaired NARCA's 2016 Spring Litigation Boot Camp",
                    CreatedDate = Convert.ToDateTime( "2016-05-17 16:55:29.0370000" ),
                    StartDate = Convert.ToDateTime( "2016-05-07 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;On May 7, 2016, partner Alane Becket chaired the inaugural litigation Boot Camp at the Spring Conference of the National Creditors Bar Association (NARCA) in Chicago. The Boot Camp featured six segments designed to introduce young attorneys or those new to collection practice to various aspects of collections litigation. In addition to chairing this successful event, Alane presented the &amp;quot;Evidence Overview&amp;quot; block.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Exhibited at the CRS Conference",
                    CreatedDate = Convert.ToDateTime( "2016-05-17 16:55:11.1800000" ),
                    StartDate = Convert.ToDateTime( "2016-05-11 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2016-05-13 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer Cramer attended and exhibited at the annual Collections and Recovery Solutions Conference in Las Vegas, May 11-13, 2016. The conference offered B&amp;amp;L the opportunity to network at an exclusive gathering of industry professionals.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"ABI Spring Meeting 2016",
                    CreatedDate = Convert.ToDateTime( "2016-04-19 10:32:13.1630000" ),
                    StartDate = Convert.ToDateTime( "2016-04-14 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2016-04-17 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Managing Partner Alane Becket moderated a panel at the 34th Annual American Bankruptcy Institute Spring Meeting in Washington, D.C., from April 14-17, 2016. Alane was joined by the National Consumer Law Center&amp;#39;s John Rao and Jon Pearson from Ballard Spahr to discuss, &amp;quot;What is the CFBP, and Why Do I Care?&amp;quot;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Firm Represented at Tech Conferences",
                    CreatedDate = Convert.ToDateTime( "2016-04-19 10:29:43.7630000" ),
                    StartDate = Convert.ToDateTime( "2016-04-03 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2016-04-28 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Stu Cramer attended the EPIQ Systems User Conference in Sanibel Island, Florida from April 3-6, 2016. The annual event enables Becket &amp;amp; Lee to stay abreast of various technological developments and tools accessible to bankruptcy practitioners.&lt;/p&gt;

&lt;p&gt;Stu will also be attending the Bankruptcy Software Specialists&amp;#39; 32nd Annual Chapter 13 Bankruptcy Seminar in Chicago, IL, April 25-28, 2016.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Atteneded the 42nd Annual SBLI Seminar",
                    CreatedDate = Convert.ToDateTime( "2016-04-19 10:25:01.6130000" ),
                    StartDate = Convert.ToDateTime( "2016-03-31 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2016-04-02 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;The 42nd Annual Southeastern Bankruptcy Law Institute Seminar was held in Atlanta, GA, March 31 - April 2, 2016. Partner Alane Becket spoke on the topic &amp;quot;Hey, give me some, too! - Issues Regarding Claim Allowance,&amp;quot; along with Houston attorney Johnnie Patterson. In the months since the 11th Circuit&amp;#39;s decision in LVNV vs Crawford, proofs of claims have again taken center stage in consumer bankruptcy cases. This panel surveyed the post-Crawford claims litigation landscape, including the use and nuances of statutes of limitations, the availability of state and federal consumer protection statutes, and the use of defensive judicial doctrines. &amp;lt;/p&amp;gt;&amp;lt;p&amp;gt; The following week, Alane was in Atlanta presenting to the National Association of Bankruptcy Trustees, along with NABT Past President and Bankruptcy Judge James W. Boyd and former ABI President Richardo Kilpatrick and Judge, at a program entitled &amp;quot;Money for Nothing&amp;quot;, addressing challenges with creditor claims in chapter 7 cases.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L Attended CBA Live 2016",
                    CreatedDate = Convert.ToDateTime( "2016-03-30 13:49:52.4370000" ),
                    StartDate = Convert.ToDateTime( "2016-05-07 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2016-05-09 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer attended CBA LIVE 2016 in Phoenix, AZ from Mar. 7-9, 2016. CBA LIVE is an annual three-day conference organized by the Consumer Bankers Association, which provides information across nine areas of retail banking. Becket &amp;amp; Lee also exhibited at the conference.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket on Panel at Emory University Symposium",
                    CreatedDate = Convert.ToDateTime( "2016-03-03 15:18:17.4770000" ),
                    StartDate = Convert.ToDateTime( "2016-02-25 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket was invited to participate in a panel at the 13th Annual Emory Bankruptcy Developments Journal Symposium. The EBDJ is an annual event held at Emory University School of Law in Atlanta, GA. On February 25, 2016, Alane&amp;#39;s panel presented on the topic &amp;quot;Recent Developments in Bankruptcy Regulation: Mortgage Servicing Rules, the FDCPA, and the CFPB&amp;quot;.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Partner Alane Becket Speaks at the 5th Circuit Bankruptcy Bench-Bar Conference",
                    CreatedDate = Convert.ToDateTime( "2016-03-03 15:17:56.2300000" ),
                    StartDate = Convert.ToDateTime( "2016-02-24 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2016-02-26 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Alane Becket recently served on a panel discussion of Debt Collection and the Fair Debt at the 5th Circuit Bankruptcy Bench-Bar Conference, held in New Orleans, LA, February 24-26, 2016. This session, led by Judge Robert Drain, addressed one of the hottest issues in consumer bankruptcy; the question of what remedies are available for creditor misconduct, including actions under consumer financial protection statutes and the use of class actions in bankruptcy.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Firm Attended and Exhibited at DBA 2016",
                    CreatedDate = Convert.ToDateTime( "2016-02-24 16:02:29.3430000" ),
                    StartDate = Convert.ToDateTime( "2016-02-09 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2016-02-11 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Firm Attended and Exhibited at DBA 2016 Partner Tom Lee and Business Operations Analyst Stu Cramer represented represent the firm at the 19th Annual DBA International Conference. The conference was held at the Aria Resort in Las Vegas from February 9-11, 2016. The firm also exhibited at the event.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket elected to the Board of Directors for the American Bankruptcy Institute",
                    CreatedDate = Convert.ToDateTime( "2016-01-04 10:10:23.9800000" ),
                    StartDate = Convert.ToDateTime( "2009-04-24 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;During ABI&amp;#39;s 32nd Annual Spring Meeting, held April 24-27, 2009 in Washington, D.C, Alane Becket was elected to the Board of Directors for the American Bankruptcy Institute and Co-Chair of the ABI&amp;#39;s Consumer Bankruptcy Committee. Becket &amp;amp; Lee has been active in the ABI for almost 20 years and this appointment is the result of years of service to the ABI. Alane has distinguished herself as a speaker at ABI seminars and meetings, moderator of the Consumer Bankruptcy Committee&amp;#39;s list serve, Editor of the Consumer Committee&amp;#39;s Newsletter, columnist for the ABI Journal, Education Director for the Consumer Committee, and Editor of the Consumer Education Center on the ABI&amp;#39;s Website. It was her work ethic, presentation skills and organizational abilities, combined with her legal expertise, which caught the Board&amp;#39;s attention. Alane was asked to join the Board earlier this year and was officially approved by the President at the ABI&amp;#39;s Annual meeting last month.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Attended ABI's Annual Leadership Conference",
                    CreatedDate = Convert.ToDateTime( "2016-01-04 10:09:24.1600000" ),
                    StartDate = Convert.ToDateTime( "2015-12-03 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2015-12-05 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket attended the American Bankruptcy Institutes 27th Annual Winter Leadership Conference in Phoenix from December 3-5, 2015. The program features topics designed for consumer and business practitioners, as well as financial advisors.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"NARCA 2015 Fall Collection Conference",
                    CreatedDate = Convert.ToDateTime( "2015-11-19 10:14:08.1170000" ),
                    StartDate = Convert.ToDateTime( "2015-10-14 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2015-10-17 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket attended the National Association of Retail Collection Attorneys annual conference in Washington, DC from Oct. 14-17, 2015. Alane introduced Sam Gerdano, Executive Director of the American Bankruptcy Institute, speaking about how new household debt patterns, such as the rise in student load debt, predict what&amp;#39;s ahead for creditors, collectors and debt buyers . This was the ABI&amp;#39;s first presentation to NARCA.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee to Attended Debt Connection Symposium & Expo (DCS2015)",
                    CreatedDate = Convert.ToDateTime( "2015-09-18 10:03:06.6270000" ),
                    StartDate = Convert.ToDateTime( "2015-09-18 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer attended the 2015 Debt Connection Symposium &amp;amp; Expo in Austin, TX. The firm exhibited at this conference geared for collections, recovery, and debt sales professionals from creditors, healthcare, collection agencies, collection attorney firms, debt buyers, and related industry vendors.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee Attended 2015 National Conference of Bankruptcy Clerks ",
                    CreatedDate = Convert.ToDateTime( "2015-08-21 12:40:35.8300000" ),
                    StartDate = Convert.ToDateTime( "2015-08-10 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2015-08-13 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee represented Becket &amp;amp; Lee at the annual conference in Atlanta, Georgia from August 10-13, 2015. Participation in this conference provided Becket &amp;amp; Lee the opportunity to strengthen relationships with court personnel and improve communication on industry related issues.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket attended the 20th Annual Southeast Bankruptcy Workshop",
                    CreatedDate = Convert.ToDateTime( "2015-08-05 12:08:32.5630000" ),
                    StartDate = Convert.ToDateTime( "2015-07-23 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2015-07-26 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket attended and participated in a panel discussion at the ABI&amp;#39;s 20th Annual Southeast Bankruptcy Workshop in Florida from July 23-26, 2015. The panel topic, &amp;quot;What Is Hot in July Besides the Weather? Litigation in Consumer Cases&amp;quot;, focused on &lt;em&gt;Crawford v. LVNV Funding&lt;/em&gt; and related litigation, consumer protection (including the basics of credit reporting and regulatory actions), mortgage modifications, post-discharge actions, and the UST&amp;#39;s enforcement activities.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended NACTT's Annual Conference in Salt Lake City",
                    CreatedDate = Convert.ToDateTime( "2015-07-13 15:43:08.4930000" ),
                    StartDate = Convert.ToDateTime( "2015-07-01 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2015-07-04 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partners Alane Becket and Gil Weisman along with Business Operations Analyst Stu Cramer attended the annual meeting of the National Association of Chapter 13 Trustees in Salt Lake City, Utah from July 1-4, 2015. On July 3, Alane participated in a panel discussion of the recent Crawford v. LVNV Funding decision with Laurie Weatherford, Ch. 13 Trustee for the Middle District of Florida, and the Honorable Michael B. Kaplan, United States Bankruptcy Judge for the District of New Jersey (Trenton). Once again, Becket &amp;amp; Lee is was a proud sponsor of the NACTT&amp;#39;s educational program.&lt;/p&gt;

&lt;p&gt;The event provides Becket &amp;amp; Lee with opportunities to interact with the trustees, while staying abreast of issues impacting the bankruptcy process. The Firm&amp;#39;s participation in events of this nature demonstrates its commitment to providing its clients with comprehensive, informed representation that evolves with the changing legal and regulatory landscape.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Spoke at the 2015 NCCR Conference ",
                    CreatedDate = Convert.ToDateTime( "2015-06-09 18:10:52.4700000" ),
                    StartDate = Convert.ToDateTime( "2015-06-01 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2015-06-03 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;In 2014, the Eleventh Circuit Court of Appeals ruled that filing a claim in a bankruptcy case on out of statute debt is a violation of the FDCPA. At the 2015 NCCR Conference, Partner Alane Becket discussed the current status of Crawford, what is happening in other circuits, as well as the intersection of two laws: the FDCPA and the U.S. Bankruptcy Code. The conference was held June 1-3, 2015 in New Orleans.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Presented at NARCA Spring Conference",
                    CreatedDate = Convert.ToDateTime( "2015-05-19 14:03:07.7830000" ),
                    StartDate = Convert.ToDateTime( "2015-05-06 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2015-05-09 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket spoke at the National Association of Retail Collection Attorneys 2015 Spring Collection Conference in Nashville, TN (May 6-9, 2015). Alane&amp;#39;s Topic: &lt;em&gt;Determining Statute of Limitations; There is No &amp;quot;Easy Button&amp;quot;.&lt;/em&gt; Alane was joined by Joann Needleman, Esquire, Maurice &amp;amp; Needleman, P.C. and Barbara A. Sinsley, Esquire, Hudson Cook, LLP.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L Exhibited at CRS Conference",
                    CreatedDate = Convert.ToDateTime( "2015-05-19 14:02:23.2470000" ),
                    StartDate = Convert.ToDateTime( "2015-05-06 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2015-05-08 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer attended and exhibit at the annual Collections and Recovery Solutions conference in Las Vegas, May 6-8, 2015.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Stu Cramer Attended Tech Conference",
                    CreatedDate = Convert.ToDateTime( "2015-05-19 14:02:06.1730000" ),
                    StartDate = Convert.ToDateTime( "0215-04-22 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2015-04-24 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Stu Cramer attended the EPIQ Systems User Conference in Key West, Florida from April 22-24, 2015. The annual event enables Becket &amp;amp; Lee to stay abreast of various technological developments and tools accessible to bankruptcy practitioners.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"ABI Spring Meeting 2015",
                    CreatedDate = Convert.ToDateTime( "2015-04-17 16:19:51.9700000" ),
                    StartDate = Convert.ToDateTime( "2015-04-16 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2015-04-19 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Managing Partner Alane Becket attended the 33nd Annual American Bankruptcy Institute Spring Meeting in Washington, D.C., from April 16-19, 2015.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Presented at Southeastern Bankruptcy Law Institute Seminar",
                    CreatedDate = Convert.ToDateTime( "2015-04-01 17:13:53.4030000" ),
                    StartDate = Convert.ToDateTime( "2015-03-26 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2015-03-28 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket spoke at the 41st Annual SBLI Seminar in Atlanta (March 26-28, 2015) on the topic &lt;em&gt;Litigation: Complaint to Determine Dischargeability of Student Loan.&lt;/em&gt; The presentation covered the rules of evidence in a student loan hardship case, the legal basis for the complaint, the evidence necessary for trial, and other relative issues. Alane was joined by the Honorable William H. Brown.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Firm Attended CBA Live 2015",
                    CreatedDate = Convert.ToDateTime( "2015-04-01 17:13:17.7200000" ),
                    StartDate = Convert.ToDateTime( "2015-03-23 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2015-03-25 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer attended CBA LIVE 2015 in Orlando, FL (Mar. 23-25, 2015). CBA LIVE is an annual three-day conference organized by the Consumer Bankers Association, which provides information across nine areas of retail banking.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L Attended the 2015 Debt Buyers' Conference",
                    CreatedDate = Convert.ToDateTime( "2015-03-12 12:39:16.9870000" ),
                    StartDate = Convert.ToDateTime( "2015-02-03 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2015-02-05 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer attended the 18th Annual DBA International Conference at the Aria Resort in Las Vegas Feb. 3-5, 2015. The firm also exhibited at the event.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Moderated at ABI Event in March 2015",
                    CreatedDate = Convert.ToDateTime( "2015-03-12 12:38:22.4430000" ),
                    StartDate = Convert.ToDateTime( "2015-03-05 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2015-03-07 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket moderated a panel discussion of current consumer bankruptcy topics at the 39th Annual Alexander L. Paskay Memorial Bankruptcy Seminar in Tampa, Florida (Mar. 5-7, 2015). The session covered recent developments in the Eleventh Circuit, as well as other topics of regional and national importance. The panel included bankruptcy attorneys, as well as a Chapter 13 Trustee.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Invited to Testify on Bankruptcy Rules",
                    CreatedDate = Convert.ToDateTime( "2015-01-29 16:53:06.3000000" ),
                    StartDate = Convert.ToDateTime( "2015-01-23 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;On Friday, January 23, 2015, Alane Becket testified before the Federal Advisory Committee on Rules of Bankruptcy Procedure in Washington, D.C. regarding the proposed National Chapter 13 Plan Form. Alane testified in support of the adoption of a national form for Chapter 13 plans.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"ABA's Invitation to Alane Becket",
                    CreatedDate = Convert.ToDateTime( "2015-01-29 16:52:45.1430000" ),
                    StartDate = Convert.ToDateTime( "2015-01-10 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2015-01-13 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;The American Bar Association recently invited Partner Alane Becket to participate in a panel at its Annual Consumer Financial Services Winter Meeting. Alane&amp;#39;s presentation, entitled Proofs of Claim on Time-Barred Debt After Crawford, examined the Eleventh Circuit&amp;rsquo;s recent decision, including the legal and practical ramifications. The event was held in New Orleans from January 10-13, 2015.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket at NARCA 2014 Fall Conference",
                    CreatedDate = Convert.ToDateTime( "2014-12-01 12:22:59.5970000" ),
                    StartDate = Convert.ToDateTime( "2014-10-22 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2014-10-25 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket presented at the NARCA 2014 Fall Collection Conference in Las Vegas, which ran from October 22-25. Alane&amp;#39;s panel presentation, &amp;quot;Collection Litigation is NOT Scattershot Litigation&amp;quot;, discussed the term &amp;quot;Scattershot Litigation&amp;quot; as it is currently being used by the CFPB, along with an exploration of practical concerns involving application of the term. She was joined on the panel by attorneys Joann Needleman and Barbara Sinsley.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee Presented at FSCOR 2014",
                    CreatedDate = Convert.ToDateTime( "2014-12-01 12:22:36.0000000" ),
                    StartDate = Convert.ToDateTime( "2014-10-27 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2014-10-29 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer attended the 22nd Annual Financial Services Collections &amp;amp; Operational Risk Conference in Las Vegas. The conference was held October 27-29 and Tom spoke on the subject &amp;quot;Bankruptcy Claims Process - Today and Upcoming Changes&amp;quot;. The presentation included a discussion of the proposed chapter 13 national plan form; risk management issues related to consumer debt sales; and recent developments in the law.&lt;/p&gt;

&lt;p&gt;As in prior years, Becket &amp;amp; Lee also exhibited at the event.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended Judges' Conference",
                    CreatedDate = Convert.ToDateTime( "2014-10-13 12:20:48.0300000" ),
                    StartDate = Convert.ToDateTime( "2014-10-09 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2014-10-11 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;From October 8-11, 2014, Partners Alane Becket and Tom Lee represented the firm at the National Conference of Bankruptcy Judges in Chicago.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Participated in NARCA Webinar",
                    CreatedDate = Convert.ToDateTime( "2014-09-26 10:57:19.7030000" ),
                    StartDate = Convert.ToDateTime( "2014-09-23 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;On September 23, 2014, Partner Alane Becket led a NARCA-sponsored webinar entitled &amp;quot;What Collection Attorneys Need to Know When a Debtor Files for Bankruptcy&amp;quot;. The webinar examined areas of concern such as verification of bankruptcy status, managing pending litigation and garnishments, and the applicability of the FDCPA for bankruptcy-related acts.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended September Events",
                    CreatedDate = Convert.ToDateTime( "2014-09-12 10:13:18.3930000" ),
                    StartDate = Convert.ToDateTime( "2014-09-09 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2014-09-14 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Beginning September 9, 2014, Partner Tom Lee and Business Operations Analyst Stu Cramer attended the 2014 Debt Connection Symposium &amp;amp; Expo in Las Vegas. The firm also exhibited at this event.&lt;/p&gt;

&lt;p&gt;Partner Tom Lee then attended the Annual Meeting of the National Association of Bankruptcy Trustees in Salt Lake City, UT, which was held September 11-14, 2014.&lt;/p&gt;

&lt;p&gt;Both events represented great opportunities for the firm to interact with other industry and bankruptcy professionals.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L at July Events: NACTT and NCBC",
                    CreatedDate = Convert.ToDateTime( "2014-07-23 17:36:29.0900000" ),
                    StartDate = Convert.ToDateTime( "2014-07-15 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;In mid-July 2014, Partners Alane Becket, Tom Lee and Gil Weisman and Business Operations Analyst Stu Cramer attended the annual seminar of the National Association of Chapter 13 Trustees in Chicago. As in prior years, Becket &amp;amp; Lee was a proud sponsor of the NACTT&amp;#39;s educational program.&lt;/p&gt;

&lt;p&gt;Alane Becket was also invited to participate in a panel presentation entitled &amp;quot;Who Gets Undistributed Money in the Trustee&amp;#39;s Hands on Conversion and/or Dismissal?&amp;quot; Alane will be presenting along with the Honorable Brian Lynch from the Bankruptcy Court in Washington and Isabel Balboa, Chapter 13 Trustee from the District of New Jersey.&lt;/p&gt;

&lt;p&gt;Partner Tom Lee also represented the Firm at the National Conference of Bankruptcy Clerks in St. Louis, MO. Attending and participating in events such as these are an integral part of Becket &amp;amp; Lee&amp;#39;s continuing commitment to building and maintaining its relationships with bankruptcy professionals.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Invited to NARCA Spring 2014 Event",
                    CreatedDate = Convert.ToDateTime( "2014-05-20 15:45:29.1170000" ),
                    StartDate = Convert.ToDateTime( "2014-05-15 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2014-05-17 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket was invited to participate at the NARCA Annual Spring Conference in a panel discussion of &amp;quot;What Collection Attorneys Need to Know When a Debtor Files for Bankruptcy&amp;quot;. The session covered areas of particular concern such as verification of bankruptcy status, managing pending litigation and garnishments, and the applicability of the FDCPA for bankruptcy-related acts. The event was held May 15-17 in Miami Beach, FL.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Firm Exhibited at CRS 2014",
                    CreatedDate = Convert.ToDateTime( "2014-05-20 15:45:07.6400000" ),
                    StartDate = Convert.ToDateTime( "2014-05-07 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2014-05-09 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;From May 7-9, 2014, Partner Tom Lee and Business Operations Analyst Stu Cramer attended and exhibited at the annual Collections and Recovery Solutions conference in Las Vegas.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Managing Partner Attended Commercial Law League Event",
                    CreatedDate = Convert.ToDateTime( "2014-05-02 10:12:22.5070000" ),
                    StartDate = Convert.ToDateTime( "2014-04-24 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2014-04-26 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Managing Partner Tom Lee attended the Commercial Law League of America Annual Convention and Midwest Meeting. The event was held in Chicago April 24-26, 2014.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"ABI Spring Meeting 2014",
                    CreatedDate = Convert.ToDateTime( "2014-05-02 10:10:03.1300000" ),
                    StartDate = Convert.ToDateTime( "2014-04-24 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2014-04-27 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Managing Partner Alane Becket attended the 32nd Annual ABI Spring Meeting in Washington, D.C., which ran from April 24-27, 2014.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L at 9th Annual CCN Conference",
                    CreatedDate = Convert.ToDateTime( "2014-04-14 14:30:00.6400000" ),
                    StartDate = Convert.ToDateTime( "2014-04-02 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2014-04-04 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Business Operations Analyst Stu Cramer attended the Credit and Collection News 9th Annual Conference in Naples, FL from April 2-4, 2014.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"CBA Live 2014",
                    CreatedDate = Convert.ToDateTime( "2014-04-07 09:56:05.3200000" ),
                    StartDate = Convert.ToDateTime( "2014-03-31 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2014-04-02 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee attended CBA LIVE 2014 in National Harbor, MD, which ran from March 31-April 2, 2014. CBA LIVE is an annual three-day conference organized by the Consumer Bankers Association, which provides information across nine areas of retail banking.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Firm Exhibited at NCOR 2014",
                    CreatedDate = Convert.ToDateTime( "2014-04-07 09:55:44.7900000" ),
                    StartDate = Convert.ToDateTime( "2014-03-25 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Becket &amp;amp; Lee exhibited at the 18th Annual National Collections &amp;amp; Operational Risk Conference held in Miami Beach, FL in late-March 2014. Partner Tom Lee and Business Operations Analyst Stu Cramer also attended the event.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended Debt Buyers' Conference in February 2014",
                    CreatedDate = Convert.ToDateTime( "2014-02-17 17:12:41.5270000" ),
                    StartDate = Convert.ToDateTime( "2014-02-05 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2014-02-07 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer attended the 17th Annual DBA International Conference at the Aria Resort in Las Vegas, which ran from February 5-7, 2014. Becket &amp;amp; Lee also exhibited at the event.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Represented Firm at 2013 Annual Judges' Conference",
                    CreatedDate = Convert.ToDateTime( "2014-01-15 11:15:56.4700000" ),
                    StartDate = Convert.ToDateTime( "2013-10-30 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Beginning on October 30, 2013, Partner Alane Becket represented the firm at the National Conference of Bankruptcy Judges in Atlanta. Alane was asked by NCBJ President Judge Ray Mullins to serve on the Conference&amp;#39;s Education Committee, and she participated in a panel discussion about the new Chapter 13 Plan Form. Alane&amp;#39;s fellow panelists include Judge Rebecca Buehler Connelly, from the Western District of Virginia and Chapter 13 Trustee Margaret Burks. The session was moderated by Judge Eugene R. Wedoff, the incoming President of the NCBJ.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended FSCOR 2013",
                    CreatedDate = Convert.ToDateTime( "2013-10-25 17:00:33.1500000" ),
                    StartDate = Convert.ToDateTime( "2013-10-21 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer attended the 21st Annual Financial Services Collections &amp;amp; Operational Risk Conference in Chicago. The conference ran from October 21-23, 2013 and Becket &amp;amp; Lee exhibited at the event.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Presented at October Bankruptcy Events",
                    CreatedDate = Convert.ToDateTime( "2013-10-25 16:59:55.7930000" ),
                    StartDate = Convert.ToDateTime( "2013-10-16 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2013-10-19 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket presented at the NARCA 2013 Fall Collection Conference in Washington, DC. The conference ran from October 16-19. Alane&amp;#39;s presentation, &amp;quot;Bankruptcy Update: The National Chapter 13 Plan Form&amp;quot;, addressed the new requirements for Chapter 13 plans and the pending changes to the bankruptcy Rules, including how these changes will impact creditors.&lt;/p&gt;

&lt;p&gt;Alane also spoke on the subject of Student Loan Dischargeability at the Dallas-Fort Worth Area Chapter 13 Consumer Bankruptcy Conference on October 21.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"DCS 2013 B&L Exhibited",
                    CreatedDate = Convert.ToDateTime( "2013-09-26 15:41:22.0400000" ),
                    StartDate = Convert.ToDateTime( "2013-09-09 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Business Operations Analyst Stu Cramer attended the 2013 Debt Connection Symposium &amp;amp; Expo in Las Vegas beginning on September 9, 2013. As in prior years, the firm also exhibited at the event.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended Trustee Conference in August",
                    CreatedDate = Convert.ToDateTime( "2013-08-14 09:37:26.6770000" ),
                    StartDate = Convert.ToDateTime( "2013-08-10 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;In early August, Partners Tom Lee and Gil Weisman and Business Operations Analyst Stu Cramer attended the annual meeting of the National Association of Chapter 13 Trustees in New York City. Once again, Becket &amp;amp; Lee was a proud sponsor of the NACTT&amp;#39;s educational program.&lt;/p&gt;

&lt;p&gt;The event provided the Firm with opportunities to interact with the trustees, while staying abreast of issues impacting the bankruptcy process. Indeed, the Firm&amp;#39;s participation in events of this nature demonstrates its commitment to providing its clients with comprehensive, informed representation that evolves with the changing legal and regulatory landscape.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"CRS 2013: Tom Lee Presented/Firm Exhibited",
                    CreatedDate = Convert.ToDateTime( "2013-05-14 16:32:46.8200000" ),
                    StartDate = Convert.ToDateTime( "2013-05-08 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2013-05-10 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;From May 8-10, 2013, Partner Tom Lee and Business Operations Analyst Stu Cramer attended the annual Collections and Recovery Solutions conference in Las Vegas. On Friday, May 10th, Tom led a roundtable discussion of the proposed national new chapter 13 form plan and its potential ramifications on creditors. Becket &amp;amp; Lee also exhibited at the event.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L at NARCA Spring 2013 Conference",
                    CreatedDate = Convert.ToDateTime( "2013-05-14 16:29:48.4530000" ),
                    StartDate = Convert.ToDateTime( "2013-05-08 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2013-05-11 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket attended the 2013 Spring Collection Conference of the National Association of Retail Collection Attorneys in Las Vegas. The conference ran from May 8-11, 2013.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Managing Partners Attended ABI Spring Meeting",
                    CreatedDate = Convert.ToDateTime( "2013-05-14 16:28:14.1500000" ),
                    StartDate = Convert.ToDateTime( "2013-04-18 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2013-04-21 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Managing Partners Alane Becket and Tom Lee attended the recent 31st Annual ABI Spring Meeting in National Harbor, Maryland. The conference ran from April 18-21, 2013.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Partner Tom Lee Co-Presented At NCCR 2013; Firm Exhibited",
                    CreatedDate = Convert.ToDateTime( "2013-04-08 10:53:11.5630000" ),
                    StartDate = Convert.ToDateTime( "2013-03-20 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2103-03-22 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer attended the 17th Annual National Collections &amp;amp; Credit Risk Conference in New Orleans March 20-22, 2013. Tom also co-presented on the subject &amp;quot;Emerging Technologies in Collection Agency Management&amp;quot; and the firm exhibited at the event.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee Presented At CBA Live",
                    CreatedDate = Convert.ToDateTime( "2013-03-15 10:25:33.0770000" ),
                    StartDate = Convert.ToDateTime( "2013-03-13 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;On Wednesday, March 13, 2013, Partner Tom Lee led a roundtable discussion on the proposed Chapter 13 Plan Form as part of the Default Management Forum at CBA LIVE 2013. CBA LIVE is an annual three-day conference organized by the Consumer Bankers Association, which provides information across nine areas of retail banking.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Stu Cramer Attended Bankruptcy Tech Conference",
                    CreatedDate = Convert.ToDateTime( "2013-03-15 10:25:16.2200000" ),
                    StartDate = Convert.ToDateTime( "2013-03-06 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2013-03-08 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Stu Cramer attended the EPIQ Systems User Conference in Clearwater Beach, Florida from March 6-8, 2013. The annual event enables Becket &amp;amp; Lee to stay abreast of various technological developments and tools accessible to bankruptcy practitioners.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended and Exhibited at Debt Buyers' Conference in February 2013",
                    CreatedDate = Convert.ToDateTime( "2013-02-18 13:22:27.8970000" ),
                    StartDate = Convert.ToDateTime( "2013-02-05 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2013-02-07 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Alane Becket, Tom Lee and Stu Cramer attended the 16th Annual DBA International Conference at the Aria Resort in Las Vegas, February 5-7, 2013. Becket &amp;amp; Lee also exhibited at the event.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Attended NARCA Conference",
                    CreatedDate = Convert.ToDateTime( "2012-11-30 13:00:10.4200000" ),
                    StartDate = Convert.ToDateTime( "2012-10-17 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket attended the NARCA 2012 Fall Collection Conference in Baltimore, MD. The conference ran from October 17-20.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"DCS 2012: B&L Attended and Exhibited",
                    CreatedDate = Convert.ToDateTime( "2012-11-30 12:54:51.6230000" ),
                    StartDate = Convert.ToDateTime( "2012-09-10 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer attended the 2012 Debt Connection Symposium &amp;amp; Expo in Las Vegas beginning on September 10, 2012. The firm also exhibited at the event. For more information on the conference, please visit the official website at &lt;a href=&quot;http://dcs2012.com/&quot; target=&quot;DCS2012&quot;&gt;dcs2012.com&lt;/a&gt;.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Exhibited at FSCC 2012",
                    CreatedDate = Convert.ToDateTime( "2012-11-30 12:54:05.6200000" ),
                    StartDate = Convert.ToDateTime( "2012-10-24 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2012-10-26 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer attended the 20th Annual Financial Services Collections &amp;amp; Credit Risk Conference in Scottsdale, AZ. Tom also chaired the pre-conference Future Leaders Forum. The conference ran from October 24-26 and Becket &amp;amp; Lee exhibited at the event. For more information on FSCC 2012, please visit the official website at &lt;a href=&quot;http://www.collectionscreditrisk.com&quot; target=&quot;Parent&quot;&gt; http://www.collectionscreditrisk.com.&lt;/a&gt;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Invited to Speak at 2012 Annual Judges' Conference",
                    CreatedDate = Convert.ToDateTime( "2012-11-30 12:53:35.6370000" ),
                    StartDate = Convert.ToDateTime( "2012-10-24 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Beginning on October 24, 2012, Alane Becket represented the firm at the National Conference of Bankruptcy Judges in San Diego, CA. At the conference, Alane participated in a panel discussion of &amp;quot;Unresolved Issues in Chapter 13&amp;quot;. Her fellow panelists included U.S. Bankruptcy Court Judge Steven Rhodes, Chapter 13 Trustee Jan Hamilton, and attorney Jenny Doling.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee Attended 2012 Chapter 7 Trustee Conference",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:23:16.8730000" ),
                    StartDate = Convert.ToDateTime( "2012-09-05 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Beginning on September 5, 2012, Tom Lee attended the NABT 2012 Fall Seminar in Colorado. Aimed at Chapter 7 trustees, this event enabled the Firm to interact with the trustees while gaining additional industry insight.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee at NCBC 2012",
                    CreatedDate = Convert.ToDateTime( "2012-08-13 16:36:56.9730000" ),
                    StartDate = Convert.ToDateTime( "2012-08-10 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;In August, Partner Tom Lee represented the Firm at the National Conference of Bankruptcy Clerks in San Francisco. The conference provided Becket &amp;amp; Lee with an outstanding opportunity to reinforce its relationships with court personnel, while fostering open communication on work product and industry-related issues.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Invited to Speak, Firm Attended Ch. 13 Trustees' Conference",
                    CreatedDate = Convert.ToDateTime( "2012-07-18 16:40:56.5930000" ),
                    StartDate = Convert.ToDateTime( "2012-07-18 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;In July, Partners Tom Lee and Alane Becket attended the annual meeting of the National Association of Chapter 13 Trustees in New Orleans. Business Operations Analyst Stu Cramer also attended.&lt;/p&gt;

&lt;p&gt;Alane was invited to speak at the conference and she participated in a panel discussion examining how the recent Baud, Kagenveama, and Espinosa decisions are impacting unsecured creditors. In particular, the session addressed due process concerns of notice to unsecured creditors in &amp;quot;unusual&amp;quot; plan provisions and what happens after plan confirmation.&lt;/p&gt;

&lt;p&gt;Once again, Becket &amp;amp; Lee was a proud sponsor of the NACTT&amp;#39;s educational program.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Stu Cramer Attended Annual Conference Focused on Bankruptcy Technology Solutions",
                    CreatedDate = Convert.ToDateTime( "2012-06-04 17:31:34.7130000" ),
                    StartDate = Convert.ToDateTime( "2012-05-21 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2012-05-23 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Beginning May 21 and continuing through May 23, 2012, Business Operations Analyst Stu Cramer attended the annual BSS Chapter 13 Trustee user conference in Memphis, TN. This year&amp;#39;s event focused on discussion topics presented by the Trustees and their staff, as well as coordinating ACH creditor disbursements.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L Attended, Exhibited At Invitation-Only Creditors' Event",
                    CreatedDate = Convert.ToDateTime( "2012-05-17 16:18:06.2600000" ),
                    StartDate = Convert.ToDateTime( "2012-05-08 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2012-05-11 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;From May 8-11, 2012, Partner Tom Lee and Business Operations Analyst Stu Cramer attended the annual Collections and Recovery Solutions conference in Las Vegas. Becket &amp;amp; Lee also exhibited at this premiere invitation-only event aimed at senior level creditors involved in collection, recovery operations and strategy.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Presented Two Consumer Sessions at SBLI Conference",
                    CreatedDate = Convert.ToDateTime( "2012-04-26 15:53:48.0900000" ),
                    StartDate = Convert.ToDateTime( "2012-03-22 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2012-03-23 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Alane Becket was a speaker at the 38th Annual Southeastern Bankruptcy Law Institute in Atlanta. On Thursday, March 22, 2012, her presentation entitled &amp;quot;Hardship Discharge for Chapter 13 Debtors and Discharge of Student Loans&amp;quot; included the following topics:&lt;/p&gt;

&lt;ul&gt;
	&lt;li&gt;Whether student loans are ever dischargeable in a chapter 7 or 13;&lt;/li&gt;
	&lt;li&gt;Service issues;&lt;/li&gt;
	&lt;li&gt;Requirements for filing adversary proceedings;&lt;/li&gt;
	&lt;li&gt;Explanation and application of the William C. Ford program; and&lt;/li&gt;
	&lt;li&gt;Effect of the timing of the filing of the complaint for hardship discharge.&lt;/li&gt;
&lt;/ul&gt;

&lt;p&gt;Then, on Friday, March 23, 2012, Alane discussed &amp;quot;Asserting Claims in Chapter 7&amp;#39;s and Chapter 13&amp;#39;s&amp;quot;. This presentation addressed germane issues such as:&lt;/p&gt;

&lt;ul&gt;
	&lt;li&gt;Requirements of a properly filed claim;&lt;/li&gt;
	&lt;li&gt;Standing to file;&lt;/li&gt;
	&lt;li&gt;Attachments necessary to file with the court;&lt;/li&gt;
	&lt;li&gt;Effect of Federal Rule of Bankruptcy Procedure 3001(f); and&lt;/li&gt;
	&lt;li&gt;What is necessary to prove debt in the face of objections to claim.&lt;/li&gt;
&lt;/ul&gt;

&lt;p style=&quot;text-align:center&quot;&gt;For more information on the event, please visit the official website at &lt;a href=&quot;http://sbli-inc.org/schedule.html&quot;&gt;sbli-inc.org/schedule.html&lt;/a&gt;.&lt;/p&gt;

&lt;p&gt;&amp;nbsp;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket a Panelist at Annual ABI Event",
                    CreatedDate = Convert.ToDateTime( "2012-04-23 14:57:21.5100000" ),
                    StartDate = Convert.ToDateTime( "2012-04-19 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2012-04-23 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Beginning on April 19th, Alane Becket attended the American Bankruptcy Institute&amp;#39;s 30th Annual Spring Meeting in National Harbor, Maryland. At the conference, Alane participated on a panel discussing the use of non-standard plan provisions in chapter 13, along with Judge Ray Mullins of Atlanta and John Rao, a member of the Advisory Committee on Bankruptcy Rules and attorney with the National Consumer Law Center. Alane was also recently reelected to a second 3 year term on the ABI&amp;#39;s Board of Directors and will continue her duties as a member of the Publications Committee.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee at NCCR 2012",
                    CreatedDate = Convert.ToDateTime( "2012-03-21 16:12:32.9670000" ),
                    StartDate = Convert.ToDateTime( "2012-03-15 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;On Thursday, March 15, 2012, Tom Lee presented at the 16th Annual National Collections &amp;amp; Credit Risk Conference in New Orleans. Tom joined co-presenter Chris Lundquist in an interview session entitled &amp;quot;First Look - The New Bankruptcy Rules and Changing Trends: What&amp;#39;s Next?&amp;quot;&lt;/p&gt;

&lt;p style=&quot;text-align:center&quot;&gt;The firm&amp;#39;s Business Operations Analyst, Stu Cramer, also attended the conference and the firm exhibited. For more information on the conference, please visit the official website at: &lt;a href=&quot;http://www.collectionscreditrisk.com/nccr&quot;&gt;www.collectionscreditrisk.com/nccr&lt;/a&gt;.&lt;/p&gt;

&lt;p&gt;&amp;nbsp;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Stu Cramer Attended EPIQ Systems Event",
                    CreatedDate = Convert.ToDateTime( "2012-03-13 15:07:07.2500000" ),
                    StartDate = Convert.ToDateTime( "2012-03-07 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2012-03-09 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Stu Cramer attended the EPIQ Systems User Conference in Clearwater Beach, Florida from March 7-9, 2012. This annual event enables the firm to stay apprised of technological advancements and tools available to bankruptcy practitioners.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended and Exhibited at Annual Debt Buyers' Conference February 2012",
                    CreatedDate = Convert.ToDateTime( "2012-02-20 10:14:16.4330000" ),
                    StartDate = Convert.ToDateTime( "2012-02-07 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2012-02-09 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Alane Becket, Tom Lee and Stu Cramer attended the 15th Annual DBA International Conference at the Aria Resort in Las Vegas, February 7-9, 2012. The firm also exhibited at this event.&lt;/p&gt;

&lt;p style=&quot;text-align:center&quot;&gt;For more information on the conference, please visit the official website at &lt;a href=&quot;http://www.dbainternational.org/&quot;&gt;http://www.dbainternational.org/&lt;/a&gt;.&lt;/p&gt;

&lt;p&gt;&amp;nbsp;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Recognized by the American Bankruptcy Institute",
                    CreatedDate = Convert.ToDateTime( "2011-12-14 16:15:04.1770000" ),
                    StartDate = Convert.ToDateTime( "2011-12-01 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2011-12-03 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;On December 1-3, 2011, Partner Alane Becket attended the American Bankruptcy Institute&amp;#39;s annual Winter Leadership Conference. During the event, Alane received publication recognition as co-editor of the book&lt;em&gt; Best of ABI 2011: The Year in Consumer Bankruptcy.&lt;/em&gt; The book contains a select group of the best articles and conference materials produced by the ABI in 2011 and is organized by topic.&lt;/p&gt;

&lt;p style=&quot;text-align:center&quot;&gt;For more information on the book, please visit the ABI&amp;#39;s website at &lt;a href=&quot;http://bookstore.abi.org/&quot;&gt;http://bookstore.abi.org/&lt;/a&gt;.&lt;/p&gt;

&lt;p&gt;&amp;nbsp;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Exhibited at FSCC 2011",
                    CreatedDate = Convert.ToDateTime( "2011-11-16 18:32:35.6770000" ),
                    StartDate = Convert.ToDateTime( "2011-11-02 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2011-11-04 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;On November 2-4, Partner Tom Lee and Business Operations Analyst Stu Cramer attended the 19th Annual Financial Services Collections &amp;amp; Credit Risk Conference in Las Vegas. Becket &amp;amp; Lee also exhibited at the conference. For more information on FSCC 2011, please visit the official website at &lt;a href=&quot;http://www.collectionscreditrisk.com/&quot; target=&quot;collectionscreditrisk&quot;&gt;www.collectionscreditrisk.com. &lt;/a&gt;&lt;/p&gt;

&lt;p style=&quot;text-align:center&quot;&gt;&lt;a href=&quot;DOCUMENTS/FSCC ecard-FINAL.pdf#zoom=100&quot;&gt;Click here for the FSCC Conference eCard. &lt;/a&gt;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee and Stu Cramer Attended and Exhibited at DCS 2011",
                    CreatedDate = Convert.ToDateTime( "2011-10-24 12:57:12.5470000" ),
                    StartDate = Convert.ToDateTime( "2011-09-13 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2011-09-15 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;On September 13-15, Partner Tom Lee and Business Operations Analyst Stu Cramer attended the 2011 Debt Connection Symposium &amp;amp; Expo. The firm will also be exhibiting at the event. For more information on the conference, please visit the official website at: &lt;a href=&quot;http://dcs2011.com/&quot; target=&quot;newPage&quot;&gt;http://dcs2011.com/&lt;/a&gt;.&lt;/p&gt;

&lt;p style=&quot;text-align:center&quot;&gt;&lt;a href=&quot;DOCUMENTS/BL-DCS-2011-ad.pdf#zoom=90&quot; target=&quot;blank&quot;&gt;Click here for the DCS Conference eCard.&lt;/a&gt;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Participated in Panel Presentation and Received Award at Annual Judges' Conference in October",
                    CreatedDate = Convert.ToDateTime( "2011-10-24 11:48:02.8400000" ),
                    StartDate = Convert.ToDateTime( "2011-10-24 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;On Friday, October 14th, Partner Alane Becket participated in a panel presentation entitled &amp;quot;Hot Topics in Chapter 7 and 13 (Disposable Income, Exemptions, Case Conversions, Debtor Standing and Judicial Estoppel)&amp;quot; at the 85th Annual National Conference of Bankruptcy Judges. Partners Tom Lee and Gil Weisman were also in attendance.&lt;/p&gt;

&lt;p&gt;In addition, at a special conference luncheon, Alane and Associate William McNeal received a publication award for their work on the American Bankruptcy Institute&amp;#39;s book Consumer Bankruptcy: Fundamentals of Chapter 7 and Chapter 13 of the U.S. Bankruptcy Code (Third Edition).&lt;/p&gt;

&lt;p style=&quot;text-align:left&quot;&gt;If you would like more information on the conference, please visit &lt;a href=&quot;http://www.ncbj.org&quot; target=&quot;NCBJ&quot;&gt;www.ncbj.org&lt;/a&gt;.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee Joined Chapter 7 Trustees at Annual Conference",
                    CreatedDate = Convert.ToDateTime( "2011-09-26 13:56:52.8100000" ),
                    StartDate = Convert.ToDateTime( "2011-09-22 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee attended the 2011 Annual Meeting of the National Association of Bankruptcy Trustees in Florida, which began on September 22, 2011. The conference provided an excellent opportunity for Becket &amp;amp; Lee to personally interact with the Chapter 7 trustees, while simultaneously staying abreast of the latest developments in bankruptcy.&lt;/p&gt;

&lt;p style=&quot;text-align:left&quot;&gt;For more information on the conference, please visit &lt;a href=&quot;http://www.nabt.com&quot; target=&quot;NABT&quot;&gt;www.nabt.com&lt;/a&gt;.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Partner Gil Weisman Presented Twice at NACTT 2011",
                    CreatedDate = Convert.ToDateTime( "2011-08-16 13:31:29.2930000" ),
                    StartDate = Convert.ToDateTime( "2011-08-16 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;In August, Becket &amp;amp; Lee Partner Gil Weisman presented during the plenary session at the annual meeting of the National Association of Chapter 13 Trustees in Anaheim, California. Entitled &amp;quot;Post Lanning/Ransom Developments&amp;quot;, the presentation delved into the evolving issue of projected disposable income in light of the critical Lanning and Ransom Supreme Court decisions. Gil followed this session with a more interactive panel discussion of the topic later in the conference.&lt;/p&gt;

&lt;p&gt;Once again, Becket &amp;amp; Lee was a proud sponsor of the NACTT&amp;#39;s educational program.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee in Attendance at June 2011 Conferences ",
                    CreatedDate = Convert.ToDateTime( "2011-06-21 13:59:22.0600000" ),
                    StartDate = Convert.ToDateTime( "2011-06-12 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2011-06-17 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Beginning on June 12, 2011, Partner Tom Lee attended CBA LIVE, an annual conference organized by the Consumer Bankers Association. The conference was held in Orlando, Florida.&lt;/p&gt;

&lt;p&gt;Then, from June 14-17, Tom joined the National Conference of Bankruptcy Clerks for its annual conference in New Orleans. Attended by many of the Bankruptcy Clerks, as well as their staff, the conference was an excellent opportunity to get feedback on B&amp;amp;L&amp;#39;s work, provide input on future projects and make sure each clerk knows we welcome their comments throughout the year.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket a Featured Speaker at CRS 2011",
                    CreatedDate = Convert.ToDateTime( "2011-05-20 12:16:23.1400000" ),
                    StartDate = Convert.ToDateTime( "2011-05-11 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;On Wednesday, May 11, 2011, Alane Becket was a featured speaker at a Pre-Conference Bankruptcy Workshop during this year&amp;#39;s Collection and Recovery Solutions event in Las Vegas. The workshop focused on bankruptcy updates, including proof of claim rules and recent court decisions impacting bankruptcy recoveries and processes. For more information on CRS 2011, please visit the official website at &lt;a href=&quot;http://www.crs2011.com/&quot;&gt;www.crs2011.com.&lt;/a&gt;&lt;/p&gt;

&lt;p&gt;&lt;a href=&quot;documents/BLAttendeeeCard.pdf#zoom=100&quot;&gt;Click here for the CRS Conference eCard&lt;/a&gt;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Speaks at Resource Management’s Collection and Recovery Solutions 2010 Conference",
                    CreatedDate = Convert.ToDateTime( "2011-03-28 11:19:17.6830000" ),
                    StartDate = Convert.ToDateTime( "2011-03-28 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;At this exclusive event in Las Vegas, Ms. Becket conducted three interactive roundtable discussions focusing on recent developments in the bankruptcy world that have the potential to drastically change current processes and expectations for bankrupt accounts. Special attention was given to the operational and legal challenges facing creditors now and in the upcoming months. The conference&amp;#39;s Web site is &lt;a href=&quot;http://www.crs2010.com&quot;&gt;www.crs2010.com&lt;/a&gt;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee Discussed Supreme Court Rulings, Firm Exhibited at NCCR",
                    CreatedDate = Convert.ToDateTime( "2011-03-16 10:17:36.9930000" ),
                    StartDate = Convert.ToDateTime( "2011-03-14 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;On Monday, March 14, 2011, Tom Lee presented at the 15th Annual National Collections &amp;amp; Credit Risk Conference in Miami. Tom discussed the impact of recent Supreme Court decisions on bankruptcy recoveries. Stu Cramer also attended and the firm exhibited at this event. For more information on the conference, please visit the official website at: &lt;a href=&quot;http://www.collectionscreditrisk.com/&quot;&gt;http://www.collectionscreditrisk.com/.&lt;/a&gt;&lt;/p&gt;

&lt;p style=&quot;text-align:center&quot;&gt;&lt;a href=&quot;DOCUMENTS/BL-NCCR2011-EMAIL 20110302.pdf#zoom=100&quot;&gt;Click here for the NCCR Conference eCard&lt;/a&gt;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Presented at Annual ABI Event",
                    CreatedDate = Convert.ToDateTime( "2011-03-16 10:05:19.0170000" ),
                    StartDate = Convert.ToDateTime( "2011-03-10 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2011-03-12 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Alane Becket spoke at the ABI&amp;#39;s 35th Annual Judge Alexander L. Paskay Seminar on Bankruptcy Law and Practice, held March 10-12, 2011 in Tampa, Florida. Alane&amp;#39;s presentation addressed &amp;quot;What&amp;#39;s in Store for Consumer Practitioners in 2011&amp;quot;. For more information, please visit the conference website at:&lt;a href=&quot;http://www.abiworld.org/SP11&quot;&gt;&amp;nbsp;www.abiworld.org/SP11.&lt;/a&gt;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Stu Cramer Discussed ACH with Chapter 13 Trustees...",
                    CreatedDate = Convert.ToDateTime( "2011-03-01 11:22:43.0000000" ),
                    StartDate = Convert.ToDateTime( "2011-02-24 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;On February 24, 2011, Stu Cramer addressed Chapter 13 trustees on the topic of banking updates and ACH payments at the EPIQ Systems annual conference held in Clearwater Beach, Florida.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L Attended and Exhibited at 14th Annual DBA ",
                    CreatedDate = Convert.ToDateTime( "2011-02-16 11:13:16.7000000" ),
                    StartDate = Convert.ToDateTime( "2011-02-08 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2011-02-10 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Alane Becket, Tom Lee and Stu Cramer attended the 14th Annual DBA International Conference in Las Vegas, February 8-10, 2011. The firm also exhibited at this event. For more information on the conference, please visit the official website at &lt;a href=&quot;http://www.dbainternational.org/events/annual-conference/2011/index.asp&quot;&gt;http://www.dbainternational.org&lt;/a&gt;&lt;/p&gt;

&lt;p style=&quot;text-align:center&quot;&gt;&lt;a href=&quot;DOCUMENTS/BL-DBA-20110119.pdf&quot;&gt;Click here for the DBA Conference eCard&lt;/a&gt;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L Participation at 84th Annual National Conference of Bankruptcy Judges",
                    CreatedDate = Convert.ToDateTime( "2010-11-23 16:07:38.3170000" ),
                    StartDate = Convert.ToDateTime( "2010-10-15 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;On October 15, 2010, Partner Alane Becket moderated a panel entitled &amp;quot;Consumer Real Estate Issues - Mortgage Proof Issues, Preference Challenges to Foreclosures and Lien Stripping&amp;quot;. The panel was a joint effort between the American Bankruptcy Institute, where Alane serves as a Board Member and Co-Chair of its Consumer Bankruptcy Committee, and the Bankruptcy Judges Conference. Partner Tom Lee also attended the conference, which drew approximately 150 judges and hundreds of bankruptcy professionals from throughout the country. Additional information on the conference can be found at &lt;a href=&quot;http://www.ncbj.org/&quot;&gt;www.ncbj.org&lt;/a&gt;&lt;/p&gt;

&lt;p&gt;&amp;nbsp;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee Joined Chapter 7 Trustees at Annual Meeting",
                    CreatedDate = Convert.ToDateTime( "2010-11-23 16:03:29.8930000" ),
                    StartDate = Convert.ToDateTime( "2010-11-23 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Tom Lee attended the 2010 Annual Meeting of the National Association of Bankruptcy Trustees in San Francisco in late September. The event, which annually attracts over 500 participants, is the premier conference of the Chapter 7 trustee community and offers Becket &amp;amp; Lee the opportunity to meet, in person, the many trustees its staff interacts with during the year. For additional information on the conference or the NABT, please visit &lt;a href=&quot;http://www.nabt.com/&quot;&gt;www.nabt.com&lt;/a&gt;.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee & Stu Cramer Represent Becket & Lee at Industry Events",
                    CreatedDate = Convert.ToDateTime( "2010-10-27 17:49:05.2200000" ),
                    StartDate = Convert.ToDateTime( "2010-09-14 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2010-09-16 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;On September 14-16, Partner Tom Lee and Business Operations Analyst Stu Cramer attended the 2010 Debt Connection Symposium &amp;amp; Expo. Among other things, the conference addressed &amp;quot;current challenges... such as the 2007 meltdown of delinquency and losses, strategy changes, stabilization, and improvements&amp;quot;.&lt;/p&gt;

&lt;p&gt;On October 24-26, Tom and Stu attended the 18th Annual Financial Services Collections &amp;amp; Credit Risk Conference. Tom, a member of the conference&amp;#39;s Advisory Board, participated in the planning of the educational sessions. This year&amp;#39;s event focused on enhancing collections methods and capabilities through the use of best practices, and also provided guidance on related regulatory concerns.&lt;/p&gt;

&lt;p&gt;By attending these events, Becket &amp;amp; Lee maintains its commitment to education and interaction with fellow industry professionals, ensuring the highest quality representation for our clients.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Attends National Association of Retail Collection Attorneys' 2010 Fall Conference",
                    CreatedDate = Convert.ToDateTime( "2010-10-27 17:47:45.8930000" ),
                    StartDate = Convert.ToDateTime( "2010-10-21 00:00:00.0000000" ),
                    EndDate = Convert.ToDateTime( "2010-10-23 00:00:00.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket represented the Firm at this important industry conference which took place October 21-23 in Las Vegas. Previously on the Education Committee, Alane is recognized as one of the conference&amp;#39;s leading bankruptcy experts. In addition to law firms and in-house counsel, this three-day educational program attracted credit grantors and buyers/sellers of consumer debt.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Partner Gil Weisman Presented at NACTT",
                    CreatedDate = Convert.ToDateTime( "2010-08-03 18:18:04.0530000" ),
                    StartDate = Convert.ToDateTime( "2010-07-25 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;In July, Becket &amp;amp; Lee Partner Gil Weisman presented on a panel entitled &amp;quot;Have We Disposed of Disposable Income?&amp;quot; at the annual meeting of the National Association of Chapter 13 Trustees in Grapevine Texas. The panel discussed whether the recent Supreme Court case of Hamilton vs. Lanning, in which the Court held that a debtor&amp;#39;s &amp;quot;projected disposable income&amp;quot; may take account of a debtor&amp;#39;s future earnings, has settled the issue of plan payment amount that has been so contentiously litigated since BAPCPA.&lt;/p&gt;

&lt;p&gt;Continuing its longstanding commitment to the Association&amp;#39;s educational mission, Becket &amp;amp; Lee sponsored two days of educational programming at this year&amp;#39;s NACTT conference.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"John Sheehan Participates in American Bankruptcy Institute’s Spring Meeting",
                    CreatedDate = Convert.ToDateTime( "2010-07-12 20:42:05.5000000" ),
                    StartDate = Convert.ToDateTime( "2010-07-12 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;B &amp;amp; L Partner John Sheehan was a panelist at the ABI Consumer Bankruptcy Committee&amp;#39;s educational session, which recently took place during ABI&amp;#39;s Annual Spring Meeting in National Harbor, Md. John represented the creditor&amp;#39;s position on the panel in a session entitled &amp;quot;I&amp;#39;d Like You More if You Didn&amp;#39;t Drive Me Crazy: Recurring Issues Among Consumer Lawyers and Trustees, and How to Avoid Them.&amp;quot; The session was designed to allow sometimes opposing parties to discuss constructive solutions to common problems, and was part of the Consumer Bankruptcy Committee&amp;#39;s goal of making bankruptcy less adversarial by facilitating open communication among parties.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket elected to Board of Directors...",
                    CreatedDate = Convert.ToDateTime( "2010-07-02 14:25:00.9200000" ),
                    StartDate = Convert.ToDateTime( "2010-07-02 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Alane Becket was elected to the Board of Directors for the American Bankruptcy Institute and Co-Chair of the ABI&amp;#39;s Consumer Bankruptcy Committee. Becket &amp;amp; Lee has been active in the ABI for almost 20 years and this appointment is the result of years of service to the ABI. Alane has distinguished herself as a speaker at ABI seminars and meetings, moderator of the Consumer Bankruptcy Committee&amp;#39;s list serve, Editor of the Consumer Committee&amp;#39;s Newsletter, columnist for the ABI Journal, Education Director for the Consumer Committee, and Editor of the Consumer Education Center on the ABI&amp;#39;s Website. It was her work ethic, presentation skills and organizational abilities, combined with her legal expertise, that caught the Board&amp;#39;s attention. Alane was asked to join the Board earlier this year and was officially approved by the President at the ABI&amp;#39;s Annual meeting last month.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"A Claimant's Dilemma:  The Statute of Limitations and Proofs of Claim",
                    CreatedDate = Convert.ToDateTime( "2015-04-21 14:46:31.4570000" ),
                    StartDate = Convert.ToDateTime( "2015-04-21 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 3,
                    EventHtml = @"&lt;p style=&quot;text-align:center&quot;&gt;Alane A. Becket and William A. McNeal&lt;/p&gt;

&lt;p&gt;&lt;a href=&quot;http://www.becket-lee.com/documents/Crawford-ABI Journal-A Claimant&#39;s Dilemma-201404.pdf#zoom=100&quot; target=&quot;PDI&quot;&gt;Click here for full article...&lt;/a&gt;&lt;/p&gt;

&lt;p&gt;Reprinted with permission from the ABI Journal, Vol. XXXIV, No. 4, April 2015. For more information, visit &lt;a href=&quot;http://www.abi.org&quot; target=&quot;blank&quot;&gt;www.abi.org.&lt;/a&gt;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"FILER BEWARE! IT'S NOT JUST THE RULES COMMITTEE CHANGING THE RULES",
                    CreatedDate = Convert.ToDateTime( "2014-11-20 20:10:39.9730000" ),
                    StartDate = Convert.ToDateTime( "2014-11-20 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 3,
                    EventHtml = @"&lt;p style=&quot;text-align:center&quot;&gt;Alane A. Becket, Gilbert B. Weisman, William A. McNeal&lt;/p&gt;

&lt;p&gt;&lt;a href=&quot;http://www.becket-lee.com/documents/Crawford-Norton Article-41505120-Final.pdf#zoom=100&quot; target=&quot;PDI&quot;&gt;Click here for full article...&lt;/a&gt;&lt;/p&gt;

&lt;p&gt;Reprinted from Norton Bankruptcy Law Adviser, (September 2014) with permission. Copyright &amp;copy; (2014) Thomson Reuters/West. For more information about this publication please visit &lt;a href=&quot;http://www.west.thomson.com&quot; target=&quot;blank&quot;&gt; www.west.thomson.com.&lt;/a&gt;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Proofs of Claim - Two Cases and a Lesson Learned",
                    CreatedDate = Convert.ToDateTime( "2011-10-31 17:57:48.2400000" ),
                    StartDate = Convert.ToDateTime( "1011-10-31 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 3,
                    EventHtml = @"&lt;p style=&quot;text-align:center&quot;&gt;Alane Becket, Managing Partner and William McNeal, Associate&lt;/p&gt;

&lt;p&gt;&lt;a href=&quot;http://www.becket-lee.com/documents/Proofs%20of%20Claims-Two%20Cases%20and%20a%20Lesson%20Learned-May2010.pdf#zoom=100&quot; target=&quot;newWindow&quot;&gt;Click here for full article...&lt;/a&gt;&lt;/p&gt;

&lt;p&gt;Reprinted from Norton Bankruptcy Law Adviser, (May, 2010) with permission. Copyright &amp;copy; (2010) Thomson Reuters/West. For more information about this publication please visit &lt;a href=&quot;http://www.west.thomson.com&quot; target=&quot;blank&quot;&gt; www.west.thomson.com.&lt;/a&gt;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Projected Disposable Income Captures the Attention of the Supreme Court -Twice!",
                    CreatedDate = Convert.ToDateTime( "2011-10-31 17:57:15.1400000" ),
                    StartDate = Convert.ToDateTime( "2011-10-31 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 3,
                    EventHtml = @"&lt;p&gt;&amp;nbsp;&lt;/p&gt;

&lt;p style=&quot;text-align:center&quot;&gt;Gil Weisman, Partner and William A. McNeal, Associate&lt;/p&gt;

&lt;p&gt;&lt;a href=&quot;http://www.becket-lee.com/documents/Projected%20Disposable%20Income%20Captures%20Attention-Apr2011.pdf#zoom=100&quot; target=&quot;PDI&quot;&gt;Click here for full article...&lt;/a&gt;&lt;/p&gt;

&lt;p&gt;Reprinted from Norton Bankruptcy Law Adviser, (April, 2011) with permission. Copyright &amp;copy; (2011) Thomson Reuters/West. For more information about this publication please visit &lt;a href=&quot;http://www.west.thomson.com&quot; target=&quot;blank&quot;&gt; www.west.thomson.com.&lt;/a&gt;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = "The \"Hanging Paragraph\" and a Secured Creditor's Surrender Dilemma ",
                    CreatedDate = Convert.ToDateTime( "2017-06-07 18:54:35.4492057" ),
                    StartDate = Convert.ToDateTime( "1900-01-01 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 4,
                    EventHtml = @"&lt;p&gt;One of the many changes made to bankruptcy practice by the Bankruptcy Abuse Prevention and Consumer Protection Act of 2005 (BAPCPA) is the treatment of a claim for a debt secured by a motor vehicle or other personal property of the debtor. New language inserted at the end of 11 U.S.C. Section 1325(a) by BAPCPA changed the pre-BAPCPA practice of bifurcating (separating) a secured claim into secured and unsecured components if the value of the collateral was less than the amount of the claim. The new statutory language, nicknamed the &amp;quot;hanging paragraph&amp;quot; because of its physical location and appearance on the printed page, appears to eliminate the bifurcation of a secured claim, allowed by 11 U.S.C. Section 506 if the debt was incurred within 910 days prior to petition and if it is collateralized by a motor vehicle, or within one year prior to petition if it is secured by other personal property.&lt;/p&gt;

&lt;p&gt;Prior to BAPCPA, there were several options available for treatment of secured claims in Chapter 13. The first option was an agreement between a debtor and a secured claimant. Neither the &amp;quot;hanging paragraph&amp;quot; nor the current language of 11 U.S.C. Section 1325(a)(5)(A) alters that possibility.&lt;/p&gt;

&lt;p&gt;The second option was the so-called &amp;quot;cram down.&amp;quot; Under this option, a debtor could retain the property and pay the secured claim over the life of his plan, despite the creditor&amp;#39;s objection to the contrary.&lt;/p&gt;

&lt;p&gt;In Assocs. Commercial Corp. v. Rash,the United States Supreme Court explained this option:&lt;/p&gt;

&lt;p style=&quot;margin-left:40px&quot;&gt;&lt;em&gt;Under the cram down option, the debtor is permitted to keep the property over the objection of the creditor; the creditor retains the lien securing the claim, see &amp;sect; 1325(a)(5)(B)(i), and the debtor is required to provide the creditor with payments, over the life of the plan, that will total the present value of the allowed secured claim, i.e., the present value of the collateral, see &amp;sect; 1325(a)(5)(B)(ii). The value of the allowed secured claim is governed by &amp;sect; 506(a) of the Code.&lt;/em&gt;&lt;/p&gt;

&lt;p&gt;The last sentence was important because it effectively allowed bifurcation of the claim into secured and unsecured components.&lt;/p&gt;

&lt;p&gt;BAPCPA dramatically changed this option by excepting recently incurred secured debt from bifurcation. In the words of one court, &amp;quot;Debtors must now treat the entire allowed amount of the secured creditor&amp;#39;s claim in the plan as one claim. That is what the hanging paragraph requires.&amp;quot;&lt;/p&gt;

&lt;p&gt;The third option for a debtor was to surrender the collateral. Prior to BAPCPA, any deficiency still owed to the creditor, resulting from the collateral&amp;#39;s value being less than the secured claim, was treated as an unsecured claim. Treatment of claims arising from surrendered property, pursuant to the new &amp;quot;hanging paragraph&amp;quot; under BAPCPA, is not as settled. Courts are divided over whether the inapplicability of 11 U.S.C. Section 506 to secured claims described eliminates the bifurcation of a claim after a debtor has surrendered the collateral, such surrender thereby fully satisfying the claim.&lt;/p&gt;

&lt;p&gt;Most courts find that the statutory language very clearly and unambiguously eliminates claim bifurcation. The wording plainly states that &amp;quot;[f]or purposes of paragraph (5), section 506 shall not apply&amp;quot; if the debt was incurred within 910 days prior to petition and if it is collateralized by a motor vehicle, or within one year prior to petition if it is secured by other personal property. A Court explained:&lt;/p&gt;

&lt;p style=&quot;margin-left:40px&quot;&gt;&lt;em&gt;...[T]he language of the hanging paragraph is not ambiguous. If &amp;sect; 506 does not apply, there can be no bifurcation of the claim, whether or not the collateral is worth less than the claim and whether or not the collateral is surrendered. Thus, removing the bifurcation provisions of &amp;sect; 506 means that the 910-claim is satisfied in full by surrender of the collateral under &amp;sect; 1325(a)(5)(C).&lt;/em&gt;&lt;/p&gt;

&lt;p&gt;The court detected a fairness and balance in this approach, observing:&lt;/p&gt;

&lt;p style=&quot;margin-left:40px&quot;&gt;&lt;em&gt;Ironically, the same provision that prevents the debtor from lien stripping and reducing a creditor&amp;#39;s allowed secured claim prevents the creditor from claiming a deficiency against the debtor. While this new language may not operate to hoist the 910-creditor by his own petard, surely the creditor may be said to hang by his own paragraph.&lt;/em&gt;&lt;/p&gt;

&lt;p&gt;A minority of courts do not find the language of the &amp;quot;hanging paragraph&amp;quot; to be clear. For example, one court resorted to an examination of legislative history to inform what it perceived to be ambiguous statutory language. It determined that while Congress certainly could have written into the statute clear and unambiguous language prohibiting a deficiency claim after surrender of property, it did not.&lt;/p&gt;

&lt;p&gt;While the &amp;quot;hanging paragraph&amp;quot; clearly prohibits bifurcation of a claim for debt recently incurred, it does not preclude a secured claimant from pursuing any applicable state law remedy, including an unsecured claim, for a deficiency resulting from a debtor&amp;#39;s surrender of the collateral. One appellate court elaborated:&lt;/p&gt;

&lt;p style=&quot;margin-left:40px&quot;&gt;&lt;em&gt;It seems extremely unlikely, given the purposes expressed in the titles of the amendments, that the intent of the amendment was to eliminate the long existing right of creditors in bankruptcy to an unsecured deficiency claim.... Even those courts that have adopted the majority position denying deficiency claims have acknowledged that the result is probably not what Congress intended, but have figuratively shrugged their shoulders and relied on the conclusion that the statute unambiguously requires a contrary result.&lt;/em&gt;&lt;/p&gt;

&lt;p&gt;Thus it seems that, as so often happens, what is clear and unambiguous to one court is not so to another. While the &amp;quot;hanging paragraph&amp;quot; of 11 U.S.C. Section 1325(a) appears to eliminate the bifurcation of a secured claim pursuant to 11 U.S.C. Section 506 if the debt was incurred within 910 days pre-petition and if it is collateralized by a motor vehicle, or within one year pre-petition if it is secured by other personal property, it may not completely deny a creditor any recourse to satisfy a deficiency created by the surrender of collateral that is worth less than the amount of the creditor&amp;#39;s claim.&lt;/p&gt;

&lt;p&gt;This is another issue under BAPCPA that is expected to go through the appellate process and eventually reach the Supreme Court. Until then, secured creditors are governed by the divergent opinions of how their claim will be treated. Thus, the jurisdiction of the court will determine whether a deficiency claim will be allowed after surrender.&lt;/p&gt;

&lt;div&gt;
&lt;h6 style=&quot;text-align:center&quot;&gt;&lt;em&gt;Bankruptcy Report&lt;/em&gt; is produced by Becket &amp;amp; Lee LLP, Attorneys at Law, as a service to our clients. Copyright 2007 by Becket &amp;amp; Lee LLP, except as otherwise noted. Reproduction of this newsletter is strictly prohibited without written permission from the publisher.&lt;/h6&gt;
&lt;/div&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Company President Found Individually Liable for Corporate Account",
                    CreatedDate = Convert.ToDateTime( "2017-06-07 18:51:43.2072057" ),
                    StartDate = Convert.ToDateTime( "1900-01-01 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 4,
                    EventHtml = @"&lt;p style=&quot;text-align:justify&quot;&gt;The Debtor in this Chapter 11 case, filed in the Middle District of Alabama, objected to Becket &amp;amp; Lee&amp;#39;s client&amp;#39;s $20,000 claim for the Debtor&amp;#39;s business credit card, citing merely that he either did not owe the debt or did not agree with the amount of the debt listed on the claim. The lack of specificity in the objection caused Becket &amp;amp; Lee Associate Attorney Natalie McGhee to contact the Debtor&amp;#39;s Counsel, who admitted that the objection was filed in order to coerce the Creditor to reduce the amount of the claim. The Debtor (incorrectly) assumed that the Creditor would rather lower the claim amount than litigate the validity of the claim, a tactic that apparently had worked with some of the Debtor&amp;#39;s other creditors.&lt;/p&gt;

&lt;p style=&quot;text-align:justify&quot;&gt;Becket &amp;amp; Lee responded to the objection, arguing that it was so lacking in detail that the Creditor was unable to formulate a response to it. Discovery requests and responses were exchanged by both parties, during which the Debtor was provided with account statements and the contract governing the account. In the Debtor&amp;#39;s discovery responses, he finally settled on the position that the debt was not his personal liability, but rather the liability of his company. Although the account agreement clearly specified the liability of both the company and the responsible company officer for the charges on the account, the Debtor alleged that the lack of a signature on the agreement precluded the Creditor from holding him liable for the debt.&lt;/p&gt;

&lt;p style=&quot;text-align:justify&quot;&gt;In response to the new allegations, Becket &amp;amp; Lee filed a brief and affidavit from the Creditor, arguing that, in accordance with the terms of the account agreement, the Debtor&amp;#39;s use of the card constituted acceptance of the account agreement, and, therefore, no signature was necessary to bind the Debtor to the terms of the agreement.&lt;/p&gt;

&lt;p style=&quot;text-align:justify&quot;&gt;Shortly after the Creditor&amp;#39;s brief was filed, the Debtor&amp;#39;s Counsel made an offer to resolve the objection if the Creditor reduced its claim by $10,000. The creditor declined but counter-offered to reduce the claim by a nominal amount, accounting for a few months of finance charges and late fees incurred after the Debtor&amp;#39;s last payment. The Debtor rejected this offer. With no chance of settlement, Becket &amp;amp; Lee and the Creditor prepared for the evidentiary hearing. A witness from the Creditor was prepared to testify via telephone.&lt;/p&gt;

&lt;p style=&quot;text-align:justify&quot;&gt;Shortly before the evidentiary hearing, the Judge reversed his earlier decision and refused to allow the Creditors&amp;#39; witness to appear by telephone. After some persuading, the Judge returned to his previous decision to allow the telephonic witness, only to change his mind again at the hearing two days later. At that hearing, the Debtor admitted he used the card but testified that he did not remember who opened the account for the company and claimed that he never made any payments. The Debtor further testified that he did not remember ever seeing a copy of the account agreement. The Creditor&amp;#39;s records, however, indicated that the Creditor&amp;#39;s representative had spoken with the Debtor approximately one month prior to the bankruptcy.&lt;/p&gt;

&lt;p style=&quot;text-align:justify&quot;&gt;The matter was set for a second hearing at which time the Creditor&amp;#39;s witness was required to appear in person.&lt;/p&gt;

&lt;p style=&quot;text-align:justify&quot;&gt;In preparation for the second hearing, a supplemental brief was filed to address the contingency that the court might find that the Debtor was not &lt;em&gt;contractually&lt;/em&gt; liable for the account because he did not sign the account agreement. Although this position is not necessarily valid, Becket &amp;amp; Lee&amp;#39;s experience is that in certain areas of the country, courts have required evidence of the debtor&amp;#39;s signature on &amp;quot;something&amp;quot; in order to find liability for an individual on a corporate debt. Therefore, the supplemental brief focused on the theory of &amp;quot;unjust enrichment,&amp;quot; which is the legal principle holding that a party should not be permitted, unjustly, to enrich himself at the expense of another, but should be required to make restitution for property or benefits received where it is just and equitable that such restitution to be made. Becket &amp;amp; Lee argued that the Debtor would be unjustly enriched if he were allowed to use the credit card to obtain assets to keep his business going, keep the profits from the business for himself, and then successfully object to paying the claim in his bankruptcy case.&lt;/p&gt;

&lt;p style=&quot;text-align:justify&quot;&gt;At the hearing, the Creditor&amp;#39;s witness testified that not all accounts are opened by a written application in the first instance; in fact many accounts are opened over the phone or internet, with no signature whatsoever. The witness further testified that upon approval of an application, a credit card is mailed to the responsible corporate officer, along with the account agreement. The account agreement specifies the terms of the account and the liability of both the company, and its representative, for the debt. The agreement directs the user not to use the account unless the user agrees to the terms of the agreement.&lt;/p&gt;

&lt;p style=&quot;text-align:justify&quot;&gt;The Judge reserved a ruling at the hearing but later issued a decision overruling the Debtor&amp;#39;s objection and allowing the claim. In its written ruling, the Court elaborated on the question of whether the Debtor was primarily liable or a guarantor on the account. This issue is significant because in Alabama, a claim against a guarantor must be evinced by the guarantor&amp;#39;s signature, showing assent to be secondarily liable for the debt of another. Here, the court found that the provisions of the contract were unambiguous on their face, and by its terms, the Debtor was not a guarantor, but rather was primarily liable for the account. Thus, a signature was not required.&lt;/p&gt;

&lt;p style=&quot;text-align:justify&quot;&gt;The court agreed with Becket &amp;amp; Lee&amp;#39;s argument that use of the card signified assent to the account agreement and that the Debtor was personally liable with the company on the account, notwithstanding the fact that he did not sign a contract. The Court noted that the account statements included the Debtor&amp;#39;s name, that the Debtor was President of the company, and that the charges on the account were for expenses for the Debtor&amp;#39;s business. Having determined that the Debtor was, in fact, responsible, the Court allowed the claim in full.&lt;br /&gt;
&lt;em&gt;In re Adams&lt;/em&gt;, Bankruptcy No. 03-30172-WRS-11 (Bankr. M.D. of Al. 2003)&lt;/p&gt;

&lt;div&gt;
&lt;h6 style=&quot;text-align:center&quot;&gt;&lt;em&gt;Bankruptcy Report&lt;/em&gt; is produced by Becket &amp;amp; Lee LLP, Attorneys at Law, as a service to our clients. Copyright 2007 by Becket &amp;amp; Lee LLP, except as otherwise noted. Reproduction of this newsletter is strictly prohibited without written permission from the publisher.&lt;/h6&gt;
&lt;/div&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Can a Debtor Really Keep an Escalade?",
                    CreatedDate = Convert.ToDateTime( "2017-06-07 18:50:48.2362057" ),
                    StartDate = Convert.ToDateTime( "1900-01-01 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 4,
                    EventHtml = @"&lt;p style=&quot;text-align:justify&quot;&gt;The intent of Congress when implementing BAPCPA in 2005 was to prevent abuse of the bankruptcy system and to ensure that those who can afford to repay some portion of their unsecured debts be required to do so. Recently, several courts have ruled on the issue of a debtor&amp;#39;s right to deduct secured obligations for luxury items from his or her Current Monthly Income (CMI) with results seemingly contradictory to the legislative intent of BAPCPA. Recently this issue came before Judge Gorman of the Central District of Illinois in&lt;em&gt; In Re Carlton&lt;/em&gt;, 370 B.R. 188, (Bankr. C.D. Ill., 2007).&lt;/p&gt;

&lt;p style=&quot;text-align:justify&quot;&gt;The Trustee in&lt;em&gt; In Re Carlton&lt;/em&gt; objected to the Debtors&amp;#39; Schedule I, Official Form B22C, and confirmation of the Debtors&amp;#39; Chapter 13 plan. He asserted that the Debtors were not paying all of their projected disposable income into the plan. Projected disposable income under BAPCPA is based on CMI minus certain allowed expenses. Debtors use Official Form B22C to calculate their CMI and determine their projected disposable income. In the case of above-median debtors, such as the Carltons, income and expenses are calculated according to 1325(b)(3) which in turn, looks to the &amp;quot;means test&amp;quot; expenses found in section 707(b)(2)(A). Section 707(b)(2)(A)(iii) instructs that, for secured obligations, the allowed monthly expense is the contractual amount due over five years divided by 60. This amount is then deducted from the debtors&amp;#39; CMI in order to determine their projected disposable income. In &lt;em&gt;In Re Carlton&lt;/em&gt;, the Debtors took a monthly expense deduction for each of their three vehicles, including a 2003 Cadillac Escalade. These deductions reduced the amount of money the Debtors were required to put towards their Chapter 13 plan by reducing their projected disposable income, and ultimately reduced payments to their unsecured creditors.&lt;/p&gt;

&lt;p style=&quot;text-align:justify&quot;&gt;The Trustee argued that the Debtors should not be permitted to take a deduction from their CMI for each of their three vehicles. The Trustee had specific concerns with the Carltons&amp;#39; $604.71 deduction for their Cadillac Escalade. He asserted that the Court should have denied any deduction for the Debtors&amp;#39; obligation related to this car because it was a luxury vehicle and, therefore, not a reasonable or necessary expense.&lt;/p&gt;

&lt;p style=&quot;text-align:justify&quot;&gt;The Trustee further argued that if the Court ruled correctly with regard to the secured debt deductions, the Debtors&amp;#39; plan could not have been confirmed pursuant to section 1325(b). Section 1325(b)(1)(B) requires that, if the trustee or holder of a secured claim objects to the confirmation of the plan, the court may not approve the plan unless it provides that all of the debtor&amp;#39;s projected disposable income be applied for payment to the unsecured creditors under the plan. If the Debtors had not been permitted to take the secured debt deduction for their Cadillac, their projected disposable income would have been increased by the $604.71. Consequently, the Debtors&amp;#39; plan would not have been confirmed as proposed because it would not have included all of the Debtors&amp;#39; projected disposable income.&lt;/p&gt;

&lt;p style=&quot;text-align:justify&quot;&gt;However, the Court did not agree with the Trustee&amp;#39;s position and held that the Debtors&amp;#39; deductions were all properly taken. The Court declined to impose its own judgment on the issues of reasonableness and necessity with regard to the Debtors&amp;#39; secured debt deductions. Judge Gorman held that the section 707(b)(2) prevented the Court from implementing a reasonable and necessary standard on secured debt deductions. She explains that, because Congress inserted the reasonable and necessary language into certain sections of BAPCPA, it can be determined that, with respect to other sections, Congress did not intend for that language to apply. The language of section 707(b)(2)(A)(iii)(I) specifically states that the deductions should include the &amp;quot;total of all amounts scheduled as contractually due&amp;quot; and does not impose a &amp;quot;reasonable and necessary&amp;quot; requirement for the collateral. Additionally, the section provides a precise formula for the calculation of the deductions allowed.&lt;/p&gt;

&lt;p style=&quot;text-align:justify&quot;&gt;The Court contends that, when these inclusions are taken into consideration, Congress could not have intended to allow the secured debt deductions to be subject to a reasonable and necessary standard without including such language specifically. For that reason, the Debtors were entitled to include the secured debt deductions for all three of their vehicles. This holding may have significant consequences with regard to unsecured creditors in Chapter 13 cases. Essentially, this interpretation of section 707(b)(2)(A)(iii) and secured debt deductions allows debtors to take an unlimited number of deductions for an unlimited amount, so long as the deduction is determined by the formula set forth in the section. These deductions could reduce the amount of a debtor&amp;#39;s projected disposable income considerably, thereby also reducing the amount distributed to general unsecured creditors through the Chapter 13 Plan.&lt;/p&gt;

&lt;h6 style=&quot;text-align:justify&quot;&gt;Becket &amp;amp; Lee disagrees that section 707(b)(2)(A)(iii) allows a debtor to take a monthly allowance for any collateral, frivolous or not, as is the majority interpretation of this section. See the article authored by attorneys at B&amp;amp;L in &lt;em&gt;The Quarterly&lt;/em&gt;, a National Association of Chapter Thirteen Trustees publication.&lt;/h6&gt;

&lt;div&gt;
&lt;h6 style=&quot;text-align:center&quot;&gt;&lt;span style=&quot;font-size:11px&quot;&gt;&lt;em&gt;Bankruptcy Report&lt;/em&gt; is produced by Becket &amp;amp; Lee LLP, Attorneys at Law, as a service to our clients. Copyright 2007 by Becket &amp;amp; Lee LLP, except as otherwise noted. Reproduction of this newsletter is strictly prohibited without written permission from the publisher.&lt;/span&gt;&lt;/h6&gt;
&lt;/div&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = "\"Inc.\" Offers No Protection For Debtor",
                    CreatedDate = Convert.ToDateTime( "2017-06-07 18:48:34.3932057" ),
                    StartDate = Convert.ToDateTime( "1900-01-01 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 4,
                    EventHtml = @"&lt;p style=&quot;text-align:center&quot;&gt;&lt;strong&gt;Alane Becket, Managing Partner&lt;/strong&gt;&lt;/p&gt;

&lt;p&gt;The debtor filed a Chapter 13 bankruptcy owing only $41,000 in unsecured debt, over $30,000 of which was owed to a single creditor. The debtor also owned a commercial property valued at almost $800,000 with a mortgage of only $275,000. Because the debtor had so much equity in his real property, under the &amp;quot;best interests of the creditors test&amp;quot; the debtor was required to repay his unsecured creditors in full.&lt;/p&gt;

&lt;p&gt;The best interest of the creditors test is shorthand for 11 U.S.C. &amp;sect; 1325(a)(4) which requires that a Chapter 13 plan, in order to be confirmed, pay unsecured creditors no less than what they would have received in a hypothetical Chapter 7 case. Here, since a liquidation of the debtor&amp;#39;s commercial property would have yielded over $500,000 in profit to the debtor, the best interest of the creditors test mandated full payment to unsecured claims.&lt;/p&gt;

&lt;p&gt;Because any money left over after the payment of all unsecured claims would be returned to the Debtor, it was not surprising when the debtor objected to the creditor&amp;#39;s claim, seeking its disallowance by alleging that the debt was incurred by his corporation and that he was not personally responsible for the obligations incurred by his corporation. The creditor, represented by Becket &amp;amp; Lee, filed a Response to the objection. The Response noted, among other things, that the debtor listed a debt to the creditor on his signed and sworn schedule of unsecured claims. The debtor did not mark the debt as &amp;quot;disputed&amp;quot;. The Response argued that the Debtor did not meet his burden of proof to overcome the evidentiary value of the proof of claim.&lt;/p&gt;

&lt;p&gt;Becket &amp;amp; Lee later supplemented the creditor&amp;#39;s Response by filing an affidavit of the creditor attesting to the history of the account. Specifically, in 2002, the debtor originally opened the account with another creditor. During the life of the account, it was purchased by the current creditor. The creditor was able to retrieve the account agreement from the time the account was active with it and the account agreement from the original creditor. Both agreements clearly held the company representative responsible for all charges on the account. The creditor was also able to produce account statements for the account, as well as copies of advance checks written by the debtor in the amounts of $13,000 and $3,600.&lt;/p&gt;

&lt;p&gt;A preliminary hearing was held on the Debtor&amp;#39;s objection at which time the court ordered the creditor to produce &amp;quot;something&amp;quot; evidencing the debtor&amp;#39;s assent to being held liable for the advances on the account. Because a signed application was not available, Becket &amp;amp; Lee, on behalf of its client, filed a second supplemental brief arguing that proof of a signed agreement is not the only way to show assent to liability on an account. More specifically, in accordance with the terms of many credit card agreements, acceptance of the terms of the agreement can be shown by the cardholder&amp;#39;s use of the account.&lt;/p&gt;

&lt;p&gt;In addition, the account agreement contained a &amp;quot;choice of law&amp;quot; provision which stated that it was governed by the laws of Rhode Island. The second account agreement, from the current creditor, had a choice of law provision which held that the laws of Delaware were applicable to the account. Becket &amp;amp; Lee showed in its brief that regardless of whether the laws of Rhode Island, Delaware, or even New Jersey, where the bankruptcy case was pending, were applicable, all three states have law that provide that acceptance or use of a credit facility by a consumer binds the consumer to the terms of the agreement.&lt;/p&gt;

&lt;p&gt;A total of eight hearings were held on this matter. It appeared that the judge was reluctant to hold the debtor liable for a debt incurred for business purposes. Becket &amp;amp; Lee provided substantial supporting documentation and legal authority to show that, regardless of how the account was used, the terms of the agreement showed the Debtor was liable on the debt.&lt;/p&gt;

&lt;p&gt;Immediately prior to the last hearing on the objection, the court asked both parties for a summary of their arguments. Becket &amp;amp; Lee reiterated its position that, under the law, the debtor was responsible for the balance due on the account by virtue of the terms of the account agreement. In the alternative, it was argued that, because the corporation was owned 100 percent by the Debtor, it would be inequitable to allow the debtor to incur debt in the corporation&amp;#39;s name, take for himself all the profits of the corporation, and then refuse to pay the debts of the corporation from the sale of the property occupied by the corporation. Under the legal theory of quantum meriut, it was argued, the Debtor should be responsible for the accounts. Quantum meriut means &amp;quot;as much as he deserves&amp;quot; and is an equitable doctrine based on the concept that no one who benefits by the labor and materials of others should be unjustly enriched thereby, and that the law implies a promise to pay a reasonable amount for labor and materials furnished even absent a specific contract therefore.&lt;/p&gt;

&lt;p&gt;After the eighth and final hearing, the court ruled in favor of the creditor. The court did not elaborate on its decision but cited the Debtor&amp;#39;s 100 percent interest in the corporation that obtained the benefit of the credit as weighing on its decision. The creditor&amp;#39;s claim of over $30,000 will be paid in full.&lt;/p&gt;

&lt;p&gt;&lt;em&gt;In re Jeffrey Satkin&lt;/em&gt;, Case no. 05-23156 (Bankr. D. N.J. 2005)&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Temporary Underemployment No Basis To Discharge Student Loan Debt",
                    CreatedDate = Convert.ToDateTime( "2017-06-07 18:47:32.3682057" ),
                    StartDate = Convert.ToDateTime( "1900-01-01 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 4,
                    EventHtml = @"&lt;p style=&quot;text-align:center&quot;&gt;William J. Becket, Partner&lt;/p&gt;

&lt;p&gt;The Debtor filed a Complaint against student loan creditors, seeking to discharge student loan debt totaling more than $170,000. In the Complaint, the Debtor alleged she was employed at the highest paying employment available to her, and that her monthly expenses were nearly equal to her income. Therefore, the Debtor argued, she had no ability to repay her student loans and was entitled to a discharge of the student loan debt.&lt;/p&gt;

&lt;p&gt;Upon the granting of a general discharge in a bankruptcy case, a debtor receives a discharge of most unsecured debt. However, certain unsecured debts are not automatically discharged. Among debts not automatically discharged by the general discharge are educational loans made, insured or guaranteed by a governmental unit, loans made under a program funded in whole or in part by a governmental unit or nonprofit institution, and other qualified educational loans, as defined by the Internal Revenue Code.&lt;/p&gt;

&lt;p&gt;In order to obtain a discharge of an otherwise nondischargeable educational loan, a debtor must file a complaint and obtain a declaratory judgment that the debtor and his/her dependants would suffer &amp;quot;undue hardship&amp;quot; if the loan(s) were not discharged. Statutory law does not define undue hardship, and courts have generally adopted one of two tests to determine whether undue hardship exists. These tests are known as the Brunner test and the &amp;quot;totality of the circumstances&amp;quot; test. In this case, the controlling standard was the Brunner test.&lt;/p&gt;

&lt;p&gt;Under the Brunner test, originally described by the Second Circuit Court of Appeals, and subsequently adopted by several other Circuits, the debtor must prove: (1) that the debtor cannot maintain, based on current income and expenses, a minimal standard of living for herself and her dependents if forced to repay the loans; (2) that additional circumstances exist indicating that this state of affairs is likely to persist for a significant portion of the repayment period of the student loans; and (3) that the debtor has made good faith efforts to repay the loans.&lt;/p&gt;

&lt;p&gt;In this case, the Debtor&amp;#39;s primary argument appeared to be that she was presently unable to repay the loans from available income, after deduction of monthly expenses. Facts which weighed against the Debtor in her undue hardship claim included the following: 1) the Debtor was young, only 27 years old, and had no dependants; 2) the Debtor had no physical or mental disability which might effect her ability to earn income; 3) the Debtor had earned two undergraduate B.S. degrees; 4) the Debtor had no secured creditors; 5) The Debtor admitted that her prospects were improving, and that she expected a rise in income in the near future; 6) the Debtor formerly held a position with a higher salary, indicating that she was capable of earning more than she currently earned; 7) the Debtor was newly married by the time the case went to trial, and her spouse&amp;#39;s separate income was available to contribute to household expenses; and finally, 9) the Debtor had expressed an intent to repay only student loans which her parents had co-signed as liable parties.&lt;/p&gt;

&lt;p&gt;At trial, the court found that, after subtracting household expenses from net income, the Debtor did have significant excess income available in her monthly budget. The court noted that the addition of the Debtor&amp;#39;s spouse&amp;#39;s income to the household budget drastically enhanced the excess household income, thereby freeing up a significant portion of the Debtor&amp;#39;s individual income for repayment of the student loans. The court also observed that the Debtor and her new spouse had medical insurance through their employer, and both regularly contributed to their 401k plans. The court also found certain of the Debtor&amp;#39;s monthly expenses to be beyond &amp;quot;minimal&amp;quot;, as that term is used in the Brunner test, including a gym membership, a household cleaning service, and payments on prepetition dischargeable debts.&lt;/p&gt;

&lt;p&gt;In ruling on application of the facts to the Brunner test for determining undue hardship, the court found that the Debtor did meet the third prong of the Brunner test, because she had made a good faith effort to repay the loans by having made a number of interest payments on the loans over a period of years. However, the Court also found that the Debtor could not meet the first prong of the Brunner test because she would still be able to maintain a minimal standard of living if forced to repay the loans. The Debtor&amp;#39;s recent marriage, and the addition of her spouse&amp;#39;s income to the household budget, were critical to the decision, as they made a difference in the excess income the Debtor had available to repay the student loans. Finally, having failed the first prong of the Brunner test, the debtor would necessarily be unable to show that any hardship she alleged would be long-lasting (failing the second prong of the test), since the court found that undue hardship was not presently evident.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"In Calculating Plan Payments, Can Debtors Deduct For A Car Payment They Don't Have?",
                    CreatedDate = Convert.ToDateTime( "2017-06-07 18:46:51.4972057" ),
                    StartDate = Convert.ToDateTime( "1900-01-01 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 4,
                    EventHtml = @"&lt;p style=&quot;text-align:center&quot;&gt;Emily Abbott, Associate Attorney&lt;/p&gt;

&lt;p&gt;In the Bankruptcy Abuse Prevention and Consumer Protection Act of 2005 (BAPCPA), Congress requires that the Collection Financial Standards, established by the Internal Revenue Service, be used for certain calculations for debtors in bankruptcy.&lt;/p&gt;

&lt;p&gt;Collection Financial Standards&lt;br /&gt;
The Standards are a set of established expense limits used by the IRS to help determine a taxpayer&amp;#39;s ability to pay delinquent tax liabilities. These Standards are predetermined dollar amounts for monthly expenses for basic necessities such as a food, clothing, housing, and a vehicle. The amounts for certain items vary depending on the region in which a taxpayer lives.&lt;/p&gt;

&lt;p&gt;Use of Standards in Bankruptcy&lt;br /&gt;
In bankruptcy, these Standards for expenses are to be used in two distinct calculations: (1) in determining which debtors will be permitted to proceed with Chapter 7 bankruptcy, i.e., the means test, and (2) in determining what is reasonable for certain Chapter 13 debtors to spend and, thus, how much those debtors will have available to repay creditors. This is of critical importance to unsecured creditors because, of course, it is more likely they will be paid in a Chapter 13, and also because once in Chapter 13, the less a debtors&amp;#39; expenses, the more disposable income will be available for repayment of unsecured creditors.&lt;/p&gt;

&lt;p&gt;Standard for Vehicle Ownership&lt;br /&gt;
The Bankruptcy Code (&amp;quot;Code&amp;quot;) is clear that use of the Standards is intended because it specifically refers to them in BAPCPA-revised section 707; however, just how and when to use the Standards has been the subject of much litigation in bankruptcy courts across the country. By far, the most hotly debated issue is the application of the Standard for vehicle ownership. The Standard for vehicle ownership is currently listed on an IRS chart as $489 per car, regardless of where the taxpayer lives or whether she leases or finances.&lt;/p&gt;

&lt;p&gt;The specific question that has arisen for debtors in bankruptcy is this: can a debtor who has no car payment deduct the Standard amount for vehicle ownership anyway? In other words, is this amount a fixed allowance for all debtors or is it applicable only when a debtor actually has a car payment? Debtors, in order to avoid Chapter 13, or to reduce their repayment obligation once in a Chapter 13, argue that Congress intended for application of the Standard as a fixed amount regardless of their circumstances. They argue this based on language of the Code that says their expenses &amp;quot;shall be&amp;quot; the &amp;quot;applicable monthly expense amounts specified under&amp;quot; the Standards. The word &amp;quot;applicable&amp;quot;, the debtors argue, requires them to apply the Standard according to how many cars they own. Creditors and Chapter 13 Trustees will argue that the word applicable means a debtor must have a car payment in order for that Standard to be applicable to her. Additionally, objectors will argue that it is helpful to look at how the IRS uses its own Standards because the IRS&amp;#39; method maximizes repayment.&lt;/p&gt;

&lt;p&gt;How the IRS Applies Its Vehicle Ownership Standards&lt;br /&gt;
In order to actually use the Standards, one has to go outside the Code because the numbers are set forth in charts in IRS materials, all of which can be found on the internet. The IRS has set its Standards up such that there are two separate monthly amounts applicable to transportation expenses: one for ownership (cost of acquisition, whether a lease or purchase) and the other for operation (gas, maintenance, insurance, registration). The IRS practice, as set forth in its written guidance materials, is to allow taxpayers who actually incur a car payment (lease or financing) to deduct a maximum of $489 in determining how much they can afford to pay per month to repay a tax obligation. This limit applies nationwide.&lt;/p&gt;

&lt;p&gt;A single taxpayer is normally allowed one car so if that taxpayer happens to have two cars, she does not get to deduct two amounts, just the actual or Standard, whichever is less, for the one car. Married taxpayers with two car payments will, under IRS practice, be permitted use of the Standard twice, subject to the &amp;quot;actual or Standard, whichever is less&amp;quot; rule for each car. The IRS limits married taxpayers to two vehicles. For operating costs, taxpayers with a vehicle get a fixed amount depending on the region where they live. (If taxpayers do not have a car at all, they get another figure for public transportation regardless of what they spend.)&lt;/p&gt;

&lt;p&gt;Case Law&lt;br /&gt;
The bankruptcy courts faced with this issue so far are split, with decisions favoring use of the Standard regardless of whether a debtor has a payment slightly outnumbering decisions ruling against a debtor&amp;#39;s use of the Standard where there is no payment. These courts generally reason that the word &amp;quot;applicable&amp;quot; does not have the meaning creditors and Trustees assign to it and further, that Congress did not specifically adopt IRS&amp;#39; guidance materials in the language of the Code and thus, the IRS&amp;#39; method is irrelevant in the bankruptcy context.&lt;/p&gt;

&lt;p&gt;The good news for creditors is that the seven appellate courts publishing opinions on this issue as of this date have ruled against a debtor&amp;#39;s use of the Standard where the debtor has no car payment.&lt;/p&gt;

&lt;p&gt;Ninth Circuit BAP: In re Ransom&lt;br /&gt;
Becket &amp;amp; Lee LLP litigated this issue in In re Ransom, 380 B.R. 799 (9th Cir. B.A.P. 2007). In Ransom, an above-median Chapter 13 debtor sought to deduct $471 (the Standard for car ownership at the time) even though he paid off his car previous to his bankruptcy filing. The BAP found the plain language of the Code, specifically the word &amp;quot;applicable&amp;quot;, meant the debtor had to actually have a car payment in order to take the expense.&lt;/p&gt;

&lt;p&gt;Further, the BAP looked at the requirement to use the Standards in the context of the Code and the purpose behind BAPCPA and found, quite logically, what is important is the payments that debtors actually make, not how many cars they own, because the payments that debtors make are what actually affect their ability to make payment to their creditors.&lt;/p&gt;

&lt;p&gt;Although the BAP cited with approval lower courts that had specifically followed the IRS guidelines, the decision was not specifically based on this. Mr. Ransom has appealed the decision of the 9th Circuit BAP to the Court of Appeals for the Ninth Circuit and Becket &amp;amp; Lee LLP will continue to defend its victory.&lt;/p&gt;

&lt;p&gt;8th Cir BAP: In re Wilson One of the most recent appellate rulings on this issue is notable. Another Bankruptcy Appellate Panel in In re Wilson, Case No. 07-6050, 2007 Bankr. LEXIS 567 (8th Cir B.A.P. March 14, 2008), reversed the ruling of the Bankruptcy Court for the Western District of Arkansas that a debtor who owns a car outright can take the Standard expense.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Are Balance Transfers Avoidable?",
                    CreatedDate = Convert.ToDateTime( "2017-06-07 18:45:30.2072057" ),
                    StartDate = Convert.ToDateTime( "1900-01-01 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 4,
                    EventHtml = @"&lt;p style=&quot;text-align:center&quot;&gt;Crystal Jones, Associate Attorney&lt;/p&gt;

&lt;p&gt;Pre-petition, the Debtor transferred $10,000 from one credit card account to another through the use of convenience checks. The Trustee sought to force the receiving creditor (Creditor B) to pay the $10,000 over to the bankruptcy estate pursuant to 11 U.S.C.&amp;sect; 547(b), which allows a bankruptcy trustee to recover preferential payments made pre-petition for the benefit of all creditors. The Bankruptcy Court ruled in the Trustee&amp;#39;s favor. Creditor B appealed, arguing that the payment, made directly from one creditor to another by use of convenience checks, was not a transfer of &amp;quot;property of the debtor,&amp;quot; one of the required elements of a preference.&lt;/p&gt;

&lt;p&gt;The preference laws were designed, as the Bankruptcy Court notes in this case, to remove the incentive of creditors of an insolvent debtor from &amp;quot;competitive last-minute grabbing&amp;quot; of a debtor&amp;#39;s assets. Importantly, a transfer is only preferential if the property transferred belongs to the debtor. The Bankruptcy Court held that a transfer directly from one creditor to another, made by use of convenience checks was in fact, a transfer of property of the debtor.&lt;/p&gt;

&lt;p&gt;On appeal, Creditor B made several arguments. It contended that the Debtor had no &amp;quot;property interest&amp;quot; in the money that was transferred. Further, Creditor B argued that the &amp;quot;earmarking doctrine&amp;quot; applied to the transfer. The earmarking doctrine applies when borrowed funds are specifically earmarked by the lender to pay a particular creditor. If the earmarking doctrine applied to the transfer, argued Creditor B, the funds would never really be the Debtor&amp;#39;s property. For the preference law to apply, the property sought to be returned must have been the debtor&amp;#39;s property to begin with. Finally, Creditor B argued that, because the transfer did not cause a diminution of the estate, it wasn&amp;#39;t a preferential transfer. The Appeals Court disagreed with Creditor B and reaffirmed the Bankruptcy Court&amp;#39;s holding.&lt;/p&gt;

&lt;p&gt;The Appeals Court explained that the Debtor exercised significant control over the money by choosing to pay a single creditor, rather than paying all creditors pro rata or, alternatively, keeping the money and using it to purchase property. The Appeals Court stated that if the Debtor had chosen to keep the convenience check funds or purchased property with them, the assets of the estate at the time of bankruptcy would have been greater. This could have allowed equal distribution of such assets to creditors pro rata. Instead, the Debtor chose to disburse the proceeds of these checks to a single creditor. As such, the estate was essentially &amp;quot;diminished&amp;quot; of the assets that could have otherwise been acquired.&lt;/p&gt;

&lt;p&gt;Creditor B, in a related argument, contended that because the Debtor deposited the convenience checks in her bank account, the transactions involved a &amp;quot;transfer of debt&amp;quot; which would merely result in a substitution of creditors, not a depletion of the Debtor&amp;#39;s estate. The Appeals Court rejected this argument pointing to the &amp;quot;economic reality&amp;#39; of the transaction. The Court explained that a balance transfer is in the nature of a a loan from the bank. When the Debtor obtained the loan, she also obtained control of the loan proceeds, making it irrelevant that the Debtor never had cash in hand.&lt;/p&gt;

&lt;p&gt;The Appeals Court also rejected Creditor B&amp;#39;s argument that earmarking doctrine applied to the transfer. In this case, it is undisputed that Creditor A, in issuing the convenience checks, did not specifically restrict the funds for payment of the Debtor&amp;#39;s debt to Creditor B. The Court held that it was the Debtor, not the lender, who exercised control of the funds and designated such payment to the creditor of his choosing. The Appeals Court acknowledged that other bankruptcy courts have viewed similar transfers differently. In&lt;em&gt; In re Parks&lt;/em&gt;, which is currently on appeal from a Kansas bankruptcy court, the court held that a transfer of credit card balances was &amp;quot;a mere substitution of creditors which had no impact on either the property of the estate or the value of the claims asserted against the estate.&amp;quot; Additionally, in a decision from Utah, the court stated that the &amp;quot;availability of credit&amp;quot; constituted only a potential wealth because creditors could not force debtors to use such credit to create liquidity for distribution.&lt;/p&gt;

&lt;p&gt;The Appeals Court stated that these opinions disregard the fact that, had the Debtor retained the proceeds of these convenience checks, they would have been available to all creditors equally. As such, the Appeals Court reaffirmed the Bankruptcy Court&amp;#39;s granting of the Trustee&amp;#39;s Motion for Summary Judgment on her preference claim, and ordered Creditor B to return the $10,000 to the estate. Meoli v. MBNA Am. Bank, N.A. (&lt;em&gt;In re Wells&lt;/em&gt;) 382 B.R. 355, (B.A.P. 6th Cir. 2008)&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Supreme Court Rules on Calculation of Chapter 13 Plan Payment",
                    CreatedDate = Convert.ToDateTime( "2017-06-07 18:44:51.4112057" ),
                    StartDate = Convert.ToDateTime( "1900-01-01 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 4,
                    EventHtml = @"&lt;p&gt;On June 7, 2010, the Supreme Court decided the case of &lt;em&gt;Hamilton v. Lanning&lt;/em&gt;, 560 U.S. ___ (2010), for which the lower court decisions have been reported in detail in Becket &amp;amp; Lee&amp;#39;s newsletter, &lt;em&gt;Bankruptcy Report&lt;/em&gt;.&lt;/p&gt;

&lt;p&gt;In the six months prior to filing her petition, the debtor accepted a buyout from her employer, coincident with her termination. This financial &amp;quot;bump&amp;quot; placed her &amp;quot;current monthly income&amp;quot; above the median income for Kansas. Recognizing the transience of this income figure, the debtor proposed a chapter 13 plan payment based on her far lower income and expenses at the time of her petition and as anticipated thereafter.&lt;/p&gt;

&lt;p&gt;The chapter 13 trustee objected to the confirmation of the debtor&amp;#39;s proposed plan, arguing that the Bankruptcy Code determined the plan payment to be the amount found on the &amp;quot;bottom line&amp;quot; of Official Form 22C. This bottom line is the result of subtracting the Form&amp;#39;s expenses from the debtor&amp;#39;s &amp;quot;current monthly income,&amp;quot; which is also calculated in strict compliance with the statute.&lt;/p&gt;

&lt;p&gt;The Supreme Court of the United States affirmed the United States Court of Appeals for the Tenth Circuit, rejecting the so-called mechanical approach as inconsonant with the Code. It held that &amp;quot;when a bankruptcy court calculates a debtor&amp;#39;s projected disposable income, the court may account for changes in the debtor&amp;#39;s income or expenses that are known or virtually certain at the time of confirmation.&amp;quot; Echoing the appeals court&amp;#39;s analysis, the Court opined that the meaning of statutory language such as &amp;quot;projected&amp;quot; (as in &amp;quot;projected disposable income&amp;quot;), &amp;quot;to be received in the applicable commitment period,&amp;quot; and &amp;quot;as of the effective date of the plan&amp;quot; (being defined by the Court as the confirmation date), lead to a holding that &amp;quot;the &amp;#39;forward-looking approach&amp;#39; is correct.&amp;quot; Such an approach is further supported by pre-BAPCPA practice, still valid &amp;quot;&amp;#39;absent a clear indication that Congress intended such a departure.&amp;#39;&amp;quot; The Court rejected as flawed each of the trustee&amp;#39;s suggested &amp;quot;work arounds&amp;quot; to avoid or mitigate the effects of the mechanical approach he urged.&lt;/p&gt;

&lt;p&gt;The dissent agreed that while &amp;quot;expenses at least arguably depend on estimations of the debtor&amp;#39;s future circumstances,&amp;quot; a debtor&amp;#39;s current monthly income is a statutorily defined fixed amount based strictly on historical data. Such result was the only proper outcome considering the strict language of the statute. If this result runs counter to that which Congress intended, it may correct it.&lt;/p&gt;

&lt;p&gt;As a practical matter, &lt;em&gt;Lanning&lt;/em&gt; should drive courts to require debtors to propose chapter 13 plans that more realistically reflect their ability to pay creditors. Also, this decision should have some effect on the case of &lt;em&gt;Ransom v. MBNA, Am. Bank, N.A. (In re Ransom)&lt;/em&gt;, currently before the Supreme Court. Litigated successfully by Becket &amp;amp; Lee through the Ninth Circuit Court of Appeals, &lt;em&gt;Ransom&lt;/em&gt; denied an &amp;quot;above-median&amp;quot; chapter 13 debtor an expense for vehicle ownership for a vehicle unencumbered by a loan or lease obligation, holding that the plain language of the Bankruptcy Code prohibited the debtor from deducting the expense for a car he owns &amp;quot;free and clear.&amp;quot; It would not permit the debtor to reduce his payments to his unsecured creditors on the basis of a &amp;quot;fictitious expense.&amp;quot;&lt;/p&gt;

&lt;p&gt;On June 8, 2010, Becket &amp;amp; Lee partner Alane Becket participated in a teleconference sponsored by the American Bankruptcy Institute in which she, a chapter 13 trustee and several law professors discussed &lt;em&gt;Lanning&lt;/em&gt; and its practical impact for both creditors and debtors. A recording of the teleconference is available on the ABI&amp;#39;s website (&lt;a href=&quot;http://www.abiworld.org/webinars/2010/Hamilton_Lanning_Supreme_Court/index.html&quot;&gt;&lt;span style=&quot;color:#0066cc&quot;&gt;www.abiworld.org&lt;/span&gt;&lt;/a&gt;).&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Supreme Court Rules on the Expensing of Fictional Car Payment ",
                    CreatedDate = Convert.ToDateTime( "2017-06-07 18:44:15.7412057" ),
                    StartDate = Convert.ToDateTime( "1900-01-01 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 4,
                    EventHtml = @"&lt;p&gt;On January 11, 2011, the Supreme Court decided the case of &lt;em&gt;Ransom v. FIA Card Services, N.A.&lt;/em&gt;, No. 09-907, &lt;em&gt;slip op.&lt;/em&gt; (U.S. Jan. 11, 2011). The Court determined that a debtor may not claim a car ownership allowance to reduce the amount paid into a chapter 13 plan for a car owned free and clear of any liens or leases. This ruling will provide Ransom&amp;#39;s unsecured creditors an additional $28,000.&lt;/p&gt;

&lt;p&gt;The Bankruptcy Code states that a &amp;quot;debtor&amp;#39;s monthly expenses shall be the debtor&amp;#39;s &lt;em&gt;applicable &lt;/em&gt; monthly expense amounts specified under the National Standards and Local Standards&amp;quot; (emphasis added). The Court decided that an expense is &amp;quot;applicable&amp;quot; if a debtor incurs costs that correspond to it-more precisely, &amp;quot;only if the debtor will incur that kind of expense during the life of the plan.&amp;quot; Furthermore, the Court examined the statutory context of the means test, particularly its use in the calculation of a chapter 13 debtor&amp;#39;s disposable income. Chapter 13 requires a debtor&amp;#39;s expense amounts to be &amp;quot;reasonably necessary.&amp;quot; The Court reasoned that if a debtor will not pay a particular expense during the life of his plan, then an allowance for a wholly fictional expense is not reasonably necessary. Finally, the Court reminded that Congress purposed, in its 2005 amendments to the Bankruptcy Code (enacted as the Bankruptcy Abuse Prevention and Consumer Protection Act of 2005), to ensure that a debtor repays creditors the maximum affordable amount. Allowing the debtor to deduct an expense that he does not pay would, according to the Supreme Court, thwart this purpose.&lt;/p&gt;

&lt;p&gt;This case, along with the &lt;em&gt;Lanning&lt;/em&gt; decision by the Supreme Court last year, provides the framework for determining how to calculate a chapter 13 debtor&amp;#39;s plan payments under BAPCPA. The combined effect is positive for unsecured creditors, and reinforces Congressional intent of having debtors repay as much as they can afford.&lt;/p&gt;

&lt;p&gt;Becket &amp;amp; Lee served as counsel to FIA Card Services in this matter, briefing this case for the bankruptcy court and the Bankruptcy Appellate Panel, and briefing and arguing the matter before the Ninth Circuit Court of Appeals. At the Supreme Court, Becket &amp;amp; Lee served as co-counsel and assisted with the preparation of the brief and oral argument. Future editions of &lt;em&gt;Bankruptcy Report&lt;/em&gt; will have a more detailed analysis of the impact of both the &lt;em&gt;Ransom and Lanning&lt;/em&gt; decisions.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );

                await context.SaveChangesAsync();

            }
        }
    }
}