using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.Net_Skills._07_IO
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-iterate-through-a-directory-tree

            //File
            //string[] lines = System.IO.File.ReadAllLines(@"E:\0109链接 - 副本.xlsx", Encoding.Default);

            //StreamReader
            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(@"E:\0109链接 - 副本.xlsx",Encoding.Default);
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                counter++;
            }

            file.Close();

        }
    }
}