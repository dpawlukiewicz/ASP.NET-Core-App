using System.Collections.Generic;
using System.Linq;
using MyAwesomeApp.Services;
using Xunit;

namespace MyAwesomeApp.Tests
{
    public class ValuesService_GetValues_Tests
    {
        [Fact]
        public void GetValues_Returns_Three_Values()
        {
            var valuesService = new ValuesService();
            var values = valuesService.GetValues().ToArray();

            Assert.Equal(values.Length, 3);
        }
    }
}