using System;
using System.Collections.Generic;
using Xunit;

namespace CalculatorTests
{
    public class Calculator
    {
        public Calculator(string mode, string model) { }
        public int Add(int value1, int value2) => value1 + value2;
        public bool SwitchOn() => true;
        public bool SwitchOff() => true;
    }

    public class CalculatorTest
    {
        [Theory]
        [MemberData(nameof(TestParameters.MixerModeModelNumberData), MemberType = typeof(TestParameters))]
        public void CanAdd(string mode, string model, int num1, int num2, int num3)
        {
            var calculator = new Calculator(mode, model);
            var result = calculator.Add(num1, num2);
            Assert.Equal(num3, result);
        }

        [Theory]
        [MemberData(nameof(TestParameters.MixerModeModelData), MemberType = typeof(TestParameters))]
        public void CanSwitchOnOff(string mode, string model)
        {
            var calculator = new Calculator(mode, model);
            var result = calculator.SwitchOn();
            Assert.True(result);
            result = calculator.SwitchOff();
            Assert.True(result);
        }
    }
}