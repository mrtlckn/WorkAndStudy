using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
namespace WebApplication15
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            PopulateRssFeed("https://rss.nytimes.com/services/xml/rss/nyt/World.xml");
        }
      
        private void PopulateRssFeed(string url1)
        {
            string RssFeedUrl = url1;
            List<News> feeds = new List<News>();
            try
            {
                XDocument xDoc = new XDocument();
                xDoc = XDocument.Load(RssFeedUrl);
                var items = (from x in xDoc.Descendants("item")
                             select new
                             {
                                 title = x.Element("title").Value,
                                 link = x.Element("link").Value,
                                 pubDate = x.Element("pubDate").Value,
                                 description = x.Element("description").Value,
                                 image = x.Element("link").Value

                             });
                
                if (items != null)
                {
                    foreach (var i in items)
                    {
                        News f = new News
                        {
                            Title = i.title,
                            Link = i.link,
                            PublishDate = i.pubDate,
                            Description = i.description,
                            Image = i.image
                        };

                        feeds.Add(f);
                    }
                }
                
                gvRss.DataSource = feeds;
                gvRss.DataBind();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PopulateRssFeed("https://rss.nytimes.com/services/xml/rss/nyt/Technology.xml");
        }

        protected void btnSport_Click(object sender, EventArgs e)
        {
            PopulateRssFeed("https://rss.nytimes.com/services/xml/rss/nyt/Sports.xml");
        }

        protected void btnScience_Click(object sender, EventArgs e)
        {
            PopulateRssFeed("https://rss.nytimes.com/services/xml/rss/nyt/Science.xml");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            PopulateRssFeed("https://rss.nytimes.com/services/xml/rss/nyt/Health.xml");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            PopulateRssFeed("https://rss.nytimes.com/services/xml/rss/nyt/Travel.xml");
        }

        protected void btnArts_Click(object sender, EventArgs e)
        {
            PopulateRssFeed("https://rss.nytimes.com/services/xml/rss/nyt/Arts.xml");
        }

        protected void btnJobs_Click(object sender, EventArgs e)
        {
            PopulateRssFeed("https://rss.nytimes.com/services/xml/rss/nyt/Jobs.xml");
        }
    }
}