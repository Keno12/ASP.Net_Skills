using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;

namespace ASP.Net_Skills.Common
{
    public class JRequest
    {
        HttpContext _context;
        public HttpContext _Context
        {
            set { _context = value; }
            get {
                if (_context == null)
                {
                    _context = HttpContext.Current;
                }
                return _context;
            }
        }
        Dictionary<string, string> dic = null;///new Dictionary<string, string>();
        string _postParam = "";
        public byte[] PostpParambyte { get; set; }
        public string postParam
        {
            get
            {
                if (string.IsNullOrEmpty(_postParam))
                {
                    _postParam = _Context.Request.Url.Query.TrimStart('?');
                }
                return _postParam;
            }

            set
            {
                _postParam = value;
            }
        }
    
        public JRequest(string quryStr)
        {
            Init(quryStr);
        }
        public JRequest()
        {
            postParam = RequestPara();
            Init(postParam);
        }

        public JRequest(HttpContext context)
        {
            _Context = context;
            postParam = RequestPara();
            Init(postParam);
        }

        public JRequest(HttpContext context, string quryStr)
        {
            _Context = context;          
            Init(quryStr);
        }
        void Init(string quryStr)
        {
            if (!string.IsNullOrWhiteSpace(quryStr))
            {
                postParam = quryStr;
                dic = new Dictionary<string, string>();
                string[] list = quryStr.Split('&');
                string key;
                foreach (string s in list)
                {
                    if (!string.IsNullOrEmpty(s))
                    {
                        if (s.Contains('='))
                        {
                            string[] paramValue = s.Split('=');
                            key = paramValue[0].ToLower().Trim();
                            if (!dic.Keys.Contains(key))
                                dic.Add(key, paramValue[1]);
                        }
                        else
                        {
                            key = s.ToLower().Trim();
                            if (!dic.Keys.Contains(key))
                            {
                                dic.Add(key, "");
                            }
                        }
                    }
                }
            }
        }


        public string GetQueryStr(string key)
        {
            if (_Context.Request[key] != null)
            {
                return _Context.Request[key];
            }
            else if (_Context.Request.Form[key] != null)
            {
                return _Context.Request.Form[key];
            }
            string value;
            if (dic != null)
            {
                dic.TryGetValue(key.ToLower().Trim(), out value);
                return value == null ? "" : value;// Common.FilterForSql(value);
            }
            else
            {
                return "";
            }

        }

        public int GetQueryInt(string key)
        {
            string str = GetQueryStr(key);
            int i;
            int.TryParse(str, out i);
            return i;

        }

        public long GetQueryLong(string key)
        {
            string str = GetQueryStr(key);
            int i;
            int.TryParse(str, out i);
            return i;

        }

        public DateTime? GetQueryDateTime(string key)
        {
            string str = GetQueryStr(key);
            DateTime d;
            if (DateTime.TryParse(str, out d))
            {
                return d;
            }
            return null;
        }
        public Decimal GetQueryDecimal(string key)
        {
            string str = GetQueryStr(key);
            Decimal d;
            if (Decimal.TryParse(str, out d))
            {
                return d;
            }
            return 0;
        }



        public string RequestPara()
        {
            string param = string.Empty;

            ///流的形式读取参数
            using (Stream MyStream = _Context.Request.InputStream)
            {
                byte[] _tmpData = new byte[MyStream.Length];// 

                if (_tmpData.Length > 0)
                {
                    MyStream.Read(_tmpData, 0, _tmpData.Length);
                    param = Encoding.UTF8.GetString(_tmpData);
                    PostpParambyte = _tmpData;
                }
                 
            }
            return param;
        }
    }

}
