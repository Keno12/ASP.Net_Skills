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


        public static List<News> GetNews()
        {
            List<News> list = new List<News>
            {
                new News{ Title="女人为了让头发变卷，真是丧心病狂！", Url="http://h5.news.ynet.com/2018/01/08/842554t1170.html?hdbk",Img="http://img3.ynet.com/2018/01/08/6b460ef5c526c8b424133398b69ad454_500x-_90.jpg"},
                new News{ Title="盘点最奇葩的飞机餐 吃到只能自认倒霉了吧！", Url="http://h5.news.ynet.com/2018/01/08/842593t1170.html?hdbk",Img="http://img2.ynet.com/2018/01/08/152edaab4d8e93c3db67d0a7244664ca_500x-_90.jpg"},
                new News{ Title="这个巨婴宝宝创当地医院十年之最 生下来一脸不高兴", Url="http://h5.news.ynet.com/2018/01/08/842620t1170.html?hdbk",Img="http://img1.ynet.com/2018/01/08/3b123676f22555749534aadb1d4b14d9_500x-_90.jpg"},
                new News{ Title="真爱无敌！全世界毛发最多的女孩结婚了", Url="http://h5.news.ynet.com/2018/01/08/842668t1170.html?hdbk",Img="http://img1.ynet.com/2018/01/08/068180fc05ec0e91c01686b750d724b9_500x-_90.jpg"},
                new News{ Title="蛤？韩国大部分艺人年收入竟然不足6万块？", Url="http://h5.ent.ynet.com/2018/01/08/842767t1263.html?hdbk",Img="http://img2.ynet.com/2018/01/08/69bbcff24841c41002f64b2b758f5102_500x-_90.jpg"},
                new News{ Title="承包娱乐圈天鹅颈的人，终于出了个大头脖子短的可爱小花", Url="http://h5.ent.ynet.com/2018/01/08/842614t1263.html?hdbk",Img="http://img2.ynet.com/2018/01/08/3b944a672829d6fe8ee63cf016f10201_500x-_90.jpg"},
                new News{ Title="初代网红现状：有人被逼假死，有人当CEO，她在靠整容捞钱", Url="http://h5.ent.ynet.com/2018/01/08/842749t1263.html?hdbk",Img="http://img3.ynet.com/2018/01/08/27e8e6b3c981fa6ece1cf87f6faa5e80_500x-_90.jpg"},
                new News{ Title="依旧同框，只是眼里再无爱意，佟丽娅：为了孩子！", Url="http://h5.ent.ynet.com/2018/01/08/842722t1263.html?hdbk",Img="http://img3.ynet.com/2018/01/08/5502c5da42795de97f99edfb1e9ab19c_500x-_90.jpg"},
                new News{ Title="你那里的冬天有多冷？刚泡好的面竟能冻上", Url="http://h5.news.ynet.com/2018/01/08/841888t1170.html?hdbk",Img="http://img2.ynet.com/2018/01/08/96bdcb1aa7c744ab8ff941b35f2b9d72_500x-_90.jpg"},
                new News{ Title="世界各地的路边摊美食，这样的土豆看着难以下咽", Url="http://h5.news.ynet.com/2018/01/08/842833t1170.html?hdbk",Img="http://img1.ynet.com/2018/01/08/9b80ef07a594c2c32d841c6b5e83b9d9_500x-_90.jpg"},
                new News{ Title="胖新娘穿150万奢华婚纱结婚，身上还贴满欧元", Url="http://h5.news.ynet.com/2018/01/08/842782t1170.html?hdbk",Img="http://img2.ynet.com/2018/01/08/1eadff033c0e29251914a4ac12f803d1_500x-_90.jpg"},
                new News{ Title="悬崖峭壁上的“山顶洞人”，已在洞里住了五十多年", Url="http://h5.news.ynet.com/2018/01/08/842515t1170.html?hdbk",Img="http://img2.ynet.com/2018/01/08/c107e7812a6a11016ed1445d9e737076_500x-_90.jpg"},
                new News{ Title="刚满18岁的明星，她比王俊凯吴磊起点高，如今却这样", Url="http://h5.news.ynet.com/2018/01/08/842494t1170.html?hdbk",Img="http://img2.ynet.com/2018/01/08/eb820b82b119adac58ceddc194ad42f7_500x-_90.jpg"},
                new News{ Title="女孩从小学开始给娃娃做衣服，如今的水平已令人惊叹", Url="http://h5.news.ynet.com/2018/01/08/842467t1170.html?hdbk",Img="http://img3.ynet.com/2018/01/08/6742ac123ce475a583bf45a4163e070f_500x-_90.jpg"},
                new News{ Title="最“不正经”的雕塑，挖鼻孔、吐舌头太辣眼睛", Url="http://h5.news.ynet.com/2018/01/08/841717t1170.html?hdbk",Img="http://img1.ynet.com/2018/01/08/77162032d798d1a73e5eb58e6624d4fb_500x-_90.jpg"},
                new News{ Title="印度“肌肉夫妻”身材壮如虎 痴迷健身狂拿28块奖牌", Url="http://h5.news.ynet.com/2018/01/08/843033t1170.html?hdbk",Img="http://img3.ynet.com/2018/01/08/6b460ef5c526c8b424133398b69ad454_500x-_90.jpg"},
                new News{ Title="河南女大学生雪天穿单衣热舞 不怕冻只要美", Url="http://h5.news.ynet.com/2018/01/08/843912t1170.html?hdbk",Img="http://img1.ynet.com/2018/01/08/32adfca96933cc0ac17f3134317a18d4_500x-_90.jpg"},
                new News{ Title="腹肌最迷人的男星：易烊千玺上榜，张艺兴垫底，第1名被称完美！", Url="http://h5.ent.ynet.com/2018/01/08/843411t1263.html?hdbk",Img="http://img2.ynet.com/2018/01/08/0752547aabe7082538497e15ebf687f7.jpg"},
                new News{ Title="说到娃娃脸，就会想到赵丽颖陈妍希，但51岁的她才是鼻祖", Url="http://h5.ent.ynet.com/2018/01/08/842653t1263.html?hdbk",Img="http://img1.ynet.com/2018/01/08/d629963c49ef96dd72d2615a90ca1b91_500x-_90.jpg"},
                new News{ Title="贾乃亮微博获丈母娘点赞，如今她却悄悄改了微博名", Url="http://h5.ent.ynet.com/2018/01/08/842692t1263.html?hdbk",Img="http://img2.ynet.com/2018/01/08/82149c3b3081937f497d140145f94a10_500x-_90.jpg"},

                new News{ Title="小伙非洲打工月挣2万，在黑人眼中他就是“土豪”", Url="http://h5.news.ynet.com/2018/01/09/846252t1170.html?hdbk",Img="http://img2.ynet.com/2018/01/09/389a662c299286b3cdfd49b848c9b4d1_500x-_90.jpg"},
                new News{ Title="三岁小女孩跟着小狗去到草丛，13天后小狗独自回家见人就咆哮", Url="http://h5.news.ynet.com/2018/01/09/846279t1170.html?hdbk",Img="http://img3.ynet.com/2018/01/09/6e35dbe8c6dfeed8fd1fab58d543286d_500x-_90.jpg"},
                new News{ Title="四大巨人与女星合影的尴尬 黄奕眼里全是易建联", Url="http://h5.ent.ynet.com/2018/01/09/846306t1263.html?hdbk",Img="http://img1.ynet.com/2018/01/09/0bebebabdd40e3326f09fbff00ecdb0b_500x-_90.jpg"},
                new News{ Title="七张经典照片：小燕子玩手机，星爷牵手黄圣依", Url="http://h5.ent.ynet.com/2018/01/09/846327t1263.html?hdbk",Img="http://img1.ynet.com/2018/01/09/d317fe92186df60347e8814f8d6c00b9_500x-_90.jpg"},
                new News{ Title="电视剧里鬼一样的妆容！把造型师拖下去用风油精滴眼睛！", Url="http://h5.news.ynet.com/2018/01/09/845415t1170.html?hdbk",Img="http://img3.ynet.com/2018/01/09/83be2b6124d5f2be2386356edeb6d9c3_500x-_90.jpg"},
                new News{ Title="盘点：这些热播电视剧里的男主都眼瞎吗？", Url="http://h5.news.ynet.com/2018/01/09/846111t1170.html?hdbk",Img="http://img1.ynet.com/2018/01/09/e4e55c6c14f94cf4bfe54ec1345fbbe5_500x-_90.jpg"},
                new News{ Title="刘嘉玲同学合照独领风骚，这些和同学合照的明星个个鹤立鸡群！", Url="http://h5.news.ynet.com/2018/01/08/842554t1170.html?hdbk",Img="http://img3.ynet.com/2018/01/08/6b460ef5c526c8b424133398b69ad454_500x-_90.jpg"},
                new News{ Title="凭大长腿成网红，嫁豪门开美术馆逆袭名媛，如今和法国总统是好友", Url="http://h5.news.ynet.com/2018/01/09/846297t1170.html?hdbk",Img="http://img1.ynet.com/2018/01/09/7574be1e8ce9890c1c5d8e17f4453ba0_500x-_90.JPEG"},
                new News{ Title="45岁李冰冰曝29岁男友“喜好”，惹观众哈哈大笑，吴昕巧妙圆场！", Url="http://h5.news.ynet.com/2018/01/09/846507t1170.html?hdbk",Img="http://img1.ynet.com/2018/01/09/308f6b3a81923a181299c2ee701b62b4_500x-_90.jpg"},
                new News{ Title="有这六个特征的人会比同龄人显老！吃对饮食也能养出好肌肤", Url="http://h5.news.ynet.com/2018/01/09/845490t1170.html?hdbk",Img="http://img1.ynet.com/2018/01/09/4e33c06debc2c54cb96558d598da76c5_500x-_90.jpg"},
                new News{ Title="和李晨交换一个五官选什么？范冰冰的回答太好笑了！", Url="http://h5.news.ynet.com/2018/01/09/844869t1170.html?hdbk",Img="http://img1.ynet.com/2018/01/10/396533d137c26db711890d56fa3cecf6_500x-_90.jpg"},
                new News{ Title="本是千万富翁，却在北极求婚南极结婚，足迹遍布地球各大最危险地", Url="http://h5.news.ynet.com/2018/01/09/846513t1170.html?hdbk",Img="http://img1.ynet.com/2018/01/09/cedf06fce2e04944d3f942fce03f7b1c_500x-_90.jpg"},
                new News{ Title="图揭百年前各国年轻人的真实面貌，跟电视剧反差有点大", Url="http://h5.news.ynet.com/2018/01/09/846339t1170.html?hdbk",Img="http://img3.ynet.com/2018/01/09/2945b5f75b4d856039aafe27094d0009_500x-_90.jpg"},
                new News{ Title="世界拥有最强大脑的十个人，每一个都超乎你的想象", Url="http://h5.news.ynet.com/2018/01/09/846114t1170.html?hdbk",Img="http://img2.ynet.com/2018/01/09/70f5c7dcfd8cae061279f5960e1482ae_500x-_90.jpg"},
                new News{ Title="长得不像爸妈？看完这组图才知道隔代遗传多厉害", Url="http://h5.news.ynet.com/2018/01/09/846105t1170.html?hdbk",Img="http://img1.ynet.com/2018/01/09/4582c63cc9d45efee122705e8fe1fb98_500x-_90.jpg"},
                new News{ Title="曾和成龙结怨22年，后嫁给不老男神生了帅儿子	", Url="http://h5.news.ynet.com/2018/01/09/844785t1170.html?hdbk",Img="http://img2.ynet.com/2018/01/10/8e883b81598d3d8febfe477326f55014_500x-_90.jpg"},
                new News{ Title="直击全世界最幸运的8个人，有人捡漏赚3亿，有人吃饭吃到宝", Url="http://h5.news.ynet.com/2018/01/09/844812t1170.html?hdbk",Img="http://img2.ynet.com/2018/01/10/9f28d19abf82ac8a212ea1168c010bee_500x-_90.jpg"},
                new News{ Title="在男生眼里，女生哪些打扮真的很丑，你上榜了吗？", Url="http://h5.news.ynet.com/2018/01/09/844899t1170.html?hdbk",Img="http://img2.ynet.com/2018/01/10/497fb1d9f75bcbe55a2e387d6d86e34e_500x-_90.jpg"},
                new News{ Title="43岁生7个孩子，被丈夫抛弃后用6个月狂减30斤，第二任很爱她！", Url="http://h5.news.ynet.com/2018/01/09/845172t1170.html?hdbk",Img="http://img3.ynet.com/2018/01/10/29680b02a3e46782f2d4f90859aa522d_500x-_90.jpg"},
                new News{ Title="14个“离谱”山寨品牌，哪一个你中招过？", Url="http://h5.news.ynet.com/2018/01/09/846192t1170.html?hdbk",Img="http://img3.ynet.com/2018/01/09/665b7a67d0f146828ee8d468b09ca72b_500x-_90.jpg"}
            };

            return list;
        }
    }
}