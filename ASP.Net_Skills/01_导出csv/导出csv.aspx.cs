using ASP.Net_Skills.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.Net_Skills
{
    public partial class 导出csv : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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
            string filePath = "E:\\123.csv";
            File.WriteAllText(filePath, csv.ToString(), Encoding.UTF8);
        }
    }
}