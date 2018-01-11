using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASP.Net_Skills.Entity;
using ASP.Net_Skills.Common;
using System.Web.Services;
using System.Web.Script.Services;

namespace ASP.Net_Skills._06_ajax_get
{
    public partial class index2 : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var jq = new JRequest();
            var list = ModelData.GetNews();
            string res = JsonHelper.ObjectToJSON(list);
            Response.Write("{\"res\":{\"news\":" + res + "}}");
        }
    }


}