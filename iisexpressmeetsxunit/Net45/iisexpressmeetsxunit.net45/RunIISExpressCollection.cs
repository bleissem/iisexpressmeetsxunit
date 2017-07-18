using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace iisexpressmeetsxunit.net45
{    
    public abstract class RunIISExpressCollection: ICollectionFixture<RunIISExpress>
    {
        public const string Const = "RunIISExpressCollection";
    }
}
