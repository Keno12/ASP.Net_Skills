using System;
using System.Collections.Generic;
using ASP.Net_Skills.Entity;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.Net_Skills
{
    public partial class ThreadDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Print print = new Print();
            Thread[] threads = new Thread[10];
            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(new ThreadStart(print.PrintNumber));
                threads[i].Name = i.ToString() + "号线程";
            }

            foreach (var item in threads)
            {
                item.Start();
                Response.Write("=   ");
            }
        }

    }

    public class Print
    {
        public void PrintNumber()
        {
            lock (this)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(i);
                }
            }

        }
    }

}