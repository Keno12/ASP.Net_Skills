using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.Net_Skills._07_IO
{
    public partial class index2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string path = @"E:\";
            var txtFiles = Directory.EnumerateFiles(path, "*.txt");
            foreach (var file in txtFiles)
            {
                string fileName = file.Substring(path.Length + 1);
            }
        }
    }
}