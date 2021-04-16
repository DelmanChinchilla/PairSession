using System;
using Xunit;

namespace PairSession.Tests
{
    public class Should_return
    {
        [Fact]
        public void should_return_true_if_number_is_an_even()
        {
           bool result = Service.isAnEvenNumber(2);
           Assert.True(result, "it should be an even number");
        }

        [Fact]
        public void should_return_true_if_subtraction_is_positive()
        {
           bool result = Service.isPositiveResult(10,5);
           Assert.True(result, "it should be positive");
        }
        
    }
}
