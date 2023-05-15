using UnityEngine;

namespace BuilderPattern
{
    public class BurgerBuilderTest : MonoBehaviour
    {
        [SerializeField] private BurgerMeatType meatForBuilder = BurgerMeatType.Beef;
        [SerializeField] private BurgerMeatType meatForFluentBuilder = BurgerMeatType.Chicken;
        
        private BurgerBuilder burgerBuilder = new BurgerBuilder();
        private FluentBurgerBuilder fluentBurgerBuilder = new FluentBurgerBuilder();

        private void Start()
        {
            //Builder Pattern
            var meat = meatForBuilder.ToString();
            burgerBuilder.Cook(meat);
            burgerBuilder.AddKetchup();
            burgerBuilder.AddMustard();
            burgerBuilder.AddOnion();
            var burger = (Burger)burgerBuilder.GetBurger();
            burger.Show();
            
            //Fluent Builder Pattern
            var meat2 = meatForFluentBuilder.ToString();
            var burger2 = (Burger)fluentBurgerBuilder.Cook(meat2)
                .AddMayo()
                .AddPickle()
                .GetBurger();
            burger2.Show();
        }
    }
}