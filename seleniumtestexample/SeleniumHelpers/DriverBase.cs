using System;
using NUnit.Framework;

namespace seleniumtestexample
{
    [TestFixture]
    public class DriverBase: DriverFactory
    {
        private BrowserType _browserType;

        public DriverBase(BrowserType browserType)
        {
            _browserType = browserType;
        }

        [SetUp]
        public void InitializeTest()
        {
            GetDriver(_browserType);
        }

        [TearDown]
        public void CloseBrowser()
        {
            try
            {
                _driver.Quit();
                _driver.Close();
            }
            catch (Exception)
            {
            }
        }
    }
}
