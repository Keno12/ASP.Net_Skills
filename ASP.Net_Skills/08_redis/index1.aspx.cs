using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.Net_Skills._08_redis
{
    public partial class index1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //E:\workinstalled\Redis\Redis\redis - service.exe
            var db = RedisManager.Instance.GetDatabase();

            string value = "abcdefg";
            db.StringSet("mykey", value);

            string result = db.StringGet("mykey");
            

            Response.Write(result);
        }
    }
}