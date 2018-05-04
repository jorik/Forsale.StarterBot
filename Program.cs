using System;
using System.IO;
using RemoteBotClient;

namespace ForSale.StarterBot.DotnetCore 
{
    public static class Program
    {
        // Also put the API key in the Makefile, if you haven't done so already
        private const string ApiKey = "your-api-key";
    
        public static void Main(string[] args)
        {
            var botInterface = RemoteBotClientInitializer.Init(ApiKey, forceLocal: false);

            new Session().Run(botInterface);
        }
    }
}
