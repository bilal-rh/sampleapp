namespace sampleapp.Tests;
using sampleapp;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
      MyService myService = new MyService();

            bool result = true;

            Assert.False(result, "1 should not be prime");
    }
}