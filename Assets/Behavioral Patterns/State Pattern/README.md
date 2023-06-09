# State Pattern
## *Intent*
State Pattern used to change the behavior of an object when its internal state changes. The object will appear to change its class.

![State Pattern](https://refactoring.guru/images/patterns/diagrams/state/structure-ru.png)

:mag:
## *Applicability*
State Pattern should be used when:
* An object's behavior depends on its state, and it must change its behavior at run-time depending on that state.
* Operations have large, multipart conditional statements that depend on the object's state. This state is usually represented by one or more enumerated constants. Often, several operations will contain this same conditional structure. The State pattern puts each branch of the conditional in a separate class. This lets you treat the object's state as an object in its own right that can vary independently from other objects.


:clipboard: 
## *How to implement*
1. Identify an existing class, or create a new class, that will serve as the "state machine" from the client's perspective. That class is the "wrapper" class.

