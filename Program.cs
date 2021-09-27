using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuestionServer.Managers;

namespace QuestionServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            QuestionsManager._questions.Add(new Question(1));
            QuestionsManager._questions.Add(new Question(2));
            QuestionsManager._questions.Add(new Question(3));
            QuestionsManager._questions.Add(new Question(4));
            
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
