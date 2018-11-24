using NUnit.Framework;
using System.Collections.Generic;

namespace seleniumtestexample
{

    [TestFixture]
    [Parallelizable]
    public class ChromeTesting : DriverBase
    {
        public ChromeTesting() : base(BrowserType.Chrome)
        {

        }

        [Test]
        [TestCaseSource(typeof(TestData), "ValueOfSearch")]
        public void GoogleSearchTest(IDictionary<string, string> parameters)
        {
            // Arrange
            var searchPage = new SearchPage(_driver);

            // Act
            searchPage.SearchTheWord(parameters);

            // Assert
            Assert.That(_driver.PageSource.Contains(parameters["word"]), Is.EqualTo(true), "Fail doest not exist");

        }
    }

    [TestFixture]
    [Parallelizable]
    public class FirefoxTesting : DriverBase
    {
        public FirefoxTesting() : base(BrowserType.Firefox)
        {

        }

        [Test]
        [TestCaseSource(typeof(TestData), "ValueOfSearch")]
        public void FirefoxSearchTest(IDictionary<string, string> parameters)
        {
            // Arrange
            var searchPage = new SearchPage(_driver);

            // Act
            searchPage.SearchTheWord(parameters);

            // Assert
            Assert.That(_driver.PageSource.Contains(parameters["word"]), Is.EqualTo(true), "Fail doest not exist");

        }
    }

}
