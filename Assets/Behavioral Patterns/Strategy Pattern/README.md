# Strategy Pattern
## *Intent*
Strategy Pattern used to define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

![Strategy Pattern](https://refactoring.guru/images/patterns/diagrams/strategy/structure.png)

:mag:
## *Applicability*
Strategy Pattern should be used when:
* Use the Strategy pattern when you want to use different variants of an algorithm within an object and be able to switch from one algorithm to another during runtime.
* Use the Strategy when you have a lot of similar classes that only differ in the way they execute some behavior.
* Use the pattern to isolate the business logic of a class from the implementation details of algorithms that may not be as important in the context of that logic.
* Use the pattern when your class has a massive conditional operator that switches between different variants of the same algorithm.
* Use the pattern to implement the `Open/Closed Principle`. Each algorithm is implemented in its own class, which can be used independently from other classes.
* Use the pattern when an algorithm uses data that clients shouldn’t know about. Use the Strategy pattern when you want to use different variants of an algorithm within an object and be able to switch from one algorithm to another during runtime.


:clipboard: 
## *How to implement*
1. Make sure that the Context class can work with strategies via some generic interface. Usually, this interface declares a single method for executing the algorithm.
2. One by one, extract all algorithms into their own classes. They should all follow the same interface, which forces them to implement the behavior consistently.
3. Declare the strategy interface in the Context class.
4. Add a setter for replacing values of the strategy field. This setter can be used by clients to inject the desired behavior into the context.
5. Clients should create specific strategy objects and pass them to the context via the setter method. It’s possible to swap strategies inside the context at runtime.
6. The context delegates the work to a linked strategy object instead of executing it on its own.
7. Clients should put the objects into the context that correspond to the desired behavior. The context should not configure objects on its own, choosing a strategy should be the client’s responsibility.
8. The context should work with the strategy objects only via the strategy interface. This way the context isn’t coupled to concrete strategies, which makes it easier to reuse these classes in other contexts.
9. The context might define some helper methods for working with strategies. These methods can help clients avoid working with the context class directly.
10. The context forwards some requests to the strategy object, instead of implementing multiple versions of the algorithm on its own.
11. The strategy interface lets the strategy be swapped at runtime. It also lets the strategy object access the data stored in the context, but only when the context explicitly exposes some of its internal state through the strategy interface.
12. The concrete strategy classes implement different variations of an algorithm the context uses. The strategy object often doesn’t contain any state of its own and relies on the context to provide it with any required data.
13. The context isn’t responsible for creating strategy objects and passing them to the context. Instead, clients of the context choose which strategy to use and then pass it to the context. This makes the context independent of how strategies are created and composed.
14. The context usually doesn’t know the concrete classes of strategies it works with. It should work with all strategies via the strategy interface. Usually, the context accepts strategies via the constructor, but some contexts may also provide setters for injecting the strategy into the context.
15. The context may define an interface that lets strategies access its data.
16. The context passes all data required by strategies via this interface. It’s the context’s responsibility to choose which data to pass to which strategy. The context should not expose its internal data directly to the strategies, otherwise, you’d be breaking the Encapsulation principle.
17. The context should only expose the data that’s required by a strategy. It’s the context’s responsibility to choose which data to pass to which strategy. The context should not expose its internal data directly to the strategies, otherwise, you’d be breaking the Encapsulation principle.

