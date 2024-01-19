using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System.Drawing;


namespace TestingCalculatorApp
{
    public class Testcase6
    {
        public static AppiumDriver<AndroidElement>? _driver;
        IWebElement plus, minus, divide, multiply, equals, point;
        IWebElement[] digits = new IWebElement[10];

        [Test]
        public void BeforeTest()
        {
            AppiumOptions driverOption = new AppiumOptions();

            //cài đặt
            driverOption.AddAdditionalCapability("platformName", "android");
            driverOption.AddAdditionalCapability("appium:deviceName", "Pixel XL API 34");
            driverOption.AddAdditionalCapability("appium:uid", "emulator-5554");
            driverOption.AddAdditionalCapability("appium:platformVersion", "14");
            driverOption.AddAdditionalCapability("appium:appPackage", "com.google.android.calculator");
            driverOption.AddAdditionalCapability("appium:appActivity", "com.android.calculator2.Calculator");
            driverOption.AddAdditionalCapability("appium:skipUnlock", true);
            driverOption.AddAdditionalCapability("appium:noReset", false);

            _driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), driverOption);

            plus = _driver.FindElementByAccessibilityId("plus");
            minus = _driver.FindElementByAccessibilityId("minus");
            divide = _driver.FindElementByAccessibilityId("divide");
            multiply = _driver.FindElementByAccessibilityId("multiply");
            equals = _driver.FindElementByAccessibilityId("equals");
            point = _driver.FindElementByAccessibilityId("point");

            digits[0] = _driver.FindElementById("com.google.android.calculator:id/digit_0");
            digits[1] = _driver.FindElementById("com.google.android.calculator:id/digit_1");
            digits[2] = _driver.FindElementById("com.google.android.calculator:id/digit_2");
            digits[3] = _driver.FindElementById("com.google.android.calculator:id/digit_3");
            digits[4] = _driver.FindElementById("com.google.android.calculator:id/digit_4");
            digits[5] = _driver.FindElementById("com.google.android.calculator:id/digit_5");
            digits[6] = _driver.FindElementById("com.google.android.calculator:id/digit_6");
            digits[7] = _driver.FindElementById("com.google.android.calculator:id/digit_7");
            digits[8] = _driver.FindElementById("com.google.android.calculator:id/digit_8");
            digits[9] = _driver.FindElementById("com.google.android.calculator:id/digit_9");
        }

        [TestCase]
        public void Test6()
        {

            Clear();

            digits[1].Click();
            digits[2].Click();
            digits[3].Click();
            point.Click();
            digits[4].Click();
            digits[5].Click();
            digits[6].Click();
            plus.Click();
            digits[4].Click();
            digits[5].Click();
            digits[6].Click();
            point.Click();
            digits[7].Click();
            digits[8].Click();
            digits[9].Click();
            equals.Click();

            string result = Result();
            string expected = "580.245";
            Assert.AreEqual(result, expected);
        }

        private void Clear()
        {
            IWebElement clear = _driver.FindElementById("com.google.android.calculator:id/clr");
            clear.Click();
        }

        private string Result()
        {
            IWebElement result = _driver.FindElementById("com.google.android.calculator:id/result_final");
            return result.Text;
        }
    }
}