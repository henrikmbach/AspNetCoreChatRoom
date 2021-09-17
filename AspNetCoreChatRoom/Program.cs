using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace AspNetCoreChatRoom
{
  public class Program
  {
    public static void Main(string[] args)
    {
      CreateWebHostBuilder(args).Build().Run();
    }

    private static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
      WebHost.CreateDefaultBuilder(args)
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        // According to this: https://www.tutorialspoint.com/what-is-the-use-of-useiisintegration-in-chash-asp-net-core
        // Until Asp.Net 2.2 there were 2 processes, so UseIISIntegration was needed to do some reverse proxy stuff.
        // TODO after project has been upgraded to Asp.Net version after 2.2 remove this line:
        .UseIISIntegration()
        .UseStartup<Startup>();
  }
}
