using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharp_NetCore
{
    public class Tests : DriverHelper
    {


        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver(@"D:\Work\Automation_Study\Driver");
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");
            Assert.Pass();
        }
    }
}