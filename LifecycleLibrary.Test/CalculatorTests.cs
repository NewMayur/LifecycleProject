using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LifecycleLibrary.Test
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(4, 2, 2)]
        public void Divide_SimpleValueShouldCalculate(double x, double y, double expected)
        {
            //Arrange

            //Act
            double actual = Calculator.Divide(x, y);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
