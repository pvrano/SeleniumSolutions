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
            driver.Navigate().GoToUrl("https://mas-man-publicnorlrg.dev.360online.com/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        

        [Test]
        public void Loginto360()
        {
            IWebElement loginUser = driver.FindElement(By.Name("loginfmt"));
            loginUser.SendKeys("360admin@test.p360o.com");
            loginUser.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            IWebElement loginpswrd = driver.FindElement(By.Id("i0118"));
            loginpswrd.SendKeys("A0UKjUhaOaERhYh26CI4");
            loginpswrd.SendKeys(Keys.Enter);
            IWebElement yesbtn = driver.FindElement(By.Id("idSIButton9"));
            yesbtn.Submit();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //LogintoPublic360 loginPageOject = new LogintoPublic360();
            //loginPageOject.Login(driver, "360admin@test.p360o.com", "A0UKjUhaOaERhYh26CI4");
            String title = driver.Title;
            Console.WriteLine(title);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement menuBtn = driver.FindElement(By.XPath("//button[@id='MainMenuOpenButton']"));
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