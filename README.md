# Design Patterns in Unity

This repository provides comprehensive implementations of widely used design patterns in Unity, based on the well-known Gang of Four (GoF) design patterns. These patterns are categorized into three main types: Behavioral, Creational, and Structural patterns. Each folder within the repository contains a detailed implementation of a specific design pattern, along with a brief explanation of its purpose, key principles, and real-world use cases in game development. By exploring the various patterns, you will gain insights into how to solve common software design problems in an efficient and scalable way, using the Unity game development engine.

## Behavioral Patterns
Behavioral design patterns focus on algorithms and the delegation of responsibilities between objects.

- **[Chain of Responsibility Pattern](./Assets/Behavioral%20Patterns/Chain%20Of%20Responsibility%20Pattern/README.md):** Allows requests to be passed along a chain of handlers.
- **[Command Pattern](./Assets/Behavioral%20Patterns/Command%20Pattern/README.md):** Encapsulates a request as an object, enabling parameterization and queuing of requests.
- **[Iterator Pattern](./Assets/Behavioral%20Patterns/Iterator%20Pattern/README.md):** Provides a way to sequentially access elements in a collection without exposing its underlying structure.
- **[Mediator Pattern](./Assets/Behavioral%20Patterns/Mediator%20Pattern/README.md):** Defines an object that manages interactions between other objects to reduce dependencies.
- **[Memento Pattern](./Assets/Behavioral%20Patterns/Memento%20Pattern/README.md):** Captures the state of an object without revealing its structure, allowing the object to be restored later.
- **[Observer Pattern](./Assets/Behavioral%20Patterns/Observer%20Pattern/README.md):** Allows one object to notify other objects about changes in its state.
- **[State Pattern](./Assets/Behavioral%20Patterns/State%20Pattern/README.md):** Allows an object to change its behavior when its internal state changes.
- **[Strategy Pattern](./Assets/Behavioral%20Patterns/Strategy%20Pattern/README.md):** Defines a family of algorithms and makes them interchangeable.
- **[Template Method Pattern](./Assets/Behavioral%20Patterns/Template%20Method%20Pattern/README.md):** Defines the skeleton of an algorithm, allowing certain steps to be overridden by subclasses.
- **[Visitor Pattern](./Assets/Behavioral%20Patterns/Visitor%20Pattern/README.md):** Allows operations to be performed on objects of different types without modifying their classes.

## Creational Patterns
Creational design patterns provide various mechanisms for object creation, promoting flexibility and reusability of existing code.

- **[Abstract Factory Pattern](./Assets/Creational%20Patterns/Abstract%20Factory%20Pattern/README.md):** Provides an interface for creating families of related or dependent objects without specifying their concrete classes.
- **[Builder Pattern](./Assets/Creational%20Patterns/Builder%20Pattern/README.md):** Separates the construction of a complex object from its representation, allowing the same construction process to create different representations.
- **[Factory Method Pattern](./Assets/Creational%20Patterns/Factory%20Method%20Pattern/README.md):** Defines an interface for creating an object, but lets subclasses decide which class to instantiate.
- **[Prototype Pattern](./Assets/Creational%20Patterns/Prototype%20Pattern/README.md):** Specifies the kinds of objects to create using a prototypical instance and creates new objects by copying this prototype.
- **[Singleton Pattern](./Assets/Creational%20Patterns/Singleton%20Pattern/README.md):** Ensures a class has only one instance and provides a global point of access to it.

## Structural Patterns
Structural design patterns explain how to assemble objects and classes into larger structures while maintaining flexibility and efficiency.

- **[Adapter Pattern](./Assets/Structural%20Patterns/Adapter%20Pattern/README.md):** Converts one interface into another expected by the client.
- **[Bridge Pattern](./Assets/Structural%20Patterns/Bridge%20Pattern/README.md):** Decouples an abstraction from its implementation, allowing the two to vary independently.
- **[Composite Pattern](./Assets/Structural%20Patterns/Composite%20Pattern/README.md):** Allows you to compose objects into tree-like structures to represent part-whole hierarchies.
- **[Decorator Pattern](./Assets/Structural%20Patterns/Decorator%20Pattern/README.md):** Adds responsibilities to an object dynamically, without modifying its structure.
- **[Facade Pattern](./Assets/Structural%20Patterns/Facade%20Pattern/README.md):** Provides a simplified interface to a complex subsystem.
- **[Flyweight Pattern](./Assets/Structural%20Patterns/Flyweight%20Pattern/README.md):** Reduces the number of objects created by sharing objects that have the same state.
- **[Proxy Pattern](./Assets/Structural%20Patterns/Proxy%20Pattern/README.md):** Provides a surrogate or placeholder for another object to control access to it.

## How to Use

1. Clone the repository to your local machine:

   ```bash
   git clone https://github.com/tigran-sargsyan-w/design-patterns-unity.git
   ```
2. Open the project in Unity.

3. Navigate to the corresponding pattern folder to explore the implementation.

## Contributing

Feel free to fork the repository, create an issue for bugs or feature requests, and submit pull requests for improvements.
