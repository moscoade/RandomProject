using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using TechTalk.SpecFlow;

namespace RandomProject.Hooks
{
    [Binding]
    public class BaseTest
    {

        public static IWebDriver driver;

        [BeforeScenario]
        public static void BeforeScenarioWithTag()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            // driver.Close();
        }
    }
}