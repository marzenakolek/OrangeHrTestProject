using OrangeHrAddToList1.PageObject_Model;

namespace OrangeHrAddToList1.Utils
{
    public static class LoginHelper
    {
        private static OrangeHrLogInPOM _pageLogIn { get; set; }

        static LoginHelper()
        {
            _pageLogIn = new OrangeHrLogInPOM(Environment.Driver);
        }

        public static bool Login(string login, string password, string webpage, string errorwebpage)
        {
            Environment.Driver.Navigate().GoToUrl(webpage);

            _pageLogIn.txtUsername.SendKeys(login);
            _pageLogIn.txtPassword.SendKeys(password);
            _pageLogIn.btnLogin.Click();

            if (errorwebpage == Environment.Driver.Url) { return false; }
            return true;
        }
    }
}

