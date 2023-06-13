# Memento Pattern
## *Intent*
Memento Pattern used to restore an object to its previous state (undo via rollback).

![Memento Pattern](https://refactoring.guru/images/patterns/diagrams/memento/structure1.png)

:mag:
## *Applicability*
Memento Pattern is used when:
- a snapshot of (some portion of) an object's state must be saved so that it can be restored to that state later, and
- a direct interface to obtaining the state would expose implementation details and break the object's encapsulation.

:clipboard: 
## *How to implement*
1. Decide what state must be saved.
2. Decide what classes must know about the Memento.
3. Design a Memento class that stores the state of the originator.
4. Originator is the object that has an internal state that may change. It also defines the method for saving the state object in the Memento and the method for restoring the state object from the Memento.
5. Caretaker is the object that knows why and when the Originator needs to save and restore itself to and from the Memento. It holds the Memento but never modifies it.
6. Design a class that is responsible for storing the Mementos. This class is called the Caretaker.
7. The Caretaker is responsible for the Memento's safekeeping but never operates on or examines the contents of a Memento.
8. The Caretaker keeps track of the originator's history (that is, sequence of Mementos) so that you can reuse the Originator's state if necessary.
9. The Caretaker is the only object that can access the Memento, except for the Originator.
10. The Memento may expose a few of its members to other objects, but only to the Originator or Caretaker.
11. The Memento pattern does not necessarily require that the state of the Originator be immutable. However, for the sake of simplicity and clarity, the Originator's state should be immutable.
12. The Memento pattern is often used in conjunction with the Command pattern. An Undo operation can be done by restoring the object to its previous state and then invoking an operation.
13. The Memento pattern is also known as Token.
