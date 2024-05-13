using GuerrillaNtp;
using NtpClient;

GuerrillaNtp.NtpClient client = GuerrillaNtp.NtpClient.Default;
NtpHelper ntpHelper = new NtpHelper();

while (true)
{
    NtpClock clock = ntpHelper.QueryWithBackoff(client); // see example above

    DateTimeOffset local = clock.Now;
    DateTimeOffset utc = clock.UtcNow;

    DateTime localDate = clock.Now.LocalDateTime;
    DateTime utcDate = clock.UtcNow.UtcDateTime;

    Console.WriteLine("Local Now Date: " + local);
    Console.WriteLine("Utc Now Date: " + utc);
    Console.WriteLine("LocalDate Now Date: " + localDate);
    Console.WriteLine("UtcDate Now Date: " + utcDate);

    Thread.Sleep(TimeSpan.FromDays(1));
}
