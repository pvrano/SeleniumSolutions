using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;

namespace CreateCase
{
    public class LogintoCMS
    {
        public  IWebDriver driver;
       
        


        [FindsBy(How = How.Name , Using = "login")]
        public IWebElement user_name { get; set; }

        [FindsBy(How = How.Id, Using = "i0118")]
        public IWebElement user_password { get; set; }

        [FindsBy(How = How.Id , Using = "idSIButton9")]
        public IWebElement yes_button { get; set; }
        public object PageFactory { get; private set; }

        public void Login(IWebDriver driver, string username, string password)
        {
            user_name.SendKeys(username);
            user_name.SendKeys(Keys.Enter);
            user_password.SendKeys(password);
            user_name.SendKeys(Keys.Enter);
            yes_button.Submit();
        }



    }
}
