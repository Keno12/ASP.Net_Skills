using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.Net_Skills
{
    public partial class DataTableExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //http://www.cnblogs.com/emilyhyj/archive/2010/09/26/1836249.html

            DataTable dt = new DataTable("data");
            dt.Columns.Add("Name", Type.GetType("System.String"));
            dt.Columns.Add("Age", Type.GetType("System.Int32"));

            dt.Rows.Add(new object[] { "张三", 12 });
            dt.Rows.Add(new object[] { "李四", 14 });
            dt.Rows.Add(new object[] { "王五", 12 });
            dt.Rows.Add(new object[] { "王五", 12 });
            dt.Rows.Add(new object[] { "王五", });
            dt.Rows.Add(new object[] { "", 12 });
            dt.Rows.Add(new object[] { "王五", 12 });
        }
    }
}