using ASP.Net_Skills.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

/// <summary>
/// BasePage 的摘要说明
/// </summary>
public class BasePage : System.Web.UI.Page
{
    //public static string CDNurl = ConfigurationManager.AppSettings["CDNURL"].ToString();
    //public static string CDNurlM = ConfigurationManager.AppSettings["CDNurlM"].ToString();
    //public static string CDNurlJS = ConfigurationManager.AppSettings["CDNURLJS"].ToString();
    //public static string picsPath = ConfigurationManager.AppSettings["IndexFilePath_PicArea"].ToString();
    public string userName, role, siteName = "";
    public int PortNum = 0;
    public string CPID = "";
    public HttpCookie UserCookie = null;
    public string cookieName = "";
    protected string pageDescription = "";
    public static List<User> customerList = null;
    public static List<News> productList = null;

    string keyList = "statisticKey";
    protected override void OnLoad(EventArgs e)
    {

        //try
        //{
        //    if (!CheckUser())
        //    {
        //        Response.Write("<script>parent.window.location.href='../Login.aspx';window.location.href='../Login.aspx';</script>");
        //        Response.Redirect("~/Login.aspx");
        //        return;
        //    }
        //    //if (!MemoryCacheHelper.ContainsKey(keyList))
        //    //{
        //    //    GetLoadSSPandAD();
        //    //    MemoryCacheHelper.Add<string>(keyList, "LoadStatistic", null, DateTime.Now.AddMinutes(5));
        //    //}




        //}
        //catch (Exception ex)
        //{

        //}
        base.OnLoad(e);
    }


	public BasePage()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    public void GetLoadSSPandAD()
    {
        //int sspcount = 0;
        //customerList = BllCustomer.GetList("1=1 ", 1, 200, "CID desc", ref sspcount);
        //productList = BllProduct.GetList("1=1 ", 1, 200, "PID desc", ref sspcount);
        //channelList = BllChannel.GetList("1=1 ", 1, 200, "ChannelID desc", ref sspcount);

    }
    /// <summary>
    /// 验证来源合法性
    /// </summary>
    /// <returns></returns>
    private bool CheckUser()
    {
        //string CID = Tools.GetcookieValue("CID");
        //string CustomerName = Tools.GetcookieValue("CustomerName");
        //string token = Tools.GetcookieValue("Token");//
        //Uri ss = System.Web.HttpContext.Current.Request.UrlReferrer;
        //string md5Str = Common.MD5Str(CID + "-" + CustomerName + "-" + "GoalMobi.Statistic");
        //if (md5Str == token)
        //{
        //    return true;
        //}
        return false;
    }
    /// <summary>
    /// 处理时间函数
    /// </summary>
    /// <param name="timeRange"></param>
    public static string SetDateTimeRange(string timeRange)
    {
        string timewhere = "";
        string[] timeArr = timeRange.Split('-');
        if (timeArr.Length == 2)
        {

            if (!string.IsNullOrEmpty(timeArr[0]))
            {
                timewhere += " and CurrentTime >= '" + DateTime.Parse(timeArr[0]).ToString("yyyy-MM-dd 00:00:00") + "'";
            }
            if (!string.IsNullOrEmpty(timeArr[1]))
            {
                timewhere += " and CurrentTime <= '" + DateTime.Parse(timeArr[1]).ToString("yyyy-MM-dd 23:59:59") + "'";
            }
        }
        return timewhere;
    }
}