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
            
            if (!context.Events.Any() || context.Events.Count() != 135)
            {
                // delete
                context.RemoveRange( context.Events );
                await context.SaveChangesAsync();

                var eventObj = new Event()
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
                    Title = @"Supreme Court Rules on the Expensing of Fictional Car Payment ",
                    CreatedDate = Convert.ToDateTime( "2017-06-07 18:44:15.7412057" ),
                    StartDate = Convert.ToDateTime( "2011-05-31 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 4,
                    EventHtml = @"&lt;p&gt;On January 11, 2011, the Supreme Court decided the case of &lt;em&gt;Ransom v. FIA Card Services, N.A.&lt;/em&gt;, No. 09-907, &lt;em&gt;slip op.&lt;/em&gt; (U.S. Jan. 11, 2011). The Court determined that a debtor may not claim a car ownership allowance to reduce the amount paid into a chapter 13 plan for a car owned free and clear of any liens or leases. This ruling will provide Ransom&amp;#39;s unsecured creditors an additional $28,000.&lt;/p&gt;

&lt;p&gt;The Bankruptcy Code states that a &amp;quot;debtor&amp;#39;s monthly expenses shall be the debtor&amp;#39;s &lt;em&gt;applicable &lt;/em&gt; monthly expense amounts specified under the National Standards and Local Standards&amp;quot; (emphasis added). The Court decided that an expense is &amp;quot;applicable&amp;quot; if a debtor incurs costs that correspond to it-more precisely, &amp;quot;only if the debtor will incur that kind of expense during the life of the plan.&amp;quot; Furthermore, the Court examined the statutory context of the means test, particularly its use in the calculation of a chapter 13 debtor&amp;#39;s disposable income. Chapter 13 requires a debtor&amp;#39;s expense amounts to be &amp;quot;reasonably necessary.&amp;quot; The Court reasoned that if a debtor will not pay a particular expense during the life of his plan, then an allowance for a wholly fictional expense is not reasonably necessary. Finally, the Court reminded that Congress purposed, in its 2005 amendments to the Bankruptcy Code (enacted as the Bankruptcy Abuse Prevention and Consumer Protection Act of 2005), to ensure that a debtor repays creditors the maximum affordable amount. Allowing the debtor to deduct an expense that he does not pay would, according to the Supreme Court, thwart this purpose.&lt;/p&gt;

&lt;p&gt;This case, along with the &lt;em&gt;Lanning&lt;/em&gt; decision by the Supreme Court last year, provides the framework for determining how to calculate a chapter 13 debtor&amp;#39;s plan payments under BAPCPA. The combined effect is positive for unsecured creditors, and reinforces Congressional intent of having debtors repay as much as they can afford.&lt;/p&gt;

&lt;p&gt;Becket &amp;amp; Lee served as counsel to FIA Card Services in this matter, briefing this case for the bankruptcy court and the Bankruptcy Appellate Panel, and briefing and arguing the matter before the Ninth Circuit Court of Appeals. At the Supreme Court, Becket &amp;amp; Lee served as co-counsel and assisted with the preparation of the brief and oral argument. Future editions of &lt;em&gt;Bankruptcy Report&lt;/em&gt; will have a more detailed analysis of the impact of both the &lt;em&gt;Ransom and Lanning&lt;/em&gt; decisions.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Supreme Court Rules on Calculation of Chapter 13 Plan Payment",
                    CreatedDate = Convert.ToDateTime( "2017-06-07 18:44:51.4112057" ),
                    StartDate = Convert.ToDateTime( "2011-05-30 00:00:00.0000000" ),
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
                    Title = @"Are Balance Transfers Avoidable?",
                    CreatedDate = Convert.ToDateTime( "2017-06-07 18:45:30.2072057" ),
                    StartDate = Convert.ToDateTime( "2011-05-29 00:00:00.0000000" ),
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
                    Title = @"In Calculating Plan Payments, Can Debtors Deduct For A Car Payment They Don't Have?",
                    CreatedDate = Convert.ToDateTime( "2017-06-07 18:46:51.4972057" ),
                    StartDate = Convert.ToDateTime( "2011-05-28 00:00:00.0000000" ),
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
                    Title = @"Temporary Underemployment No Basis To Discharge Student Loan Debt",
                    CreatedDate = Convert.ToDateTime( "2017-06-07 18:47:32.3682057" ),
                    StartDate = Convert.ToDateTime( "2011-05-27 00:00:00.0000000" ),
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
                    Title = "\"Inc.\" Offers No Protection For Debtor",
                    CreatedDate = Convert.ToDateTime( "2017-06-07 18:48:34.3932057" ),
                    StartDate = Convert.ToDateTime( "2011-05-26 00:00:00.0000000" ),
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
                    Title = @"Can a Debtor Really Keep an Escalade?",
                    CreatedDate = Convert.ToDateTime( "2017-06-07 18:50:48.2362057" ),
                    StartDate = Convert.ToDateTime( "2011-05-25 00:00:00.0000000" ),
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
                    Title = @"Company President Found Individually Liable for Corporate Account",
                    CreatedDate = Convert.ToDateTime( "2017-06-07 18:51:43.2072057" ),
                    StartDate = Convert.ToDateTime( "2011-05-23 00:00:00.0000000" ),
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
                    Title = "The \"Hanging Paragraph\" and a Secured Creditor's Surrender Dilemma ",
                    CreatedDate = Convert.ToDateTime( "2017-06-07 18:54:35.4492057" ),
                    StartDate = Convert.ToDateTime( "2011-05-22 00:00:00.0000000" ),
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
                    Title = "Credit Reporting Emerging as \"Hot\" Issue in Bankruptcy Litigation",
                    CreatedDate = Convert.ToDateTime( "2017-06-09 13:31:16.8202517" ),
                    StartDate = Convert.ToDateTime( "2011-05-21 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 4,
                    EventHtml = @"&lt;p&gt;Furnishing information to credit reporting agencies is a common transaction in the creditor-debtor relationship. However, when a debtor files for bankruptcy protection, several questions arise: Does the Bankruptcy Code compel a creditor to update the agencies after a debtor receives a discharge in bankruptcy? Is the failure to do so an &amp;quot;act&amp;quot; to collect a discharged debt, actionable under the Bankruptcy Code or another federal statute? Will the Creditor be liable for damages if it does not update a credit report to show the debtor&amp;#39;s discharge? In a recent opinion, a bankruptcy court had the opportunity to discuss these questions and review previous case law on this important topic. Since this issue will undoubtedly be the subject of significant litigation in the future, it is important that all creditors are aware of this litigation and the holdings of various bankruptcy courts.&lt;/p&gt;

&lt;p&gt;In &lt;em&gt;Torres&lt;/em&gt;, which was a consolidation of two cases with similar facts against the same Creditor, the last information supplied by the Creditor was pre-petition, and showed the accounts as &amp;quot;past due&amp;quot; or &amp;quot;charged off.&amp;quot; The entries also included the balance on the accounts. The complaints alleged that the Creditor refused the Debtors&amp;#39; requests to supply updated information to the credit reporting agencies, reflecting that the creditor&amp;#39;s debts had been discharged in bankruptcy. According to the Debtors, the Creditor&amp;#39;s inaction violated the discharge injunction in the bankruptcy code, which, after the Debtors&amp;#39; discharge, prohibits the &amp;quot;commencement or continuation of an action, the employment of process, or an act, to collect, recover or offset any such debt as a personal liability of the debtor.&amp;quot; The Debtors also alleged a violation of the Fair Credit Reporting Act while the Creditor insisted that it was not required to &amp;quot;update&amp;quot; a report after a debtor received a discharge. The Debtors further averred that the failure to update their reports was part of a larger scheme by the Creditor to coerce collection of discharged debts.&lt;/p&gt;

&lt;p&gt;The Creditor filed motions to dismiss the Debtors&amp;#39; complaints, arguing that the actions were not &amp;quot;acts to collect&amp;quot; the debts, that the pre-petition information was accurate, that it had no after-discharge duty to update the agencies with the Debtors&amp;#39; discharge, and that its actions did not rise to the level of willfulness and egregious or oppressive conduct or bad faith. To support its position, the Creditor relied on three prior bankruptcy court opinions that it averred showed that its failure to update the reports were not acts to collect a debt. The Court reviewed each of the cases cited by the Creditor but found none persuasive.&lt;/p&gt;

&lt;p&gt;The first case involved a debtor&amp;#39;s lawsuit claiming a the creditor violated the discharge injunction by allegedly making false reports to credit reporting agencies. In that case, the court held that false reporting alone is not a violation of the Bankruptcy Code. Rather, to be actionable as a violation of the discharge injunction, a false statement must be reported &lt;em&gt;with the intention&lt;/em&gt; of forcing the debtors to pay the debt. Because in &lt;em&gt;Torres&lt;/em&gt; the Debtors alleged that the Creditor engaged in a pattern of abusive and threatening collections schemes intended to force payment of discharged debts, the court distinguished the Creditor&amp;#39;s first supporting case. Additionally, the Court noted that several other Bankruptcy Courts had already ruled that false or outdated reporting to the credit agencies, even without further collection attempts, can constitute an &amp;quot;act&amp;quot; to extract payment, in direct violation of Section 524.&lt;/p&gt;

&lt;p&gt;The second case relied upon by the Creditor in its defense was similar to the first in that the debtor failed to adequately prove that the Creditors&amp;#39; reporting was an &amp;quot;act&amp;quot; to collect a debt. However, the &lt;em&gt;Torres&lt;/em&gt; Court did note that the earlier court did foresee situations where the continued reporting of a debt may in fact be an &amp;quot;act&amp;quot; sufficient to violate the discharge injunction of Section 524; namely, &amp;quot;. . . if the act of reporting a debt was undertaken for the specific purpose of coercing the debtor into paying the debt.&amp;quot;&lt;/p&gt;

&lt;p&gt;Finally, the Court was not persuaded by the third case cited by the Creditor in which the court found that, because a discharged debt is not extinguished, but rather, is merely unenforceable against the debtor, reporting the debt and the balance as &amp;quot;past due&amp;quot; was not inaccurate. This Torres Court simply disagreed with this finding, instead holding that a credit report that continues to note a discharged debt as &amp;quot;outstanding,&amp;quot; &amp;quot;charged off,&amp;quot; or &amp;quot;past due&amp;quot; is &amp;quot;unquestionably inaccurate and misleading, because end users will construe it to mean that the lender still has the ability to enforce the debt&amp;quot; because it was never discharged, the debtor has reaffirmed the debt, or the debt was declared nondischargeable.&lt;/p&gt;

&lt;p&gt;In denying the Creditor&amp;#39;s motion to dismiss the complaints, the Court questioned the Creditor&amp;#39;s position that credit reporting is &amp;quot;of only historical interest, lacking any continuing effect on a consumer&amp;#39;s life&amp;quot; which was a &amp;quot;highly unusual position for a financial institution to take.&amp;quot; While stopping short of finding liability at this stage, the Court&amp;#39;s refusal to dismiss the complaints means that the Debtors will be able to continue to pursue their claims and will likely begin to engage in discovery of the Creditor&amp;#39;s credit reporting practices. This case signals an emerging split of authority on the issue of whether or not a creditor is required to update a credit report after a bankruptcy is filed, and if so, what must be reported and when. Future issues of &lt;em&gt;Bankruptcy Report&lt;/em&gt; will follow significant developments on this most important issue for creditors.&lt;br /&gt;
&lt;em&gt;In re Torres/In re Mateo&lt;/em&gt;, 2007 Bankr. Lexis 1478 (S.D.N.Y.)&lt;/p&gt;

&lt;div&gt;
&lt;h6 style=&quot;text-align:center&quot;&gt;&lt;em&gt;Bankruptcy Report&lt;/em&gt; is produced by Becket &amp;amp; Lee LLP, Attorneys at Law, as a service to our clients. Copyright 2007 by Becket &amp;amp; Lee LLP, except as otherwise noted. Reproduction of this newsletter is strictly prohibited without written permission from the publisher.&lt;/h6&gt;
&lt;/div&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Supreme Court's Ruling Provides Other Benefits",
                    CreatedDate = Convert.ToDateTime( "2017-06-09 13:32:23.2318922" ),
                    StartDate = Convert.ToDateTime( "2011-05-20 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 4,
                    EventHtml = @"&lt;p&gt;Certainly the Supreme Court&amp;#39;s decision in &lt;em&gt;Marrama&lt;/em&gt; has the benefit of resolving the question of the limits on a debtor&amp;#39;s right to convert in the face of bad faith conduct. However, the opinion also exposes the Supreme Court&amp;#39;s views on bankruptcy in general, its purposes, and how lower courts may act in crafting rulings that meet the goals of bankruptcy.&lt;/p&gt;

&lt;p&gt;The Court&amp;#39;s ruling acknowledged once again that bankruptcy is for the &amp;quot;honest but unfortunate debtor.&amp;quot; The Court also recognized the power of a bankruptcy court to &amp;quot;take appropriate action in response to fraudulent conduct by the atypical litigant who has demonstrated that he is not entitled to the relief available to the typical debtor.&amp;quot; Moreover, the Supreme Court condoned use of the bankruptcy court&amp;#39;s general powers under section 105 of the Code to &amp;quot;take any action that is necessary or appropriate to prevent an abuse of process...&amp;quot; to reach the correct result in this case.&lt;/p&gt;

&lt;p&gt;This language and the Court&amp;#39;s sentiment will be helpful to practitioners struggling to interpret the complex and sometimes unclear language of the Code resulting from its amendment by the Bankruptcy Abuse Prevention and Consumer Protection Act of 2005.&lt;/p&gt;

&lt;p&gt;For example, in the now frequent disputes over the amount a Chapter 13 debtor must pay to unsecured creditors, there is a clear split of authority over whether the amount is determined exclusively by the calculations made on the Official Form developed by the Rules Committee for use by Chapter 13 debtors, or whether a bankruptcy court may consider the debtor&amp;#39;s actual financial circumstances.&lt;/p&gt;

&lt;p&gt;The formulaic method has been criticized as rigid and artificial. The alternative approach that looks to a debtor&amp;#39;s actual financial circumstances has been criticized as a product of impermissible judicial legislation and beyond the plain language of the Code&amp;#39;s new regime.&lt;/p&gt;

&lt;p&gt;Regardless of what approach a bankruptcy court uses to calculate a debtor&amp;#39;s required plan payment, unsecured creditors may rely on &lt;em&gt;Marrama&lt;/em&gt; in urging a court to effect the Code in accordance with its purposes and spirit.&lt;/p&gt;

&lt;div&gt;
&lt;h6&gt;&lt;em&gt;Bankruptcy Report&lt;/em&gt; is produced by Becket &amp;amp; Lee LLP, Attorneys at Law, as a service to our clients. Copyright 2007 by Becket &amp;amp; Lee LLP, except as otherwise noted. Reproduction of this newsletter is strictly prohibited without written permission from the publisher.&lt;/h6&gt;
&lt;/div&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L's Complaint Results in Extreme Sanctions for Debtor's BPP",
                    CreatedDate = Convert.ToDateTime( "2017-06-09 13:33:37.2442927" ),
                    StartDate = Convert.ToDateTime( "2011-05-19 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 4,
                    EventHtml = @"&lt;p&gt;When Becket &amp;amp; Lee LLP files a fraud complaint on behalf of a Creditor, not only does the pleading become a matter of public record, but certain interested parties are served in accordance with the rules of procedure. These parties typically include the Chapter 7 Trustee assigned to the case, and the Office of the United States Trustee, who oversees the bankruptcy system.&lt;/p&gt;

&lt;p&gt;In a recent adversary proceeding, B&amp;amp;L&amp;#39;s complaint sparked interest at the U.S. Trustee&amp;#39;s office, and, based on the information contained in the exhibits, led to dismissal of the debtor&amp;#39;s case, and extreme sanctions for his bankruptcy petition preparer.&lt;/p&gt;

&lt;p&gt;A debtor is not always represented by an attorney; rather, a bankruptcy petition preparer (BPP) may assist a debtor in completing the necessary documents in preparation for filing bankruptcy. BPP&amp;#39;s are governed by Section 110 of the Bankruptcy Code, which includes sanctions and penalties for those preparers not abiding by the rules. Penalties range from monetary fines, disgorgement of any fees paid by a debtor, and/or having to reimburse a debtor for attorneys&amp;#39; fees later incurred to rectify problems created by the preparer, to being permanently barred from ever preparing documents to be filed in the bankruptcy court in the future.&lt;/p&gt;

&lt;p&gt;The Debtor held two credit card accounts, both of which were &amp;quot;run up&amp;quot; in a very short time period prior to his bankruptcy filing. Charges included over $21,000 at a business called American Internet for &amp;quot;real estate consulting&amp;quot;, $6,800 for lamps, $5,300 for &amp;quot;food and beverage&amp;quot;, $2,784 at Circuit City, and $2,998 for jewelry. Although payment in full was required, the only payments the Debtor tendered to the Creditor were three insufficient funds checks. B&amp;amp;L filed the fraud complaint and, receiving no answer, obtained a default judgment against the Debtor.&lt;/p&gt;

&lt;p&gt;After receiving its copy of the Creditor&amp;#39;s complaint, the U.S. Trustee moved to reopen the Debtor&amp;#39;s case, which had already been discharged. The U.S. Trustee reviewed the account statements showing all of the luxury charges but noted that the Debtor failed to list the purchases anywhere in his petition and schedules.&lt;/p&gt;

&lt;p&gt;The U.S. Trustee deposed the Debtor. Under oath, the Debtor admitted lying on his petition about his home address, personal property and other information, all at the behest of his BPP. He said that he bought the jewelry, electronics, lamps and then sold them for approximately 50 percent to fund his gambling addiction. The Debtor also explained that the American Internet charges were, in fact, fraudulent cash advances incurred through the service establishment account of his BPP. When it came time to pay the BPP, the Debtor was instructed to give the BPP all of his credit cards. The BPP told the Debtor that he could help the Debtor by getting cash for him using the cards, in exchange for 50 percent of the cash obtained. The BPP also counseled the Debtor to open five new credit cards; filling out the applications and presenting them to the Debtor for signature.&lt;/p&gt;

&lt;p&gt;The BPP and the Debtor went to various stores where they purchased items using the accounts. After making the charges, the preparer gave the Debtor small amounts of cash. The BPP took the purchases, which he sold for cash.&lt;/p&gt;

&lt;p&gt;The Debtor testified that the next month, when the billing statements began arriving, the Debtor turned them over to the BPP. The BPP then demanded money from the Debtor for charges that were solely the Debtor&amp;#39;s and not related to their money making scheme. The BPP told the Debtor that they should keep using his credit cards because they were about to be cut off for failure to pay, but that he would not have to pay since they would file the bankruptcy petition.&lt;/p&gt;

&lt;p&gt;The Debtor testified that he went along with these plans because he &amp;quot;trusted him&amp;quot; but was also &amp;quot;fearful.&amp;quot; The Debtor lied to the Trustees and the court because he was &amp;quot;afraid to make an enemy&amp;quot; of the BPP. Later, the BPP told the Debtor to continue the charade, and that he would find him a &amp;quot;good attorney.&amp;quot; That was the last time the Debtor heard from the BPP. However, this was not the last that the BPP would hear from the U.S. Trustee or the Bankruptcy Court.&lt;/p&gt;

&lt;p&gt;The Trustee filed for sanctions against the BPP. The motion detailed the &amp;quot;abusive conduct&amp;quot; in this case, including how the BPP took advantage of the Debtor, how he aided and abetted his credit card and bankruptcy fraud as well as other crimes, and monetarily benefited from this scheme. Based on this conduct, the Trustee moved the Court for an Order issuing an injunction preventing the preparer from ever doing this again in the future, to impose monetary fines, and to disgorge his fees including the money obtained from the charges on the credit card.&lt;/p&gt;

&lt;p&gt;The Court set a hearing on the motion and ordered that the BPP file a response and appear to explain why he should not be punished. The hearing was never held since the BPP reached an agreement with the U.S. Trustee. The BPP denied the allegations of the motion, but nevertheless stated that he was leaving the United States and returning to his home country. Thus, the Court signed the agreement and forever barred this individual from acting as a bankruptcy petition preparer.&lt;/p&gt;

&lt;p&gt;&lt;em&gt;In re Tony&lt;/em&gt;, No. SA-05-12694-jb (Bankr. C.D. Cal., 2005).&lt;/p&gt;

&lt;div&gt;
&lt;h6 style=&quot;text-align:center&quot;&gt;&lt;em&gt;Bankruptcy Report&lt;/em&gt; is produced by Becket &amp;amp; Lee LLP, Attorneys at Law, as a service to our clients. Copyright 2006 by Becket &amp;amp; Lee LLP, except as otherwise noted. Reproduction of this newsletter is strictly prohibited without written permission from the publisher.&lt;/h6&gt;
&lt;/div&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Disposable Income: Then or Now?",
                    CreatedDate = Convert.ToDateTime( "2017-06-09 13:34:58.4094084" ),
                    StartDate = Convert.ToDateTime( "2011-05-18 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 4,
                    EventHtml = @"&lt;p&gt;The last issue of the Bankruptcy Report introduced a few early cases addressing the requirement for a Chapter 13 plan to devote all of a debtor&amp;#39;s projected disposable income to paying unsecured creditors. Since then, more decisions have been issued, as creditors, Trustees, and courts increase their scrutiny of debtors&amp;#39; plans as part of the plan confirmation process.&lt;/p&gt;

&lt;p&gt;&lt;strong&gt;I. What is projected disposable income and why is it important?&lt;/strong&gt;&lt;/p&gt;

&lt;p&gt;First, a brief review of the issue. It has always been the case that, in order to gain confirmation of a Chapter 13 plan, a debtor must pay in full each allowed unsecured claim or devote to the plan all &amp;quot;projected disposable income&amp;quot; &amp;quot;to be received&amp;quot; during the plan term.&lt;/p&gt;

&lt;p&gt;BAPCPA added to this requirement a definition of &amp;quot;disposable income&amp;quot;. Since the definition does not include the word &amp;quot;projected&amp;quot;, some courts have found that &amp;quot;projected disposable income&amp;quot; can potentially be an amount different from the new definition of &amp;quot;disposable income&amp;quot;. Others, by various devices, have not.&lt;/p&gt;

&lt;p&gt;This, then, is the issue: whether &amp;quot;projected disposable income&amp;quot; is distinguishable from &amp;quot;disposable income&amp;quot; for the purposes of plan confirmation. The Bankruptcy Code explicitly defines disposable income as current monthly income, less reasonable monthly expenses. If a debtor&amp;#39;s current monthly income exceeds the median family income of her state, the reasonableness of the expenditure amounts is determined by tests set forth in 11 U.S.C. &amp;sect; 707(b)(2), otherwise known as the &amp;quot;means test&amp;quot;. If a debtor is below the state&amp;#39;s median, the debtor&amp;#39;s expenses are examined under the standard of &amp;quot;reasonable and necessary.&amp;quot;&lt;/p&gt;

&lt;p&gt;According to some, a debtor&amp;#39;s &lt;strong&gt;projected&lt;/strong&gt; disposable income is not the same as the debtor&amp;#39;s &amp;quot;disposable income,&amp;quot; calculated according to the formula noted above. By the addition of the word &amp;quot;projected&amp;quot;, as well as the language &amp;quot;to be received&amp;quot;, the Bankruptcy Code appears to require a determination of a debtor&amp;#39;s &lt;strong&gt;anticipated&lt;/strong&gt; income, rather than the debtor&amp;#39;s income determined at the petition date and by the formula.&lt;/p&gt;

&lt;p&gt;&lt;strong&gt;II. &amp;quot;Projected&amp;quot; disposable income is consequentially different from disposable income.&lt;/strong&gt;&lt;/p&gt;

&lt;p&gt;In the last issue, we revisited the case of &lt;em&gt;In re Hardacre&lt;/em&gt;. In that case, the United States Bankruptcy Court for the Northern District of Texas concluded that projected disposable income &amp;quot;necessarily refers to income that the debtor reasonably expects to receive during the term of her plan.&amp;quot; Many others agree. For example, the court, in &lt;em&gt;In re Dew&lt;/em&gt;, opined that &amp;quot;disposable income in &amp;sect; 1325(b)(2) is not necessarily the same as projected disposable income in &amp;sect;1325(b)(1)(B)....To hold otherwise would assign no meaning to the term &amp;#39;projected&amp;#39;, which would be contrary to rules of statutory construction.&amp;quot; Other decisions agreed, holding that Congress intended, by the inclusion of the word &amp;quot;projected&amp;quot;, a forward-looking examination of a debtor&amp;#39;s anticipated income, realizing that, possibly because of the circumstances that resulted in bankruptcy, a debtors after-bankruptcy income may not be similar to her before-bankruptcy income.&lt;/p&gt;

&lt;p&gt;The Bankruptcy Report&amp;#39;s last issue also reviewed &lt;em&gt;In re Jass&lt;/em&gt;, which focused not only on the language of the statute, but its purpose as well. Other courts followed, using similar reasoning, including &lt;em&gt;In re Grady&lt;/em&gt;, which found, on the basis of the plain language of the statute and the policy goals of the Bankruptcy Code, that determination of projected disposable income necessarily requires a consideration of a debtor&amp;#39;s future and historical finances. In &lt;em&gt;In re Risher&lt;/em&gt;, the court required that income tax refunds go into plan payments because projected disposable income is based on anticipated income over the term of the plan. Another case, &lt;em&gt;In re Pak&lt;/em&gt;, declared that, for the purposes of confirmation of a Chapter 13 plan, a determination of projected disposable income must include a debtor&amp;#39;s actual and anticipated future income. In another case, &lt;em&gt;In re Fuger&lt;/em&gt;, the court decided that the term &amp;quot;projected disposable income&amp;quot; requires that a plan&amp;#39;s payments be based on disposable income as projected into the future.&lt;/p&gt;

&lt;p&gt;&lt;strong&gt;III. &amp;quot;Projected&amp;quot; disposable income is the same as disposable income.&lt;/strong&gt;&lt;/p&gt;

&lt;p&gt;Predictably, another approach denies any independent operation of the term &amp;quot;projected&amp;quot; as used to modify &amp;quot;disposable income&amp;quot;. The United States Bankruptcy Court for the Eastern District of North Carolina held that the Code &amp;quot;plainly sets forth a new definition and method for calculating disposable income,&amp;quot; to which projected disposable income is &amp;quot;linked&amp;quot;, and that determination of disposable income is a mathematical calculation mandated by the formula set forth in Section 1325(b)(2). As a result, &amp;quot;debtors with no disposable income under the new law have no projected disposable income.&amp;quot; The Court noted that there may be cases where the formula allows debtors who actually have excess income each month to avoid paying anything to their unsecured creditors; however, it felt that the already determined disposable income was the most obvious interpretation of the language of the amendment. The Court did note that, &amp;quot;Perhaps Congress, in an effort to make higher income debtors pay more to their unsecured creditors, unwittingly reached the opposite result(&lt;em&gt;In re Alexander&lt;/em&gt;).&amp;quot;&lt;/p&gt;

&lt;p&gt;&lt;strong&gt;IV. Projected disposable income is a function of projected expenses.&lt;/strong&gt;&lt;/p&gt;

&lt;p&gt;Recall that projected disposable income is a &amp;quot;net&amp;quot; figure rather than a &amp;quot;gross&amp;quot; amount. Consequently, a few objections to confirmation have focused on the expense side of the ledger. Thus, the issue becomes whether to use, in the words of the United States Bankruptcy Court for the Western District of Missouri, &amp;quot;historical or projected expenses to determine the amount of a debtor&amp;#39;s disposable income that must be devoted to a chapter 13 plan&amp;quot; (&lt;em&gt;In re Renicker&lt;/em&gt;). The &lt;em&gt;Renicker&lt;/em&gt; court, examining statutory language that disposable income is net of amounts reasonably necessary &amp;quot;to be expended&amp;quot;, decided that the plain language of the statute &amp;quot;unambiguously indicates that prospective - not historical - expenses are to be used to calculate disposable income.&amp;quot;&lt;/p&gt;

&lt;p&gt;&lt;strong&gt;V. Disposable income may not consider projected expenses.&lt;/strong&gt;&lt;/p&gt;

&lt;p&gt;Following the same logic as the debate over income, a court stated that expenses for above median income debtors cannot be what &amp;quot;may&amp;quot; occur. Instead, expenses are limited to those disclosed on Form B22C, completed in strict compliance with the expenses allowed under the means test (&lt;em&gt;In re Guzman&lt;/em&gt;). The Court admitted that &amp;quot;the result of such enforcement is contrary to the popular notion that BAPCPA would require well-to-do debtors to repay as much of their debts as possible.&amp;quot;&lt;/p&gt;

&lt;p&gt;The court &lt;em&gt;In re Fuller&lt;/em&gt; ruled that &amp;quot;above-median debtors may not deduct from their income their actual expenses.&amp;quot; &amp;quot;Rather, they must use the specific, standardized dollar amounts listed in certain IRS publications....It doesn&amp;#39;t matter if the debtor feels those amounts are unreasonably low, if the Trustee feels those amounts are unreasonably high...&amp;quot; By the statute&amp;#39;s terms, only a below median income debtor is permitted to use &amp;quot;actual&amp;quot; expenses, subject to a determination of reasonableness.&lt;/p&gt;

&lt;p&gt;Clearly, &amp;quot;disposable income&amp;quot; and &amp;quot;projected disposable income&amp;quot; are grist for much judicial consideration and perhaps apt subjects for Congressional clarification.&lt;/p&gt;

&lt;div&gt;
&lt;p&gt;&lt;em&gt;Bankruptcy Report&lt;/em&gt; is produced by Becket &amp;amp; Lee LLP, Attorneys at Law, as a service to our clients. Copyright 2006 by Becket &amp;amp; Lee LLP, except as otherwise noted. Reproduction of this newsletter is strictly prohibited without written permission from the publisher.&lt;/p&gt;
&lt;/div&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"No Order in the Court!",
                    CreatedDate = Convert.ToDateTime( "2017-06-09 13:37:52.1597817" ),
                    StartDate = Convert.ToDateTime( "2011-05-17 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 4,
                    EventHtml = @"&lt;p&gt;New Code section 11 U.S.C. &amp;sect; 521(i), states that if an individual debtor in a Chapter 7 or 13 case fails to file all of the documentation required by &amp;sect; 521(a)(1) within 45 days after the date of the filing of the petition, the case shall be &amp;quot;automatically dismissed&amp;quot; effective on the 46th day after the date of the filing of the petition. A court order dismissing the case is not required.&lt;/p&gt;

&lt;p&gt;Several concerns have been raised regarding &amp;quot;automatic dismissals&amp;quot; that might occur, without any notice to interested parties. For example, debtors are required to file 60 days of &amp;quot;payment advices&amp;quot; with their petitions. If the debtor misses one pay advice, the case is &amp;quot;automatically dismissed.&amp;quot; But what if no one recognizes this and the case goes on? What if the debtor receives a discharge? Can a party later challenge this on the basis that the case was &amp;quot;dismissed&amp;quot; on the 46th day?&lt;/p&gt;

&lt;p&gt;One Florida judge mused over these questions and issued this creative opinion in a case curiously called &lt;em&gt;In Re Riddle:&lt;/em&gt;&lt;/p&gt;

&lt;p style=&quot;margin-left:40px&quot;&gt;I do not like dismissal automatic,&lt;br /&gt;
It seems to me to be traumatic.&lt;br /&gt;
I do not like it in this case,&lt;br /&gt;
I do not like it any place.&lt;/p&gt;

&lt;p style=&quot;margin-left:40px&quot;&gt;As a judge I am most keen&lt;br /&gt;
to understand, What does it mean?&lt;br /&gt;
How can any person know&lt;br /&gt;
what the docket does not show?&lt;/p&gt;

&lt;p style=&quot;margin-left:40px&quot;&gt;What is the clue on the 46th day?&lt;br /&gt;
Is the case still here, or gone away?&lt;br /&gt;
And if a debtor did not do&lt;br /&gt;
what the Code had told him to&lt;br /&gt;
and no concerned party knew it,&lt;br /&gt;
Still the Code says the debtor blew it.&lt;br /&gt;
Well that is what it seems to say:&lt;br /&gt;
the debtor&amp;#39;s case is then &amp;quot;Oy vay!&amp;quot;&lt;/p&gt;

&lt;p style=&quot;margin-left:40px&quot;&gt;This kind of law is symptomatic&lt;br /&gt;
of something very problematic.&lt;br /&gt;
For if the Trustee does not know&lt;br /&gt;
then which way should the trustee go?&lt;/p&gt;

&lt;p style=&quot;margin-left:40px&quot;&gt;Should the trustee&amp;#39;s view prismatic&lt;br /&gt;
continue to search the debtor&amp;#39;s attic&lt;br /&gt;
and collect debtors&amp;#39; assets in his fist&lt;br /&gt;
for distribution in a case that stands dismissed?&lt;br /&gt;
After a dismissal automatic&lt;br /&gt;
would this not be a bit erratic?&lt;/p&gt;

&lt;p style=&quot;margin-left:40px&quot;&gt;The poor trustee cannot know&lt;br /&gt;
the docket does not dismissal show.&lt;br /&gt;
What&amp;#39;s a poor trustee to do -&lt;br /&gt;
except perhaps to say, &amp;quot;Boo hoo!&amp;quot;&lt;/p&gt;

&lt;p style=&quot;margin-left:40px&quot;&gt;And if the case goes on as normal&lt;br /&gt;
and debtor gets a discharge formal,&lt;br /&gt;
what if a year later some fanatic&lt;br /&gt;
claims the case was dismissed automatic?&lt;/p&gt;

&lt;p style=&quot;margin-left:40px&quot;&gt;Was there a case, or wasn&amp;#39;t there one?&lt;br /&gt;
How do you undo what&amp;#39;s been done?&lt;br /&gt;
Debtor&amp;#39;s property is gone as if by a thief,&lt;br /&gt;
and Debtor is stripped but gets no relief.&lt;/p&gt;

&lt;p style=&quot;margin-left:40px&quot;&gt;I do not like dismissal automatic.&lt;br /&gt;
On this point I am emphatic!&lt;br /&gt;
I do not wish to be dramatic,&lt;br /&gt;
but I can not endure this static.&lt;br /&gt;
Something more in 521 is needed&lt;br /&gt;
for dismissal automatic to be heeded.&lt;/p&gt;

&lt;p style=&quot;margin-left:40px&quot;&gt;Dismissal automatic is not understood.&lt;br /&gt;
For all concerned this is not good.&lt;br /&gt;
Before this problem gets too old&lt;br /&gt;
it would be good if we were told:&lt;br /&gt;
What does automatic dismissal mean?&lt;br /&gt;
And by what means can it been seen?&lt;br /&gt;
Are we only left to guess?&lt;br /&gt;
Oh please Congress, fix this mess!&lt;br /&gt;
Until it&amp;#39;s fixed what should I do?&lt;br /&gt;
How can I explain this mess to you?&lt;/p&gt;

&lt;p style=&quot;margin-left:40px&quot;&gt;If the Code required an old fashioned order,&lt;br /&gt;
that would create a legal border,&lt;br /&gt;
with complying debtors&amp;#39; cases defended&lt;br /&gt;
and 521 violators&amp;#39; cases ended,&lt;br /&gt;
from the unknown status of dismissal automatic,&lt;br /&gt;
to the certainty of a status charismatic.&lt;br /&gt;
The dismissal automatic problem would be gone,&lt;br /&gt;
and debtors, trustees and courts could move on.&lt;/p&gt;

&lt;p style=&quot;margin-left:40px&quot;&gt;As to this case, how should I proceed?&lt;br /&gt;
Review of the record is warranted, indeed.&lt;br /&gt;
A very careful record review,&lt;br /&gt;
tells this Court what it should do.&lt;br /&gt;
Was this case dismissed automatic?&lt;br /&gt;
It definitely was NOT and that&amp;#39;s emphatic.&lt;/p&gt;

&lt;p&gt;&lt;em&gt;In re Riddle&lt;/em&gt;, Bankruptcy No. 06-11313 (Bankr. S.D. Fla. 2006).&lt;/p&gt;

&lt;div&gt;
&lt;h6 style=&quot;text-align:center&quot;&gt;&lt;em&gt;Bankruptcy Report&lt;/em&gt; is produced by Becket &amp;amp; Lee LLP, Attorneys at Law, as a service to our clients. Copyright 2006 by Becket &amp;amp; Lee LLP, except as otherwise noted. Reproduction of this newsletter is strictly prohibited without written permission from the publisher.&lt;/h6&gt;
&lt;/div&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = "Curtain Closes on \"Documentation\" Objections in South Florida ",
                    CreatedDate = Convert.ToDateTime( "2017-06-09 13:40:14.3319975" ),
                    StartDate = Convert.ToDateTime( "2011-05-16 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 4,
                    EventHtml = @"&lt;p&gt;Southern Florida was historically one of the most active jurisdictions in claim litigation. Debtors, apparently betting on a creditor&amp;#39;s unwillingness to spend money to defend a claim where repayment was by no means guaranteed, employed this strategy to disallow thousands of claims, and resultantly millions of dollars, through this mechanism.&lt;/p&gt;

&lt;p&gt;Judicial intervention was rare, as claims were disallowed &amp;quot;by default&amp;quot; if a creditor did not respond to the objection. If a creditor did respond, the debtor&amp;#39;s objection was typically withdrawn prior to a hearing. Recently, Becket &amp;amp; Lee scored a major victory in this battle when the Chief Bankruptcy Judge for the Southern District of Florida ruled that claim objections based solely on &amp;quot;insufficient documentation&amp;quot; would no longer be granted.&lt;/p&gt;

&lt;p&gt;In conformance with what has become the generally accepted majority view, the Court overruled objections to claims, refusing to disallow them for a putative lack of sufficient supporting documentation. The court repeated the position taken by &amp;quot;the vast majority of courts&amp;quot;, that a failure to comply fully with the documentation requirements of Fed. R. Bankr. P. 3001(c) is no basis for disallowing, or &lt;strong&gt;objecting to&lt;/strong&gt;, a claim. Rather, only the Bankruptcy Code, particularly 11 U.S.C. section 502(b), provides the grounds for disallowing a claim, and does not include insufficiency of documentation among them.&lt;/p&gt;

&lt;p&gt;As a general matter, a proof of claim may be sufficiently supported by an account summary and need not include the account agreement or evidence of each transaction. The court went on to specify its tests for sufficient documentation.&lt;/p&gt;

&lt;p&gt;First, a claim that is scheduled by the debtor, undisputed, in an amount equal to or greater than claimed requires little, if any, documentation. To the debtor who may schedule his debts as disputed in an attempt to force an unwarranted evidentiary burden on the creditor, the court warned that, &amp;quot;the term undisputed is not meant to solely relate to how the debt is scheduled, but rather to the lack of any objection to the merits of the claim&amp;quot;.&lt;/p&gt;

&lt;p&gt;The court overruled with prejudice objections to claims that corresponded to scheduled debts depicting identical account numbers and amounts that matched or exceeded those claimed.&lt;/p&gt;

&lt;p&gt;Second, a claim that exceeds the debtor&amp;#39;s scheduled amount need only be supported to the degree it exceeds the amount scheduled.&lt;/p&gt;

&lt;p&gt;Third, a claim for an unscheduled debt may, when challenged by a debtor&amp;#39;s objection, require more extensive documentation such as account statements. Nevertheless, such an objection will not stand if based solely on a lack of documentation. The court made its sentiment very clear:&lt;/p&gt;

&lt;p style=&quot;margin-left:40px&quot;&gt;&lt;em&gt;[T]his Court will not tolerate attempts to obtain orders disallowing these claims if the only basis for the objection is lack of documentation.&lt;/em&gt;&lt;/p&gt;

&lt;p&gt;Its patience was worn thin by:&lt;/p&gt;

&lt;p style=&quot;margin-left:40px&quot;&gt;&lt;em&gt;. . . debtors taking advantage of the cost of responding to claims objections and obtaining orders striking claims which the debtor has acknowledged owing in whole or in part.&lt;/em&gt;&lt;/p&gt;

&lt;p&gt;Since this opinion was published, other Judges in Southern Florida have adopted its reasoning and the volume of objections from this area has, temporarily at least, slowed to a trickle.&lt;/p&gt;

&lt;p&gt;&lt;em&gt;In re Moreno&lt;/em&gt;, No. 03-18692-BKC-RAM (Bankr. S.D. Fla. Apr. 13, 2006).&lt;/p&gt;

&lt;h6&gt;&lt;em&gt;Bankruptcy Report&lt;/em&gt; is produced by Becket &amp;amp; Lee LLP, Attorneys at Law, as a service to our clients. Copyright 2006 by Becket &amp;amp; Lee LLP, except as otherwise noted. Reproduction of this newsletter is strictly prohibited without written permission from the publisher.&lt;/h6&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @" Creditor Successfully Opens Default and Keeps Preferential Payments",
                    CreatedDate = Convert.ToDateTime( "2017-06-09 13:42:35.5691198" ),
                    StartDate = Convert.ToDateTime( "2011-05-15 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 4,
                    EventHtml = @"&lt;p&gt;In April 2003, the Debtors filed a Chapter 13 petition. The Debtors&amp;#39; attorney sent the creditor bank two letters requesting a return of preferential payments, which the Debtors intended to use to fund their Chapter 13 plan. The letters were sent to the address used by the creditor for receiving payments. The creditor did not respond to the letters and in December 2005, the debtors filed a complaint against the creditor, seeking return of the pre-petition payments.&lt;/p&gt;

&lt;p&gt;According to the proof of service, the complaint was also served at the creditor&amp;#39;s payment center. The complaint did not reach the creditor&amp;#39;s legal department and, therefore, the legal department did not respond to the complaint by filing an answer. Once the time to answer the complaint expired, the Debtors applied to the clerk of the court for entry of default, a preliminary step in obtaining a judgment against a defaulting party. After a default is entered by the clerk, the petitioning party may then request the court enter a judgment in its favor, based upon the default.&lt;/p&gt;

&lt;p&gt;The creditor received notice of the entry of default and referred it to Becket &amp;amp; Lee to attempt to obtain relief from the default. B&amp;amp;L partner Bill Becket&amp;#39;s review of the case suggested two procedural defects. First, service of the complaint appeared improper, and second, the complaint was not filed within the applicable statute of limitations. As such, if the default were opened, the suit would likely be dismissed as having not been timely filed. Therefore, on behalf of the creditor, Becket &amp;amp; Lee filed a motion to set aside the default.&lt;/p&gt;

&lt;p&gt;The bankruptcy court agreed with Mr. Becket&amp;#39;s analysis. It first discussed the standard for relief from a judgment entered by default, holding, &amp;quot;Where timely relief is sought from a default judgment and the movant has a meritorious defense, doubt, if any, should be resolved in favor of the motion to set aside the judgment.&amp;quot; Here, a default judgment had not been entered at the time Mr. Becket requested relief from the entry of default. Thus, the standard for setting aside the clerk&amp;#39;s entry of default is even more liberal and requires only &amp;quot;good cause,&amp;quot; which, according to the court, is to be more broadly construed than the specific grounds for opening a default judgment.&lt;/p&gt;

&lt;p&gt;In either case, however, a primary consideration for the court is whether the movant has a meritorious defense should the default be set aside. Here, the court relied on both the due process issue, and on the statute of limitations defense, in finding &amp;quot;good cause&amp;quot; to open the default.&lt;/p&gt;

&lt;p&gt;Regarding service of the complaint, the court noted that the fact that the bank did not respond to two letters sent to the payment address should have made the debtor&amp;#39;s attorney question whether the bank was receiving the letters. Second, the court ruled that service on a payment address was inadequate to meet the standard that it be &amp;quot;reasonably calculated ... to apprise interested parties of the pendency of the action.&amp;quot; Moreover, the court specifically noted that, &amp;quot;With today&amp;#39;s technology, it is easy enough to find the service address of record, or the agent for service of process, for most any business entity.&amp;quot;&lt;/p&gt;

&lt;p&gt;Noting the probable success of the statue of limitations defense raised by Mr. Becket, the court set aside the default. The bank will now likely keep the over $22,000 in payments it received prior to the Debtors&amp;#39; filing.&lt;/p&gt;

&lt;p&gt;&lt;em&gt;In re Kellenbeck&lt;/em&gt;, Bankruptcy No.03-23527 (Bankr. E. D. Ca. 2003)&lt;/p&gt;

&lt;div&gt;
&lt;h6 style=&quot;text-align:center&quot;&gt;&lt;em&gt;Bankruptcy Report&lt;/em&gt; is produced by Becket &amp;amp; Lee LLP, Attorneys at Law, as a service to our clients. Copyright 2006 by Becket &amp;amp; Lee LLP, except as otherwise noted. Reproduction of this newsletter is strictly prohibited without written permission from the publisher.&lt;/h6&gt;
&lt;/div&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"2nd Circuit Rules on Arbitration Clause in Bankruptcy Matter",
                    CreatedDate = Convert.ToDateTime( "2017-06-09 13:43:54.5350156" ),
                    StartDate = Convert.ToDateTime( "2011-05-14 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 4,
                    EventHtml = @"&lt;p&gt;The Debtor filed a class action against a credit card issuer, alleging a violation of the automatic stay. In response, the creditor moved to stay or dismiss the class action so that the matter could be arbitrated, pursuant to the binding arbitration clause found in the credit card account agreement. The bankruptcy court denied the creditor&amp;#39;s motion, holding that the &amp;quot;core&amp;quot; nature of an automatic stay violation more appropriately placed it before the bankruptcy court rather than an arbitrator. Upon appeal, the district court agreed. The Court of Appeals for the Second Circuit reversed the district court.&lt;/p&gt;

&lt;p&gt;While agreeing that the Debtor&amp;#39;s claim was a &amp;quot;core&amp;quot; bankruptcy matter, the Second Circuit found no inherent conflict between the Bankruptcy Code and the Federal Arbitration Act, whose upholding of contractual arbitration provisions posed no jeopardy to the objectives of bankruptcy. Previous appellate reviews by district courts had often found no conflict between the Code&amp;#39;s stay provisions and compulsory arbitration, especially when the issues were not central to the Code&amp;#39;s purposes and policies, and/or to the distribution of an estate in bankruptcy. The Court pointed out that the Debtor&amp;#39;s estate had already been fully administered and her debts discharged. Second, thanks to her decision to proceed in a class action, she distanced her stay violation claim, diluting its relevance to her individual bankruptcy. Third, the Court disagreed that a stay was so closely related to an injunctive order that a bankruptcy court was uniquely and exclusively able to interpret and enforce it.&lt;/p&gt;

&lt;p&gt;In sum, the Court acknowledged the importance of the automatic stay, but found no grounds in statute to exempt, categorically, any automatic stay related dispute from resolution by arbitration.&lt;/p&gt;

&lt;p&gt;Creditors may now be able to compel a debtor to arbitrate stay violations and possibly other matters rather than allow the debtor to file suit in local bankruptcy courts across the country. Instead of contending with the vastly different results that occur, and the high costs of defending actions in bankruptcy courts, creditors in automatic stay disputes may now be able to take advantage of the predictability and reduced costs arbitration can provide.&lt;/p&gt;

&lt;p&gt;&lt;em&gt;MBNA America Bank, N.A. vs Hill, No. 04-2086-BK&lt;/em&gt;, 2006 U.S. App. LEXIS 1786 (2d Cir. Jan. 25, 2006).&lt;/p&gt;

&lt;h6 style=&quot;text-align:center&quot;&gt;&lt;em&gt;Bankruptcy Report&lt;/em&gt; is produced by Becket &amp;amp; Lee LLP, Attorneys at Law, as a service to our clients. Copyright 2006 by Becket &amp;amp; Lee LLP, except as otherwise noted. Reproduction of this newsletter is strictly prohibited without written permission from the publisher.&lt;/h6&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"You Can't Buy Love - Especially On Credit",
                    CreatedDate = Convert.ToDateTime( "2017-06-09 13:44:40.7896406" ),
                    StartDate = Convert.ToDateTime( "2011-05-13 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 4,
                    EventHtml = @"&lt;p&gt;Fraudulent debtors who have been sued for credit card abuse will often defend their need to file bankruptcy. While some are honest, and can demonstrate good justification for filing bankruptcy, many will resort to desperate, convoluted and/or fabricated defenses in order to avoid paying their debts. Becket &amp;amp; Lee has heard &amp;quot;reasons&amp;quot; for non-payment ranging from the mundane and probable (loss of a job, adverse financial downturn, illness, divorce), to the incredible (threats from organized crime families, cultural and/or family traditions that include gifting of luxury goods, intention of repaying charges through gambling or lottery winnings). A recent case prosecuted by Becket &amp;amp; Lee on behalf of a Creditor had all the makings of a TV movie of the week.&lt;/p&gt;

&lt;p&gt;The Debtor had three credit card accounts with the Creditor when he filed his Chapter 7 case. Becket &amp;amp; Lee reviewed the activity on the accounts along with his court documents for possible fraud. On the first account, in the span of only a few days, the Debtor charged over $18,000, including $10,000 at a limousine company and almost $9,000 for &amp;quot;electronics.&amp;quot; On the second and third accounts, he incurred another $10,000 and $11,000 respectively for &amp;quot;electronics&amp;quot;. The Debtor then failed to remit payment on the accounts.&lt;/p&gt;

&lt;p&gt;The Debtor&amp;#39;s bankruptcy documents painted a gloomy financial picture that demonstrated there was no way the Debtor could have intended to repay the charges. He owned no real property, and had spartan personal property; that is, except for a brand new $40,000 automobile he bought just before his bankruptcy filing. Further, in addition to the Creditor&amp;#39;s accounts, the Debtor owed over $430,000 in other credit/charge card debt. The Debtor had little to no monthly income, and hadn&amp;#39;t been meaningfully employed in the years immediately preceding his bankruptcy, earning only $8,000 in each of the three preceding years. The Debtor&amp;#39;s bankruptcy documents showed a connection to a limousine business, which, the Debtor claimed, ceased operations four years prior to the bankruptcy.&lt;/p&gt;

&lt;p&gt;B&amp;amp;L Associate Attorney Ken Kleppinger sent a letter to the Debtor&amp;#39;s attorney offering the Debtor an opportunity to explain how he intended to repay the huge purchases made on the Creditor&amp;#39;s accounts, and asking that the Debtor disclose any mitigating circumstances for what appeared to be a clear case of fraud. Receiving no response, Mr. Kleppinger filed a Complaint to Determine Dischargeability of Debt, arguing that the Debtor ran up his accounts, incurring the charges fraudulently and without the intention of repaying the debts. Only once litigation was commenced did the Debtor&amp;#39;s attorney reply to Becket &amp;amp; Lee with a long, sorry tale of woe.&lt;/p&gt;

&lt;p&gt;The Debtor claimed that all of these charges were made in an attempt to save his marriage, which, apparently, was in considerable trouble at the time the charges were made. While the Debtor&amp;#39;s wife was characterized as &amp;quot;smart&amp;quot; by the attorney, the Debtor was considered meek and having &amp;quot;little self-esteem or will.&amp;quot; The attorney claimed that the wife manipulated the Debtor into running up his credit cards for her own benefit. The Debtor admitted that he made all the charges, but qualified this admission with the statement that he did so simply to appease her and to restore some semblance of a normal life. It was this &amp;quot;abusive relationship&amp;quot; and &amp;quot;lack of self-assuredness&amp;quot; that caused the Debtor&amp;#39;s spending spree, according to the attorney.&lt;/p&gt;

&lt;p&gt;As to what was purchased, the Debtor claimed not to be able to remember. He thought some of the charges were for the wife&amp;#39;s limousine business which, he now admitted, was still a going concern, while others were for household usage. The Debtor alleged to have made the charges in a vain attempt to save his fledgling marriage, but, despite all of the purchases, his wife divorced him anyway. The ex-wife kept the marital assets, including the items from the Debtor&amp;#39;s shopping spree, while the Debtor ended up receiving a small amount of alimony.&lt;/p&gt;

&lt;p&gt;Mr. Kleppinger explained to the Debtor&amp;#39;s attorney that, even if the Debtor&amp;#39;s story were true, the fact remained that the Debtor made the charges and could not have realistically intended to repay the Creditor, because he simply did not have the means to do so. The Debtor&amp;#39;s attorney was convinced of the strength of the Creditor&amp;#39;s case, and negotiated a large lump sum settlement. In order to pay the settlement amount, the Debtor apparently borrowed the money from a family member - most likely not his ex-wife.&lt;/p&gt;

&lt;p&gt;In re Vainshtein, Bankruptcy No. 03-49787 (Bankr. N.D. Il. 2003).&lt;/p&gt;

&lt;div&gt;
&lt;h6 style=&quot;text-align:center&quot;&gt;&lt;em&gt;Bankruptcy Report&lt;/em&gt; is produced by Becket &amp;amp; Lee LLP, Attorneys at Law, as a service to our clients. Copyright 2004 by Becket &amp;amp; Lee LLP, except as otherwise noted. Reproduction of this newsletter is strictly prohibited without written permission from the publisher.&lt;/h6&gt;
&lt;/div&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Defining and Terminating the Co-Debtor Stay",
                    CreatedDate = Convert.ToDateTime( "2017-06-09 13:45:40.9156526" ),
                    StartDate = Convert.ToDateTime( "2011-05-12 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 4,
                    EventHtml = @"&lt;p&gt;Often, more than one person is liable to a creditor under a security agreement or on a credit card account. Yet, in many instances, only one of the liable parties on an account will file bankruptcy (the debtor), while the other person (the non-filing co-debtor or NFCD) does not. As creditors are keenly aware, once a person files for bankruptcy, the Automatic Stay prevents acts to collect the debt from the debtor. Chapter 13 debtors are afforded the additional protection of the Co-debtor Stay. The following is an overview of the Co-debtor Stay and the procedure to terminate the Co-debtor Stay so that collection activities can commence against the non-filing co-debtor (NFCD).&lt;/p&gt;

&lt;p&gt;In petitions filed under Chapter 7 or Chapter 11 of the Bankruptcy Code, there is no co-debtor stay and the creditor may proceed with collection activities against the co-debtor under applicable state law. The policy behind the co-debtor stay in Chapter 13 is to prevent creditors from placing indirect pressure on the debtor by continuing collection activities against co-debtors, who are usually the debtor&amp;#39;s spouse, family members or friends. Where a debtor files a petition under Chapter 13, the Bankruptcy Code provides protection to co-debtors of the debtor, if the debts for which the co-debtor is liable with the debtor are consumer debts, usually meaning they were incurred for personal as opposed to business purposes.&lt;/p&gt;

&lt;p&gt;The effect of the co-debtor stay is that if a consumer has filed for bankruptcy under Chapter 13, and there is a co-debtor on the account, the creditor must not attempt to collect the debt from the co-debtor. Doing so is a violation of the co-debtor stay and the creditor may be subject to sanctions for a violation. Creditors are not forever barred from pursuing the co-debtor, but they will have to wait until the debtor&amp;#39;s Chapter 13 case is completed before they can attempt to collect the debt from the co-debtor. Creditors are not without recourse, however, in cases where the co-debtor stay applies.&lt;/p&gt;

&lt;p&gt;Creditors can file a Motion for Relief from the Co-debtor Stay and ask the Court to terminate the Stay under any one of three appropriate circumstances. First, under section 1301(c)(1) of the Bankruptcy Code, the co-debtor stay can be lifted if, as between the two parties on the account, the NFCD actually received the benefit from the account or debt. Second, pursuant to section 1301(c)(2), the stay must be lifted if the debtor&amp;#39;s Chapter 13 Plan does not propose to pay 100 percent of the creditor&amp;#39;s claim. Finally, under section 1301(c)(3), the stay must be lifted if the creditor would be irreparably harmed by continuation of the co-debtor stay. Generally, once a Motion for Relief from Co-debtor Stay is filed, a hearing will be held to determine if the stay should be lifted or modified. However, if the Motion is filed under section 1301(c)(2), alleging that the Plan does not propose a 100 percent payment to the creditor of a co-signed debt, the stay is automatically lifted 20 days after the filing of the Motion unless the debtor or co-debtor files a written objection to the Motion.&lt;/p&gt;

&lt;p&gt;Usually, a Motion for Relief from Co-debtor Stay involves proving who is actually liable on an account and whether the creditor actually holds a claim against the co-debtor. Under these circumstances, a creditor may be asked to produce documentation establishing the co-debtor&amp;#39;s liability, such as a signed application for credit.&lt;/p&gt;

&lt;p&gt;Another common defense to a Motion for Relief from the Co-debtor Stay is that the debtor assumed the debt as part of a divorce. Therefore, the argument goes, the creditor should not be permitted to lift the Stay protecting the non-filing spouse because the debtor agreed to accept full liability for the debt as part of the divorce settlement. Unfortunately for the non-bankrupt spouse, this argument usually fails. Generally, the allocation of debts pursuant to a divorce decree does not bind the creditor. That is, the divorcing spouses cannot alter the creditor&amp;#39;s contract with them to alleviate one party&amp;#39;s liability for a debt without the appropriate notice to the creditor if it is done in a court with jurisdiction over the creditor or the creditor&amp;#39;s consent. If the debtor&amp;#39;s Plan is not amended to pay the debt at 100 percent, the Stay will be lifted and the creditor can pursue collection against the non-filing spouse. Of course, since the parties are divorced, often the debtor has no incentive to agree to pay the debt 100 percent through the Plan. If the NFCD is required to make payment on the debt, the terms of the divorce decree would give the NFCD a cause of action against the debtor&amp;#39;s ex-spouse to recover any losses. But, since the debtor is in bankruptcy and presumably will receive a discharge, the non-filing spouse will likely be unable to enforce the terms of the divorce decree to make the debtor pay for any losses.&lt;/p&gt;

&lt;p&gt;NFCDs also commonly oppose a creditor&amp;#39;s Motion for Relief from Co-debtor Stay because they are unable to pay the debt. Nevertheless, the Court should grant the Motion for Relief if the debtor&amp;#39;s Chapter 13 Plan does not provide for 100 percent of the creditor&amp;#39;s claim, which under the Bankruptcy Code, is a clear reason to terminate the co-debtor stay. The inability of the NFCD to repay the debt is not a defense to the Motion.&lt;/p&gt;

&lt;p&gt;Once a Motion for Relief from Co-debtor Stay is granted and the co-debtor stay is terminated, the creditor can then proceed against the co-debtor under the appropriate non-bankruptcy, state court collection laws. Often the bankruptcy courts will only allow relief from the co-debtor stay to the extent the debtor will not be paid through the plan. For example, if the debtor&amp;#39;s plan calls for the creditor to be paid 30 percent through the plan, the court may grant relief so the creditor can pursue the remaining 70 percent of the debt.&lt;/p&gt;

&lt;div&gt;
&lt;h6 style=&quot;text-align:center&quot;&gt;&lt;em&gt;Bankruptcy Report&lt;/em&gt; is produced by Becket &amp;amp; Lee LLP, Attorneys at Law, as a service to our clients. Copyright 2004 by Becket &amp;amp; Lee LLP, except as otherwise noted. Reproduction of this newsletter is strictly prohibited without written permission from the publisher.&lt;/h6&gt;
&lt;/div&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Denial of Discharge Bankruptcy Code 727 and Its Importance to Creditors",
                    CreatedDate = Convert.ToDateTime( "2017-06-09 13:46:37.9863591" ),
                    StartDate = Convert.ToDateTime( "2011-05-11 00:00:00.0000000" ),
                    EndDate = null,
                    EventTypeId = 4,
                    EventHtml = @"&lt;p&gt;It is well known that the basic premise of the bankruptcy system is that of the &amp;quot;fresh start.&amp;quot; Every debtor&amp;#39;s goal in filing a Chapter 7 bankruptcy petition is to be relieved of debts when the bankruptcy court grants the &amp;quot;discharge&amp;quot;. However, in order to receive a discharge, the debtor must be honest and make truthful disclosures as to all of his assets and property, otherwise known as the &amp;quot;bankruptcy estate&amp;quot;. If the debtor fails to do so, there may be serious consequences to the debtor, including a denial of discharge.&lt;/p&gt;

&lt;p&gt;Section 727 of the Bankruptcy Code contains the provisions dealing with discharge, referred to by Congress as the &amp;quot;heart of the fresh start&amp;quot; concept. Under this code section, the bankruptcy court is required to grant the debtor&amp;#39;s discharge so long as the debtor fulfills all of his responsibilities to the court, the trustee and the creditors. The debtor must provide accurate information about all income, assets, liabilities, and any transfers of property made in a certain time period. To further help ensure the integrity of the system, the debtor must sign the bankruptcy petition and documents subject to the penalty of perjury. The debtor is also required to testify as to the accuracy of the information in the documents at the Meeting of Creditors, which is held in every bankruptcy case.&lt;/p&gt;

&lt;p&gt;All of these disclosures help the trustee and the court to evaluate the estate of the debtor and determine whether there are any non-exempt assets that could be liquidated and distributed to the creditors. The only way the estate can truly be evaluated is through the full and honest disclosures of the debtor. However, if the debtor fails to live up to his end of the bargain, the Bankruptcy Code specifically delineates a suitable punishment. Under Section 727(c)(1), the Chapter 7 Trustee, United States Trustee or a creditor may file a complaint to determine whether grounds exist for the bankruptcy judge to deny the debtor a discharge. While there are several reasons that the debtor&amp;#39;s discharge could be denied, the most commonly litigated by creditors are the transferring and hiding of assets or information, failing to keep proper financial records, and making false statements with regard to the debtor&amp;#39;s case.&lt;/p&gt;

&lt;p&gt;The first ground upon which to request a denial of discharge is any action by the debtor which intends to &amp;quot;hinder, delay or defraud the creditors or an officer of the estate and transfers or conceals property within one year prior to filing bankruptcy.&amp;quot; An obvious example would be the pre-petition transfer of real estate to a family member for $1.00 or the intentional failure to list a bank account or personal property in the bankruptcy documents. Unsecured creditors are most likely to discover this type of fraud when reviewing the debtor&amp;#39;s use of its credit. Presumably, if a debtor charges $10,000 worth of jewelry and then files bankruptcy a short time later, the debtor should still be in possession of this property unless he has transferred it away. Bankruptcy schedules require disclosures of both personal property and a list of property given away as gifts. If the jewelry is not listed anywhere in the schedules, a creditor may have grounds to file a complaint against the debtor, since it would appear that the debtor was intentionally concealing the property or its transfer from the trustee and court.&lt;/p&gt;

&lt;p&gt;A second reason that a creditor might file a complaint seeking a denial of discharge is if the debtor has concealed, destroyed or falsified books and records from which the debtor&amp;#39;s financial condition might be ascertained. For example, if a debtor owns and operates a business, but fails to produce, or even alters, the financial records to intentionally mislead the trustee, that debtor can be denied a discharge.&lt;/p&gt;

&lt;p&gt;The third most common reason a debtor could be denied discharge is for making &amp;quot;false oaths or accounts,&amp;quot; that is, lying to the trustee and creditors. These misrepresentations and falsehoods can be contained in the debtor&amp;#39;s petition and/or schedules, or can be made at the Meeting of Creditors. It is important to note that this also is a crime under federal law, thereby subjecting a lying debtor to jail time. If a creditor has sufficient information to demonstrate the debtor is not being truthful, that creditor may decide to initiate a suit within the bankruptcy seeking to have the debtor&amp;#39;s discharge denied. The deadline for filing such a lawsuit is 60 days after the first date set for the Meeting of Creditors, which is the same deadline as for filing a complaint to determine dischargeability of debt pursuant to Bankruptcy Code Section 523 (the fraud exception to discharge). However, it is important to note the difference between a complaint under Section 523 and one under Section 727. In the former, a creditor is seeking a judgment that its debt should not be discharged, while in the latter, a creditor seeks to have the debtor&amp;#39;s entire discharge denied. These remedies are not mutually exclusive, however; a creditor may file either or both types of complaints.&lt;/p&gt;

&lt;p&gt;Assuming the creditor has timely filed its complaint Objecting to Discharge, the matter will proceed like other litigation in that the debtor must file an answer, discovery may be conducted, and the case will be set for trial. If the court rules in favor of the objecting creditor, the debtor will not receive a discharge. This means that none of the debtor&amp;#39;s debts will be wiped out and the debtor will owe each of his creditors the debts that were due when the bankruptcy petition was filed.&lt;/p&gt;

&lt;p&gt;One final point of interest to creditors is that it is possible for a debtor to receive a discharge, but later have it revoked. This can happen when a creditor or a trustee comes across information after the court has entered a discharge order. If information is later discovered that would have resulted in the denial of discharge, the discharge can be revoked by the bankruptcy judge. Section 727(d) allows for revocation if the discharge was obtained by the fraud of the debtor, and the creditor did not know of the fraud until after the discharge date. Note, however, that the creditor must seek to revoke discharge within 1 year after discharge is granted, or before the case is closed, whichever is later.&lt;/p&gt;

&lt;p&gt;In any event, a creditor should be mindful that once the bankruptcy court enters the appropriate order denying discharge and the case is closed, that creditor, and all creditors, may begin to attempt to collect their debts from the debtor. The automatic stay that starts as soon as the debtor files the bankruptcy petition is terminated upon denial of discharge, and creditors may take appropriate collection actions. Denial of discharge is a very drastic remedy and, when warranted, should be used to its full benefit so that a fraudulent debtor cannot abuse the system to discharge his debts.&lt;/p&gt;

&lt;div&gt;
&lt;h6 style=&quot;text-align:center&quot;&gt;&lt;em&gt;Bankruptcy Report&lt;/em&gt; is produced by Becket &amp;amp; Lee LLP, Attorneys at Law, as a service to our clients. Copyright 2004 by Becket &amp;amp; Lee LLP, except as otherwise noted. Reproduction of this newsletter is strictly prohibited without written permission from the publisher.&lt;/h6&gt;
&lt;/div&gt;
"
                };
                context.Events.Add( eventObj );


                await context.SaveChangesAsync();

            }
        }
    }
}