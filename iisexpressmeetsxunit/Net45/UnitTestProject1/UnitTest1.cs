

using iisexpressmeetsxunit.net45;
using System;
using Xunit;

namespace UnitTestProject45
{
    [CollectionDefinition(Const)]
    public class A  : RunIISExpressCollection
    {

    }

    [Collection(RunIISExpressCollection.Const)]
    public class UnitTest1
    {
        public UnitTest1(RunIISExpress iis)
        {
            m_IIS = iis;
        }

        RunIISExpress m_IIS;

        [Fact]
        public void TestMethod1()
        {
            Assert.True(m_IIS != null);
        }
    }
}
