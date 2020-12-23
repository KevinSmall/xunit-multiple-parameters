using System;
using System.Collections.Generic;
using Xunit;

namespace CalculatorTests
{
    public static class TestParameters
    {
        public static IEnumerable<Tuple<int, int, int>> NumberDataSet()
        {
            yield return new Tuple<int, int, int>(1, 2, 3);
            yield return new Tuple<int, int, int>(-4, -6, -10);
        }

        public static IEnumerable<string> ModeDataSet()
        {
            yield return "scientific";
            yield return "normal";
        }

        public static IEnumerable<string> ModelDataSet()
        {
            yield return "T-800";
            yield return "T-900";
        }

        public static IEnumerable<object[]> MixerModeModelNumberData()
        {
            foreach (var mode in ModeDataSet())
            {
                foreach (var model in ModelDataSet())
                {
                    foreach (var numbers in NumberDataSet())
                    {
                        yield return new object[] { mode, model, numbers.Item1, numbers.Item2, numbers.Item3 };
                    }
                }
            }
        }

        public static IEnumerable<object[]> MixerModeModelData()
        {
            foreach (var mode in ModeDataSet())
            {
                foreach (var model in ModelDataSet())
                {
                    yield return new object[] { mode, model };
                }
            }
        }
    }
}