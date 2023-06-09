using System.Collections;
using System.Collections.Generic;

namespace IteratorPattern
{
    public class Wallet : IEnumerable<Coin>
    {
        private List<Coin> coins = new List<Coin>();

        public void AddCoin(Coin coin)
        {
            coins.Add(coin);
        }

        public IIterator<Coin> GetIterator()
        {
            return new CoinIterator(coins);
        }

        public IEnumerator<Coin> GetEnumerator()
        {
            return coins.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}