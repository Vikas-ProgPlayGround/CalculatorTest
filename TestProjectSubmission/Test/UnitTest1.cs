using System.Numerics;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestProjectSubmission.Page;
using TestProjectSubmission.Utilities;

namespace TestProjectSubmission.Test
{
    public class Tests : Base
    {
        //int num1 = 6, num2 = 8;
        int num1 = 15, num2 = 7;

        [Test]
        public void CheckAddition()
        {
            NumberFunctionaityPage numberFunctionaityPage = new NumberFunctionaityPage(GetDriver());
            if (num1 == 0 && num2 == 0) TestContext.WriteLine("Output is " + 0);
            numberFunctionaityPage.ClearCalculator();
            numberFunctionaityPage.EnterInputNumberOnKeyboard(num1);
            numberFunctionaityPage.PerformOperation("Add");
            numberFunctionaityPage.EnterInputNumberOnKeyboard(num2);
            Assert.That(numberFunctionaityPage.GetResult(), Is.EqualTo((num1 + num2).ToString()), "Test passed for Addition");
        }

        [Test]
        public void CheckSubtraction()
        {
            NumberFunctionaityPage numberFunctionaityPage = new NumberFunctionaityPage(GetDriver());
            if (num1 == 0 && num2 == 0) TestContext.WriteLine("Output is " + 0);
            numberFunctionaityPage.ClearCalculator();
            numberFunctionaityPage.EnterInputNumberOnKeyboard(num1);
            numberFunctionaityPage.PerformOperation("Subtract");
            numberFunctionaityPage.EnterInputNumberOnKeyboard(num2);
            Assert.That(numberFunctionaityPage.GetResult(), Is.EqualTo((num1 - num2).ToString()), "Test passed for Subtract");

        }

        [Test]
        public void CheckMultiplication()
        {
            NumberFunctionaityPage numberFunctionaityPage = new NumberFunctionaityPage(GetDriver());
            if (num1 == 0 && num2 == 0) TestContext.WriteLine("Output is " + 0);
            numberFunctionaityPage.ClearCalculator();
            numberFunctionaityPage.EnterInputNumberOnKeyboard(num1);
            numberFunctionaityPage.PerformOperation("Multiply");
            numberFunctionaityPage.EnterInputNumberOnKeyboard(num2);
            Assert.That(numberFunctionaityPage.GetResult(), Is.EqualTo((num1 * num2).ToString()), "Test passed for Multiplication");

        }

        [Test]
        public void CheckDivision()
        {

            NumberFunctionaityPage numberFunctionaityPage = new NumberFunctionaityPage(GetDriver());
            if (num1 == 0 && num2 == 0) TestContext.WriteLine("Output is " + 0);
            numberFunctionaityPage.ClearCalculator();
            numberFunctionaityPage.EnterInputNumberOnKeyboard(num1);
            numberFunctionaityPage.PerformOperation("Divide");
            numberFunctionaityPage.EnterInputNumberOnKeyboard(num2);
            double exresult = Math.Round((double)num1 / num2, 9);
            Assert.That(numberFunctionaityPage.GetResult(), Is.EqualTo(exresult.ToString()), "Test passed for Division");

        }

    }
}