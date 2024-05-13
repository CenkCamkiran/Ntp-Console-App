using GuerrillaNtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtpClient
{
    public class NtpHelper
    {
        public NtpClock QueryWithBackoff(GuerrillaNtp.NtpClient client)
        {
            var delay = TimeSpan.FromSeconds(1);
            while (true)
            {
                try
                {
                    return client.Query();
                }
                catch
                {
                    Thread.Sleep(delay);
                    delay = 2 * delay;
                }
            }
        }
    }
}
