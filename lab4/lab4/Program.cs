
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using lab4.Utils;
using lab4;

namespace lab3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DbInitializationUtil.Init();

            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
