using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;


namespace CreateCase
{
    public class Tests
    {

        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            ChromeDriver chromedriver = new ChromeDriver();
            driver = chromedriver;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("www.testFilelocation.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        

        [Test]
        public void Loginto360()
        {
            IWebElement loginUser = driver.FindElement(By.Name("login"));
            loginUser.SendKeys("passwordtext");
            loginUser.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            IWebElement loginpswrd = driver.FindElement(By.Id("element_id"));
            loginpswrd.SendKeys("GUIKeyHere");
            loginpswrd.SendKeys(Keys.Enter);
            IWebElement yesbtn = driver.FindElement(By.Id("selectorIdhere"));
            yesbtn.Submit();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
            String title = driver.Title;
            Console.WriteLine(title);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement menuBtn = driver.FindElement(By.XPath("//button[@id='MainMenuButton']"));
            menuBtn.Click();
            IWebElement caseTitle = driver.FindElement(By.XPath("//*[@id=\"DeltaTopNavigation\"]/div/nav/div[2]/div[2]/ul/li/ul/li[1]/div/button/span/div"));
            caseTitle.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            IWebElement caseCreateBox = driver.FindElement(By.CssSelector("iframe[src*='/locator/DMS/Case/New']"));
            driver.SwitchTo().Frame(caseCreateBox);
            driver.FindElement(By.Id("PlaceHolderMain_MainView_AccessCodeComboControl_selectize")).Click();
            
            
           




        }

    }
}
