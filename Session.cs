using System;
using RemoteBotClient;

namespace ForSale.StarterBot.DotnetCore 
{
    public class Session 
    {
        public void Run(IBotInterface botInterface) 
        {
            string line;
      
            var strategy = new Strategy();
            
            botInterface.Log($"Started default-bot for ForSale.");
            
            while ((line = botInterface.ReadLine()) != null) {
                
                if (line == string.Empty) continue;
                var parts = line.ToLower().Split(' ');

                Console.WriteLine($"READ: {line}");
                
                switch (parts[0]) {
                    case "settings":
                        switch (parts[1]) {
                            case "your_bot":
                                strategy.BotName = parts[2];
                                break;
                        }
                        break;
                    case "match":
                        switch (parts[1]) {
                            case "highest_bid":
                                strategy.HighestBid = int.Parse(parts[2]);
                                break;
                        }
                        break;
                    case "action":
                        var amount = strategy.NextMove();
                        var action = amount.HasValue ? $"bid {amount}" : "take";
                        
                        botInterface.WriteLine(action);
                        Console.WriteLine($"WRITE: action");
                        break;
                }
            }
        }
    }
}
