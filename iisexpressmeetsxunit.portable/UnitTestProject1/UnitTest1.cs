
using iisexpressmeetsxunit.portable;
using System;
using Xunit;

namespace UnitTestProject1
{
    [CollectionDefinition(RunIISExpressCollection.Const)]
    public class A  : RunIISExpressCollection
    {

    }


    [Collection("DbCollection")]
    public class UnitTest1
    {
        public UnitTest1(RunIISExpress a)
        {

        }

        [Fact]
        public void TestMethod1()
        {
        }
    }
}
