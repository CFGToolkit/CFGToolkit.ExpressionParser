using System.Collections.Generic;
using Xunit;

namespace CFGToolkit.ExpressionParser.Tests
{
    public class BasicTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void Parse(string expression)
        {
            var result = ExpressionParser.Parse(expression, ExpressionLanguage.C);
            Assert.NotNull(result);
        }

        public static IEnumerable<object[]> Data => new List<object[]>
        {
                new object[] { @"1+1" },
                new object[] { @"5++" },
                new object[] { @"x++" },
                new object[] { @"--x" },
                new object[] { @"+1+1" },
                new object[] { @"-1+1" },
                new object[] { @"2*3+1" },
                new object[] { @"5-3*5" },
                new object[] { @"a[1] * 3" },
                new object[] { @"a[b] * 3" },
                new object[] { @"a == 1 ? 3 : 4" },
                new object[] { @"a == 1 ? b == 3 ? 4 : 3 : 1" },
                new object[] { @"a[1] * 3 == 4" },
                new object[] { @"a[x+3*4] * 3 == 4" },
                new object[] { @"!(a[1] * 3 == 4)" },
                new object[] { @"!false" },
                new object[] { @"!true" },
                new object[] { @"(1 == 2) || (3 == 3)" }
        };
    }
}
