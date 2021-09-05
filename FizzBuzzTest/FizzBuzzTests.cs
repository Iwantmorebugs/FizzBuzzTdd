using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzTests
    {
        private readonly FizzBuzz.FizzBuzz _sut;

        public FizzBuzzTests()
        {
            _sut = new FizzBuzz.FizzBuzz();
        }

        [Fact]
        public void Given1ThenExpectResultIsNull()
        {
            var expected = string.Empty;
            var result = _sut.DoFizzBuzz(1);
            result.Should().Be(expected);
        }

        [Fact]
        public void Given3ThenExpectResultIFizz()
        {
            var expected = "Fizz";
            var result = _sut.DoFizzBuzz(3);
            result.Should().Be(expected);
        }

        [Fact]
        public void Given5ThenExpectResultIFizz()
        {
            var expected = "Buzz";
            var result = _sut.DoFizzBuzz(5);
            result.Should().Be(expected);
        }

        [Fact]
        public void Given15ThenExpectResultIFizzBuzz()
        {
            var expected = "FizzBuzz";
            var result = _sut.DoFizzBuzz(15);
            result.Should().Be(expected);
        }

        [Fact]
        public void Given0ThenItShouldThrowIndexOutOfRangeException()
        {
            Action act = () => _sut.DoFizzBuzz(0);
            act.Should().Throw<IndexOutOfRangeException>();
        }
    }
}
