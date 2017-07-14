using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iisexpressmeetsxunit.portable
{
    public class RunIISExpress: IDisposable
    {
        public RunIISExpress()
        {

        }

        ~RunIISExpress()
        {
            this.Dispose(false);
        }

        private void Dispose(bool disposing)
        {

        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
