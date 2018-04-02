using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShareT.RedisCon
{
    /// <summary>
    /// String类型是最常用的数据类型，在Redis中以KKey/Value存储。
    /// </summary>
    public class StringDemo
    {
        public static void Start()
        {
            var redisMangement = new RedisManagerPool("127.0.0.1:6379");
            var client = redisMangement.GetClient();

            client.Set<int>("pwd", 111);                       //普通字符串  
            int pwd = client.Get<int>("pwd");
            Console.WriteLine(pwd);
            var todoTools = client.As<Todo>();
            Todo todo = new Todo() { Content = "123", Id = todoTools.GetNextSequence(), Order = 1 };
            client.Set<Todo>("todo", todo);                    //object  
            Todo getTodo = client.Get<Todo>("todo");
            Console.WriteLine(getTodo.Content);

            List<Todo> list = new List<Todo>() { new Todo() { Content = "123" }, new Todo() { Content = "234" } };      //List<Object>  

            client.Set("list", list);
            List<Todo> getList = client.Get<List<Todo>>("list");

            foreach (var VARIABLE in getList)
            {
                Console.WriteLine(VARIABLE.Content);
            }
            Console.ReadLine();
        }
    }
}
