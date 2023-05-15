using UnityEngine;

namespace PrototypePattern
{
    public class PrototypeTest: MonoBehaviour
    {
        [SerializeField] private string name = "";
        [SerializeField] private int health = 100;
        [SerializeField] private int damage = 10;
        private void Start()
        {
            var warrior = new Warrior(name, health, damage);
            Debug.Log($"The origin warrior name is {warrior.Name} " +
                      $"with health {warrior.Health} and damage {warrior.Damage}");
            //Simple Clone
            var warriorClone = warrior.Clone();
            Debug.Log($"The clone warrior name is {warriorClone.Name} " +
                      $"with health {warriorClone.Health} and damage {warriorClone.Damage}");
            //Deep Clone
            var warriorDeepClone = warrior.DeepClone("Archer", 200, 20);
            Debug.Log($"The deep clone warrior name is {warriorDeepClone.Name} " +
                      $"with health {warriorDeepClone.Health} and damage {warriorDeepClone.Damage}");
        }
    }
}