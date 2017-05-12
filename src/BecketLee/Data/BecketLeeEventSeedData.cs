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
            if (!context.Events.Any() || context.Events.Count() < 195)
            {
                // delete
                context.RemoveRange( context.Events );
                await context.SaveChangesAsync();


                var eventObj = new Event()
                {
                    Title = @"Alane Becket Appointed to NARCA Board of Directors",
                    CreatedDate = Convert.ToDateTime( "2016-01-04 10:04:03.2197384" ),
                    EventTypeId = 1,
                    EventHtml = @"

&lt;p&gt;
    Becket &amp; Lee is pleased to announce Managing Partner Alane Becket was 
    recently appointed to the Board of Directors of the National Creditor&#39;s Bar 
    Association (NARCA), formerly the National Association of Retail Collection 
    Attorneys.  Normally an elected position, Alane was selected by President 
    Harvey Moore, to fill a vacant position.  Alane has been named Co-Chair of 
    the Professional Standards and Grievance Committee and Co-Chair of the Attorney 
    Practicum Sub-Committee of the Education Committee.  As a member of the 
    Education Committee, Alane will focus on NARCA&#39;s law practice educational 
    content.
&lt;/p&gt;
&lt;p&gt;
    Alane also serves on the Executive Committee of the American Bankruptcy Institute, 
    where she is the Vice President of Publications, overseeing the monthly ABI Journal 
    and the ABI&#39;s roster of other bankruptcy books, available at 
    &lt;a href=&quot;http://www.abi.org/bookstore&quot; target=&quot;bookstore&quot;&gt;http://www.abi.org/bookstore&lt;/a&gt;.  
&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Named Executive Editor of ABI Journal",
                    CreatedDate = Convert.ToDateTime( "2012-11-13 10:40:56.0788915" ),
                    EventTypeId = 1,
                    EventHtml = @"

&lt;p&gt;
Partner Alane Becket was recently appointed as Executive Editor 
of the American Bankruptcy Institute&#39;s flagship publication, &lt;i&gt;ABI Journal.&lt;/i&gt;  
The &lt;i&gt;Journal&lt;/i&gt; is published 11 times annually and covers the entire range of 
insolvency issues, with articles written by some of the most knowledgeable 
professionals in the industry.  
&lt;/p&gt;

&lt;p&gt;
Becket &amp; Lee has been active in the ABI for over 20 years.  Alane has 
served on the ABI&#39;s Board of Directors since 2009.  She has lectured 
at numerous ABI events and writes extensively for its publications.  Her 
work has been featured in &lt;i&gt;ABI Journal&lt;/i&gt; and she most recently served as 
co-editor of the book &lt;i&gt;&quot;ABI 2011: The Year in Consumer Bankruptcy&quot;&lt;/i&gt; 
and authored &lt;i&gt;&quot;Consumer Bankruptcy (Third Edition):  Fundamentals of 
Chapter 7 and Chapter 13 of the U.S. Bankruptcy Code&quot;.&lt;/i&gt; 
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L PCI Compliant",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:27.8389535" ),
                    EventTypeId = 1,
                    EventHtml = @"&lt;p&gt;
We are pleased to announce that Becket &amp; Lee LLP 
is certified as compliant with the Payment Card Industry Data Security Standard.  
By achieving this important benchmark, we reaffirm our ongoing commitment to the 
security and integrity of all client data.  &lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L Now PCI Compliant",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:27.7921544" ),
                    EventTypeId = 1,
                    EventHtml = @"&lt;p&gt;
We are pleased to announce that effective October 31, 2011, Becket &amp; Lee LLP 
is certified as compliant with the Payment Card Industry Data Security Standard.  
By achieving this important benchmark, we reaffirm our ongoing commitment to the 
security and integrity of all client data.  &lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L Attorneys Receive Publication Award from ABI",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:27.7609550" ),
                    EventTypeId = 1,
                    EventHtml = @"
&lt;p&gt;
On Friday, October 14, 2011, Partner Alane Becket and Associate William McNeal 
received special publication awards from the American Bankruptcy Institute at a 
luncheon held during the 85th Annual National Conference of Bankruptcy Judges.  
The awards were given in recognition of their extensive efforts on the recently 
revised edition of the ABI treatise Consumer Bankruptcy:  &lt;i&gt;Fundamentals of Chapter 
7 and Chapter 13 of the U.S. Bankruptcy Code &lt;/i&gt;(3d. Edition).  
&lt;/p&gt;&lt;p&gt;
Among other things, this revised edition covers the fundamentals of consumer bankruptcy 
proceedings under chapters 7 and 13 of the Code, including updated information on the 
changes in the law since BAPCPA.  Moreover, it includes important information on today&#39;s 
most litigated questions, such as issues surrounding applicable commitment periods in 
chapter 13 plans, projected disposable income, case conversion and exemptions.  Finally, 
the book provides critical analyses of several new U.S. Supreme Court decisions, including 
&lt;i&gt;Lanning, Ransom, Espinosa and Milavetz.&lt;/i&gt;
&lt;/p&gt;&lt;p&gt;
For more information on the publication, please visit 
&lt;a href=&quot;http://bookstore.abi.org/&quot;&gt;http://bookstore.abi.org/&lt;/a&gt;.  
&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee Speaks to Visa Members",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:27.2773643" ),
                    EventTypeId = 1,
                    EventHtml = @"


&lt;p&gt;
On March 22, 2011, Tom shared his expertise on the recent Supreme Court 
decisions impacting creditor recoveries in a bankruptcy webinar 
presented by Visa for its members.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );


                eventObj = new Event()
                {
                    Title = @"A Claimant's Dilemma:  The Statute of Limitations and Proofs of Claim.",
                    CreatedDate = Convert.ToDateTime( "2015-04-21 14:41:20.4719083" ),
                    EventTypeId = 3,
                    EventHtml = @"

&lt;p style=&quot;text-align:center&quot;&gt;
Alane A. Becket and William A. McNeal
&lt;/p&gt;
&lt;p&gt;
&lt;a href=&quot;http://www.becket-lee.com/documents/Crawford-ABI Journal-A Claimant&#39;s Dilemma-201404.pdf#zoom=100&quot; target=&quot;PDI&quot;&gt;Click here for full article...&lt;/a&gt;&lt;br&gt;
&lt;/p&gt;
&lt;p&gt;
Reprinted with permission from the ABI Journal, Vol. XXXIV, No. 4, April 2015.  For more information, visit &lt;a href=&quot;http://www.abi.org&quot; target=&quot;blank&quot;&gt;www.abi.org.&lt;/a&gt;
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"FILER BEWARE! IT'S NOT JUST THE RULES COMMITTEE CHANGING THE RULES",
                    CreatedDate = Convert.ToDateTime( "2014-12-01 12:17:01.8592026" ),
                    EventTypeId = 3,
                    EventHtml = @"

&lt;p style=&quot;text-align:center&quot;&gt;
Alane A. Becket, Gilbert B. Weisman, William A. McNeal
&lt;/p&gt;
&lt;p&gt;
&lt;a href=&quot;http://www.becket-lee.com/documents/Crawford-Norton Article-41505120-Final.pdf#zoom=100&quot; target=&quot;PDI&quot;&gt;Click here for full article...&lt;/a&gt;&lt;br&gt;
&lt;/p&gt;
&lt;p&gt;
Reprinted from Norton Bankruptcy Law Adviser, (September 2014) with permission. Copyright &amp;copy; (2014) Thomson Reuters/West. 
For more information about this publication please visit &lt;a href=&quot;http://www.west.thomson.com&quot; target=&quot;blank&quot;&gt;
www.west.thomson.com.&lt;/a&gt;
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Proofs of Claim - Two Cases and a Lesson Learned",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:28.5565397" ),
                    EventTypeId = 3,
                    EventHtml = @"
&lt;p style=&quot;text-align: center&quot;&gt;
Alane Becket, Managing Partner and William McNeal, Associate
&lt;/p&gt;


&lt;p&gt;
&lt;a href=&quot;http://www.becket-lee.com/documents/Proofs%20of%20Claims-Two%20Cases%20and%20a%20Lesson%20Learned-May2010.pdf#zoom=100&quot; target=&quot;newWindow&quot;&gt;
Click here for full article...&lt;/a&gt;&lt;/p&gt;

&lt;p&gt;
Reprinted from Norton Bankruptcy Law Adviser, (May, 2010) with permission.  
Copyright &amp;copy; (2010) Thomson Reuters/West.  For more information about this 
publication please visit &lt;a href=&quot;http://www.west.thomson.com&quot; target=&quot;blank&quot;&gt;
www.west.thomson.com.&lt;/a&gt;

&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Projected Disposable Income Captures the Attention of the Supreme Court-Twice!",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:28.5097406" ),
                    EventTypeId = 3,
                    EventHtml = @"

&lt;p&gt;
&lt;p style=&quot;text-align: center&quot;&gt;Gil Weisman, Partner and William A. McNeal, Associate&lt;/p&gt;
&lt;p&gt;
&lt;a href=&quot;http://www.becket-lee.com/documents/Projected%20Disposable%20Income%20Captures%20Attention-Apr2011.pdf#zoom=100&quot; target=&quot;PDI&quot;&gt;Click here for full article...&lt;/a&gt;&lt;br&gt;
&lt;/p&gt;
&lt;p&gt;
Reprinted from Norton Bankruptcy Law Adviser, (April, 2011) with permission.  
Copyright &amp;copy; (2011) Thomson Reuters/West.  For more information about this 
publication please visit &lt;a href=&quot;http://www.west.thomson.com&quot; target=&quot;blank&quot;&gt;
www.west.thomson.com.&lt;/a&gt;
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );

                eventObj = new Event()
                {
                    Title = @"Partner Alane Becket attended the ABI Spring Meeting",
                    CreatedDate = Convert.ToDateTime( "2017-05-08 13:04:39.9707046" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Alane Becket attended the American Bankruptcy Institute&#39;s Spring Meeting in Washington, DC April 20-23, 2017. ABI&#39;s Annual Spring Meeting serves as the bankruptcy industry&#39;s one-stop resource for premier networking and quality education. The Annual Spring Meeting includes inspiring keynote sessions, important networking events, and a variety of targeted education sessions.  Alane is Vice President of Publications for the ABI.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee to Attend the CRS Conference",
                    CreatedDate = Convert.ToDateTime( "2017-05-08 13:02:11.1266328" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst Stu Cramer will attend and exhibit at the annual Collections and Recovery Solutions Conference in Las Vegas, May 10-12, 2017. The conference offers B&amp;L the opportunity to network at an exclusive gathering of industry professionals.  This year Tom will lead a roundtable discussion, the topic:  &lt;i&gt;Bankruptcy – Issues and Updates&lt;/i&gt;. This year, there are new bankruptcy  rules scheduled to go into place December 1, 2017, making various changes to consumer bankruptcy practice, including shortening the time frame to file a proof of claim.  On January 17, 2017, the Supreme Court of the United States heard arguments in &lt;i&gt;Midland Funding v. Aleida Johnson&lt;/i&gt;: the ultimate disposition of this case will resolve the question of the treatment of out of statute debt in bankruptcy and, if ever, the FDCPA applies in bankruptcy matters. The roundtable will be an open discussion regarding these items and any other consumer bankruptcy issues.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Partner Alane Becket attend the ABI Spring Meeting",
                    CreatedDate = Convert.ToDateTime( "2017-05-05 12:56:04.6613536" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Alane Becket attended the American Bankruptcy Institute’s Spring Meeting in Washington, DC April 20-23, 2017. ABI’s Annual Spring Meeting serves as the bankruptcy industry’s one-stop resource for premier networking and quality education. The Annual Spring Meeting includes inspiring keynote sessions, important networking events, and a variety of targeted education sessions.  Alane is Vice President of Publications for the ABI.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L Represented at Tech Conferences",
                    CreatedDate = Convert.ToDateTime( "2017-05-05 12:52:17.9890352" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Stu Cramer attended the EPIQ Systems User Conference in Kansas City, MO, April 18-21, 2017. The annual event enables Becket &amp; Lee to stay abreast of various technological developments and tools accessible to bankruptcy practitioners. 
&lt;/p&gt;&lt;p&gt;
Stu also attended the Bankruptcy Software Specialists 33rd Annual Chapter 13 Bankruptcy Seminar in Orlando, FL, April 25-27, 2017.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Presented at the 43rd Annual SBLI Seminar",
                    CreatedDate = Convert.ToDateTime( "2017-04-05 13:47:28.6227978" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
The 43rd Annual Southeastern Bankruptcy Law Institute Seminar was held in Atlanta, GA, March 30 - April 1, 2017.  As in prior years, Partner Alane Becket spoke at the event, this time on the topic of the Consumer Financial Protection Bureau (&quot;CFPB&quot;). The CFPB is in the headlines almost every week. Its activities touch every aspect of consumer finance, from regulating consumer lenders, industry participants and even lawyers, to rulemaking, enforcement actions, consumer protection initiatives and education. This session covered what one needs to know about the CFPB as a bankruptcy practitioner, a lawyer, a consumer financial service provider, and a consumer. 
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket to Attend the 43rd Annual SBLI Seminar",
                    CreatedDate = Convert.ToDateTime( "2017-04-04 09:57:10.9007737" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
The 43rd Annual Southeastern Bankruptcy Law Institute Seminar will be held in Atlanta, 
GA, March 30 - April 1, 2017.  Partner Alane Becket&#39;s topic: &quot;CFPB&quot;.   &quot;The CFPB&quot; is 
in the headlines almost every week. Its activities touch every aspect of consumer finance, 
from regulating consumer lenders, industry participants and even lawyers, to rulemaking, 
enforcement actions, consumer protection initiatives and education. 
This session will cover what one need to know about the CFPB as a bankruptcy practitioner, 
a lawyer, a consumer financial service provider, and a consumer.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"CBA Live 2017",
                    CreatedDate = Convert.ToDateTime( "2017-03-24 13:45:13.0476552" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst Stu Cramer will attend 
CBA LIVE 2017 in Grapevine, TX from April 2-5. CBA LIVE is an annual 
conference organized by the Consumer Bankers Association, which provides 
information across nine areas of retail banking. Becket &amp; Lee will also 
exhibit at the conference. 
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee Represented Firm at Marketplace Lending Conference",
                    CreatedDate = Convert.ToDateTime( "2017-03-24 13:43:59.6412598" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
On March 6 and 7, 2017, Tom Lee attended LendIt 2017 in New York City. 
The conference provided opportunities to meet decision-makers in the 
growing marketplace lending community, as Becket &amp; Lee continues to 
expand in providing services to this sector. 
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee Attending Marketplace Lending Conference",
                    CreatedDate = Convert.ToDateTime( "2017-02-23 17:57:57.5035025" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
On March 6 and 7, 2017, Tom Lee will attend LendIt 2017 in New York City. The conference will 
provide the firm opportunities to meet decision-makers in the growing marketplace lending 
community and continue Becket &amp; Lee&#39;s expansion in providing services to this sector. 
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Exhibited at DBA International 2017 Annual Conference",
                    CreatedDate = Convert.ToDateTime( "2017-02-20 13:56:28.7711396" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst Stu Cramer represented the firm at the 
20th Annual DBA International Conference. The conference was held at the Aria Resort in 
Las Vegas from February 7-9, 2017. In addition to attending the conference, Becket &amp; Lee 
also exhibited at the event.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee to Exhibit at DBA International 2017 Annual Conference",
                    CreatedDate = Convert.ToDateTime( "2017-01-06 15:03:39.9346715" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst Stu Cramer will represent the firm at the 20th Annual DBA International Conference. The conference will be held at the Aria Resort in Las Vegas from February 7-9, 2017.  In addition to attending the conference, Becket &amp; Lee will also exhibit at the event. 
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Attended ABI Winter Leadership Conference",
                    CreatedDate = Convert.ToDateTime( "2017-01-06 15:02:24.3412686" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Alane Becket attended the American Bankruptcy Institute&#39;s Winter Leadership Conference in Rancho Palos Verdes, CA, December 1-3, 2016.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = "Alane Becket Named Among \"25 Most Influential Women in Collections\"",
                    CreatedDate = Convert.ToDateTime( "2016-11-04 10:44:48.2747930" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
The firm is pleased to report that Partner Alane Becket was named one of the &quot;25 Most Influential Women in Collections&quot; by 
Collection Advisor magazine and was featured on its September/October 2016 cover.  The issue is available via Collection 
Advisor&#39;s website at: &lt;a href=&quot;http://issuu.com/collectionadvisor/docs/collection_advisor_september_octobe?e=23956006/38860619&quot;&gt;http://issuu.com/collectionadvisor/docs/collection_advisor_september_octobe?e=23956006/38860619&lt;/a&gt;
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket to Attend ABI Winter Leadership Conference",
                    CreatedDate = Convert.ToDateTime( "2016-11-04 10:42:34.2432801" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Alane Becket will be attending the American Bankruptcy Institute&#39;s Winter Leadership Conference in Rancho Palos Verdes, CA, December 1-3, 2016
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Chair of NARCA 2016 Fall Conference; Elected to Board of Directors",
                    CreatedDate = Convert.ToDateTime( "2016-11-04 10:41:23.0868872" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Alane Becket was the conference Chair at the National Creditors Bar Association (NARCA) Fall Conference in Las Vegas from October 26-29, 2016.  At the conference, Alane was elected to the Board of Directors for a two-year term.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Partners Alane Becket & Tom Lee Represented B&L at Annual Judges' Conference",
                    CreatedDate = Convert.ToDateTime( "2016-11-04 10:35:22.5705582" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Alane Becket and Tom Lee attended the National Conference of Bankruptcy Judges in San Francisco, CA from October 26-29, 2016.  The innovative education program offered excellent networking opportunities; NCBJ typically attracts in excess of 1,500 bankruptcy professionals.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Attended the 36th Annual ABI Midwestern Bankruptcy Institute Conference",
                    CreatedDate = Convert.ToDateTime( "2016-11-04 10:33:35.0078475" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Alane Becket attended this annual conference held in Kansas City, Missouri, September 29-30, 2016. 
Alane participated in the Consumer Debate: &quot;Resolved: An out-of-statute proof of claim violates the FDCPA,&quot; 
along with Thad O. Bartholow of Kellett &amp; Bartholow PLLC; Dallas. 
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket to Attend the 36th Annual ABI Midwestern Bankruptcy Institute Conference",
                    CreatedDate = Convert.ToDateTime( "2016-09-21 16:33:30.2532967" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Alane Becket will attend this annual conference held this year in Kansas City, Missouri, 
September 29-30, 2016.  Alane will participate in the Consumer Debate:  &quot;Resolved: An out-of-statute 
proof of claim violates the FDCPA,&quot; along with Thad O. Bartholow of Kellett &amp; Bartholow PLLC; Dallas.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Attended the ABI Southwest Conference",
                    CreatedDate = Convert.ToDateTime( "2016-09-21 16:31:41.7999609" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Alane Becket joined the American Bankruptcy Institute for the 23rd Annual Southwest Bankruptcy Conference 
in Las Vegas, September 10-12, 2016. Experienced practitioners and regional judges presented workshops on 
a variety of topics relating to both business and consumer bankruptcy. At the conference, Alane participated 
in the ABI&#39;s &quot;Great Debate&quot; on the topic: &quot;The filing of a Proof of Claim, for a debt on which the statute 
of limitations has run, is a violation of the FDCPA.&quot; 
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended the 2016 Debt Connection Symposium and Expo",
                    CreatedDate = Convert.ToDateTime( "2016-09-21 16:29:46.2997336" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst Stu Cramer attended the 2016 Debt Connection Symposium &amp; Expo 
in Tucson, AZ, September 13-15, 2016. The firm exhibited at this conference geared for collections, 
recovery, and debt sales professionals. 
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended the NABT 2016 Annual Convention",
                    CreatedDate = Convert.ToDateTime( "2016-09-21 16:28:39.9246366" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee attended the annual meeting of the National Association of Bankruptcy Trustees 
in San Diego, September 7-11, 2016. This annual event enables Becket &amp; Lee to interact with the 
Chapter 7 bankruptcy trustees, while staying current on bankruptcy developments. 
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee to Attend the 2016 Debt Connection Symposium and Expo",
                    CreatedDate = Convert.ToDateTime( "2016-08-03 15:21:50.5312376" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst Stu Cramer will be attending the 2016 Debt Connection Symposium &amp; Expo in Tucson, AZ from September 13 -15, 2016. The firm will exhibit at this conference geared for collections, recovery, and debt sales professionals.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket to Attend ABI Southwest Conference",
                    CreatedDate = Convert.ToDateTime( "2016-08-03 15:19:56.1091586" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Alane Becket will join the American Bankruptcy Institute for the 23rd Annual Southwest Bankruptcy Conference in Las Vegas from September 10-12, 2016. Experienced practitioners and regional judges will present workshops on a variety of topics relating to both business and consumer bankruptcy.  At the conference, Alane will participate in the ABI&#39;s &quot;Great Debate&quot; on the topic: The filing of a Proof of Claim, for a debt on which the statute of limitations has run, is a violation of the FDCPA.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee to Attend the NABT 2016 Annual Convention",
                    CreatedDate = Convert.ToDateTime( "2016-08-03 15:18:26.9371075" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee will be attending the annual meeting of the National Association of Bankruptcy Trustees in San Diego from September 7-11, 2016. This event enables Becket &amp; Lee to interact with the Chapter 7 bankruptcy trustees, while staying current on bankruptcy developments.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended NACTT's Annual Conference Philadelphia",
                    CreatedDate = Convert.ToDateTime( "2016-08-03 15:12:45.0145479" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partners Tom Lee, Alane Becket and Gil Weisman along with Operations Manager 
Stu Cramer attended the annual meeting of the National Association of 
Chapter 13 Trustees in Philadelphia, PA from July 20-23, 2016. On July 21, 
Gil participated in a panel discussion along with the Chapter 13 Standing 
Trustee for the District of Kansas, Jan M. Hamilton and Honorable Michael B. 
Kaplan, US Bankruptcy Judge for the District of New Jersey. Their topic: 
&lt;i&gt;Dischargeability Litigation: Defining fraud and examining discharge 
exceptions (other than student loans.)&lt;/i&gt;
&lt;/p&gt;&lt;p&gt;
On July 22, Alane joined Chapter 13 Standing Trustee for the District 
of Nevada, Kathleen A. Leavitt along with attorneys Joann Needleman and 
Barbara A. Sinsley in a panel discussion, What does the CFPB have to do 
with bankruptcy? On July 23, Alane participated in a question and answer 
follow-up discussion, CFPB- Ask the Experts. Joining Alane in this session 
was Chapter 13 Standing Trustee for the Central District of California, 
Amrane Cohen, Joanne Needleman and Barbara A. Sinsley. Once again, Becket &amp; Lee 
was a proud sponsor of the NACTT&#39;s educational program. 
&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee to Attend NACTT's Annual Conference Philadelphia",
                    CreatedDate = Convert.ToDateTime( "2016-07-14 09:31:16.2203393" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partners Tom Lee, Alane Becket and Gil Weisman along with Operations 
Manager Stu Cramer will be attending the annual meeting of the 
National Association of Chapter 13 Trustees in Philadelphia, PA from 
July 20-23, 2016. On July 21, Gil will participate in a panel 
discussion along with the Chapter 13 Standing Trustee for the 
District of Kansas, Jan M. Hamilton and Honorable Michael B. Kaplan, 
US Bankruptcy Judge for the District of New Jersey.  Their topic:  
Dischargeability Litigation: Defining fraud and examining discharge 
exceptions (other than student loans.)
&lt;/p&gt;&lt;p&gt;
On July 22, Alane will join Chapter 13 Standing Trustee for the 
District of Nevada, Kathleen A. Leavitt along with attorneys Joann 
Needleman and Barbara A. Sinsley in a panel discussion, What does 
the CFPB have to do with bankruptcy? On July 23, Alane will participate 
in a question and answer follow-up discussion, CFPB- Ask the Experts.  
Joining Alane in this session is Chapter 13 Standing Trustee for the 
Central District of California, Amrane Cohen, Joanne Needleman and 
Barbara A. Sinsley.  Once again, Becket &amp; Lee is a proud sponsor of 
the NACTT&#39;s educational program. 
&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Partner Alane Becket Chaired NARCA's 2016 Spring Litigation Boot Camp",
                    CreatedDate = Convert.ToDateTime( "2016-05-17 16:53:03.9621874" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
On May 7, 2016, partner Alane Becket chaired the inaugural litigation Boot 
Camp at the Spring Conference of the National Creditors Bar Association (NARCA) 
in Chicago.  The Boot Camp featured six segments designed to introduce young 
attorneys or those new to collection practice to various aspects of collections 
litigation.  In addition to chairing this successful event, Alane presented 
the &quot;Evidence Overview&quot; block.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Exhibited at the CRS Conference",
                    CreatedDate = Convert.ToDateTime( "2016-05-17 16:50:26.2108452" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst Stu Cramer 
Cramer attended and exhibited at the annual Collections 
and Recovery Solutions Conference in Las Vegas, May 11-13, 2016.  
The conference offered B&amp;L the opportunity to network at an 
exclusive gathering of industry professionals.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee to Exhibit at the CRS Conference",
                    CreatedDate = Convert.ToDateTime( "2016-04-19 10:33:39.4854316" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst Stu Cramer 
will attend and exhibit at the annual Collections and Recovery 
Solutions Conference in Las Vegas, May 11-13, 2016.  The 
conference offers B&amp;L the opportunity to network at an 
exclusive gathering of industry professionals.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"ABI Spring Meeting 2016",
                    CreatedDate = Convert.ToDateTime( "2016-04-19 10:31:44.7984197" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Managing Partner Alane Becket moderated a panel at the 
34th Annual American Bankruptcy Institute Spring Meeting 
in Washington, D.C., from April 14-17, 2016.  Alane was 
joined by the National Consumer Law Center&#39;s John Rao 
and Jon Pearson from Ballard Spahr to discuss, &quot;What 
is the CFBP, and Why Do I Care?&quot;
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Firm Represented at Tech Conferences",
                    CreatedDate = Convert.ToDateTime( "2016-04-19 10:27:14.3308286" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Stu Cramer attended the EPIQ Systems User Conference in Sanibel Island, Florida 
from April 3-6, 2016. The annual event enables Becket &amp; Lee to stay abreast of 
various technological developments and tools accessible to bankruptcy practitioners. 
&lt;/p&gt;&lt;p&gt;
Stu will also be attending the Bankruptcy Software Specialists&#39; 32nd Annual 
Chapter 13 Bankruptcy Seminar in Chicago, IL, April 25-28, 2016.

&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Attended the 42nd Annual SBLI Seminar",
                    CreatedDate = Convert.ToDateTime( "2016-04-19 10:21:31.7072784" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
The 42nd Annual Southeastern Bankruptcy Law Institute Seminar was held in 
Atlanta, GA, March 31 - April 2, 2016. Partner Alane Becket spoke on the topic 
&quot;Hey, give me some, too! - Issues Regarding Claim Allowance,&quot; along with Houston 
attorney Johnnie Patterson. In the months since the 11th Circuit&#39;s decision in 
LVNV vs Crawford, proofs of claims have again taken center stage in consumer bankruptcy 
cases. This panel surveyed the post-Crawford claims litigation landscape, including the 
use and nuances of statutes of limitations, the availability of state and federal 
consumer protection statutes, and the use of defensive judicial doctrines. 
&lt;/p&gt;&lt;p&gt;
The following week, Alane was in Atlanta presenting to the National Association of 
Bankruptcy Trustees, along with NABT Past President and Bankruptcy Judge James W. Boyd 
and former ABI President Richardo Kilpatrick and Judge, at a program entitled 
&quot;Money for Nothing&quot;, addressing challenges with creditor claims in chapter 7 cases. 

&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket to speak at the 42nd Annual SBLI Seminar",
                    CreatedDate = Convert.ToDateTime( "2016-03-30 13:48:33.2331736" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
The 42nd Annual Southeastern Bankruptcy Law Institute Seminar will be held in Atlanta, GA March 31 - April 2, 2016.  
Partner Alane Becket will be speaking on the topic &quot;Hey, give me some, too! - Issues Regarding Claim Allowance&quot; 
In the months since the 11th Circuit&#39;s decision in LVNV vs Crawford, proofs of claims have again taken center 
stage in consumer bankruptcy cases. This panel will survey the post-Crawford claims litigation landscape, 
including the use and nuances of statutes of limitations, the availability of state and federal consumer 
protection statutes, and the use of defensive judicial doctrines.   
&lt;/p&gt;&lt;p&gt;
The following week, Alane will again be in Atlanta presenting to the National Association of Bankruptcy Trustees 
at a program entitled &quot;Money for Nothing&quot;, addressing challenges with claims in chapter 7 cases.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L Attended CBA Live 2016",
                    CreatedDate = Convert.ToDateTime( "2016-03-30 13:44:45.0139673" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst Stu Cramer attended CBA LIVE 2016 in Phoenix, AZ from Mar. 7-9, 2016. CBA LIVE is an annual three-day conference organized by the Consumer Bankers Association, which provides information across nine areas of retail banking. Becket &amp; Lee also exhibited at the conference.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Partner Alane Becket Speaks at the 5th Circuit Bankruptcy Bench-Bar Conference",
                    CreatedDate = Convert.ToDateTime( "2016-03-03 15:15:01.5193772" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Alane Becket recently served on a panel discussion of Debt Collection and the Fair Debt 
at the 5th Circuit Bankruptcy Bench-Bar Conference, held in New Orleans, LA, February 24-26, 2016.  
This session, led by Judge Robert Drain, addressed one of the hottest issues in consumer bankruptcy; 
the question of what remedies are available for creditor misconduct, including actions under consumer 
financial protection statutes and the use of class actions in bankruptcy.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket on Panel at Emory University Symposium",
                    CreatedDate = Convert.ToDateTime( "2016-03-03 15:08:02.6538312" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Alane Becket was invited to participate in a panel at the 13th Annual Emory Bankruptcy 
Developments Journal Symposium. The EBDJ is an annual event held at Emory University School of 
Law in Atlanta, GA. On February 25, 2016, Alane&#39;s panel presented on the topic &quot;Recent Developments 
in Bankruptcy Regulation: Mortgage Servicing Rules, the FDCPA, and the CFPB&quot;. &lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket on Panel at Emory University Symposium",
                    CreatedDate = Convert.ToDateTime( "2016-02-24 15:59:04.3226307" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Alane Becket was invited to participate in a panel at the 13th Annual Emory Bankruptcy Developments Journal Symposium.  
The EBDJ is an annual event held at Emory University School of Law in Atlanta, GA.  On February 25, 2016, Alane&#39;s panel will present on the topic 
&quot;Recent Developments in Bankruptcy Regulation: Mortgage Servicing Rules, the FDCPA, and the CFPB&quot;.  
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L at CBA Live 2016",
                    CreatedDate = Convert.ToDateTime( "2016-02-24 15:57:17.2286707" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst Stu Cramer will attend CBA LIVE 2016 in Phoenix, AZ (Mar. 7-9, 2016). CBA LIVE is an annual three-day conference organized by the Consumer Bankers Association, which provides information across nine areas of retail banking. Becket &amp; Lee will also exhibit at the conference.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Firm Attended and Exhibited at DBA 2016",
                    CreatedDate = Convert.ToDateTime( "2016-02-24 15:56:02.0410366" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Firm Attended and Exhibited at DBA 2016 
Partner Tom Lee and Business Operations Analyst Stu Cramer represented represent the firm at the 19th Annual DBA International Conference. 
The conference was held at the Aria Resort in Las Vegas from February 9-11, 2016.  The firm also exhibited at the event. 
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket elected to the Board of Directors for the American Bankruptcy Institute",
                    CreatedDate = Convert.ToDateTime( "2016-01-04 10:07:20.8294876" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
    During ABI&#39;s 32nd Annual Spring Meeting, held April 24-27, 2009 in Washington, D.C, 
    Alane Becket was elected to the Board of Directors for the American Bankruptcy Institute 
    and Co-Chair of the ABI&#39;s Consumer Bankruptcy Committee. Becket &amp; Lee has been active 
    in the ABI for almost 20 years and this appointment is the result of years of service 
    to the ABI. Alane has distinguished herself as a speaker at ABI seminars and meetings, 
    moderator of the Consumer Bankruptcy Committee&#39;s list serve, Editor of the Consumer 
    Committee&#39;s Newsletter, columnist for the ABI Journal, Education Director for the 
    Consumer Committee, and Editor of the Consumer Education Center on the ABI&#39;s Website. 
    It was her work ethic, presentation skills and organizational abilities, combined 
    with her legal expertise, which caught the Board&#39;s attention. Alane was asked to 
    join the Board earlier this year and was officially approved by the President at 
    the ABI&#39;s Annual meeting last month. 
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Firm Attending and Exhibiting at DBA 2016",
                    CreatedDate = Convert.ToDateTime( "2016-01-04 10:00:41.6412025" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst Stu Cramer will once 
again represent the firm at the 19th Annual DBA International Conference.  
As in prior years, the conference will be held at the Aria Resort in 
Las Vegas.  The firm will be exhibiting at the event, which runs from 
February 9-11, 2016. 
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Attended ABI's Annual Leadership Conference",
                    CreatedDate = Convert.ToDateTime( "2016-01-04 09:59:17.7348319" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Alane Becket attended the American Bankruptcy Institutes 
27th Annual Winter Leadership Conference in Phoenix from December 3-5, 2015.  
The program features topics designed for consumer and business practitioners, 
as well as financial advisors.  
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Attended ABI's Annual Leadership Conference",
                    CreatedDate = Convert.ToDateTime( "2015-11-19 10:11:08.1541370" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Alane Becket attended the American Bankruptcy Institutes 
27th Annual Winter Leadership Conference in Phoenix from December 3-5, 2015.  
The program features topics designed for consumer and business practitioners, 
as well as financial advisors.  
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"NARCA 2015 Fall Collection Conference",
                    CreatedDate = Convert.ToDateTime( "2015-11-19 10:09:55.0436782" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Alane Becket attended the National Association of Retail Collection 
Attorneys annual conference in Washington, DC from Oct. 14-17, 2015. Alane 
introduced Sam Gerdano, Executive Director of the American Bankruptcy Institute, 
speaking about how new household debt patterns, such as the rise in student load 
debt, predict what&#39;s ahead for creditors, collectors and debt buyers . This 
was the ABI&#39;s first presentation to NARCA. 
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L Partners Attended the National Conference of Bankruptcy Judges",
                    CreatedDate = Convert.ToDateTime( "2015-10-15 15:36:48.4608403" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partners Alane Becket and Tom Lee attended the conference 
in Miami Beach, FL from Sept. 27-30, 2015.  The National Conference 
of Bankruptcy Judges is an association of the Bankruptcy Judges of 
the United States which has several purposes: to provide continuing 
legal education to judges, lawyers and other involved professionals, 
to promote cooperation among the Bankruptcy Judges, to secure a greater 
degree of quality and uniformity in the administration of the Bankruptcy 
system and to improve the practice of law in the Bankruptcy Courts of 
the United States.  Alane participated on a panel at this prestigious 
conference on Claim Buying in Consumer Bankruptcy Cases along 
with a Professor studying the debt buying industry and an attorney 
representing consumer debtors.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"NARCA 2015 Fall Collection Conference",
                    CreatedDate = Convert.ToDateTime( "2015-10-15 15:34:17.2261538" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Alane Becket will attend the National Association of Retail Collection Attorneys 
annual conference in Washington, DC from Oct. 14-17, 2015.  Alane will introduce Sam Gerdano, 
Executive Director of the American Bankruptcy Institute, speaking about how new household 
debt patterns, such as the rise in student load debt, predict what&#39;s ahead for creditors, 
collectors and debt buyers .  This will be the ABI&#39;s first presentation to NARCA. 
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L Partners to Attend the National Conference of Bankruptcy Judges",
                    CreatedDate = Convert.ToDateTime( "2015-09-18 09:59:58.7368647" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partners Alane Becket and Tom Lee will attend the conference 
in Miami Beach, FL from Sept. 27-30, 2015.  The National Conference 
of Bankruptcy Judges is an association of the Bankruptcy Judges of 
the United States which has several purposes: to provide continuing 
legal education to judges, lawyers and other involved professionals, 
to promote cooperation among the Bankruptcy Judges, to secure a greater 
degree of quality and uniformity in the administration of the Bankruptcy 
system and to improve the practice of law in the Bankruptcy Courts of 
the United States.  Alane will participate on a panel at this prestigious 
conference on &lt;i&gt;Claim Buying in Consumer Bankruptcy Cases&lt;/i&gt; along 
with a Professor studying the debt buying industry and an attorney 
representing consumer debtors.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended Debt Connection Symposium & Expo (DCS2015)",
                    CreatedDate = Convert.ToDateTime( "2015-09-18 09:57:33.5793718" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst Stu Cramer attended 
the 2015 Debt Connection Symposium &amp; Expo in Austin, TX. 
The firm exhibited at this conference geared for collections, 
recovery, and debt sales professionals from creditors, healthcare, 
collection agencies, collection attorney firms, debt buyers, 
and related industry vendors.   
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended the 2015 Annual Ch. 7 Trustees' Conference",
                    CreatedDate = Convert.ToDateTime( "2015-09-18 09:55:09.7965033" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee attended the annual meeting of the National 
Association of Bankruptcy Trustees in Chicago from August 27-29. The 
event is always a great occasion for Becket &amp; Lee to interact with the 
trustees, while keeping informed on current bankruptcy issues.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee to Attend Debt Connection Symposium & Expo (DCS2015)",
                    CreatedDate = Convert.ToDateTime( "2015-08-21 12:27:07.0484181" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
From September 9-11, 2015, Partner Tom Lee and Business Operations Analyst 
Stu Cramer will attend the 2015 Debt Connection Symposium &amp; Expo in Austin, 
TX. The firm will also exhibit at this event at booth# 203. Please stop by 
the exhibition hall to discuss your bankruptcy portfolio or email or call 
to schedule a time to meet.  
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee to Attend the 2015 Annual Ch. 7 Trustees' Conference",
                    CreatedDate = Convert.ToDateTime( "2015-08-21 12:26:00.7188746" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee will be attending the annual meeting of the National 
Association of Bankruptcy Trustees in Chicago from August 27-29. The 
event is a great occasion for Becket &amp; Lee to interact with the 
trustees, while keeping informed on current bankruptcy issues.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee Attended The National Conference of Bankruptcy Clerks",
                    CreatedDate = Convert.ToDateTime( "2015-08-21 12:23:48.3254418" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee represented  Becket &amp; Lee at the annual conference in 
Atlanta, Georgia from August 10-13, 2015.  Participation in this conference 
provided Becket &amp; Lee the opportunity to strengthen relationships with 
court personnel and improve communication on industry related issues.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee to attend The National Conference of Bankruptcy Clerks",
                    CreatedDate = Convert.ToDateTime( "2015-08-05 12:06:59.7746286" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee will represent Becket &amp; Lee at the annual conference in 
Atlanta, Georgia from August 10-13, 2015.  Participation in this conference 
provides Becket &amp; Lee the opportunity to strengthen relationships with 
court personnel and improve communication on industry related issues.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket attended the 20th Annual Southeast Bankruptcy Workshop",
                    CreatedDate = Convert.ToDateTime( "2015-08-05 12:05:44.4776142" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Alane Becket attended and participated in a panel discussion at 
the ABI&#39;s 20th Annual Southeast Bankruptcy Workshop in Florida from July 23-26, 2015.  
The panel topic, &quot;What Is Hot in July Besides the Weather? Litigation in Consumer Cases&quot;, 
focused on &lt;i&gt;Crawford v. LVNV Funding&lt;/i&gt; and related litigation, consumer protection 
(including the basics of credit reporting and regulatory actions), mortgage modifications, 
post-discharge actions, and the UST&#39;s enforcement activities.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket to attend 20th Annual Southeast Bankruptcy Workshop",
                    CreatedDate = Convert.ToDateTime( "2015-07-13 15:40:08.3409494" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Alane Becket will be attending and participating in a panel discussion at 
the ABI&#39;s 20th Annual Southeast Bankruptcy Workshop in Florida from July 23-26, 2015.  
The panel topic, &lt;i&gt;&quot;What Is Hot in July Besides the Weather? Litigation in Consumer Cases&quot;&lt;/i&gt;, 
will focus on Crawford v. LVNV Funding and related litigation, consumer protection 
(including the basics of credit reporting and regulatory actions), mortgage modifications, 
post-discharge actions, and the UST&#39;s enforcement activities.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended NACTT's Annual Conference in Salt Lake City",
                    CreatedDate = Convert.ToDateTime( "2015-07-13 15:37:56.7017702" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partners Alane Becket and Gil Weisman along with Business Operations Analyst 
Stu Cramer attended the annual meeting of the National Association of 
Chapter 13 Trustees in Salt Lake City, Utah from July 1-4, 2015. On July 3, 
Alane participated in a panel discussion of the recent Crawford v. LVNV 
Funding decision with Laurie Weatherford, Ch. 13 Trustee for the Middle District 
of Florida, and the Honorable Michael B. Kaplan, United States Bankruptcy 
Judge for the District of New Jersey (Trenton).  Once again, Becket &amp; Lee 
is was a proud sponsor of the NACTT&#39;s educational program. 
&lt;/p&gt;&lt;p&gt;
The event provides Becket &amp; Lee with opportunities to interact with the 
trustees, while staying abreast of issues impacting the bankruptcy process. 
The Firm&#39;s participation in events of this nature demonstrates its commitment 
to providing its clients with comprehensive, informed representation that 
evolves with the changing legal and regulatory landscape.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee to Attend NACTT's Annual Conference in Salt Lake City",
                    CreatedDate = Convert.ToDateTime( "2015-06-09 18:09:01.4671015" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partners Alane Becket and Gil Weisman along with Business Operations Analyst 
Stu Cramer will attend the annual meeting of the National Association of 
Chapter 13 Trustees in Salt Lake City, Utah from July 1-4, 2015. On July 3, 
Alane will participate in a panel discussion of the recent Crawford v. LVNV 
Funding decision with Laurie Weatherford, Ch. 13 Trustee for the Middle District 
of Florida, and the Honorable Michael B. Kaplan, United States Bankruptcy 
Judge for the District of New Jersey (Trenton).  Once again, Becket &amp; Lee 
is also a proud sponsor of the NACTT&#39;s educational program. 
&lt;/p&gt;&lt;p&gt;
The event provides Becket &amp; Lee with opportunities to interact with the 
trustees, while staying abreast of issues impacting the bankruptcy process. 
The Firm&#39;s participation in events of this nature demonstrates its commitment 
to providing its clients with comprehensive, informed representation that 
evolves with the changing legal and regulatory landscape.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Spoke at the 2015 NCCR ConferencePresented by Collections & Credit Risk",
                    CreatedDate = Convert.ToDateTime( "2015-06-09 18:06:21.3261615" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
In 2014, the Eleventh Circuit Court of Appeals ruled that filing a 
claim in a bankruptcy case on out of statute debt is a violation of 
the FDCPA. At the 2015 NCCR Conference, Partner Alane Becket discussed 
the current status of Crawford, what is happening in other circuits, as 
well as the intersection of two laws: the FDCPA and the U.S. Bankruptcy 
Code. The conference was held June 1-3, 2015 in New Orleans.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Speaking at the 2015 NCCR Conference Presented by Collections&CreditRisk",
                    CreatedDate = Convert.ToDateTime( "2015-05-19 13:59:01.0787066" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
In 2014, the Eleventh Circuit Court of Appeals ruled that filing a 
claim in a bankruptcy case on out of statute debt is a violation of 
the FDCPA.  At this year&#39;s conference, Partner Alane Becket will 
examine the current status of Crawford, what is happening in other 
circuits, as well as the intersection of two laws: the FDCPA and the 
U.S. Bankruptcy Code. Becket &amp; Lee will also be exhibiting at the 
conference which will be held June 1-3, 2015 in New Orleans.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L Exhibited at CRS Conference",
                    CreatedDate = Convert.ToDateTime( "2015-05-19 13:55:35.0456967" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst 
Stu Cramer attended and exhibit at the annual Collections and 
Recovery Solutions conference in Las Vegas, May 6-8, 2015.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Presented at NARCA Spring Conference",
                    CreatedDate = Convert.ToDateTime( "2015-05-19 13:52:30.6378725" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Alane Becket spoke at the National Association of Retail Collection 
Attorneys 2015 Spring Collection Conference in Nashville, TN (May 6-9, 2015). 
Alane&#39;s Topic: &lt;i&gt;Determining Statute of Limitations; There is No &quot;Easy Button&quot;.&lt;/i&gt;  
Alane was joined by Joann Needleman, Esquire, 
Maurice &amp; Needleman, P.C. and Barbara A. Sinsley, Esquire, Hudson Cook, LLP.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Stu Cramer Attended Tech Conference",
                    CreatedDate = Convert.ToDateTime( "2015-05-19 13:47:41.7916863" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Stu Cramer attended the EPIQ Systems User Conference in Key West, 
Florida from April 22-24, 2015. The annual event enables Becket &amp; Lee to 
stay abreast of various technological developments and tools accessible 
to bankruptcy practitioners. 
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Stu Cramer to Attend Tech Conference",
                    CreatedDate = Convert.ToDateTime( "2015-04-17 16:18:04.8840185" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Stu Cramer will be attending the EPIQ Systems User Conference in Key West, 
Florida from April 22-24, 2015. The annual event enables Becket &amp; Lee to 
stay abreast of various technological developments and tools accessible 
to bankruptcy practitioners. 
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L Exhibiting at CRS Conference",
                    CreatedDate = Convert.ToDateTime( "2015-04-17 16:16:55.3686791" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
From May 6-8, 2015, Partner Tom Lee and Business Operations Analyst 
Stu Cramer will attend and exhibit at the annual Collections and 
Recovery Solutions conference in Las Vegas. 
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Presenting at NARCA Spring Conference",
                    CreatedDate = Convert.ToDateTime( "2015-04-17 16:15:59.8064309" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Alane Becket will speak at the National Association of Retail Collection 
Attorneys 2015 Spring Collection Conference in Nashville, TN (May 6-9, 2015). 
Alane&#39;s Topic: &lt;i&gt;Determining Statute of Limitations; There is No &quot;Easy Button&quot;.&lt;/i&gt;  
Joining Alane are Joann Needleman, Esquire, 
Maurice &amp; Needleman, P.C. and 
Barbara A. Sinsley, Esquire, Hudson Cook, LLP.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"ABI Spring Meeting 2015",
                    CreatedDate = Convert.ToDateTime( "2015-04-17 16:13:29.3695707" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Managing Partner Alane Becket attended the 33nd Annual American Bankruptcy Institute Spring Meeting in Washington, D.C., from April 16-19, 2015.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Firm Attended CBA Live 2015",
                    CreatedDate = Convert.ToDateTime( "2015-04-01 17:10:48.5659362" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst Stu Cramer 
attended CBA LIVE 2015 in Orlando, FL (Mar. 23-25, 2015).  
CBA LIVE is an annual three-day conference organized by the 
Consumer Bankers Association, which provides information 
across nine areas of retail banking. 
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Presented at Southeastern Bankruptcy Law Institute Seminar",
                    CreatedDate = Convert.ToDateTime( "2015-04-01 17:08:22.1602405" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Alane Becket spoke at the 41st Annual SBLI Seminar 
in Atlanta (March 26-28, 2015) on the topic &lt;i&gt;Litigation: Complaint 
to Determine Dischargeability of Student Loan.&lt;/i&gt; The presentation 
covered the rules of evidence in a student loan hardship case, the 
legal basis for the complaint, the evidence necessary for trial, and 
other relative issues.  Alane was joined by the Honorable William H. Brown. 
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"ABI Spring Meeting 2015",
                    CreatedDate = Convert.ToDateTime( "2015-04-01 17:05:23.1454153" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Managing Partner Alane Becket will attend the 33nd Annual 
American Bankruptcy Institute Spring Meeting in Washington, D.C., from April 16-19, 2015.    
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L Attended the 2015 Debt Buyers' Conference",
                    CreatedDate = Convert.ToDateTime( "2015-03-12 12:35:13.9475326" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst Stu Cramer 
attended the 18th Annual DBA International Conference at 
the Aria Resort in Las Vegas Feb. 3-5, 2015.  
The firm also exhibited at the event.  
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Moderated at ABI Event in March 2015",
                    CreatedDate = Convert.ToDateTime( "2015-03-12 12:32:45.2597426" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Alane Becket moderated a panel discussion of current 
consumer bankruptcy topics at the 39th Annual Alexander L. 
Paskay Memorial Bankruptcy Seminar in Tampa, Florida (Mar. 5-7, 2015). 
The session covered recent developments in the Eleventh Circuit, 
as well as other topics of regional and national importance. 
The panel included bankruptcy attorneys, as well as a Chapter 13 Trustee. 
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Speaking at Southeastern Bankruptcy Law Institute Seminar",
                    CreatedDate = Convert.ToDateTime( "2015-03-12 12:30:57.2439141" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Alane Becket will be speaking at the 41st Annual SBLI Seminar 
in Atlanta (March 26-28, 2015) on the topic &lt;i&gt;Litigation: Complaint 
to Determine Dischargeability of Student Loan.&lt;/i&gt; The presentation 
will cover the rules of evidence in a student loan hardship case, the 
legal basis for the complaint, the evidence necessary for trial, and 
other relative issues. Joining Alane will be the Honorable William H. Brown.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Firm Attending CBA Live 2015",
                    CreatedDate = Convert.ToDateTime( "2015-01-29 16:50:21.1851574" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst Stu Cramer 
will attend CBA LIVE 2015 in Orlando, FL (Mar. 23-25, 2015).  
CBA LIVE is an annual three-day conference organized by the 
Consumer Bankers Association, which provides information 
across nine areas of retail banking. 
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Moderating at ABI Event in March 2015",
                    CreatedDate = Convert.ToDateTime( "2015-01-29 16:49:16.6331850" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Alane Becket will moderate a panel discussion of current 
consumer bankruptcy topics at the 39th Annual Alexander L. Paskay 
Memorial Bankruptcy Seminar in Tampa, Florida (Mar. 5-7, 2015). 
The session will include recent developments in the Eleventh Circuit, 
as well as other topics of regional and national importance.  
The panel will include bankruptcy attorneys, as well as a Chapter 13 Trustee.   
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Invited to Testify on Bankruptcy Rules",
                    CreatedDate = Convert.ToDateTime( "2015-01-29 16:46:40.7131840" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
On Friday, January 23, 2015, Alane Becket testified before the 
Federal Advisory Committee on Rules of Bankruptcy Procedure in 
Washington, D.C. regarding the proposed National Chapter 13 Plan 
Form.  Alane testified in support of the adoption of a national 
form for Chapter 13 plans.  
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"ABA's Invitation to Alane Becket",
                    CreatedDate = Convert.ToDateTime( "2015-01-29 16:45:30.9820780" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
The American Bar Association recently invited Partner 
Alane Becket to participate in a panel at its Annual 
Consumer Financial Services Winter Meeting.  Alane&#39;s 
presentation, entitled Proofs of Claim on Time-Barred 
Debt After Crawford, examined the Eleventh Circuit�s 
recent decision, including the legal and practical ramifications.  
The event was held in New Orleans from January 10-13, 2015.  
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee Presented at FSCOR 2014",
                    CreatedDate = Convert.ToDateTime( "2014-12-01 12:21:47.4621718" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst Stu Cramer attended 
the 22nd Annual Financial Services Collections &amp; Operational Risk 
Conference in Las Vegas. The conference was held October 27-29 and 
Tom spoke on the subject &quot;Bankruptcy Claims Process - Today and Upcoming Changes&quot;. 
The presentation included a discussion of the proposed chapter 13 national 
plan form; risk management issues related to consumer debt sales; 
and recent developments in the law. 

&lt;/p&gt;&lt;p&gt;
As in prior years, Becket &amp; Lee also exhibited at the event.

&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket at NARCA 2014 Fall Conference",
                    CreatedDate = Convert.ToDateTime( "2014-12-01 12:19:58.2472719" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Alane Becket presented at the NARCA 2014 Fall Collection Conference 
in Las Vegas, which ran from October 22-25. Alane&#39;s panel presentation, 
&quot;Collection Litigation is NOT Scattershot Litigation&quot;, discussed the term 
&quot;Scattershot Litigation&quot; as it is currently being used by the CFPB, along 
with an exploration of practical concerns involving application of the term. 
She was joined on the panel by attorneys Joann Needleman and Barbara Sinsley. 
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee Speaking at FSCOR 2014",
                    CreatedDate = Convert.ToDateTime( "2014-10-13 12:11:47.4051032" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst 
Stu Cramer will attend the 22nd Annual Financial 
Services Collections &amp; Operational Risk Conference 
in Las Vegas.  The conference runs from October 27-29 
and Tom will be speaking on the subject &quot;Bankruptcy 
Claims Process - Today and Upcoming Changes&quot;.  The 
presentation will include a discussion of the proposed 
chapter 13 national plan form; risk management issues 
related to consumer debt sales; and recent developments 
in the law.  
&lt;/p&gt;&lt;p&gt;
As in prior years, Becket &amp; Lee will also exhibit at the event.  
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended Annual Judges' Conference",
                    CreatedDate = Convert.ToDateTime( "2014-10-13 12:09:27.0528029" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
From October 8-11, 2014, Partners Alane Becket and Tom Lee 
represented the firm at the National Conference of Bankruptcy Judges in Chicago.
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Participated in NARCA Webinar",
                    CreatedDate = Convert.ToDateTime( "2014-09-26 10:54:21.9116073" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;On September 23, 2014, Partner Alane Becket led a NARCA-sponsored 
webinar entitled &quot;What Collection Attorneys Need to Know When a Debtor 
Files for Bankruptcy&quot;. The webinar examined areas of concern such as 
verification of bankruptcy status, managing pending litigation and 
garnishments, and the applicability of the FDCPA for bankruptcy-related acts.  
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Speaking at NARCA Fall Conference",
                    CreatedDate = Convert.ToDateTime( "2014-09-12 10:01:52.0888903" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;Partner Alane Becket will present at the NARCA 2014 Fall Collection 
Conference in Las Vegas, which runs from October 22-25.  Alane&#39;s panel 
presentation, &quot;Collection Litigation is NOT Scattershot Litigation&quot; will 
discuss the term &quot;Scattershot Litigation&quot; as it is currently being used 
by the CFPB, along with an exploration of practical concerns involving 
application of the term. She will be joined on the panel by attorneys 
Joann Needleman and Barbara Sinsley.  
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attending Upcoming Judges' Conference",
                    CreatedDate = Convert.ToDateTime( "2014-09-12 10:01:07.7539745" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Beginning on October 8, 2014, Partners Alane Becket and Tom Lee will represent the 
firm at the National Conference of Bankruptcy Judges in Chicago.  
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended September 2014 Events",
                    CreatedDate = Convert.ToDateTime( "2014-09-12 09:58:37.2305394" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Beginning September 9, 2014, Partner Tom Lee and Business 
Operations Analyst Stu Cramer attended the 2014 Debt 
Connection Symposium &amp; Expo in Las Vegas.  The firm  
also exhibited at this event.   
&lt;/p&gt;&lt;p&gt;
Partner Tom Lee then attended the Annual Meeting of the 
National Association of Bankruptcy Trustees in 
Salt Lake City, UT, which was held September 11-14, 2014.  
&lt;/p&gt;&lt;p&gt;
Both events represented great opportunities 
for the firm to interact with other industry and
bankruptcy professionals. 
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attending September Events",
                    CreatedDate = Convert.ToDateTime( "2014-08-20 14:13:35.7162103" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Beginning September 9, 2014, Partner Tom Lee and Business 
Operations Analyst Stu Cramer will attend the 2014 Debt 
Connection Symposium &amp; Expo in Las Vegas.  The firm will 
also exhibit at this event.   
&lt;/p&gt;&lt;p&gt;
Partner Tom Lee will also attend the Annual Meeting of the 
National Association of Bankruptcy Trustees in 
Salt Lake City, UT, which runs September 11-14, 2014.  
&lt;/p&gt;&lt;p&gt;
The firm looks forward to both events as 
opportunities to interact with bankruptcy 
and industry professionals. 
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L at July Events:  NACTT and NCBC",
                    CreatedDate = Convert.ToDateTime( "2014-07-23 17:35:18.4307867" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
In mid-July 2014, Partners Alane Becket, Tom Lee and Gil Weisman and 
Business Operations Analyst Stu Cramer attended the annual seminar 
of the National Association of Chapter 13 Trustees in Chicago. As in 
prior years, Becket &amp; Lee was a proud sponsor of the NACTT&#39;s educational program. 
&lt;/p&gt;&lt;p&gt;
Alane Becket was also invited to participate in a panel presentation 
entitled &quot;Who Gets Undistributed Money in the Trustee&#39;s Hands on Conversion 
and/or Dismissal?&quot;  Alane will be presenting along with the Honorable Brian 
Lynch from the Bankruptcy Court in Washington and Isabel Balboa, Chapter 13 
Trustee from the District of New Jersey.
&lt;/p&gt;&lt;p&gt;
Partner Tom Lee also represented the Firm at the National Conference of 
Bankruptcy Clerks in St. Louis, MO.  Attending and participating in events 
such as these are an integral part of Becket &amp; Lee&#39;s continuing commitment 
to building and maintaining its relationships with bankruptcy professionals. 
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L at July Events:  NACTT and NCBC",
                    CreatedDate = Convert.ToDateTime( "2014-06-25 15:29:31.9724644" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
In mid-July 2014, Partners Alane Becket, Tom Lee and Gil Weisman and 
Business Operations Analyst Stu Cramer will attend the annual seminar 
of the National Association of Chapter 13 Trustees in Chicago. As in 
prior years, Becket &amp; Lee is a proud sponsor of the NACTT&#39;s educational program. 
&lt;/p&gt;&lt;p&gt;
Alane Becket has also been invited to participate in a panel presentation 
entitled &quot;Who Gets Undistributed Money in the Trustee&#39;s Hands on Conversion 
and/or Dismissal?&quot;  Alane will be presenting along with the Honorable Brian 
Lynch from the Bankruptcy Court in Washington and Isabel Balboa, Chapter 13 
Trustee from the District of New Jersey.
&lt;/p&gt;&lt;p&gt;
Partner Tom Lee will also represent the Firm at the National Conference of 
Bankruptcy Clerks in St. Louis, MO.  Attending and participating in events 
such as these are an integral part of Becket &amp; Lee&#39;s continuing commitment 
to building and maintaining its relationships with bankruptcy professionals. 
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Invited to NARCA Spring 2014 Event",
                    CreatedDate = Convert.ToDateTime( "2014-05-20 15:43:30.4669370" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Alane Becket was invited to participate at the NARCA 
Annual Spring Conference in a panel discussion of &quot;What Collection 
Attorneys Need to Know When a Debtor Files for Bankruptcy&quot;. The 
session covered areas of particular concern such as verification 
of bankruptcy status, managing pending litigation and garnishments, 
and the applicability of the FDCPA for bankruptcy-related acts. 
The event was held May 15-17 in Miami Beach, FL. 
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Firm Exhibited at CRS 2014",
                    CreatedDate = Convert.ToDateTime( "2014-05-20 15:41:19.2882188" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
From May 7-9, 2014, Partner Tom Lee and Business Operations Analyst 
Stu Cramer attended and exhibited at the annual Collections and 
Recovery Solutions conference in Las Vegas. 
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Managing Partner Attended Commercial Law League Event",
                    CreatedDate = Convert.ToDateTime( "2014-05-02 10:09:04.5876624" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Managing Partner Tom Lee attended the 
Commercial Law League of America Annual Convention and Midwest Meeting.  
The event was held in Chicago April 24-26, 2014.  
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"ABI Spring Meeting 2014",
                    CreatedDate = Convert.ToDateTime( "2014-05-02 10:07:07.0587692" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Managing Partner Alane Becket attended the 32nd Annual 
ABI Spring Meeting in Washington, D.C., which ran from April 24-27, 2014.  
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Speaking at NARCA Spring 2014 Event",
                    CreatedDate = Convert.ToDateTime( "2014-04-14 14:27:36.7089637" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Alane Becket was invited to participate at the NARCA Annual Spring 
Conference in a panel discussion of &quot;What Collection Attorneys Need to Know 
When a Debtor Files for Bankruptcy&quot;.  The session will cover areas of 
particular concern such as verification of bankruptcy status, managing 
pending litigation and garnishments, and the applicability of the 
FDCPA for bankruptcy-related acts.  The event will be held May 15-17 
in Miami Beach, FL.
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Firm Exhibiting at CRS 2014",
                    CreatedDate = Convert.ToDateTime( "2014-04-14 14:26:14.3755149" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
From May 7-9, 2014, Partner Tom Lee and Business Operations Analyst 
Stu Cramer will attend and exhibit at the annual Collections and 
Recovery Solutions conference in Las Vegas. 
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Managing Partner to Attend Commercial Law League Event",
                    CreatedDate = Convert.ToDateTime( "2014-04-14 14:25:16.9236613" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Beginning on Thursday, April 24, Managing Partner Tom Lee will attend the 
Commercial Law League of America Annual Convention and Midwest Meeting.  
The event is being held in Chicago and runs through April 26, 2014.  
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"ABI Spring Meeting",
                    CreatedDate = Convert.ToDateTime( "2014-04-14 14:24:16.8355429" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Managing Partner Alane Becket will attend the upcoming 32nd Annual 
ABI Spring Meeting in Washington, D.C. The conference is scheduled 
to run from April 24-27, 2014.  
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L at 9th Annual CCN Conference",
                    CreatedDate = Convert.ToDateTime( "2014-04-14 14:23:25.3893813" ),
                    EventTypeId = 2,
                    EventHtml = @"
&lt;p&gt;
Business Operations Analyst Stu Cramer attended the Credit and 
Collection News 9th Annual Conference in Naples, FL from April 2-4, 2014.  
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"CBA Live 2014",
                    CreatedDate = Convert.ToDateTime( "2014-04-07 09:54:15.8444728" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee attended CBA LIVE 2014 in National Harbor, MD, 
which ran from March 31-April 2, 2014. CBA LIVE is an annual 
three-day conference organized by the Consumer Bankers Association, 
which provides information across nine areas of retail banking. 
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Firm Exhibited at NCOR 2014",
                    CreatedDate = Convert.ToDateTime( "2014-04-07 09:52:49.1719840" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Becket &amp; Lee exhibited at the 18th Annual National Collections &amp; Operational 
Risk Conference held in Miami Beach, FL in late-March 2014. Partner 
Tom Lee and Business Operations Analyst Stu Cramer also attended the event.  
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"CBA Live 2014",
                    CreatedDate = Convert.ToDateTime( "2014-02-17 17:17:03.1632674" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee will attend CBA LIVE 2014, beginning on March 31, 2014.  CBA 
LIVE is an annual three-day conference organized by the Consumer Bankers 
Association, which provides information across nine areas of retail banking. 
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Firm Exhibiting at NCOR 2014",
                    CreatedDate = Convert.ToDateTime( "2014-02-17 17:15:56.0217282" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Becket &amp; Lee will exhibit at the 18th Annual National Collections &amp; Operational 
Risk Conference in Miami Beach, FL beginning on Monday, March 24, 2014.  Partner 
Tom Lee and Business Operations Analyst Stu Cramer will also attend.  
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended Debt Buyers' Conference in February 2014",
                    CreatedDate = Convert.ToDateTime( "2014-02-17 17:10:17.5996670" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst Stu Cramer attended the 
17th Annual DBA International Conference at the Aria Resort in Las Vegas, 
which ran from February 5-7, 2014. Becket &amp; Lee also exhibited at the event.
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attending Debt Buyers' Conference in February 2014",
                    CreatedDate = Convert.ToDateTime( "2014-01-23 18:18:47.4667556" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst Stu Cramer will attend the 
17th Annual DBA International Conference at the Aria Resort in Las Vegas, 
beginning on Wednesday, February 5, 2014.  Becket &amp; Lee will also exhibit at the event.  
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Represented Firm at 2013 Annual Judges' Conference",
                    CreatedDate = Convert.ToDateTime( "2014-01-15 11:07:06.1764234" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Beginning on October 30, 2013, Partner Alane Becket represented the firm 
at the National Conference of Bankruptcy Judges in Atlanta. Alane was asked 
by NCBJ President Judge Ray Mullins to serve on the Conference&#39;s Education 
Committee, and she participated in a panel discussion about the new 
Chapter 13 Plan Form.  Alane&#39;s fellow panelists include Judge Rebecca Buehler 
Connelly, from the Western District of Virginia and Chapter 13 Trustee 
Margaret Burks. The session was moderated by Judge Eugene R. Wedoff, 
the incoming President of the NCBJ. 
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket to Participate at 2013 Annual Judges' Conference",
                    CreatedDate = Convert.ToDateTime( "2013-10-25 16:56:55.3035193" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Beginning on October 30, 2013, Partner Alane Becket will represent the firm 
at the National Conference of Bankruptcy Judges in Atlanta. Alane was asked 
by NCBJ President Judge Ray Mullins to serve on the Conference�s Education 
Committee, and she will participate in a panel discussion about the new 
Chapter 13 Plan Form.  Alane�s fellow panelists include Judge Rebecca Buehler 
Connelly, from the Western District of Virginia and Chapter 13 Trustee 
Margaret Burks. The session will be moderated by Judge Eugene R. Wedoff, 
the incoming President of the NCBJ. 
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Presented at October Bankruptcy Events",
                    CreatedDate = Convert.ToDateTime( "2013-10-25 16:54:55.9806491" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Alane Becket presented at the NARCA 2013 Fall Collection Conference 
in Washington, DC. The conference ran from October 16-19. Alane&#39;s presentation, 
&quot;Bankruptcy Update: The National Chapter 13 Plan Form&quot;, addressed the new 
requirements for Chapter 13 plans and the pending changes to the bankruptcy 
Rules, including how these changes will impact creditors. 
&lt;/p&gt;&lt;p&gt;
Alane also spoke on the subject of Student Loan Dischargeability at the 
Dallas-Fort Worth Area Chapter 13 Consumer Bankruptcy Conference on October 21. 
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended FSCOR 2013",
                    CreatedDate = Convert.ToDateTime( "2013-10-25 16:52:12.7755415" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst Stu Cramer attended the 
21st Annual Financial Services Collections &amp; Operational Risk Conference in 
Chicago. The conference ran from October 21-23, 2013 and Becket &amp; Lee exhibited at the event.

&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L's Participation at 2013 Annual Judges' Conference",
                    CreatedDate = Convert.ToDateTime( "2013-10-08 09:47:35.9809795" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Beginning on October 30, 2013, Partners Alane Becket and Tom Lee will represent the firm at 
the National Conference of Bankruptcy Judges in Atlanta.  Alane was asked by NCBJ President 
Judge Ray Mullins to serve on the Conference�s Education Committee, and Tom will participate 
in a panel discussion about the new Chapter 13 Plan Form. His fellow panelists include Judge 
Rebecca Buehler Connelly, from the Western District of Virginia and Chapter 13 Trustee Margaret 
Burks. The session will be moderated by Judge Eugene R. Wedoff, the incoming President of the NCBJ.
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee to Attend FSCOR 2013",
                    CreatedDate = Convert.ToDateTime( "2013-10-08 09:45:04.5673795" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst Stu Cramer will attend the upcoming 21st 
Annual Financial Services Collections &amp; Operational Risk Conference in Chicago. 
Tom is also chairing the pre-conference Future Leaders Forum. The conference 
runs from October 21-23, 2013 and Becket &amp; Lee will exhibit at the event.  For more 
information on FSCC 2013, visit the official website at: 

&lt;a href=&quot;http://www.collectionscreditrisk.com/conferences/fscc/&quot; target=newWindow&gt;
&lt;p style=&quot;text-align:center&quot;&gt;
http://www.collectionscreditrisk.com/conferences/fscc/ &lt;/p&gt; &lt;/a&gt; &lt;/center&gt;

&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket to Speak at October Bankruptcy Events",
                    CreatedDate = Convert.ToDateTime( "2013-09-26 15:37:13.0328652" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Alane Becket will present at the NARCA 2013 Fall Collection Conference 
in Washington, DC. The conference runs from October 16-19. Alane&#39;s presentation, 
&quot;Bankruptcy Update: The National Chapter 13 Plan Form&quot;, will address the new 
requirements for Chapter 13 plans and the pending changes to the bankruptcy Rules, 
including how these changes will impact creditors.  
&lt;/p&gt;&lt;p&gt;
Alane is also scheduled to speak on the subject of Student Loan Dischargeability 
at the Dallas-Fort Worth Area Chapter 13 Consumer Bankruptcy Conference on October 21.  
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L's Participation at 2013 Annual Judges' Conference",
                    CreatedDate = Convert.ToDateTime( "2013-09-26 15:35:16.0648150" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Beginning on October 30, 2013, Partners Alane Becket and Tom Lee will represent the 
firm at the National Conference of Bankruptcy Judges in Atlanta. Alane is serving on 
the Conference&#39;s Education Committee, and Tom has been asked to participate in a panel 
discussion about the new Chapter 13 Plan Form. His fellow panelists include U.S. 
Bankruptcy Court Judge Rebecca Buehler Connelly and Chapter 13 Trustee Margaret Burks.  
The session will be moderated by U.S. Bankruptcy Court Judge Eugene R. Wedoff, 
the incoming President of the NCBJ.  
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee to Attend FSCO 2013",
                    CreatedDate = Convert.ToDateTime( "2013-09-26 15:33:18.0203717" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst Stu Cramer will attend the upcoming 21st 
Annual Financial Services Collections &amp; Operational Risk Conference in Chicago. 
Tom is also chairing the pre-conference Future Leaders Forum. The conference 
runs from October 21-23, 2013 and Becket &amp; Lee will exhibit at the event.  For more 
information on FSCC 2013, visit the official website at: 

&lt;a href=&quot;http://www.collectionscreditrisk.com/conferences/fscc/&quot; target=newWindow&gt;
&lt;p style=&quot;text-align:center&quot;&gt;
http://www.collectionscreditrisk.com/conferences/fscc/ &lt;/p&gt; &lt;/a&gt; &lt;/center&gt;

&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"DCS 2013: B&L Exhibited",
                    CreatedDate = Convert.ToDateTime( "2013-09-26 15:30:44.3613567" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
    Business Operations Analyst Stu Cramer attended the 2013 Debt Connection Symposium &amp; Expo 
    in Las Vegas beginning on September 9, 2013.  As in prior years, the firm also exhibited at the event. 
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended Trustee Conference in August",
                    CreatedDate = Convert.ToDateTime( "2013-08-14 09:35:38.9355267" ),
                    EventTypeId = 2,
                    EventHtml = @"



&lt;p&gt; In early August, Partners Tom Lee and Gil Weisman and Business 
Operations Analyst Stu Cramer attended the annual meeting of the 
National Association of Chapter 13 Trustees in New York City. Once 
again, Becket &amp; Lee was a proud sponsor of the NACTT&#39;s educational 
program.
&lt;/p&gt;

&lt;p&gt;The event provided the Firm with opportunities to interact with the 
trustees, while staying abreast of issues impacting the bankruptcy 
process. Indeed, the Firm&#39;s participation in events of this nature 
demonstrates its commitment to providing its clients with comprehensive, 
informed representation that evolves with the changing legal and 
regulatory landscape. 
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee to Attend Trustee Conferences in August",
                    CreatedDate = Convert.ToDateTime( "2013-07-24 09:51:49.9868967" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;In early August, Partners Tom Lee and Gil Weisman and Business Operations Analyst Stu Cramer will attend the annual meeting of the National Association of Chapter 13 Trustees in New York City. Once again, Becket &amp; Lee is a proud sponsor of the NACTT&#39;s educational program.
&lt;/p&gt;&lt;p&gt;
Then, beginning on August 8th, Tom Lee will join the Chapter 7 Trustees for their annual conference in West Virginia.
&lt;/p&gt;&lt;p&gt;
Both events provide the Firm with opportunities to interact with the trustees, while staying abreast of issues impacting the bankruptcy process. Indeed, the Firm&#39;s participation in these conferences demonstrates its commitment to providing its clients with comprehensive, informed representation that evolves with the changing legal and regulatory landscape.
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L at NARCA Spring 2013 Conference",
                    CreatedDate = Convert.ToDateTime( "2013-05-14 16:25:36.8849078" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Alane Becket attended the 2013 Spring Collection Conference 
of the National Association of Retail Collection Attorneys in Las Vegas.  
The conference ran from May 8-11, 2013.   
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Managing Partners Attended ABI Spring Meeting",
                    CreatedDate = Convert.ToDateTime( "2013-05-14 16:23:49.0590902" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Managing Partners Alane Becket and Tom Lee attended the recent 31st Annual 
ABI Spring Meeting in National Harbor, Maryland.  The conference ran from 
April 18-21, 2013.  
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"CRS 2013: Tom Lee Presented/Firm Exhibited",
                    CreatedDate = Convert.ToDateTime( "2013-05-14 16:23:34.0988820" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;From May 8-10, 2013, Partner Tom Lee and Business Operations Analyst 
Stu Cramer attended the annual Collections and Recovery Solutions 
conference in Las Vegas. On Friday, May 10th, Tom led a roundtable 
discussion of the proposed national new chapter 13 form plan and its 
potential ramifications on creditors.  Becket &amp; Lee also exhibited
at the event.
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Managing Partners Attend ABI Spring Meeting",
                    CreatedDate = Convert.ToDateTime( "2013-04-08 10:57:04.9880347" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Managing Partners Alane Becket and Tom Lee will attend the upcoming 31st Annual 
ABI Spring Meeting in National Harbor, Maryland.  The conference runs from 
April 18-21, 2013.  For more information on the event, please visit: 
&lt;a href=&quot;http://www.abiworld.org/ASM13/&quot; target=&quot;newWindow&quot;&gt;http://www.abiworld.org/ASM13/&lt;/a&gt; 
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Partner Tom Lee Co-Presented At NCCR 2013; Firm Exhibited",
                    CreatedDate = Convert.ToDateTime( "2013-04-08 10:50:23.6806072" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst Stu Cramer attended 
the 17th Annual National Collections &amp; Credit Risk Conference in New 
Orleans March 20-22, 2013.  Tom also co-presented on the subject 
&quot;Emerging Technologies in Collection Agency Management&quot; and the firm exhibited at the event. 
&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"CRS 2013: Tom Lee Presenting/Firm Exhibiting",
                    CreatedDate = Convert.ToDateTime( "2013-03-15 10:36:14.7943061" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;From May 8-10, 2013, Partner Tom Lee and Business Operations Analyst 
Stu Cramer will attend the annual Collections and Recovery Solutions 
conference in Las Vegas. On Friday, May 10th, Tom will lead a roundtable 
discussion of the proposed national new chapter 13 form plan and its 
potential ramifications on creditors.  Becket &amp; Lee will also exhibit 
at the event and invite you to stop by Booth 20 in the Exhibit Hall.    
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L to Attend NARCA Spring 2013 Conference",
                    CreatedDate = Convert.ToDateTime( "2013-03-15 10:34:42.7548961" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Alane Becket will attend the 2013 Spring Collection Conference 
of the National Association of Retail Collection Attorneys in Las Vegas.  
The conference runs from May 8-11, 2013.   
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Partner Tom Lee Speaking At NCCR 2013; Firm to Exhibit",
                    CreatedDate = Convert.ToDateTime( "2013-03-15 10:22:39.5591320" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst Stu Cramer will attend 
the 17th Annual National Collections &amp; Credit Risk Conference in New 
Orleans beginning on March 20, 2013.  Tom is also scheduled to co-present 
on the subject &quot;Emerging Technologies in Collection Agency Management&quot;.  
The conference runs through March 22, 2013 and Becket &amp; Lee will exhibit 
at the event.  
&lt;/p&gt;&lt;p style=&quot;text-align: center&quot;&gt;
For more information on NCRR 2013, please visit the official website at 
&lt;a href=&quot;http://www.collectionscreditrisk.com&quot; target=&quot;newWindow&quot;&gt;http://www.collectionscreditrisk.com&lt;/a&gt;.
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee Presented At CBA Live",
                    CreatedDate = Convert.ToDateTime( "2013-03-15 10:19:15.0132432" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;On Wednesday, March 13, 2013, Partner Tom Lee led a
roundtable discussion on the proposed Chapter 13 Plan Form as part of the Default 
Management Forum at CBA LIVE 2013.  CBA LIVE is an annual three-day conference 
organized by the Consumer Bankers Association, which provides information across 
nine areas of retail banking. 
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Stu Cramer Attended Bankruptcy Tech Conference",
                    CreatedDate = Convert.ToDateTime( "2013-03-15 10:16:44.0062112" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;Stu Cramer attended the EPIQ Systems User Conference in Clearwater Beach, Florida 
from March 6-8, 2013. The annual event enables Becket &amp; Lee to stay abreast of various technological 
developments and tools accessible to bankruptcy practitioners. 
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Stu Cramer to Attend Bankruptcy Tech Conference",
                    CreatedDate = Convert.ToDateTime( "2013-03-06 15:18:04.0957884" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;Stu Cramer will attend the EPIQ Systems User Conference in Clearwater Beach, Florida 
from March 6-8, 2013. The event enables Becket &amp; Lee to stay abreast of various technological 
developments and tools accessible to bankruptcy practitioners. 
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee To Present At CBA Live",
                    CreatedDate = Convert.ToDateTime( "2013-03-06 15:16:16.4720783" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;On Tuesday, March 12 and Wednesday, March 13, 2013, Partner Tom Lee will lead 
roundtable discussions on the proposed Chapter 13 Plan Form as part of the Default 
Management Forum at CBA LIVE 2013.  CBA LIVE is an annual three-day conference 
organized by the Consumer Bankers Association, which provides information across 
nine areas of retail banking. 
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended and Exhibited at Debt Buyers' Conference in February 2013",
                    CreatedDate = Convert.ToDateTime( "2013-02-15 16:58:25.2228800" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Alane Becket, Tom Lee and Stu Cramer attended the 16th Annual DBA 
International Conference at the Aria Resort in Las Vegas, 
February 5-7, 2013. Becket &amp; Lee also exhibited at the event.     
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attending and Exhibiting at Debt Buyers' Conference in February 2013",
                    CreatedDate = Convert.ToDateTime( "2013-01-16 11:12:20.0201044" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Alane Becket, Tom Lee and Stu Cramer will attend the 16th Annual DBA 
International Conference at the Aria Resort in Las Vegas, 
February 5-7, 2013. Becket &amp; Lee will also have an exhibit at the event.     
&lt;/p&gt;&lt;p&gt;
For more information on the conference, 
please visit the official website at 
&lt;a href=&quot;http://www.dbainternational.org/&quot; target=&quot;newWindow&quot;&gt;http://www.dbainternational.org/&lt;/a&gt;. 
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"DCS 2012: B&L Attended and Exhibited",
                    CreatedDate = Convert.ToDateTime( "2012-11-30 12:48:13.7872997" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst Stu Cramer 
attended the 2012 Debt Connection Symposium &amp; Expo in 
Las Vegas beginning on September 10, 2012. The firm 
also exhibited at the event. For more information on the 
conference, please visit the official website at 
&lt;a href=&quot;http://dcs2012.com/&quot; target=&quot;DCS2012&quot;&gt;dcs2012.com&lt;/a&gt;. 
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Exhibited at FSCC 2012",
                    CreatedDate = Convert.ToDateTime( "2012-11-30 12:45:33.6532997" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst Stu Cramer 
attended the 20th Annual Financial Services Collections &amp; Credit 
Risk Conference in Scottsdale, AZ. Tom also chaired the 
pre-conference Future Leaders Forum. The conference ran from 
October 24-26 and Becket &amp; Lee exhibited at the event. 
For more information on FSCC 2012, please visit the official 
website at &lt;a href=&quot;http://www.collectionscreditrisk.com&quot; target=&quot;Parent&quot;&gt;
http://www.collectionscreditrisk.com.&lt;/a&gt;
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Invited to Speak at 2012 Annual Judges' Conference",
                    CreatedDate = Convert.ToDateTime( "2012-11-30 12:42:34.2064997" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Beginning on October 24, 2012, Alane Becket represented the firm 
at the National Conference of Bankruptcy Judges in San Diego, CA. 
At the conference, Alane participated in a panel discussion of 
&quot;Unresolved Issues in Chapter 13&quot;. Her fellow panelists included 
U.S. Bankruptcy Court Judge Steven Rhodes, Chapter 13 Trustee 
Jan Hamilton, and attorney Jenny Doling.
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Attended NARCA Conference",
                    CreatedDate = Convert.ToDateTime( "2012-11-30 12:40:27.0820997" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Alane Becket attended the NARCA 2012 Fall Collection 
Conference in Baltimore, MD. The conference ran from October 17-20. 

&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee to Exhibit at FSCC 2012",
                    CreatedDate = Convert.ToDateTime( "2012-10-17 15:13:38.9313709" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst Stu Cramer 
will attend the upcoming 20th Annual Financial Services 
Collections &amp; Credit Risk Conference in Scottsdale, AZ.  
Tom will also be chairing the pre-conference Future Leaders Forum. 
The conference runs from October 24-26 and Becket &amp; Lee 
will be exhibiting at the event. For more information on 
FSCC 2012, please visit the official website at 
&lt;a href=&quot;http://www.collectionscreditrisk.com&quot; target=&quot;Parent&quot;&gt;
http://www.collectionscreditrisk.com.&lt;/a&gt;
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee to Exhibit at FSCC 2012",
                    CreatedDate = Convert.ToDateTime( "2012-09-26 16:52:51.3528541" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst Stu Cramer 
will attend the upcoming 20th Annual Financial Services 
Collections &amp; Credit Risk Conference in Scottsdale, AZ.  
The conference runs from October 24-26 and Becket &amp; Lee 
will be exhibiting at the event. For more information on 
FSCC 2012, please visit the official website at 
&lt;a href=&quot;http://www.collectionscreditrisk.com&quot; target=&quot;Parent&quot;&gt;
http://www.collectionscreditrisk.com.&lt;/a&gt;
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Invited to Speak at 2012 Annual Judges' Conference",
                    CreatedDate = Convert.ToDateTime( "2012-09-26 16:49:45.6372351" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Beginning on October 24, 2012, Alane Becket will represent the firm 
at the National Conference of Bankruptcy Judges in San Diego, CA.  
At the conference, Alane will participate in a panel discussion of 
&quot;Unresolved Issues in Chapter 13&quot;.  Her fellow panelists include 
U.S. Bankruptcy Court Judge Steven Rhodes, Chapter 13 Trustee 
Jan Hamilton, and attorney Jenny Doling.   

&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket to Attend NARCA Conference",
                    CreatedDate = Convert.ToDateTime( "2012-09-26 16:47:57.3751543" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Alane Becket will attend the NARCA 2012 Fall Collection 
Conference in Baltimore, MD.  The conference begins on October 
17th and runs through October 20th.  

&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee Attended 2012 Chapter 7 Trustee Conference",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:19:28.7798738" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Beginning on September 5, 2012, Tom Lee attended the NABT 2012 Fall 
Seminar in Colorado. Aimed at Chapter 7 trustees, this event enabled the 
Firm to interact with the trustees while gaining additional industry insight. 
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee to Attend Conferences in June",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:28.6501379" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Beginning on June 12, Partner Tom Lee will attend CBA LIVE, an annual conference organized by the Consumer Bankers Association.  This year&#39;s conference will be held in Orlando, Florida.  

&lt;/p&gt;&lt;p&gt;
Then, from June 14-17, Tom will join the National Conference of Bankruptcy Clerks for its annual conference in New Orleans.  Attended by many of the Bankruptcy Clerks, as well as their staff, this conference is an excellent opportunity to get feedback on B&amp;L&#39;s work, provide input on future projects and make sure each clerk knows we welcome their comments throughout the year. 

&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee in Attendance at June 2011 Conferences",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:28.6189385" ),
                    EventTypeId = 2,
                    EventHtml = @"
&lt;p&gt;
Beginning on June 12, 2011, Partner Tom Lee attended CBA LIVE, 
an annual conference organized by the Consumer Bankers Association. 
The conference was held in Orlando, Florida. &lt;/p&gt;
&lt;p&gt;
Then, from June 14-17, Tom joined the National Conference of Bankruptcy Clerks 
for its annual conference in New Orleans. Attended by many of the Bankruptcy 
Clerks, as well as their staff, the conference was an excellent opportunity 
to get feedback on B&amp;L&#39;s work, provide input on future projects and make sure 
each clerk knows we welcome their comments throughout the year. 
&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee to Attend 2012 Chapter 7 Trustee Conference",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:28.4629415" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Beginning on September 5, 2012, Tom Lee will attend the NABT 2012 Fall
Seminar in Colorado. Aimed at Chapter 7 trustees, this event enables the 
Firm to interact with the trustees while gaining additional industry insight.
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee at NCBC 2012",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:28.4473418" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
In August, Partner Tom Lee represented the Firm at the National 
Conference of Bankruptcy Clerks in San Francisco. The conference 
provided Becket &amp; Lee with an outstanding opportunity to reinforce 
its relationships with court personnel, while fostering open 
communication on work product and industry-related issues.
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"DCS 2012: B&L Attending and Exhibiting",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:28.4161424" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee and Business Operations Analyst 
Stu Cramer will attend the 2012 Debt Connection 
Symposium &amp; Expo in Las Vegas beginning on September 10th. 
The firm will also be exhibiting at the event. For 
more information on the conference, please visit the 
official website at 
&lt;a href=&quot;http://dcs2012.com/&quot; target=&quot;DCS2012&quot;&gt;dcs2012.com&lt;/a&gt;. 
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Invited to Speak, Firm Attended Ch. 13 Trustees' Conference",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:28.3849430" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
In July, Partners Tom Lee and Alane Becket attended the annual 
meeting of the National Association of Chapter 13 Trustees in New Orleans. 
Business Operations Analyst Stu Cramer also attended. 
&lt;/p&gt;&lt;p&gt;
Alane was invited to speak at the conference and she participated in a panel 
discussion examining how the recent Baud, Kagenveama, and Espinosa decisions are 
impacting unsecured creditors. In particular, the session addressed due process 
concerns of notice to unsecured creditors in &quot;unusual&quot; plan provisions and what 
happens after plan confirmation. 
&lt;/p&gt;&lt;p&gt;
Once again, Becket &amp; Lee was a proud sponsor of the NACTT&#39;s educational program.
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Stu Cramer to Attend Annual Conference Focused on Bankruptcy Technology Solutions",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:28.3537436" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Beginning May 21 and continuing through May 23, 2012, Business 
Operations Analyst Stu Cramer attended the annual BSS Chapter 13 
Trustee user conference in Memphis, TN. This year&#39;s event 
focused on discussion topics presented by the Trustees and 
their staff, as well as coordinating ACH creditor disbursements. 

&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Stu Cramer to Attend Annual Conference Focused on Bankruptcy Technology Solutions",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:28.2913448" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Beginning May 21 and continuing through May 23, 2012, 
Business Operations Analyst Stu Cramer will attend the annual 
BSS Chapter 13 Trustee user conference in Memphis, TN.  This 
year&#39;s event will focus on discussion topics presented by the 
Trustees and their staff, as well as coordinating ACH creditor 
disbursements.  
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"B&L Attended, Exhibited at Invitation-Only Creditors' Event",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:28.2601454" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
From May 8-11, 2012, Partner Tom Lee and Business Operations 
Analyst Stu Cramer attended the annual Collections and Recovery 
Solutions conference in Las Vegas.  Becket &amp; Lee also exhibited 
at this premiere invitation-only event aimed at senior level 
creditors involved in collection, recovery operations and strategy.  
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee at NCBC 2012",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:28.2445457" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
In August, Partner Tom Lee will represent the Firm at 
the National Conference of Bankruptcy Clerks in San Francisco.  
This annual conference provides Becket &amp; Lee with an outstanding 
opportunity to reinforce its relationships with court personnel, 
while fostering open communication on work product and industry-related 
issues.  
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Invited to Speak, Firm to Attend Ch. 13 Trustees' Conference",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:28.2133463" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
In July, Partners Tom Lee and Alane Becket will attend the annual meeting of 
the National Association of Chapter 13 Trustees in New Orleans. 
Business Operations Analyst Stu Cramer will also attend.
&lt;/p&gt;&lt;p&gt;
Alane was invited to speak at the conference and will participate in a panel discussion 
examining how the recent Baud, Kagenveama, and Espinosa decisions are impacting unsecured 
creditors. In particular, the session will address due process concerns of notice to 
unsecured creditors in &quot;unusual&quot; plan provisions and what happens after plan confirmation.
&lt;/p&gt;&lt;p&gt;
Once again, Becket &amp; Lee is a proud sponsor of the NACTT&#39;s educational program.
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Presented Two Consumer Sessions at SBLI Conference",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:28.1509475" ),
                    EventTypeId = 2,
                    EventHtml = @"
&lt;p&gt;
Alane Becket was a speaker at the 38th Annual Southeastern Bankruptcy 
Law Institute in Atlanta.  On Thursday, March 22, 2012, her presentation 
entitled &quot;Hardship Discharge for Chapter 13 Debtors and Discharge of Student Loans&quot;
included the following topics:  
&lt;/p&gt;
&lt;ul&gt;
&lt;li&gt;Whether student loans are ever dischargeable in a chapter 7 or 13;
&lt;li&gt;Service issues;
&lt;li&gt;Requirements for filing adversary proceedings;
&lt;li&gt;Explanation and application of the William C. Ford program; and
&lt;li&gt;Effect of the timing of the filing of the complaint for hardship discharge. 
&lt;/ul&gt;
&lt;p&gt;
Then, on Friday, March 23, 2012, Alane discussed &quot;Asserting Claims in 
Chapter 7&#39;s and Chapter 13&#39;s&quot;.  This presentation addressed germane issues such as:  
&lt;/p&gt;
&lt;ul&gt;
&lt;li&gt;Requirements of a properly filed claim; 
&lt;li&gt;Standing to file; 
&lt;li&gt;Attachments necessary to file with the court; 
&lt;li&gt;Effect of Federal Rule of Bankruptcy Procedure 3001(f); and 
&lt;li&gt;What is necessary to prove debt in the face of objections to claim.  
&lt;/ul&gt;
&lt;p style=&quot;text-align: center&quot;&gt;
For more information on the event, please visit the official website at 
&lt;a href=&quot;http://sbli-inc.org/schedule.html&quot;&gt;sbli-inc.org/schedule.html&lt;/a&gt;.   
&lt;p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket a Panelist at Annual ABI Event",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:28.1353478" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Beginning on April 19th, Alane Becket attended the American Bankruptcy Institute&#39;s 
30th Annual Spring Meeting in National Harbor, Maryland. At the conference, Alane 
participated on a panel discussing the use of non-standard plan provisions in chapter 13, 
along with Judge Ray Mullins of Atlanta and John Rao, a member of the Advisory Committee 
on Bankruptcy Rules and attorney with the National Consumer Law Center. Alane was also 
recently reelected to a second 3 year term on the ABI&#39;s Board of Directors and will 
continue her duties as a member of the Publications Committee.
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Presented Two Consumer Sessions at SBLI Conference",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:28.1041484" ),
                    EventTypeId = 2,
                    EventHtml = @"
&lt;p&gt;
Alane Becket was speaker at the 38th Annual Southeastern Bankruptcy 
Law Institute in Atlanta.  On Thursday, March 22, 2012, her presentation 
entitled &quot;Hardship Discharge for Chapter 13 Debtors and Discharge of Student Loans&quot;
included the following topics:  
&lt;/p&gt;
&lt;ul&gt;
&lt;li&gt;Whether student loans are ever dischargeable in a chapter 7 or 13;
&lt;li&gt;Service issues;
&lt;li&gt;Requirements for filing adversary proceedings;
&lt;li&gt;Explanation and application of the William C. Ford program; and
&lt;li&gt;Effect of the timing of the filing of the complaint for hardship discharge. 
&lt;/ul&gt;
&lt;p&gt;
Then, on Friday, March 23, 2012, Alane discussed &quot;Asserting Claims in 
Chapter 7&#39;s and Chapter 13&#39;s&quot;.  This presentation will address germane issues such as:  
&lt;/p&gt;
&lt;ul&gt;
&lt;li&gt;Requirements of a properly filed claim; 
&lt;li&gt;Standing to file; 
&lt;li&gt;Attachments necessary to file with the court; 
&lt;li&gt;Effect of Federal Rule of Bankruptcy Procedure 3001(f); and 
&lt;li&gt;What is necessary to prove debt in the face of objections to claim.  
&lt;/ul&gt;
&lt;p style=&quot;text-align: center&quot;&gt;
For more information on the event, please visit the official website at 
&lt;a href=&quot;http://sbli-inc.org/schedule.html&quot;&gt;sbli-inc.org/schedule.html&lt;/a&gt;.   
&lt;p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee at NCCR 2012",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:28.0885487" ),
                    EventTypeId = 2,
                    EventHtml = @"
&lt;p&gt;
On Thursday, March 15, 2012, Tom Lee presented at the 16th Annual National Collections &amp; Credit Risk Conference 
in New Orleans. Tom joined co-presenter Chris Lundquist in an interview session entitled &quot;First Look - The New 
Bankruptcy Rules and Changing Trends:  What&#39;s Next?&quot;  
&lt;/p&gt;
&lt;p style=&quot;text-align: center&quot;&gt;
The firm&#39;s Business Operations Analyst, Stu Cramer, also attended the conference and the firm exhibited.  
For more information on the conference, please visit the official website at: 
&lt;a href=&quot;http://www.collectionscreditrisk.com/nccr&quot;&gt;www.collectionscreditrisk.com/nccr&lt;/a&gt;.   
&lt;p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Stu Cramer Attended EPIQ Systems Event",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:28.0729490" ),
                    EventTypeId = 2,
                    EventHtml = @"
&lt;p&gt;
Stu Cramer attended the EPIQ Systems User Conference in Clearwater Beach, 
Florida from March 7-9, 2012.  This annual event enables the firm to stay 
apprised of technological advancements and tools available to bankruptcy 
practitioners. 
&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket to Present Two Consumer Sessions at SBLI Conference",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:28.0417496" ),
                    EventTypeId = 2,
                    EventHtml = @"
&lt;p&gt;
Alane Becket will be a speaker at the 38th Annual Southeastern Bankruptcy 
Law Institute in Atlanta.  On Thursday, March 22, 2012, her presentation 
entitled &quot;Hardship Discharge for Chapter 13 Debtors and Discharge of Student Loans&quot;
will include the following topics:  
&lt;/p&gt;
&lt;ul&gt;
&lt;li&gt;Whether student loans are ever dischargeable in a chapter 7 or 13;
&lt;li&gt;Service issues;
&lt;li&gt;Requirements for filing adversary proceedings;
&lt;li&gt;Explanation and application of the William C. Ford program; and
&lt;li&gt;Effect of the timing of the filing of the complaint for hardship discharge. 
&lt;/ul&gt;
&lt;p&gt;
Then, on Friday, March 23, 2012, Alane will discuss &quot;Asserting Claims in 
Chapter 7&#39;s and Chapter 13&#39;s&quot;.  This presentation will address germane issues such as:  
&lt;/p&gt;
&lt;ul&gt;
&lt;li&gt;Requirements of a properly filed claim; 
&lt;li&gt;Standing to file; 
&lt;li&gt;Attachments necessary to file with the court; 
&lt;li&gt;Effect of Federal Rule of Bankruptcy Procedure 3001(f); and 
&lt;li&gt;What is necessary to prove debt in the face of objections to claim.  
&lt;/ul&gt;
&lt;p style=&quot;text-align: center&quot;&gt;
For more information on the event, please visit the official website at 
&lt;a href=&quot;http://sbli-inc.org/schedule.html&quot;&gt;sbli-inc.org/schedule.html&lt;/a&gt;.   
&lt;p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee to Speak at NCCR; Firm Will Also Exhibit",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:28.0105502" ),
                    EventTypeId = 2,
                    EventHtml = @"
&lt;p&gt;
On Thursday, March 15, 2012, Tom Lee will present at the 16th Annual National Collections &amp; Credit Risk Conference 
in New Orleans. Tom will join co-presenter Chris Lundquist in an interview session entitled &quot;First Look - The New 
Bankruptcy Rules and Changing Trends:  What&#39;s Next?&quot;  
&lt;/p&gt;
&lt;p style=&quot;text-align: center&quot;&gt;
The firm&#39;s Business Operations Analyst, Stu Cramer, will also attend the conference and the firm will be exhibiting.  
For more information on the conference, please visit the official website at: 
&lt;a href=&quot;http://www.collectionscreditrisk.com/nccr&quot;&gt;www.collectionscreditrisk.com/nccr&lt;/a&gt;.   
&lt;p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Stu Cramer to Attend EPIQ Systems Event",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:27.9949505" ),
                    EventTypeId = 2,
                    EventHtml = @"
&lt;p&gt;
Beginning on Wednesday, March 7, 2012, Stu Cramer will attend the annual 
EPIQ Systems User Conference in Clearwater Beach, Florida.  This event 
enables the firm to stay apprised of technological advancements and tools 
available to bankruptcy practitioners.
&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended and Exhibited at Annual Debt Buyers' Conference in February 2012",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:27.9637511" ),
                    EventTypeId = 2,
                    EventHtml = @"
&lt;p&gt;
Alane Becket, Tom Lee and Stu Cramer attended the 15th Annual DBA International 
Conference at the Aria Resort in Las Vegas, February 7-9, 2012.  The firm also exhibited at this event.  
&lt;/p&gt;
&lt;p style=&quot;text-align: center&quot;&gt;
For more information on the conference, please visit the official 
website at &lt;a href=&quot;http://www.dbainternational.org/&quot;&gt;http://www.dbainternational.org/&lt;/a&gt;.  
&lt;p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Will Attend and Exhibit at Upcoming Annual Debt Buyers' Conference",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:27.9325517" ),
                    EventTypeId = 2,
                    EventHtml = @"
&lt;p&gt;
Alane Becket, Tom Lee and Stu Cramer will be attending the 15th Annual DBA International 
Conference at the Aria Resort in Las Vegas, February 7-9, 2012.  The firm will also exhibit at this event.  
&lt;/p&gt;
&lt;p style=&quot;text-align: center&quot;&gt;
For more information on the conference, please visit the official 
website at &lt;a href=&quot;http://www.dbainternational.org/&quot;&gt;http://www.dbainternational.org/&lt;/a&gt;.  
&lt;p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Recognized by the American Bankruptcy Institute",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:27.9013523" ),
                    EventTypeId = 2,
                    EventHtml = @"
&lt;p&gt;
On December 1-3, 2011, Partner Alane Becket attended the 
American Bankruptcy Institute&#39;s annual Winter Leadership Conference.  
During the event, Alane received publication recognition as co-editor 
of the book&lt;i&gt; Best of ABI 2011: The Year in Consumer Bankruptcy.&lt;/i&gt;  The 
book contains a select group of the best articles and conference materials 
produced by the ABI in 2011 and is organized by topic.  
&lt;/p&gt;&lt;p style=&quot;text-align: center&quot;&gt;
For more information on the book, please visit the ABI&#39;s 
website at &lt;a href=&quot;http://bookstore.abi.org/&quot;&gt;http://bookstore.abi.org/&lt;/a&gt;.  
&lt;p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee to Exhibit at FSCC 2011",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:27.8857526" ),
                    EventTypeId = 2,
                    EventHtml = @"
&lt;p&gt;
On November 2-4, Partner Tom Lee and Business Operations Analyst Stu Cramer will attend the 19th Annual 
Financial Services Collections &amp; Credit Risk Conference in Las Vegas.  Becket &amp; Lee will also be an exhibitor 
at the conference.  For more information on FSCC 2011, please visit the official website at 
&lt;a href=&quot;http://www.collectionscreditrisk.com/&quot; target=&quot;collectionscreditrisk&quot;&gt;www.collectionscreditrisk.com. &lt;/a&gt;&lt;/p&gt;

&lt;p style=&quot;text-align: center&quot;&gt;
&lt;a href=&quot;DOCUMENTS/FSCC ecard-FINAL.pdf#zoom=100&quot;&gt;
Click here for the FSCC Conference eCard. &lt;/a&gt;
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Exhibited at FSCC 2011",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:27.8545532" ),
                    EventTypeId = 2,
                    EventHtml = @"
&lt;p&gt;
On November 2-4, Partner Tom Lee and Business Operations Analyst Stu Cramer attended the 19th Annual 
Financial Services Collections &amp; Credit Risk Conference in Las Vegas.  Becket &amp; Lee also exhibited 
at the conference.  For more information on FSCC 2011, please visit the official website at 
&lt;a href=&quot;http://www.collectionscreditrisk.com/&quot; target=&quot;collectionscreditrisk&quot;&gt;www.collectionscreditrisk.com. &lt;/a&gt;&lt;/p&gt;

&lt;p style=&quot;text-align: center&quot;&gt;
&lt;a href=&quot;DOCUMENTS/FSCC ecard-FINAL.pdf#zoom=100&quot;&gt;
Click here for the FSCC Conference eCard. &lt;/a&gt;
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee to Exhibited at FSCC 2011",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:27.8077541" ),
                    EventTypeId = 2,
                    EventHtml = @"
&lt;p&gt;
On November 2-4, Partner Tom Lee and Business Operations Analyst Stu Cramer attended the 19th Annual 
Financial Services Collections &amp; Credit Risk Conference in Las Vegas.  Becket &amp; Lee also exhibited 
at the conference.  For more information on FSCC 2011, please visit the official website at 
&lt;a href=&quot;http://www.collectionscreditrisk.com/&quot; target=&quot;collectionscreditrisk&quot;&gt;www.collectionscreditrisk.com. &lt;/a&gt;&lt;/p&gt;

&lt;p style=&quot;text-align: center&quot;&gt;
&lt;a href=&quot;DOCUMENTS/FSCC ecard-FINAL.pdf#zoom=100&quot;&gt;
Click here for the FSCC Conference eCard. &lt;/a&gt;
&lt;/p&gt;

"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Participated in Panel Presentation, Received Award at Annual Judges' Conference in October",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:27.7297556" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
On Friday, October 14th, Partner Alane Becket participated in a panel presentation 
entitled &quot;Hot Topics in Chapter 7 and 13 (Disposable Income, Exemptions, Case Conversions, 
Debtor Standing and Judicial Estoppel)&quot; at the 85th Annual National Conference of Bankruptcy 
Judges.  Partners Tom Lee and Gil Weisman were also in attendance.
&lt;/p&gt;&lt;p&gt;
In addition, at a special conference luncheon, Alane and Associate William McNeal received 
a publication award for their work on the American Bankruptcy Institute&#39;s book Consumer Bankruptcy: 
Fundamentals of Chapter 7 and Chapter 13 of the U.S. Bankruptcy Code (Third Edition).  
&lt;/p&gt;
&lt;p style=&quot;text-align: left&quot;&gt;
If you would like more information on the conference, please visit &lt;a href=&quot;http://www.ncbj.org&quot; target=&quot;NCBJ&quot;&gt;www.ncbj.org&lt;/a&gt;. 

&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Participated in Panel Presentation, Received Award at Annual Judges' Conference in October",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:27.6985562" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
On Friday, October 14th, Partner Alane Becket participated in a panel presentation 
entitled &quot;Hot Topics in Chapter 7 and 13 (Disposable Income, Exemptions, Case Conversions, 
Debtor Standing and Judicial Estoppel)&quot; at the 85th Annual National Conference of Bankruptcy 
Judges.  Partners Tom Lee and Gil Weisman were also in attendance.
&lt;/p&gt;&lt;p&gt;
In addition, at a special conference luncheon, Alane and Associate William McNeal received 
a publication award for their work on the American Bankruptcy Institute&#39;s book Consumer Bankruptcy: 
Fundamentals of Chapter 7 and Chapter 13 of the U.S. Bankruptcy Code (Third Edition).  
&lt;/p&gt;
&lt;p style=&quot;text-align: left&quot;&gt;
If you would like more information on the conference, please visit &lt;a href=&quot;http://www.ncbj.org&quot; target=&quot;NCBJ&quot;&gt;www.ncbj.org&lt;/a&gt;. 

&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee Joined Chapter 7 Trustees at Annual Conference",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:27.6517571" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee will attend the 2011 Annual Meeting of 
the National Association of Bankruptcy Trustees in Florida, which
began on September 22, 2011. The conference provided an excellent 
opportunity for Becket &amp; Lee to personally interact with the 
Chapter 7 trustees, while simultaneously staying abreast 
of the latest developments in bankruptcy.  
&lt;/p&gt;
&lt;p style=&quot;text-align: left&quot;&gt;
For more information on the conference, please visit &lt;a href=&quot;http://www.nabt.com&quot; target=&quot;NABT&quot;&gt;www.nabt.com&lt;/a&gt;. 

&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee Joined Chapter 7 Trustees at Annual Conference",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:27.6205577" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Partner Tom Lee attended the 2011 Annual Meeting of 
the National Association of Bankruptcy Trustees in Florida, which
began on September 22, 2011. The conference provided an excellent 
opportunity for Becket &amp; Lee to personally interact with the 
Chapter 7 trustees, while simultaneously staying abreast 
of the latest developments in bankruptcy.  
&lt;/p&gt;
&lt;p style=&quot;text-align: left&quot;&gt;
For more information on the conference, please visit &lt;a href=&quot;http://www.nabt.com&quot; target=&quot;NABT&quot;&gt;www.nabt.com&lt;/a&gt;. 

&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket to Speak and Receive Award at Annual Judges' Conference in October",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:27.5581589" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
On Friday, October 14th, Partner Alane Becket will participate in a panel presentation 
entitled &quot;Hot Topics in Chapter 7 and 13 (Disposable Income, Exemptions, Case Conversions, 
Debtor Standing and Judicial Estoppel)&quot; at the 85th Annual National Conference of Bankruptcy 
Judges.  Partners Tom Lee and Gil Weisman will also be attending the conference.
&lt;/p&gt;&lt;p&gt;
In addition, at a special conference luncheon, Alane and Associate William McNeal will be receiving 
a publication award for their work on the American Bankruptcy Institute&#39;s book Consumer Bankruptcy: 
Fundamentals of Chapter 7 and Chapter 13 of the U.S. Bankruptcy Code (Third Edition).  
&lt;/p&gt;
&lt;p style=&quot;text-align: left&quot;&gt;
If you would like more information on the conference, please visit &lt;a href=&quot;http://www.ncbj.org&quot; target=&quot;NCBJ&quot;&gt;www.ncbj.org&lt;/a&gt;. 

&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee and Stu Cramer Attended and Exhibited at DCS 2011",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:27.5113598" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
On September 13-15, Partner Tom Lee and Business Operations Analyst Stu Cramer attended the 2011 
Debt Connection Symposium &amp; Expo.  The firm will also be exhibiting at the event.  
For more information on the conference, please visit the official website at: &lt;a href=&quot;http://dcs2011.com/&quot; target=&quot;newPage&quot;&gt;http://dcs2011.com/&lt;/a&gt;. 
&lt;/p&gt;
&lt;p style=&quot;text-align: center&quot;&gt;
&lt;a href=&quot;DOCUMENTS/BL-DCS-2011-ad.pdf#zoom=90&quot; target=&quot;blank&quot;&gt;
Click here for the DCS Conference eCard.&lt;/a&gt;
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee to Join Chapter 7 Trustees at Upcoming Conference",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:27.4645607" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
Beginning on September 22nd, Partner Tom Lee will attend the 2011 
Annual Meeting of the National Association of Bankruptcy Trustees in Florida.  
The conference provides an excellent opportunity for Becket &amp; Lee to 
personally interact with the Chapter 7 trustees, while simultaneously 
staying abreast of the latest developments in bankruptcy.  
&lt;/p&gt;
&lt;p style=&quot;text-align: left&quot;&gt;
For more information on the conference, please visit &lt;a href=&quot;http://www.nabt.com&quot; target=&quot;NABT&quot;&gt;www.nabt.com&lt;/a&gt;. 

&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee and Stu Cramer to Attend and Exhibit at DCS 2011",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:27.4333613" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;
On September 13-15, Partner Tom Lee and Business Operations Analyst Stu Cramer will attend the 2011 Debt Connection Symposium &amp; Expo.  The firm will also be exhibiting at the event.  
For more information on the conference, please visit the official website at: &lt;a href=&quot;http://dcs2011.com/&quot;&gt;http://dcs2011.com/&lt;/a&gt;. 
&lt;/p&gt;
&lt;p style=&quot;text-align: center&quot;&gt;
&lt;a href=&quot;DOCUMENTS/BL-DCS-2011-ad.pdf#zoom=90&quot;&gt;
Click here for the DCS Conference eCard.
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Partner Gil Weisman Presented Twice at NACTT 2011",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:27.3709625" ),
                    EventTypeId = 2,
                    EventHtml = @"
&lt;p&gt;
In August, Becket &amp; Lee Partner Gil Weisman presented during the plenary session at the annual meeting of the National Association of Chapter 13 Trustees in Anaheim, California.  Entitled &quot;Post Lanning/Ransom Developments&quot;, the presentation delved into the evolving issue of projected disposable income in light of the critical Lanning and Ransom Supreme Court decisions.  Gil followed this session with a more interactive panel discussion of the topic later in the conference.  
&lt;/p&gt;
&lt;p&gt;Once again, Becket &amp; Lee was a proud sponsor of the NACTT&#39;s educational program.&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket a Featured Speaker at CRS 2011",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:27.3241634" ),
                    EventTypeId = 2,
                    EventHtml = @"
&lt;p&gt;
On Wednesday, May 11, 2011, Alane Becket was a featured speaker at a Pre-Conference Bankruptcy Workshop during this year&#39;s Collection and Recovery Solutions event in Las Vegas. The workshop focused on bankruptcy updates, including proof of claim rules and recent court decisions impacting bankruptcy recoveries and processes. For more information on CRS 2011, please visit the official website at
&lt;a href=&quot;http://www.crs2011.com/&quot;&gt;www.crs2011.com.&lt;/a&gt;
&lt;/p&gt;
&lt;p align=&quot;center&quot;&gt;
&lt;a href=&quot;documents/BLAttendeeeCard.pdf#zoom=100&quot;&gt;Click here for the CRS Conference eCard&lt;/a&gt;
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket a Featured Speaker at CRS 2011",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:27.2929640" ),
                    EventTypeId = 2,
                    EventHtml = @"
&lt;p&gt;
On Wednesday, May 11th beginning at 2:00 p.m., Alane Becket will be a featured 
speaker at a Pre-Conference Bankruptcy Workshop during this year&#39;s Collection 
and Recovery Solutions event in Las Vegas. The workshop will focus on bankruptcy 
updates, including proof of claim rules and recent court decisions impacting 
bankruptcy recoveries and processes. For more information on CRS 2011, 
please visit the official website at 
&lt;a href=&quot;http://www.crs2011.com/&quot;&gt;www.crs2011.com.&lt;/a&gt;
&lt;/p&gt;
&lt;p align=&quot;center&quot;&gt;
&lt;a href=&quot;documents/BLAttendeeeCard.pdf#zoom=100&quot;&gt;Click here for the CRS Conference eCard&lt;/a&gt;
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee Discussed Supreme Court Rulings, Firm Exhibited at NCCR",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:27.2305652" ),
                    EventTypeId = 2,
                    EventHtml = @"
&lt;p&gt;
On Monday, March 14, 2011, Tom Lee presented at the 
15th Annual National Collections &amp; Credit Risk Conference in Miami.  
Tom discussed the impact of recent Supreme Court decisions on 
bankruptcy recoveries.  Stu Cramer also attended and the 
firm exhibited at this event.  For more information on the 
conference, please visit the official website at:  
&lt;a href=&quot;http://www.collectionscreditrisk.com/&quot;&gt;http://www.collectionscreditrisk.com/.&lt;/a&gt;
&lt;/p&gt;
&lt;p style=&quot;text-align: center&quot;&gt;
&lt;a href=&quot;DOCUMENTS/BL-NCCR2011-EMAIL 20110302.pdf#zoom=100&quot;&gt;Click here for the NCCR Conference eCard&lt;/a&gt;&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Presented at Annual ABI Event",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:27.2149655" ),
                    EventTypeId = 2,
                    EventHtml = @"
&lt;p&gt;
Alane Becket spoke at the ABI&#39;s 35th Annual Judge 
Alexander L. Paskay Seminar on Bankruptcy Law and Practice, 
held March 10-12, 2011 in Tampa, Florida.  
Alane&#39;s presentation addressed &quot;What&#39;s in Store for Consumer 
Practitioners in 2011&quot;.  For more information, please visit the 
conference website at:&lt;a href=&quot;http://www.abiworld.org/SP11&quot;&gt;&amp;nbsp;www.abiworld.org/SP11.&lt;/a&gt;
&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Stu Cramer Discussed ACH with Ch. 13 Trustees at Software Conference",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:27.1993658" ),
                    EventTypeId = 2,
                    EventHtml = @"
&lt;p&gt;
On February 24, 2011, Stu Cramer addressed Chapter 13 
trustees on the topic of banking updates and ACH payments 
at the EPIQ Systems annual conference held in Clearwater Beach, Florida.
&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Attended and Exhibited at DBA Event...",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:27.1525667" ),
                    EventTypeId = 2,
                    EventHtml = @"
&lt;p&gt;
Alane Becket, Tom Lee and Stu Cramer attended 
the 14th Annual DBA International Conference 
in Las Vegas, February 8-10, 2011.  The firm also exhibited at this event.  For more 
information on the conference, please visit the 
official website at &lt;a href=&quot;http://www.dbainternational.org/events/annual-conference/2011/index.asp&quot;&gt;http://www.dbainternational.org&lt;/a&gt;
&lt;/p&gt;
&lt;p style=&quot;text-align: center&quot;&gt;
&lt;a href=&quot;DOCUMENTS/BL-DBA-20110119.pdf&quot;&gt;Click here for the DBA Conference eCard&lt;/a&gt;&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee Joined Chapter 7 Trustees at Annual Meeting",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:27.0901679" ),
                    EventTypeId = 2,
                    EventHtml = @"
&lt;p&gt;
Tom Lee attended the 2010 Annual Meeting of the National Association of 
Bankruptcy Trustees in San Francisco in late September.  The event, which 
annually attracts over 500 participants, is the premier conference of the 
Chapter 7 trustee community and offers Becket &amp; Lee the opportunity to meet, 
in person, the many trustees its staff interacts with during the year.   For 
additional information on the conference or the NABT, please visit 
&lt;a href=&quot;http://www.nabt.com/&quot;&gt;www.nabt.com&lt;/a&gt;.
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Speaks at Resource Management's Collection and Recovery Solutions 2010 Conference",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:27.0589685" ),
                    EventTypeId = 2,
                    EventHtml = @"


&lt;p&gt;At this exclusive event in Las Vegas, Ms. Becket conducted 
three interactive roundtable discussions focusing on recent 
developments in the bankruptcy world that have the potential 
to drastically change current processes and expectations for 
bankrupt accounts. Special attention was given to the operational 
and legal challenges facing creditors now and in the upcoming 
months. The conference&#39;s Web site is 
&lt;a href=&quot;http://www.crs2010.com&quot;&gt;www.crs2010.com&lt;/a&gt;&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket Attends National Association of Retail Collection Attorneys' 2010 Fall Conference",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:27.0277691" ),
                    EventTypeId = 2,
                    EventHtml = @"
&lt;p&gt;
Partner Alane Becket represented the Firm at this important industry conference which took place 
October 21-23 in Las Vegas.  Previously on the Education Committee, Alane is recognized as one 
of the conference&#39;s leading bankruptcy experts.  In addition to law firms and in-house counsel, 
this three-day educational program attracted credit grantors and buyers/sellers of consumer debt.  
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Becket & Lee Participation at 84th Annual National Conference of Bankruptcy Judges",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:26.9809700" ),
                    EventTypeId = 2,
                    EventHtml = @"
&lt;p&gt;
On October 15, 2010, Partner Alane Becket moderated a panel entitled 
&quot;Consumer Real Estate Issues - Mortgage Proof Issues, Preference Challenges 
to Foreclosures and Lien Stripping&quot;.  The panel was a joint effort between the 
American Bankruptcy Institute, where Alane serves as a Board Member and Co-Chair 
of its Consumer Bankruptcy Committee, and the Bankruptcy Judges Conference.  
Partner Tom Lee also attended the conference, which drew approximately 150 
judges and hundreds of bankruptcy professionals from throughout the country. 
Additional information on the conference can be found at 
&lt;a href=&quot;http://www.ncbj.org/&quot;&gt;www.ncbj.org&lt;/a&gt;&lt;p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Tom Lee and Stu Cramer Represent Becket & Lee at Industry Events",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:26.9653703" ),
                    EventTypeId = 2,
                    EventHtml = @"
  
&lt;p&gt;
On September 14-16, Partner Tom Lee and Business Operations Analyst Stu Cramer attended the 2010 Debt Connection Symposium &amp; Expo.  Among other things, the conference addressed &quot;current challenges... such as the 2007 meltdown of delinquency and losses, strategy changes, stabilization, and improvements&quot;.
&lt;/p&gt;&lt;p&gt;
On October 24-26, Tom and Stu attended the 18th Annual Financial Services Collections &amp; Credit Risk Conference.  Tom, a member of the conference&#39;s Advisory Board, participated in the planning of the educational sessions.  This year&#39;s event focused on enhancing collections methods and capabilities through the use of best practices, and also provided guidance on related regulatory concerns.    
&lt;/p&gt;&lt;p&gt;
By attending these events, Becket &amp; Lee maintains its commitment to education and interaction with fellow industry professionals, ensuring the highest quality representation for our clients.  
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Partner Gil Weisman Presented at NACTT",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:26.9341709" ),
                    EventTypeId = 2,
                    EventHtml = @"

&lt;p&gt;In July, Becket &amp; Lee Partner Gil Weisman presented on a panel entitled &quot;Have We Disposed of Disposable Income?&quot; at the annual meeting of the National Association of Chapter 13 Trustees in Grapevine Texas. The panel discussed whether the recent Supreme Court case of Hamilton vs. Lanning, in which the Court held that a debtor&#39;s &quot;projected disposable income&quot; may take account of a debtor&#39;s future earnings, has settled the issue of plan payment amount that has been so contentiously litigated since BAPCPA.
&lt;/p&gt;
&lt;p&gt;Continuing its longstanding commitment to the Association&#39;s educational mission, Becket &amp; Lee sponsored two days of educational programming at this year&#39;s NACTT conference.
&lt;/p&gt;
"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"John Sheehan Participates in American Bankruptcy Institute's Spring Meeting",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:26.9029715" ),
                    EventTypeId = 2,
                    EventHtml = @"


&lt;p&gt;
B &amp; L Partner John Sheehan was a panelist at the ABI Consumer Bankruptcy Committee&#39;s educational session, 
which recently took place during ABI&#39;s Annual Spring Meeting in National Harbor, Md.  John represented 
the creditor&#39;s position on the panel in a session entitled &quot;I&#39;d Like You More if You Didn&#39;t Drive Me Crazy: 
Recurring Issues Among Consumer Lawyers and Trustees, and How to Avoid Them.&quot; The session was designed to 
allow sometimes opposing parties to discuss constructive solutions to common problems, and was part of the 
Consumer Bankruptcy Committee&#39;s goal of making bankruptcy less adversarial by facilitating open communication 
among parties.
&lt;/p&gt;"
                };
                context.Events.Add( eventObj );
                eventObj = new Event()
                {
                    Title = @"Alane Becket elected to the Board of Directors for the American Bankruptcy Institute....",
                    CreatedDate = Convert.ToDateTime( "2012-09-11 11:16:26.8717721" ),
                    EventTypeId = 2,
                    EventHtml = @"

    &lt;p&gt;Alane Becket was elected to the Board of Directors for the American Bankruptcy Institute and
      Co-Chair of the ABI&#39;s Consumer Bankruptcy Committee.  Becket &amp; Lee has been active in the ABI for
      almost 20 years and this appointment is the result of years of service to the ABI. Alane has
      distinguished herself as a speaker at ABI seminars and meetings, moderator of the Consumer Bankruptcy
      Committee&#39;s list serve, Editor of the Consumer Committee&#39;s Newsletter, columnist for the ABI Journal,
      Education Director for the Consumer Committee, and Editor of the Consumer Education Center on the ABI&#39;s
      Website.  It was her work ethic, presentation skills and organizational abilities, combined with her
      legal expertise, that caught the Board&#39;s attention.  Alane was asked to join the Board earlier this
      year and was officially approved by the President at the ABI&#39;s Annual meeting last month.  &lt;/p&gt;
"
                };
                context.Events.Add( eventObj );

                await context.SaveChangesAsync();

            }
        }
    }
}