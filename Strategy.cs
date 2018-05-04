using System;
using RemoteBotClient;

namespace ForSale.StarterBot.DotnetCore {
    public class Strategy {
        
        private readonly Random _random = new Random();

        public string BotName { get; set; }
        public int HighestBid { get; set; }

        public int? NextMove()
        {
            var random = _random.NextDouble();
            
            if (random >= 0.5)
            {
                var bid = HighestBid + 1;
                return bid;
            }
    
            return null;
        }
    }
}
