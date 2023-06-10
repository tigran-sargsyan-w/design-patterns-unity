# Chain Of Responsibility Pattern
## *Intent*
Chain Of Responsibility Pattern used to avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. Chain the receiving objects and pass the request along the chain until an object handles it.

![Chain Of Responsibility Pattern](https://refactoring.guru/images/patterns/diagrams/chain-of-responsibility/structure.png)

:mag:
## *Applicability*
Chain Of Responsibility Pattern used when:
* more than one object may handle a request, and the handler isn't known a priori. The handler should be ascertained automatically.
* you want to issue a request to one of several objects without specifying the receiver explicitly.
* the set of objects that can handle a request should be specified dynamically.
* it's essential to decouple a request's sender from its receiver.


:clipboard: 
## *How to implement*
1. Declare the handler interface.
2. Implement the handler interface and define the successor.
3. Client creates the chain of handlers.
4. Client submits the request to the chain.
5. Each handler decides whether to process the request or to pass it to the next handler in the chain.
6. Client receives the result.
7. Client can add or remove handlers dynamically at any point either directly to the chain or through the interface.
8. Client can implement the chain in a variety of ways, such as linked lists, trees, or arrays.
9. Client can implement different requests as different concrete handlers class.
10. Client can implement the handler as a chain of responsibility or as a command pattern.


