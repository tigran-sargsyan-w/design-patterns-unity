using UnityEngine;

namespace CompositePattern
{
    public class CompositeTest : MonoBehaviour
    {
        private void Start()
        {
            Car car = new Car();
            CarBody carBody = new CarBody();
            Engine engine = new Engine();
            Flywheel flywheel = new Flywheel();
            Piston piston = new Piston();
            
            engine.Add(flywheel);
            engine.Add(piston);
            
            car.Add(carBody);
            car.Add(engine);
            
            //piston.Display();
            engine.Display();
            //car.Display();
        }
    }
}