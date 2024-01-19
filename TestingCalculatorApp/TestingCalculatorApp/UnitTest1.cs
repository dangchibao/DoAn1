using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;


namespace TestingCalculatorApp
{
    public class Testcase1
    {
        public static AppiumDriver<AndroidElement>? _driver;
        [Test]
        public void Test1()
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

            //Thời gian đợi
            Thread.Sleep(3000);

            // Đóng ứng dụng
            _driver.CloseApp();
        }
    }
}