using System.Linq;
using FluentAssertions;
using Xunit;

namespace U4.AntiSamy.Tests
{
    public class LiteralTests : TestBase
    {

        [Fact]
        public void Test_dom_good_result()
        {
            var html = "<div align=\"right\">html</div>";

            AntiySamyResult result = new U4.AntiSamy.AntiSamy().Scan(html, TestPolicy);

            result.ErrorMessages.Count().Should().Be(0);
        }

        [Fact]
        public void TestDomBadResult()
        {
            var badHtml = "<div align=\"foo\">badhtml</div>";

            AntiySamyResult result = new U4.AntiSamy.AntiSamy().Scan(badHtml, TestPolicy);

            result.ErrorMessages.Count().Should().BeGreaterThan(0);
        }
    }
}
