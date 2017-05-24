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
            
            if (!context.Events.Any() || context.Events.Count() != 113)
            {
                // delete
                context.RemoveRange( context.Events );
                await context.SaveChangesAsync();

                var eventObj = new Event()
                {
                    Title = @"Alane Becket Chair of NARCA 2016 Fall Conference; Elected to Board of Directors",
                    CreatedDate = Convert.ToDateTime( "2016-11-04 07:58:37.3770000" ),
                    EventTypeId = 1,
                    EventHtml = @"&lt;p&gt;Alane Becket was the conference Chair at the National Creditors Bar Association (NARCA) Fall Conference in Las Vegas from October 26-29, 2016. At the conference, Alane was elected to the Board of Directors for a two-year term.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = "Alane Becket Named Among \"25 Most Influential Women in Collections\"",
                    CreatedDate = Convert.ToDateTime( "2016-11-04 07:58:00.5970000" ),
                    EventTypeId = 1,
                    EventHtml = @"&lt;p&gt;The firm is pleased to report that Partner Alane Becket was named one of the &amp;quot;25 Most Influential Women in Collections&amp;quot; by Collection Advisor magazine and was featured on its September/October 2016 cover. The issue is available via Collection Advisor&amp;#39;s website at: &lt;a href=&quot;http://issuu.com/collectionadvisor/docs/collection_advisor_september_octobe?e=23956006/38860619&quot;&gt;http://issuu.com/collectionadvisor/docs/collection_advisor_september_octobe?e=23956006/38860619&lt;/a&gt;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Appointed to NARCA Board of Directors",
                    CreatedDate = Convert.ToDateTime( "2016-01-04 10:18:47.5730000" ),
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
                    EventTypeId = 1,
                    EventHtml = @"&lt;p&gt;We are pleased to announce that Becket &amp;amp; Lee LLP is certified as compliant with the Payment Card Industry Data Security Standard. By achieving this important benchmark, we reaffirm our ongoing commitment to the security and integrity of all client data.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L Attorneys Receive Publication Award from ABI",
                    CreatedDate = Convert.ToDateTime( "2011-11-10 16:07:31.8100000" ),
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
                    EventTypeId = 1,
                    EventHtml = @"&lt;p&gt;On March 22, 2011, Tom shared his expertise on the recent Supreme Court decisions impacting creditor recoveries in a bankruptcy webinar presented by Visa for its members.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee to Attend the CRS Conference",
                    CreatedDate = Convert.ToDateTime( "2017-05-08 10:09:27.8000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer will attend and exhibit at the annual Collections and Recovery Solutions Conference in Las Vegas, May 10-12, 2017. The conference offers B &amp;amp; L the opportunity to network at an exclusive gathering of industry professionals. This year Tom will lead a roundtable discussion, the topic: &lt;em&gt;Bankruptcy - Issues and Updates&lt;/em&gt;. This year, there are new bankruptcy rules scheduled to go into place December 1, 2017, making various changes to consumer bankruptcy practice, including shortening the time frame to file a proof of claim. On January 17, 2017, the Supreme Court of the United States heard arguments in &lt;em&gt;Midland Funding v. Aleida Johnson&lt;/em&gt; the ultimate disposition of this case will resolve the question of the treatment of out of statute debt in bankruptcy and, if ever, the FDCPA applies in bankruptcy matters. The roundtable will be an open discussion regarding these items and any other consumer bankruptcy issues.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Partner Alane Becket attended the ABI Spring Meeting",
                    CreatedDate = Convert.ToDateTime( "2017-05-08 10:06:44.2700000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Alane Becket attended the American Bankruptcy Institute&amp;#39;s Spring Meeting in Washington, DC April 20-23, 2017. ABI&amp;#39;s Annual Spring Meeting serves as the bankruptcy industry&amp;#39;s one-stop resource for premier networking and quality education. The Annual Spring Meeting includes inspiring keynote sessions, important networking events, and a variety of targeted education sessions. Alane is Vice President of Publications for the ABI.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L Represented at Tech Conferences",
                    CreatedDate = Convert.ToDateTime( "2017-05-05 09:54:08.1670000" ),
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
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;The 43rd Annual Southeastern Bankruptcy Law Institute Seminar was held in Atlanta, GA, March 30 - April 1, 2017. As in prior years, Partner Alane Becket spoke at the event, this time on the topic of the Consumer Financial Protection Bureau (&amp;quot;CFPB&amp;quot;). The CFPB is in the headlines almost every week. Its activities touch every aspect of consumer finance, from regulating consumer lenders, industry participants and even lawyers, to rulemaking, enforcement actions, consumer protection initiatives and education. This session covered what one needs to know about the CFPB as a bankruptcy practitioner, a lawyer, a consumer financial service provider, and a consumer.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"CBA Live 2017",
                    CreatedDate = Convert.ToDateTime( "2017-03-24 10:47:34.1830000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer will attend CBA LIVE 2017 in Grapevine, TX from April 2-5. CBA LIVE is an annual conference organized by the Consumer Bankers Association, which provides information across nine areas of retail banking. Becket &amp;amp; Lee will also exhibit at the conference.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee Represented Firm at Marketplace Lending Conference",
                    CreatedDate = Convert.ToDateTime( "2017-03-24 10:47:13.9130000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;On March 6 and 7, 2017, Tom Lee attended LendIt 2017 in New York City. The conference provided opportunities to meet decision-makers in the growing marketplace lending community, as Becket &amp;amp; Lee continues to expand in providing services to this sector.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Exhibited at DBA International 2017 Annual Conference",
                    CreatedDate = Convert.ToDateTime( "2017-02-20 10:59:47.1600000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer represented the firm at the 20th Annual DBA International Conference. The conference was held at the Aria Resort in Las Vegas from February 7-9, 2017. In addition to attending the conference, Becket &amp;amp; Lee also exhibited at the event.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Attended ABI Winter Leadership Conference",
                    CreatedDate = Convert.ToDateTime( "2017-01-06 12:04:34.5800000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket attended the American Bankruptcy Institute&amp;#39;s Winter Leadership Conference in Rancho Palos Verdes, CA, December 1-3, 2016.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Partners Alane Becket & Tom Lee Represented B&L at Annual Judges’ Conference",
                    CreatedDate = Convert.ToDateTime( "2016-11-04 07:54:09.9670000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Alane Becket and Tom Lee attended the National Conference of Bankruptcy Judges in San Francisco, CA from October 26-29, 2016. The innovative education program offered excellent networking opportunities; NCBJ typically attracts in excess of 1,500 bankruptcy professionals.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Attended the 36th Annual ABI Midwestern Bankruptcy Institute Conference",
                    CreatedDate = Convert.ToDateTime( "2016-11-04 07:52:26.5500000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket attended this annual conference held in Kansas City, Missouri, September 29-30, 2016. Alane participated in the Consumer Debate: &amp;quot;Resolved: An out-of-statute proof of claim violates the FDCPA,&amp;quot; along with Thad O. Bartholow of Kellett &amp;amp; Bartholow PLLC; Dallas.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Attended ABI Southwest Conference",
                    CreatedDate = Convert.ToDateTime( "2016-09-21 16:37:55.8830000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Alane Becket joined the American Bankruptcy Institute for the 23rd Annual Southwest Bankruptcy Conference in Las Vegas, September 10-12, 2016. Experienced practitioners and regional judges presented workshops on a variety of topics relating to both business and consumer bankruptcy. At the conference, Alane participated in the ABI&amp;#39;s &amp;quot;Great Debate&amp;quot; on the topic: &amp;quot;The filing of a Proof of Claim, for a debt on which the statute of limitations has run, is a violation of the FDCPA.&amp;quot;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended the 2016 Debt Connection Symposium and Expo",
                    CreatedDate = Convert.ToDateTime( "2016-09-21 16:37:36.0730000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer attended the 2016 Debt Connection Symposium &amp;amp; Expo in Tucson, AZ, September 13-15, 2016. The firm exhibited at this conference geared for collections, recovery, and debt sales professionals.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended the NABT 2016 Annual Convention",
                    CreatedDate = Convert.ToDateTime( "2016-09-21 16:37:14.1030000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee attended the annual meeting of the National Association of Bankruptcy Trustees in San Diego, September 7-11, 2016. This annual event enables Becket &amp;amp; Lee to interact with the Chapter 7 bankruptcy trustees, while staying current on bankruptcy developments.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended NACTT's Annual Conference Philadelphia",
                    CreatedDate = Convert.ToDateTime( "2016-08-03 15:36:35.3370000" ),
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
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee attended the annual meeting of the National Association of Bankruptcy Trustees in Chicago from August 27-29. The event is always a great occasion for Becket &amp;amp; Lee to interact with the trustees, while keeping informed on current bankruptcy issues.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Partner Alane Becket Chaired NARCA's 2016 Spring Litigation Boot Camp",
                    CreatedDate = Convert.ToDateTime( "2016-05-17 16:55:29.0370000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;On May 7, 2016, partner Alane Becket chaired the inaugural litigation Boot Camp at the Spring Conference of the National Creditors Bar Association (NARCA) in Chicago. The Boot Camp featured six segments designed to introduce young attorneys or those new to collection practice to various aspects of collections litigation. In addition to chairing this successful event, Alane presented the &amp;quot;Evidence Overview&amp;quot; block.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Exhibited at the CRS Conference",
                    CreatedDate = Convert.ToDateTime( "2016-05-17 16:55:11.1800000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer Cramer attended and exhibited at the annual Collections and Recovery Solutions Conference in Las Vegas, May 11-13, 2016. The conference offered B&amp;amp;L the opportunity to network at an exclusive gathering of industry professionals.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"ABI Spring Meeting 2016",
                    CreatedDate = Convert.ToDateTime( "2016-04-19 10:32:13.1630000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Managing Partner Alane Becket moderated a panel at the 34th Annual American Bankruptcy Institute Spring Meeting in Washington, D.C., from April 14-17, 2016. Alane was joined by the National Consumer Law Center&amp;#39;s John Rao and Jon Pearson from Ballard Spahr to discuss, &amp;quot;What is the CFBP, and Why Do I Care?&amp;quot;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Firm Represented at Tech Conferences",
                    CreatedDate = Convert.ToDateTime( "2016-04-19 10:29:43.7630000" ),
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
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;The 42nd Annual Southeastern Bankruptcy Law Institute Seminar was held in Atlanta, GA, March 31 - April 2, 2016. Partner Alane Becket spoke on the topic &amp;quot;Hey, give me some, too! - Issues Regarding Claim Allowance,&amp;quot; along with Houston attorney Johnnie Patterson. In the months since the 11th Circuit&amp;#39;s decision in LVNV vs Crawford, proofs of claims have again taken center stage in consumer bankruptcy cases. This panel surveyed the post-Crawford claims litigation landscape, including the use and nuances of statutes of limitations, the availability of state and federal consumer protection statutes, and the use of defensive judicial doctrines. &amp;lt;/p&amp;gt;&amp;lt;p&amp;gt; The following week, Alane was in Atlanta presenting to the National Association of Bankruptcy Trustees, along with NABT Past President and Bankruptcy Judge James W. Boyd and former ABI President Richardo Kilpatrick and Judge, at a program entitled &amp;quot;Money for Nothing&amp;quot;, addressing challenges with creditor claims in chapter 7 cases.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L Attended CBA Live 2016",
                    CreatedDate = Convert.ToDateTime( "2016-03-30 13:49:52.4370000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer attended CBA LIVE 2016 in Phoenix, AZ from Mar. 7-9, 2016. CBA LIVE is an annual three-day conference organized by the Consumer Bankers Association, which provides information across nine areas of retail banking. Becket &amp;amp; Lee also exhibited at the conference.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket on Panel at Emory University Symposium",
                    CreatedDate = Convert.ToDateTime( "2016-03-03 15:18:17.4770000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket was invited to participate in a panel at the 13th Annual Emory Bankruptcy Developments Journal Symposium. The EBDJ is an annual event held at Emory University School of Law in Atlanta, GA. On February 25, 2016, Alane&amp;#39;s panel presented on the topic &amp;quot;Recent Developments in Bankruptcy Regulation: Mortgage Servicing Rules, the FDCPA, and the CFPB&amp;quot;.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Partner Alane Becket Speaks at the 5th Circuit Bankruptcy Bench-Bar Conference",
                    CreatedDate = Convert.ToDateTime( "2016-03-03 15:17:56.2300000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Alane Becket recently served on a panel discussion of Debt Collection and the Fair Debt at the 5th Circuit Bankruptcy Bench-Bar Conference, held in New Orleans, LA, February 24-26, 2016. This session, led by Judge Robert Drain, addressed one of the hottest issues in consumer bankruptcy; the question of what remedies are available for creditor misconduct, including actions under consumer financial protection statutes and the use of class actions in bankruptcy.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Firm Attended and Exhibited at DBA 2016",
                    CreatedDate = Convert.ToDateTime( "2016-02-24 16:02:29.3430000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Firm Attended and Exhibited at DBA 2016 Partner Tom Lee and Business Operations Analyst Stu Cramer represented represent the firm at the 19th Annual DBA International Conference. The conference was held at the Aria Resort in Las Vegas from February 9-11, 2016. The firm also exhibited at the event.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket elected to the Board of Directors for the American Bankruptcy Institute",
                    CreatedDate = Convert.ToDateTime( "2016-01-04 10:10:23.9800000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;During ABI&amp;#39;s 32nd Annual Spring Meeting, held April 24-27, 2009 in Washington, D.C, Alane Becket was elected to the Board of Directors for the American Bankruptcy Institute and Co-Chair of the ABI&amp;#39;s Consumer Bankruptcy Committee. Becket &amp;amp; Lee has been active in the ABI for almost 20 years and this appointment is the result of years of service to the ABI. Alane has distinguished herself as a speaker at ABI seminars and meetings, moderator of the Consumer Bankruptcy Committee&amp;#39;s list serve, Editor of the Consumer Committee&amp;#39;s Newsletter, columnist for the ABI Journal, Education Director for the Consumer Committee, and Editor of the Consumer Education Center on the ABI&amp;#39;s Website. It was her work ethic, presentation skills and organizational abilities, combined with her legal expertise, which caught the Board&amp;#39;s attention. Alane was asked to join the Board earlier this year and was officially approved by the President at the ABI&amp;#39;s Annual meeting last month.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Attended ABI's Annual Leadership Conference",
                    CreatedDate = Convert.ToDateTime( "2016-01-04 10:09:24.1600000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket attended the American Bankruptcy Institutes 27th Annual Winter Leadership Conference in Phoenix from December 3-5, 2015. The program features topics designed for consumer and business practitioners, as well as financial advisors.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"NARCA 2015 Fall Collection Conference",
                    CreatedDate = Convert.ToDateTime( "2015-11-19 10:14:08.1170000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket attended the National Association of Retail Collection Attorneys annual conference in Washington, DC from Oct. 14-17, 2015. Alane introduced Sam Gerdano, Executive Director of the American Bankruptcy Institute, speaking about how new household debt patterns, such as the rise in student load debt, predict what&amp;#39;s ahead for creditors, collectors and debt buyers . This was the ABI&amp;#39;s first presentation to NARCA.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee to Attended Debt Connection Symposium & Expo (DCS2015)",
                    CreatedDate = Convert.ToDateTime( "2015-09-18 10:03:06.6270000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer attended the 2015 Debt Connection Symposium &amp;amp; Expo in Austin, TX. The firm exhibited at this conference geared for collections, recovery, and debt sales professionals from creditors, healthcare, collection agencies, collection attorney firms, debt buyers, and related industry vendors.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee Attended 2015 National Conference of Bankruptcy Clerks ",
                    CreatedDate = Convert.ToDateTime( "2015-08-21 12:40:35.8300000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee represented Becket &amp;amp; Lee at the annual conference in Atlanta, Georgia from August 10-13, 2015. Participation in this conference provided Becket &amp;amp; Lee the opportunity to strengthen relationships with court personnel and improve communication on industry related issues.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket attended the 20th Annual Southeast Bankruptcy Workshop",
                    CreatedDate = Convert.ToDateTime( "2015-08-05 12:08:32.5630000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket attended and participated in a panel discussion at the ABI&amp;#39;s 20th Annual Southeast Bankruptcy Workshop in Florida from July 23-26, 2015. The panel topic, &amp;quot;What Is Hot in July Besides the Weather? Litigation in Consumer Cases&amp;quot;, focused on &lt;em&gt;Crawford v. LVNV Funding&lt;/em&gt; and related litigation, consumer protection (including the basics of credit reporting and regulatory actions), mortgage modifications, post-discharge actions, and the UST&amp;#39;s enforcement activities.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended NACTT's Annual Conference in Salt Lake City",
                    CreatedDate = Convert.ToDateTime( "2015-07-13 15:43:08.4930000" ),
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
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;In 2014, the Eleventh Circuit Court of Appeals ruled that filing a claim in a bankruptcy case on out of statute debt is a violation of the FDCPA. At the 2015 NCCR Conference, Partner Alane Becket discussed the current status of Crawford, what is happening in other circuits, as well as the intersection of two laws: the FDCPA and the U.S. Bankruptcy Code. The conference was held June 1-3, 2015 in New Orleans.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Presented at NARCA Spring Conference",
                    CreatedDate = Convert.ToDateTime( "2015-05-19 14:03:07.7830000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket spoke at the National Association of Retail Collection Attorneys 2015 Spring Collection Conference in Nashville, TN (May 6-9, 2015). Alane&amp;#39;s Topic: &lt;em&gt;Determining Statute of Limitations; There is No &amp;quot;Easy Button&amp;quot;.&lt;/em&gt; Alane was joined by Joann Needleman, Esquire, Maurice &amp;amp; Needleman, P.C. and Barbara A. Sinsley, Esquire, Hudson Cook, LLP.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L Exhibited at CRS Conference",
                    CreatedDate = Convert.ToDateTime( "2015-05-19 14:02:23.2470000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer attended and exhibit at the annual Collections and Recovery Solutions conference in Las Vegas, May 6-8, 2015.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Stu Cramer Attended Tech Conference",
                    CreatedDate = Convert.ToDateTime( "2015-05-19 14:02:06.1730000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Stu Cramer attended the EPIQ Systems User Conference in Key West, Florida from April 22-24, 2015. The annual event enables Becket &amp;amp; Lee to stay abreast of various technological developments and tools accessible to bankruptcy practitioners.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"ABI Spring Meeting 2015",
                    CreatedDate = Convert.ToDateTime( "2015-04-17 16:19:51.9700000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Managing Partner Alane Becket attended the 33nd Annual American Bankruptcy Institute Spring Meeting in Washington, D.C., from April 16-19, 2015.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Presented at Southeastern Bankruptcy Law Institute Seminar",
                    CreatedDate = Convert.ToDateTime( "2015-04-01 17:13:53.4030000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket spoke at the 41st Annual SBLI Seminar in Atlanta (March 26-28, 2015) on the topic &lt;em&gt;Litigation: Complaint to Determine Dischargeability of Student Loan.&lt;/em&gt; The presentation covered the rules of evidence in a student loan hardship case, the legal basis for the complaint, the evidence necessary for trial, and other relative issues. Alane was joined by the Honorable William H. Brown.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Firm Attended CBA Live 2015",
                    CreatedDate = Convert.ToDateTime( "2015-04-01 17:13:17.7200000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer attended CBA LIVE 2015 in Orlando, FL (Mar. 23-25, 2015). CBA LIVE is an annual three-day conference organized by the Consumer Bankers Association, which provides information across nine areas of retail banking.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L Attended the 2015 Debt Buyers' Conference",
                    CreatedDate = Convert.ToDateTime( "2015-03-12 12:39:16.9870000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer attended the 18th Annual DBA International Conference at the Aria Resort in Las Vegas Feb. 3-5, 2015. The firm also exhibited at the event.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Moderated at ABI Event in March 2015",
                    CreatedDate = Convert.ToDateTime( "2015-03-12 12:38:22.4430000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket moderated a panel discussion of current consumer bankruptcy topics at the 39th Annual Alexander L. Paskay Memorial Bankruptcy Seminar in Tampa, Florida (Mar. 5-7, 2015). The session covered recent developments in the Eleventh Circuit, as well as other topics of regional and national importance. The panel included bankruptcy attorneys, as well as a Chapter 13 Trustee.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Invited to Testify on Bankruptcy Rules",
                    CreatedDate = Convert.ToDateTime( "2015-01-29 16:53:06.3000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;On Friday, January 23, 2015, Alane Becket testified before the Federal Advisory Committee on Rules of Bankruptcy Procedure in Washington, D.C. regarding the proposed National Chapter 13 Plan Form. Alane testified in support of the adoption of a national form for Chapter 13 plans.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"ABA's Invitation to Alane Becket",
                    CreatedDate = Convert.ToDateTime( "2015-01-29 16:52:45.1430000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;The American Bar Association recently invited Partner Alane Becket to participate in a panel at its Annual Consumer Financial Services Winter Meeting. Alane&amp;#39;s presentation, entitled Proofs of Claim on Time-Barred Debt After Crawford, examined the Eleventh Circuit&amp;rsquo;s recent decision, including the legal and practical ramifications. The event was held in New Orleans from January 10-13, 2015.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket at NARCA 2014 Fall Conference",
                    CreatedDate = Convert.ToDateTime( "2014-12-01 12:22:59.5970000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket presented at the NARCA 2014 Fall Collection Conference in Las Vegas, which ran from October 22-25. Alane&amp;#39;s panel presentation, &amp;quot;Collection Litigation is NOT Scattershot Litigation&amp;quot;, discussed the term &amp;quot;Scattershot Litigation&amp;quot; as it is currently being used by the CFPB, along with an exploration of practical concerns involving application of the term. She was joined on the panel by attorneys Joann Needleman and Barbara Sinsley.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee Presented at FSCOR 2014",
                    CreatedDate = Convert.ToDateTime( "2014-12-01 12:22:36.0000000" ),
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
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;From October 8-11, 2014, Partners Alane Becket and Tom Lee represented the firm at the National Conference of Bankruptcy Judges in Chicago.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Participated in NARCA Webinar",
                    CreatedDate = Convert.ToDateTime( "2014-09-26 10:57:19.7030000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;On September 23, 2014, Partner Alane Becket led a NARCA-sponsored webinar entitled &amp;quot;What Collection Attorneys Need to Know When a Debtor Files for Bankruptcy&amp;quot;. The webinar examined areas of concern such as verification of bankruptcy status, managing pending litigation and garnishments, and the applicability of the FDCPA for bankruptcy-related acts.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended September Events",
                    CreatedDate = Convert.ToDateTime( "2014-09-12 10:13:18.3930000" ),
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
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket was invited to participate at the NARCA Annual Spring Conference in a panel discussion of &amp;quot;What Collection Attorneys Need to Know When a Debtor Files for Bankruptcy&amp;quot;. The session covered areas of particular concern such as verification of bankruptcy status, managing pending litigation and garnishments, and the applicability of the FDCPA for bankruptcy-related acts. The event was held May 15-17 in Miami Beach, FL.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Firm Exhibited at CRS 2014",
                    CreatedDate = Convert.ToDateTime( "2014-05-20 15:45:07.6400000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;From May 7-9, 2014, Partner Tom Lee and Business Operations Analyst Stu Cramer attended and exhibited at the annual Collections and Recovery Solutions conference in Las Vegas.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Managing Partner Attended Commercial Law League Event",
                    CreatedDate = Convert.ToDateTime( "2014-05-02 10:12:22.5070000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Managing Partner Tom Lee attended the Commercial Law League of America Annual Convention and Midwest Meeting. The event was held in Chicago April 24-26, 2014.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"ABI Spring Meeting 2014",
                    CreatedDate = Convert.ToDateTime( "2014-05-02 10:10:03.1300000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Managing Partner Alane Becket attended the 32nd Annual ABI Spring Meeting in Washington, D.C., which ran from April 24-27, 2014.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L at 9th Annual CCN Conference",
                    CreatedDate = Convert.ToDateTime( "2014-04-14 14:30:00.6400000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Business Operations Analyst Stu Cramer attended the Credit and Collection News 9th Annual Conference in Naples, FL from April 2-4, 2014.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"CBA Live 2014",
                    CreatedDate = Convert.ToDateTime( "2014-04-07 09:56:05.3200000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee attended CBA LIVE 2014 in National Harbor, MD, which ran from March 31-April 2, 2014. CBA LIVE is an annual three-day conference organized by the Consumer Bankers Association, which provides information across nine areas of retail banking.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Firm Exhibited at NCOR 2014",
                    CreatedDate = Convert.ToDateTime( "2014-04-07 09:55:44.7900000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Becket &amp;amp; Lee exhibited at the 18th Annual National Collections &amp;amp; Operational Risk Conference held in Miami Beach, FL in late-March 2014. Partner Tom Lee and Business Operations Analyst Stu Cramer also attended the event.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended Debt Buyers' Conference in February 2014",
                    CreatedDate = Convert.ToDateTime( "2014-02-17 17:12:41.5270000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer attended the 17th Annual DBA International Conference at the Aria Resort in Las Vegas, which ran from February 5-7, 2014. Becket &amp;amp; Lee also exhibited at the event.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Represented Firm at 2013 Annual Judges' Conference",
                    CreatedDate = Convert.ToDateTime( "2014-01-15 11:15:56.4700000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Beginning on October 30, 2013, Partner Alane Becket represented the firm at the National Conference of Bankruptcy Judges in Atlanta. Alane was asked by NCBJ President Judge Ray Mullins to serve on the Conference&amp;#39;s Education Committee, and she participated in a panel discussion about the new Chapter 13 Plan Form. Alane&amp;#39;s fellow panelists include Judge Rebecca Buehler Connelly, from the Western District of Virginia and Chapter 13 Trustee Margaret Burks. The session was moderated by Judge Eugene R. Wedoff, the incoming President of the NCBJ.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended FSCOR 2013",
                    CreatedDate = Convert.ToDateTime( "2013-10-25 17:00:33.1500000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer attended the 21st Annual Financial Services Collections &amp;amp; Operational Risk Conference in Chicago. The conference ran from October 21-23, 2013 and Becket &amp;amp; Lee exhibited at the event.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Presented at October Bankruptcy Events",
                    CreatedDate = Convert.ToDateTime( "2013-10-25 16:59:55.7930000" ),
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
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Business Operations Analyst Stu Cramer attended the 2013 Debt Connection Symposium &amp;amp; Expo in Las Vegas beginning on September 9, 2013. As in prior years, the firm also exhibited at the event.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended Trustee Conference in August",
                    CreatedDate = Convert.ToDateTime( "2013-08-14 09:37:26.6770000" ),
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
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;From May 8-10, 2013, Partner Tom Lee and Business Operations Analyst Stu Cramer attended the annual Collections and Recovery Solutions conference in Las Vegas. On Friday, May 10th, Tom led a roundtable discussion of the proposed national new chapter 13 form plan and its potential ramifications on creditors. Becket &amp;amp; Lee also exhibited at the event.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L at NARCA Spring 2013 Conference",
                    CreatedDate = Convert.ToDateTime( "2013-05-14 16:29:48.4530000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket attended the 2013 Spring Collection Conference of the National Association of Retail Collection Attorneys in Las Vegas. The conference ran from May 8-11, 2013.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Managing Partners Attended ABI Spring Meeting",
                    CreatedDate = Convert.ToDateTime( "2013-05-14 16:28:14.1500000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Managing Partners Alane Becket and Tom Lee attended the recent 31st Annual ABI Spring Meeting in National Harbor, Maryland. The conference ran from April 18-21, 2013.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Partner Tom Lee Co-Presented At NCCR 2013; Firm Exhibited",
                    CreatedDate = Convert.ToDateTime( "2013-04-08 10:53:11.5630000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer attended the 17th Annual National Collections &amp;amp; Credit Risk Conference in New Orleans March 20-22, 2013. Tom also co-presented on the subject &amp;quot;Emerging Technologies in Collection Agency Management&amp;quot; and the firm exhibited at the event.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee Presented At CBA Live",
                    CreatedDate = Convert.ToDateTime( "2013-03-15 10:25:33.0770000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;On Wednesday, March 13, 2013, Partner Tom Lee led a roundtable discussion on the proposed Chapter 13 Plan Form as part of the Default Management Forum at CBA LIVE 2013. CBA LIVE is an annual three-day conference organized by the Consumer Bankers Association, which provides information across nine areas of retail banking.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Stu Cramer Attended Bankruptcy Tech Conference",
                    CreatedDate = Convert.ToDateTime( "2013-03-15 10:25:16.2200000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Stu Cramer attended the EPIQ Systems User Conference in Clearwater Beach, Florida from March 6-8, 2013. The annual event enables Becket &amp;amp; Lee to stay abreast of various technological developments and tools accessible to bankruptcy practitioners.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended and Exhibited at Debt Buyers' Conference in February 2013",
                    CreatedDate = Convert.ToDateTime( "2013-02-18 13:22:27.8970000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Alane Becket, Tom Lee and Stu Cramer attended the 16th Annual DBA International Conference at the Aria Resort in Las Vegas, February 5-7, 2013. Becket &amp;amp; Lee also exhibited at the event.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Attended NARCA Conference",
                    CreatedDate = Convert.ToDateTime( "2012-11-30 13:00:10.4200000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket attended the NARCA 2012 Fall Collection Conference in Baltimore, MD. The conference ran from October 17-20.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"DCS 2012: B&L Attended and Exhibited",
                    CreatedDate = Convert.ToDateTime( "2012-11-30 12:54:51.6230000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer attended the 2012 Debt Connection Symposium &amp;amp; Expo in Las Vegas beginning on September 10, 2012. The firm also exhibited at the event. For more information on the conference, please visit the official website at &lt;a href=&quot;http://dcs2012.com/&quot; target=&quot;DCS2012&quot;&gt;dcs2012.com&lt;/a&gt;.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Exhibited at FSCC 2012",
                    CreatedDate = Convert.ToDateTime( "2012-11-30 12:54:05.6200000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Tom Lee and Business Operations Analyst Stu Cramer attended the 20th Annual Financial Services Collections &amp;amp; Credit Risk Conference in Scottsdale, AZ. Tom also chaired the pre-conference Future Leaders Forum. The conference ran from October 24-26 and Becket &amp;amp; Lee exhibited at the event. For more information on FSCC 2012, please visit the official website at &lt;a href=&quot;http://www.collectionscreditrisk.com&quot; target=&quot;Parent&quot;&gt; http://www.collectionscreditrisk.com.&lt;/a&gt;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Invited to Speak at 2012 Annual Judges' Conference",
                    CreatedDate = Convert.ToDateTime( "2012-11-30 12:53:35.6370000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Beginning on October 24, 2012, Alane Becket represented the firm at the National Conference of Bankruptcy Judges in San Diego, CA. At the conference, Alane participated in a panel discussion of &amp;quot;Unresolved Issues in Chapter 13&amp;quot;. Her fellow panelists included U.S. Bankruptcy Court Judge Steven Rhodes, Chapter 13 Trustee Jan Hamilton, and attorney Jenny Doling.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee Attended 2012 Chapter 7 Trustee Conference",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:23:16.8730000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Beginning on September 5, 2012, Tom Lee attended the NABT 2012 Fall Seminar in Colorado. Aimed at Chapter 7 trustees, this event enabled the Firm to interact with the trustees while gaining additional industry insight.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee at NCBC 2012",
                    CreatedDate = Convert.ToDateTime( "2012-08-13 16:36:56.9730000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;In August, Partner Tom Lee represented the Firm at the National Conference of Bankruptcy Clerks in San Francisco. The conference provided Becket &amp;amp; Lee with an outstanding opportunity to reinforce its relationships with court personnel, while fostering open communication on work product and industry-related issues.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Invited to Speak, Firm Attended Ch. 13 Trustees' Conference",
                    CreatedDate = Convert.ToDateTime( "2012-07-18 16:40:56.5930000" ),
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
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Beginning May 21 and continuing through May 23, 2012, Business Operations Analyst Stu Cramer attended the annual BSS Chapter 13 Trustee user conference in Memphis, TN. This year&amp;#39;s event focused on discussion topics presented by the Trustees and their staff, as well as coordinating ACH creditor disbursements.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L Attended, Exhibited At Invitation-Only Creditors' Event",
                    CreatedDate = Convert.ToDateTime( "2012-05-17 16:18:06.2600000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;From May 8-11, 2012, Partner Tom Lee and Business Operations Analyst Stu Cramer attended the annual Collections and Recovery Solutions conference in Las Vegas. Becket &amp;amp; Lee also exhibited at this premiere invitation-only event aimed at senior level creditors involved in collection, recovery operations and strategy.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Presented Two Consumer Sessions at SBLI Conference",
                    CreatedDate = Convert.ToDateTime( "2012-04-26 15:53:48.0900000" ),
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
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Beginning on April 19th, Alane Becket attended the American Bankruptcy Institute&amp;#39;s 30th Annual Spring Meeting in National Harbor, Maryland. At the conference, Alane participated on a panel discussing the use of non-standard plan provisions in chapter 13, along with Judge Ray Mullins of Atlanta and John Rao, a member of the Advisory Committee on Bankruptcy Rules and attorney with the National Consumer Law Center. Alane was also recently reelected to a second 3 year term on the ABI&amp;#39;s Board of Directors and will continue her duties as a member of the Publications Committee.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee at NCCR 2012",
                    CreatedDate = Convert.ToDateTime( "2012-03-21 16:12:32.9670000" ),
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
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Stu Cramer attended the EPIQ Systems User Conference in Clearwater Beach, Florida from March 7-9, 2012. This annual event enables the firm to stay apprised of technological advancements and tools available to bankruptcy practitioners.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended and Exhibited at Annual Debt Buyers' Conference February 2012",
                    CreatedDate = Convert.ToDateTime( "2012-02-20 10:14:16.4330000" ),
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
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;At this exclusive event in Las Vegas, Ms. Becket conducted three interactive roundtable discussions focusing on recent developments in the bankruptcy world that have the potential to drastically change current processes and expectations for bankrupt accounts. Special attention was given to the operational and legal challenges facing creditors now and in the upcoming months. The conference&amp;#39;s Web site is &lt;a href=&quot;http://www.crs2010.com&quot;&gt;www.crs2010.com&lt;/a&gt;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee Discussed Supreme Court Rulings, Firm Exhibited at NCCR",
                    CreatedDate = Convert.ToDateTime( "2011-03-16 10:17:36.9930000" ),
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
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Alane Becket spoke at the ABI&amp;#39;s 35th Annual Judge Alexander L. Paskay Seminar on Bankruptcy Law and Practice, held March 10-12, 2011 in Tampa, Florida. Alane&amp;#39;s presentation addressed &amp;quot;What&amp;#39;s in Store for Consumer Practitioners in 2011&amp;quot;. For more information, please visit the conference website at:&lt;a href=&quot;http://www.abiworld.org/SP11&quot;&gt;&amp;nbsp;www.abiworld.org/SP11.&lt;/a&gt;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Stu Cramer Discussed ACH with Chapter 13 Trustees...",
                    CreatedDate = Convert.ToDateTime( "2011-03-01 11:22:43.0000000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;On February 24, 2011, Stu Cramer addressed Chapter 13 trustees on the topic of banking updates and ACH payments at the EPIQ Systems annual conference held in Clearwater Beach, Florida.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L Attended and Exhibited at 14th Annual DBA ",
                    CreatedDate = Convert.ToDateTime( "2011-02-16 11:13:16.7000000" ),
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
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Tom Lee attended the 2010 Annual Meeting of the National Association of Bankruptcy Trustees in San Francisco in late September. The event, which annually attracts over 500 participants, is the premier conference of the Chapter 7 trustee community and offers Becket &amp;amp; Lee the opportunity to meet, in person, the many trustees its staff interacts with during the year. For additional information on the conference or the NABT, please visit &lt;a href=&quot;http://www.nabt.com/&quot;&gt;www.nabt.com&lt;/a&gt;.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee & Stu Cramer Represent Becket & Lee at Industry Events",
                    CreatedDate = Convert.ToDateTime( "2010-10-27 17:49:05.2200000" ),
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
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Partner Alane Becket represented the Firm at this important industry conference which took place October 21-23 in Las Vegas. Previously on the Education Committee, Alane is recognized as one of the conference&amp;#39;s leading bankruptcy experts. In addition to law firms and in-house counsel, this three-day educational program attracted credit grantors and buyers/sellers of consumer debt.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Partner Gil Weisman Presented at NACTT",
                    CreatedDate = Convert.ToDateTime( "2010-08-03 18:18:04.0530000" ),
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
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;B &amp;amp; L Partner John Sheehan was a panelist at the ABI Consumer Bankruptcy Committee&amp;#39;s educational session, which recently took place during ABI&amp;#39;s Annual Spring Meeting in National Harbor, Md. John represented the creditor&amp;#39;s position on the panel in a session entitled &amp;quot;I&amp;#39;d Like You More if You Didn&amp;#39;t Drive Me Crazy: Recurring Issues Among Consumer Lawyers and Trustees, and How to Avoid Them.&amp;quot; The session was designed to allow sometimes opposing parties to discuss constructive solutions to common problems, and was part of the Consumer Bankruptcy Committee&amp;#39;s goal of making bankruptcy less adversarial by facilitating open communication among parties.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket elected to Board of Directors...",
                    CreatedDate = Convert.ToDateTime( "2010-07-02 14:25:00.9200000" ),
                    EventTypeId = 2,
                    EventHtml = @"&lt;p&gt;Alane Becket was elected to the Board of Directors for the American Bankruptcy Institute and Co-Chair of the ABI&amp;#39;s Consumer Bankruptcy Committee. Becket &amp;amp; Lee has been active in the ABI for almost 20 years and this appointment is the result of years of service to the ABI. Alane has distinguished herself as a speaker at ABI seminars and meetings, moderator of the Consumer Bankruptcy Committee&amp;#39;s list serve, Editor of the Consumer Committee&amp;#39;s Newsletter, columnist for the ABI Journal, Education Director for the Consumer Committee, and Editor of the Consumer Education Center on the ABI&amp;#39;s Website. It was her work ethic, presentation skills and organizational abilities, combined with her legal expertise, that caught the Board&amp;#39;s attention. Alane was asked to join the Board earlier this year and was officially approved by the President at the ABI&amp;#39;s Annual meeting last month.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"A Claimant's Dilemma:  The Statute of Limitations and Proofs of Claim",
                    CreatedDate = Convert.ToDateTime( "2015-04-21 14:46:31.4570000" ),
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
                    EventTypeId = 3,
                    EventHtml = @"&lt;p&gt;&amp;nbsp;&lt;/p&gt;

&lt;p style=&quot;text-align:center&quot;&gt;Gil Weisman, Partner and William A. McNeal, Associate&lt;/p&gt;

&lt;p&gt;&lt;a href=&quot;http://www.becket-lee.com/documents/Projected%20Disposable%20Income%20Captures%20Attention-Apr2011.pdf#zoom=100&quot; target=&quot;PDI&quot;&gt;Click here for full article...&lt;/a&gt;&lt;/p&gt;

&lt;p&gt;Reprinted from Norton Bankruptcy Law Adviser, (April, 2011) with permission. Copyright &amp;copy; (2011) Thomson Reuters/West. For more information about this publication please visit &lt;a href=&quot;http://www.west.thomson.com&quot; target=&quot;blank&quot;&gt; www.west.thomson.com.&lt;/a&gt;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                await context.SaveChangesAsync();

            }
        }
    }
}