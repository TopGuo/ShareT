using ServiceStack.Redis;
using ServiceStack.Text;
using System;

namespace ShareT.RedisCon
{
    class Program
    {
        static void Main(string[] args)
        {

            #region redis 入门基础知识
            //var redisManger = new RedisManagerPool("127.0.0.1:6379");      //Redis的连接字符串  
            //var redis = redisManger.GetClient();                           //获取一个Redis Client  
            //var redisTodos = redis.As<Todo>();
            //var newTodo = new Todo                                          //实例化一个Todo类  
            //{
            //    Id = redisTodos.GetNextSequence(),
            //    Content = "Learn Redis",
            //    Order = 1,
            //};
            //redisTodos.Store(newTodo);                                    //把newTodo实例保存到数据库中    增       
            //Todo saveTodo = redisTodos.GetById(newTodo.Id);               //根据Id查询        查  
            //"Saved Todo: {0}".Print(saveTodo.Dump());

            //saveTodo.Done = true;                                         //改  
            //redisTodos.Store(saveTodo);

            //var updateTodo = redisTodos.GetById(newTodo.Id);            //查  
            //"Updated Todo: {0}".Print(updateTodo.Dump());

            //redisTodos.DeleteById(newTodo.Id);                           //删除  

            //var remainingTodos = redisTodos.GetAll();
            //"No more Todos:".Print(remainingTodos.Dump());
            //var todos = redisTodos.GetAll();
            //"Saved Todo: {0}".Print(todos.Dump()); 
            #endregion

            //简单string redis
            //StringDemo.Start();

            //hash
            //HashDemo.Start();

            //队列/堆栈--水管/水桶
            //ListDemo.Start();

            //无序集合
            //SetDemo.Start();

            //有序集合
            SortedSetDemo.Start();


            Console.ReadLine();
        }
    }
}
