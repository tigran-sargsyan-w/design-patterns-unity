# Composite Pattern
## *Intent*
Composite used to compose objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly.

![Composite Pattern](https://refactoring.guru/images/patterns/diagrams/composite/structure-ru.png)

:mag:
## *Applicability*
Use the Composite pattern when:
- you want to represent part-whole hierarchies of objects.
- you want clients to be able to ignore the difference between compositions of objects and individual objects. Clients will treat all objects in the composite structure uniformly.
- If you find that you are using multiple objects in the same way, and often have nearly identical code to handle each of them, then composite is a good choice, it is less complex in this situation to treat primitives and composites as homogeneous.
- If you want to be able to ignore the difference between compositions of objects and individual objects, clients will treat all objects in the composite structure uniformly.
- If you want to be able to add and remove objects dynamically. A composite tree structure can be changed at runtime.
- If you want to be able to traverse the tree and perform operations on the nodes of the tree.
- If you want to have only one class with a single interface that can be used for both compositions of objects and individual objects.
- If you want that the code should be able to treat both types of objects uniformly.


:clipboard: 
## *How to implement*
1. Declare the component interface with a list of methods that make sense for both simple and complex components.
2. Create a leaf class to represent simple components. A leaf object can’t have any children.
3. Create a container class to represent complex components. A container object can contain leaf objects and other containers.


