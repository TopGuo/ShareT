using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShareT.RedisCon
{
    /// <summary>
    /// list是一个链表结构，key可以理解为链表的名字，然后往这个名字所对应的链表里加值。，list可以以队/栈的形式进行工作
    /// </summary>
    class ListDemo
    {
        public static void Start()
        {
            var redisMangement = new RedisManagerPool("127.0.0.1:6379");
            var client = redisMangement.GetClient();

            //队列的使用   //先进先出  
            client.EnqueueItemOnList("name", "zhangsan");   //入列  
            client.EnqueueItemOnList("name", "lisi");       //入列  
            long count = client.GetListCount("name");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(client.DequeueItemFromList("name"));   //出列  
            }


            //栈的使用 //先进后出  
            client.PushItemToList("name2", "wangwu");          //推入  
            client.PushItemToList("name2", "maliu");           //推入  
            long count2 = client.GetListCount("name2");
            for (int i = 0; i < count2; i++)
            {
                Console.WriteLine(client.PopItemFromList("name2"));   //弹出  
            }
        }
    }
}
