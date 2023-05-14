using UnityEngine;

namespace BuilderPattern
{
    public class BurgerBuilderTest : MonoBehaviour
    {
        [SerializeField] BurgerMeatType meatType = BurgerMeatType.Beef;
        private BurgerBuilder burgerBuilder = new BurgerBuilder();

        private void Start()
        {
            var meat = meatType.ToString();
            burgerBuilder.Cook(meat);
            burgerBuilder.AddKetchup();
            burgerBuilder.AddMustard();
            burgerBuilder.AddOnion();
            var burger = (Burger)burgerBuilder.GetBurger();
            burger.Show();
        }
    }
}