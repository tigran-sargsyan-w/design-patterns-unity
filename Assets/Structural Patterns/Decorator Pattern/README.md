# Decorator Pattern
## *Intent*
Decorator used to attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.


![Decorator Pattern](https://refactoring.guru/images/patterns/diagrams/decorator/structure.png)

:mag:
## *Applicability*
Use the Decorator pattern when you need to be able to assign extra behaviors to objects at runtime without breaking the code that uses these objects.


:clipboard: 
## *How to implement*
1. Ensure that your business domain can be represented as a primary component with multiple optional layers over it. Concrete components must be decoupled from the concrete decorators via abstraction. Thus, you can easily attach or detach decorators without affecting the code of the components.
2. Declare the decorator interface and describe a wrapping interface. The wrapping interface must have a field for storing a reference to a wrapped object. The wrapping interface’s methods must delegate the real work to the wrapped object.
3. Create concrete components. They must implement the component interface.
4. Create base decorators by following the same steps as for the components. Make sure they follow the wrapping interface.
5. Create concrete decorators by extending them from the base decorator. A concrete decorator must execute its behavior before or after the call to the parent method (which always delegates to the wrapped object).
6. The client code must be responsible for creating decorators and composing them in the way the client needs.
7. The client code must use the wrapping interface to interact with all objects in the composition.
8. As a result, we’ll get a stack of objects with a similar interface. The client doesn’t really know whether it works with a simple component or a decorator, since they both follow the same interface.


