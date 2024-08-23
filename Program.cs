using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumUsingDI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IWebDriver>(new ChromeDriver())
                .AddTransient<ITestService, TestService>()
                .BuildServiceProvider();

            var driver= serviceProvider.GetService<IWebDriver>();
            var test = serviceProvider.GetService<ITestService>();
            var test2 = serviceProvider.GetService<ITestService>();
            test.RunTest();
            var jjh = test.GetUuid();
            var jjh1 = test2.GetUuid();
            driver.Close();
            Console.WriteLine("Hello, World!");
        }
    }
}
