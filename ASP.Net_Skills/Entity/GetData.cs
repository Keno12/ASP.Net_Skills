using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.Net_Skills.Entity
{
    public class ModelData
    {
        public static List<User> GetUsers()
        {
            List<User> users = new List<User> { 
                new User{ Name="张三", Age=12 },
                new User{ Name="李四", Age=23 },
                new User{ Name="张大傻", Age=45 },
                new User{ Name="李四光", Age=56 },
                new User{ Name="王者荣耀", Age=17 },
                new User{ Name="马不停", Age=12 },
                new User{ Name="吴大达", Age=11 },
                new User{ Name="周鑫池", Age=34 },
                new User{ Name="张飞", Age=33 },
                new User{ Name="关于", Age=45 },
                new User{ Name="曹操", Age=87 },
                new User{ Name="司马懿", Age=32 },
                new User{ Name="赵云", Age=56 }
            };
            return users;
        }
    }
}