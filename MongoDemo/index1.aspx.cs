﻿using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MongoDemo
{
    public partial class index1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // MongoDB服务器 连接串
            var connectString = "mongodb://127.0.0.1:27017";
            var client = new MongoClient(connectString);
            if (client != null)
            {
                Response.Write("success");
            }
            else
            {
                Response.Write("error");
            }

        }


    }
}