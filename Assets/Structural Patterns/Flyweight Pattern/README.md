# Flyweight Pattern
## *Intent*
Flyweight used to minimize memory usage or computational expenses by sharing as much as possible with similar objects.

![Flyweight Pattern](https://refactoring.guru/images/patterns/diagrams/flyweight/structure.png)

:mag:
## *Applicability*
Use the Flyweight pattern only when your program must support a huge number of objects which barely fit into available RAM.


:clipboard: 
## *How to implement*
1. Divide fields of a class that can be turned into flyweight into two parts:
2. The intrinsic state: fields that contain unchanging, context-independent data.
3. The extrinsic state: fields that contain contextual data unique to each flyweight.
4. Leave the fields that represent the intrinsic state in the class, but make sure they’re immutable. They should only be set during object construction, and never modified afterward.
5. Go over methods that use fields of the flyweight. For each field used in the method, introduce a new parameter and use it instead of the field.
6. Optionally, create a factory class to manage the pool of flyweights. It should check for an existing flyweight before creating a new one. Once the factory is in place, clients must only request flyweights through it. They should describe the desired flyweight by passing its intrinsic state to the factory.
7. The client must store or calculate values of the extrinsic state (context) to be able to call methods of flyweight objects. Alternatively, the context can be passed to the flyweight’s methods along with the rest of the parameters. However, the first approach is preferable because it allows clients to reuse flyweights in different contexts.
8. The client calculates or saves the extrinsic state and passes it to the flyweight’s methods.
9. The client should be able to work with the flyweight object just like with any other flyweight.
10. Optionally, implement the sharing behavior inside flyweight objects. To do this, you need to keep track of the existing flyweights. Upon receiving a request, the flyweight object should look for an appropriate flyweight. If it can’t find one, it should create a new flyweight. If it does find one, it should return the existing object.
11. The client must use the factory instead of the new operator to request flyweights. The rest of the code stays the same.
12. The client must pass the requested flyweight to all of the code that previously held the flyweight’s state. The client should either reset the state of the flyweight object or discard it completely, if the context of the flyweight is no longer needed.
13. The client should be able to work with the flyweight object just like with any other flyweight.

