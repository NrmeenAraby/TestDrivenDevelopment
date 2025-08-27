using Domain;
using FluentAssertions;
namespace CalculatorTest
{
    public class UnitTest1
    {
        [Fact]
        /*public void sum_of_2_and_2_should_be_4()
        {
            var calculator = new Calculator();
            int result = calculator.Sum(2, 2);
            //if(result != 4)
            //{
            //    throw new Exception($"The Sum(2,2) was expected to be 4, but it's {result} . "); 
            //}

            //use fluent assertion instead of the if condition
            result.Should().Be(4);
        */

        // That optmization (to shorten this method)
        public void sum_of_2_and_2_should_be_4()
            => new Calculator().Sum(2, 2).Should().Be(4);




    }
}