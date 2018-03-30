using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ShareT.Data;
using ShareT.Data.Entity;
using ShareT.Web.TestDemo._AbstractFactory;

namespace ShareT.Web
{
    public class Program
    {
        public static void Main(string[] args)
       {
            #region 抽象工厂
            //AbstractFactory abstractFactory = new ConcreteFactory1();
            //Client client = new Client(abstractFactory);
            //client.Run();
            #endregion

            #region 测试类型
            //Account account = new Account();

            //var r1 = account.GetType();

            //var r2 = typeof(Account); 
            #endregion

            #region web net core 代码
            var host = BuildWebHost(args);

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context1 = services.GetRequiredService<DbTestEntity_1Context>();
                    SampleInitData.InitEf1Data(context1);
                    var context2 = services.GetRequiredService<DbTestEntity_2Context>();
                    SampleInitData.InitEf2Data(context2);
                }
                catch (Exception e)
                {
                    //初始化系统测试数据的时候报错，请联系管理员。
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(e, "初始化系统测试数据的时候报错，请联系管理员。");
                }

            }
            host.Run();
            #endregion
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUrls("http://localhost:30003")
                .UseStartup<Startup>()
                .Build();
    }
}
