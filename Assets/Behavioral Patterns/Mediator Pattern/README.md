# Mediator Pattern
## *Intent*
Mediator Pattern used to reduce communication complexity between multiple objects or classes. This pattern provides a mediator class which normally handles all the communications between different classes and supports easy maintenance of the code by loose coupling. Mediator pattern falls under behavioral pattern category.

![Mediator Pattern](https://refactoring.guru/images/patterns/diagrams/mediator/structure.png)

:mag:
## *Applicability*
Use the Mediator pattern when
* a set of objects communicate in well-defined but complex ways. The resulting interdependencies are unstructured and difficult to understand.
* reusing an object is difficult because it refers to and communicates with many other objects.
* a behavior that's distributed between several classes should be customizable without a lot of subclassing.


:clipboard: 
## *How to implement*
1. Define the `Mediator` interface and declare the methods for communication between various components.
2. Implement concrete `Mediator` classes. They should perform the actual work of interconnecting the components. Because a mediator encapsulates protocols, it can change the way components interact with each other.
3. Declare the `Colleague` interface and describe the operations that each colleague class can perform.
4. Implement concrete `Colleague` classes. A concrete colleague class knows its mediator object, but it's not aware of other colleagues. It communicates with its mediator whenever it would have otherwise communicated with another colleague.
5. Create concrete mediator objects and components. Each component is initialized with the reference to the mediator object. Components only know about their mediator object and don't communicate with each other directly.
6. Clients create and configure mediators. It's up to clients to pass mediators to the components. Since a mediator encapsulates the interaction logic between components, it has to know about their behavior and references to all of their colleagues. The best place to initialize mediators is a component's constructor.
7. Clients work with components through their interfaces. A component sends notifications to its mediator when it wants to communicate with other components. A component doesn't know the mediator's concrete class. This lets you reuse components in other programs by linking them to different mediators.
8. The mediator receives notifications from its components and reacts accordingly.

