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

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
        public static void GetData()
        {
            string filePath = "xxx.csv";
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

            List<User> users = new List<User>
            {
                new User{ Name="张三",Age=13},
                new User{Name="李四", Age=14},
                new User{Name="王五"},
                new User{ Age=14},
                new User{Name="dsf", Age=14},
            };

            var csv = new StringBuilder();
            csv.AppendLine("姓名,年龄");
            foreach (var item in users)
            {
                csv.AppendLine(item.Name + "," + item.Age);
            }
            return csv.ToString();

        }
    }
}