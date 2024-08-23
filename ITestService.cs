using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumUsingDI
{
    internal interface ITestService
    {
        public string GetUuid();
        public void RunTest();
    }
}
