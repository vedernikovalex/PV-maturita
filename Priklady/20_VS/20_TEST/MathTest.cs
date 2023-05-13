namespace _20_TEST;
using static VS_20;

[TestClass]
public class MathTest { 

    [TestMethod]
    public void TestSum()
    {
        int a = 2;
        int b = 3;
        int expected_result = a + b;
        int result = SumTwoNumbers(a,b);
        Assert.AreEqual(result, expected_result);
    }
}
