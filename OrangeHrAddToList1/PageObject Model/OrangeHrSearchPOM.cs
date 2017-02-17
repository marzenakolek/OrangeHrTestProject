using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHrAddToList1.PageObject_Model
{
    class OrangeHrSearchPOM
    {
        private IWebDriver Driver { get; set; }
        public OrangeHrSearchPOM(IWebDriver Driver)
        {

            PageFactory.InitElements(Driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='menu_admin_viewAdminModule']")]
        public IWebElement btnAdminModule { get; set; }
        [FindsBy(How = How.Id, Using = "menu_admin_Organization")]
        public IWebElement btnOrganization { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='menu_admin_viewLocations']")]
        public IWebElement btnLocation { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='searchLocation_name']")]
        public IWebElement btnLocationbox { get; set; }
        [FindsBy(How = How.Id, Using = "btnSearch")]
        public IWebElement btnSearch { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='resultTable']/tbody/tr/td[2]/a")]
        public IList <IWebElement> Location { get; set; }
        
    }
}
