using Loggr;
using NLog;
namespace ConsoleApplication4
{
    class Program
    {
        public static readonly Logger log = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            Events.Create().Text("helloworld").Post();

            log.Error("ERROR WORLD");
        }
    }
}
