using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumUsingDI
{
    internal class TestService : ITestService
    {
        private readonly IWebDriver _webdriver;
        string uuid;
        public TestService(IWebDriver webdriver)
        {
            _webdriver = webdriver;
            uuid = Guid.NewGuid().ToString();
        }

        public string GetUuid()
        {
            return uuid;
        }
        public void RunTest()
        {
            _webdriver.Navigate().GoToUrl("https://http.cat/");
        }
    }
}
