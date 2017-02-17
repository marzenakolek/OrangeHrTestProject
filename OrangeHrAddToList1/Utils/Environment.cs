using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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