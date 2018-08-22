using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.Net_Skills._08_redis
{
    /// <summary>
    /// 单列
    /// </summary>
    public class RedisManager
    {
        private RedisManager() { }
        private static ConnectionMultiplexer instance;
        private static readonly object locker = new object();
        /// <summary>
        /// 单例模式获取redis连接实例
        /// </summary>
        public static ConnectionMultiplexer Instance
        {
            get
            {
                lock (locker)
                {

                    if (instance == null)
                    {
                        if (instance == null)
                            instance = ConnectionMultiplexer.Connect("127.0.0.1"); //这里应该配置文件，不过这里演示就没写
                    }
                }
                return instance;
            }
        }
    }
}