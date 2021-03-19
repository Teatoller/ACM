using System;
using Xunit;

namespace Acme.Common.Tests
{
    public class StringHandlerTest
    {
        [Fact]
        public void InsertSpacesTestValid()
        {
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            // var actual = StringHandler.InsertSpaces(source);
            var actual = source.InsertSpaces();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertSpacesTestWithExistingSpaceValid()
        {
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            var actual = StringHandler.InsertSpaces(source);

            Assert.Equal(expected, actual);
        }
    }
}
