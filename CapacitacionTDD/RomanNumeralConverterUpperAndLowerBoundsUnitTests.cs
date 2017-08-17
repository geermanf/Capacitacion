using System;
using Xunit;
using Converters;


namespace MyFirstUnitTests
{
    public class RomanNumeralConverterUpperAndLowerBoundsUnitTests
    {

        [Fact]
        public void Number_Greater_Than_ThreeThousand_Throws_IndexOutOfRangeException_TestMethod()
        {
            // Arrange
            var converter = new RomanNumeralConverter();

            // Act
            // Assert
            Assert.Throws<IndexOutOfRangeException>(() => converter.ConvertRomanNumeral(3001));

        }

        [Fact]
        public void Number_Less_Than_One_Throws_IndexOutOfRangeException_TestMethod()
        {
            // Arrange
            var converter = new RomanNumeralConverter();

            // Act
            // Assert
            Assert.Throws<IndexOutOfRangeException>(() => converter.ConvertRomanNumeral(-1));
            

        }
    }            
}