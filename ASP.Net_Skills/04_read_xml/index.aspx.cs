using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace ASP.Net_Skills._04_read_xml
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XDocument xdoc = XDocument.Load(@"C:\Users\Keno\Desktop\data.xml");
            var news = from news1 in xdoc.Descendants("news")
                       select new
                       {
                           Title = news1.Attribute("title").Value,
                       };


        }
    }
}