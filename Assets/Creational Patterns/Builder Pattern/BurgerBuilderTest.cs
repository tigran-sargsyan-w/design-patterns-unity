using System;
using UnityEngine;

namespace BuilderPattern
{
    public class BurgerBuilderTest : MonoBehaviour
    {
        private BurgerBuilder burgerBuilder = new BurgerBuilder();

        private void Start()
        {
            Burger burger = new Burger();
            burgerBuilder.AddPart1();
            //burgerBuilder.AddPart2();
            burgerBuilder.AddPart3();
            burger = (Burger) burgerBuilder.GetProduct();
            burger.Show();
        }
    }
}