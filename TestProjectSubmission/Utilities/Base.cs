using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProjectSubmission.Utilities
{
    public class Base
    {
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            string productionUrl = "https://nuix.github.io/SDET/senior-sdet/productionCalc/index.html";
            string stagingUrl = "https://nuix.github.io/SDET/senior-sdet/stagingCalc/index.html";

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(productionUrl);
        }

        public IWebDriver GetDriver() {
            return driver;
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
