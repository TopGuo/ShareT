using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShareT.RedisCon
{
    /// <summary>
    /// Hash在Redis采用 (HashId,Key，Value)进行存储
    /// </summary>
    class HashDemo
    {
        public static void Start()
        {

            var redisMangement = new RedisManagerPool("127.0.0.1:6379");
            var client = redisMangement.GetClient();
            client.SetEntryInHash("test", "123", "aaaaa");                       //存储一次数据  test是hashid，123是key，aaaa是value  
            List<string> listKeys = client.GetHashKeys("test");                  //获取test哈希下的所有key  
            Console.WriteLine("keys in test");
            foreach (var VARIABLE in listKeys)
            {
                Console.WriteLine(VARIABLE);
            }
            List<string> listValue = client.GetHashValues("test");             //获取test哈希下的所有值  
            Console.WriteLine("test 里的所有值");
            foreach (var VARIABLE in listValue)
            {
                Console.WriteLine(VARIABLE);
            }
            string value = client.GetValueFromHash("test", listKeys[0]);      //获取test哈希下，第一个Key对应的值  
            Console.WriteLine("test 下的key" + listKeys[0] + "对应的值" + value);

        }
    }
}
