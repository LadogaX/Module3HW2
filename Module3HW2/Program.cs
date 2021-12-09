using System;
using System.Globalization;
using Microsoft.Extensions.DependencyInjection;
using Module3HW2.Models.Abstraction;
using Module3HW2.Services;

namespace Module3HW2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IServiceConfig, ServiceConfig>()
                .AddTransient<IServiceLetterGroup, ServiceLetterGroup>()
                .AddTransient<IPersonsBookService, PersonsBookService>()
                .AddTransient<Starter>()
                .BuildServiceProvider();

            var starter = serviceProvider.GetService<Starter>();

            starter.Run();
        }
    }
}
