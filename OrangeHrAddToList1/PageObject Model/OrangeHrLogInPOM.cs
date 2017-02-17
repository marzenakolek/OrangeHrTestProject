using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace OrangeHrAddToList1.PageObject_Model
{
    class OrangeHrLogInPOM
    {
        private IWebDriver Driver { get; set; }
        public OrangeHrLogInPOM(IWebDriver driver)
        {
           
            PageFactory.InitElements(Environment.Driver, this);
        }
        [FindsBy(How = How.Id, Using = "txtUsername")]
        public IWebElement txtUsername { get; set; }
        [FindsBy(How = How.Id, Using = "txtPassword")]
        public IWebElement txtPassword { get; set; }
        [FindsBy(How = How.Id, Using = "btnLogin")]
        public IWebElement btnLogin { get; set; }
        [FindsBy(How = How.ClassName, Using = "head")]
        public IWebElement Repeatbox { get; set; }
    }
}
