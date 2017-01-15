using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace OrangeHrAddToList1
{

        public static class Environment
        {
            static Environment()
            {
                Driver = new ChromeDriver();
            }
            public static IWebDriver Driver
            {
                get; set;
            }
        }
   
}