using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TestProjectSubmission.Utilities;

namespace TestProjectSubmission.Page
{
    public class NumberFunctionaityPage
    {
        private IWebDriver driver;

        public NumberFunctionaityPage(IWebDriver driver) {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "input[value='C']")]
        private IWebElement clearButton;

        [FindsBy(How=How.CssSelector, Using = "input[value='=']")]
        private IWebElement equalsButton;

        public bool CheckAllNumbersForNegative(int num1, int num2) {
            return num1 < 0 || num2 < 0;
        }

        public void ClearCalculator() { 
            clearButton.Click();
        }

        public void EnterInputNumberOnKeyboard(int input) {
            if(input > 9) {
                while (input >= 10) {
                    int temp = input / 10;
                    driver.FindElement(By.CssSelector($"input[value='{temp.ToString()}']")).Click();
                    input = input % 10;
                }
            }
                driver.FindElement(By.CssSelector($"input[value='{input.ToString()}']")).Click();
        }

        public void PerformOperation(string operand)
        {
            switch (operand)
            {
                case "Add":
                    driver.FindElement(By.CssSelector("#add")).Click();
                    break;
                case "Subtract":
                    driver.FindElement(By.CssSelector("#subtract")).Click();
                    break;
                case "Multiply":
                    driver.FindElement(By.CssSelector("#multiply")).Click();
                    break;
                case "Divide":
                    driver.FindElement(By.CssSelector("#divide")).Click();
                    break;
            }
        }

        public string GetResult() {
            equalsButton.Click();
            return driver.FindElement(By.CssSelector("#display")).Text;

        }
    }
}
