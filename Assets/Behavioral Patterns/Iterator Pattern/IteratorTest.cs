using UnityEngine;

namespace IteratorPattern
{
    public class IteratorTest : MonoBehaviour
    {
        Wallet wallet = new Wallet();
        
        private void Start()
        {
            FillUpWallet();
            DisplayCoins();
        }

        private void FillUpWallet()
        {
            wallet.AddCoin(new Coin(1));
            wallet.AddCoin(new Coin(5));
            wallet.AddCoin(new Coin(10));
            wallet.AddCoin(new Coin(25));
            wallet.AddCoin(new Coin(50));
            wallet.AddCoin(new Coin(100));
        }

        private void DisplayCoins()
        {
            IIterator<Coin> iterator = wallet.GetIterator();
            while (iterator.HasNext())
            {
                Coin coin = iterator.Next();
                coin.DisplayValue();
            }
        }
    }
}