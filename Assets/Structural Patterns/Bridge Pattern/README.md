# Bridge Pattern
## *Intent*
Bridge Pattern used to decouple an abstraction from its implementation so that the two can vary independently.

![Bridge Pattern](https://refactoring.guru/images/patterns/diagrams/bridge/structure-ru.png)

:mag:
## *Applicability*
Use the Bridge pattern when:
* you want to avoid a permanent binding between an abstraction and its implementation. This might be the case, for example, when the implementation must be selected or switched at run-time.
* both the abstractions and their implementations should be extensible by subclassing. In this case, the Bridge pattern lets you combine the different abstractions and implementations and extend them independently.
* changes in the implementation of an abstraction should have no impact on clients; that is, their code should not have to be recompiled.
* (C++) you want to hide the implementation of an abstraction completely from clients. In C++ the representation of a class is visible in the class interface.
* you have a proliferation of classes. Such a class hierarchy indicates the need for splitting an object into two parts. Rumbaugh uses the term "nested generalizations" to refer to such class hierarchies.
* you want to share an implementation among multiple objects (perhaps using reference counting), and this fact should be hidden from the client. A simple example is Coplien's String class, in which multiple objects can share the same string representation (StringRep).
* you need to map orthogonal class hierarchies.
* you want to work with multiple platforms, possibly using the same code for each (e.g., a graphics package that supports both Windows and Motif).
* you have a pervasive dependency that runs in both directions. The classic example is the relationship between Window and WindowImp in the windowing system of a user interface. WindowImp depends on Window for the window management operations it provides. Window depends on WindowImp for its platform-specific operations.
* you want to be able to change the abstraction and the implementation independently.


:clipboard: 
## *How to implement*
1. Identify the orthogonal dimensions in your classes. These independent concepts could be: abstraction/platform, domain/infrastructure, front-end/back-end, or interface/implementation.
2. See what operations the client needs and define them in the base abstraction class.
3. Determine the operations available on all platforms. Declare the ones that the abstraction needs in the general implementation interface.
4. For each platform in the application domain, create a platform-specific implementation class that implements the platform-specific versions of the operations in the implementation interface.
5. Define a derived class of the abstraction class for each platform, and compose it with the platform-specific implementation object.
6. The client should instantiate the desired abstraction and pass it to the client.
7. The client code should only depend on the abstraction class. This way the client code can support any abstraction-implementation combination.
8. The abstraction object forwards client requests to its implementation object.
9. The abstraction and implementation objects can be independently extended or composed, and the system can be configured at run-time with any combination desired.
10. The client deals with only the abstraction part of the two classes. The client can change the abstraction-implementation pairing at run-time.
11. The abstraction classes act as liaison between the client and the implementation classes.

