using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.Net_Skills
{
    public partial class ThreadDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var time = DateTime.Now.ToString("yyyyMMddhhmmss");
            var date = Convert.ToInt32(time);
        }
    }
}