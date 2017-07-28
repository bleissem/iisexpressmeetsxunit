using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace iisexpressmeetsxunit.net45
{
    public class RunIISExpress: IDisposable
    {
        public RunIISExpress()
        {
            this.RunIIS();
        }

        ~RunIISExpress()
        {
            this.Dispose(false);
        }

        private Process m_Process;

        private void RunIIS()
        {
            IISConfig config = new IISConfig();

            ProcessStartInfo psi = new ProcessStartInfo()
            {
                CreateNoWindow = true,
                LoadUserProfile = true,
                UseShellExecute = true
            };

            m_Process = Process.Start(psi);

        }

        private void Dispose(bool disposing)
        {
            if (null != m_Process)
            {
                try
                {
                    m_Process.Kill();
                    m_Process.Dispose();
                }
                catch
                {

                }
                
                m_Process = null;
            }

        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
