using System.Collections.Generic;

namespace IteratorPattern
{
    public class CoinIterator : IIterator<Coin>
    {
        private List<Coin> coins;
        private int currentPosition = 0;

        public CoinIterator(List<Coin> coins)
        {
            this.coins = coins;
        }

        public bool HasNext()
        {
            return currentPosition < coins.Count;
        }

        public Coin Next()
        {
            Coin coin = coins[currentPosition];
            currentPosition++;
            return coin;
        }
    }
}