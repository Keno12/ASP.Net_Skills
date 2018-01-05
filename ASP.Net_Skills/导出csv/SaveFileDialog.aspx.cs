using ASP.Net_Skills.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.Net_Skills
{
    public partial class SaveFileDialog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private static void GetData()
        {
            string filePath = DateTime.Now.ToString("yyyyMMddhhmmss") + ".csv";
            System.Web.HttpResponse response = System.Web.HttpContext.Current.Response;
            response.ClearContent();
            response.Clear();
            response.ContentType = "text/plain";
            response.AddHeader("Content-Disposition", "attachment; filename=" + filePath + ";");
            response.Write(GetList());
            response.Flush();
            response.End();
        }

        private static string GetList()
        {
            var users = ModelData.GetUsers();
            StringBuilder csv = new StringBuilder();

            csv.AppendLine("姓名,年龄");

            foreach (var item in users)
            {
                csv.AppendLine(item.Name + "," + item.Age);
            }
            return csv.ToString();
        }
    }
}