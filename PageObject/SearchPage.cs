using OpenQA.Selenium;
using RandomProject.Hooks;
using System.Diagnostics;
using System.Threading;

namespace RandomProject.PageObject
{
    class SearchPage
    {
        public IWebDriver driver;
        
        private By vewCart = By.XPath("//a[normalize-space()='Cart']");
        
        public SearchPage() 
        {
            driver = BaseTest.driver;
        }
        public void ClickFourRandomItems()
        {
            Random random = new Random();

            // I defined the firstItem, secondItem, thirdItem, and fourthItem locators

            int itemCount = 4;

            for (int i = 0; i < itemCount; i++)
            {
                // Generate a random integer between a specified range

                int randomIndex = random.Next(1, 5); // Generate between 1 (lower boundary) and 4 (upper boundary)
                driver.FindElement(By.XPath("//*[@id=\"main\"]/div[2]/ul/li["+randomIndex+"]/div/a[2]")).Click();

               
            }

        }

        public void VewMycart()
        {
            Thread.Sleep(2000);
            driver.FindElement(vewCart).Click();
        }
        public bool VerifyFouritemsinmycart()
        {
            return driver.Url.Contains("https://cms.demo.katalon.com/cart/");
        }
        
       

    }
}
