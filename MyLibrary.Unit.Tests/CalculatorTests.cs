using FluentAssertions;
using Xunit;

namespace MyLibrary.Unit.Tests
{
    //RED => GREEN => REFACTOR
    public class CalculatorTests
    {
        [Fact]
        public void Add_should_return_3_when_inputs_are_1_and_2()
        {
            //Fixture Setup
            var calculator = new Calculator();

            //Exersice
            var result = calculator.Add(1, 2);

            //Verify
            result.Should().Be(3);
        }

        [Fact]
        public void Add_should_return_5_when_inputs_are_3_and_2()
        {
            //Fixture Setup
            var calculator = new Calculator();

            //Exersice
            var result = calculator.Add(3, 2);

            //Verify
            result.Should().Be(5);
        }

        [Fact]
        public void Add_should_return_150_when_inputs_are_148_and_2()
        {
            //Fixture Setup
            var calculator = new Calculator();

            //Exersice
            var result = calculator.Add(148, 2);

            //Verify
            result.Should().Be(150);
        }

        [Fact]
        public void Sub_should_return_0_when_inputs_are_1_and_1()
        {
            //Fixture Setup
            var calculator = new Calculator();

            //Exersice
            var result = calculator.Sub(1, 1);

            //Verify
            result.Should().Be(0);
        }

        [Fact]
        public void Sub_should_return_1_when_inputs_are_2_and_1()
        {
            //Fixture Setup
            var calculator = new Calculator();

            //Exersice
            var result = calculator.Sub(2, 1);

            //Verify
            result.Should().Be(1);
        }

        [Fact]
        public void Sub_should_return_100_when_inputs_are_200_and_100()
        {
            //Fixture Setup
            var calculator = new Calculator();

            //Exersice
            var result = calculator.Sub(200, 100);

            //Verify
            result.Should().Be(100);
        }

        [Fact]
        public void Sub_should_return__2_when_inputs_are__4_and__2()
        {
            //Fixture Setup
            var calculator = new Calculator();

            //Exersice
            var result = calculator.Sub(-4, -2);

            //Verify
            result.Should().Be(-2);
        }

        [Fact]
        public void Multiple_should_return_4_when_inputs_are_2_and_2()
        {
            //Fixture Setup
            var calculator = new Calculator();

            //Exersice
            var result = calculator.Multiple(2, 2);

            //Verify
            result.Should().Be(4);
        }

        [Fact]
        public void Multiple_should_return_6_when_inputs_are_2_and_3()
        {
            //Fixture Setup
            var calculator = new Calculator();

            //Exersice
            var result = calculator.Multiple(2, 3);

            //Verify
            result.Should().Be(6);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 2, 4)]
        [InlineData(8, 6, 14)]
        public void Add_Tests(int a, int b, long expected)
        {
            //Fixture Setup
            var calculator = new Calculator();

            //Exersice
            var result = calculator.Add(a, b);

            //Verify
            result.Should().Be(expected);
        }


        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 2, 6)]
        [InlineData(30, 20, 600)]
        public void Multiple_Tests(int a, int b, long expected)
        {
            //Fixture Setup
            var calculator = new Calculator();

            //Exersice
            var result = calculator.Multiple(a, b);

            //Verify
            result.Should().Be(expected);
        }
    }
}
