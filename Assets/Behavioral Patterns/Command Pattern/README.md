# Command Pattern
## *Intent*
Command Pattern used to encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.

![Command Pattern](https://refactoring.guru/images/patterns/diagrams/command/structure.png)

:mag:
## *Applicability*
Use the Command pattern when you want to:
* parameterize objects by an action to perform. You can express such parameterization in a procedural language with a callback function, that is, a function that’s registered somewhere to be called at a later point. Commands are an object-oriented replacement for callbacks.
* specify, queue, and execute requests at different times. A Command object can have a lifetime independent of the original request. If the receiver of a request can be represented in an address space-independent way, then you can transfer a command object for the request to a different process and fulfill the request there.
* support undo. The Command’s `Execute` operation can store state for reversing its effects in the command itself. The Command interface must have an added `Unexecute` operation that reverses the effects of a previous call to `Execute`. Executed commands are stored in a history list. Unlimited-level undo and redo is achieved by traversing this list backwards and forwards calling `Unexecute` and `Execute`, respectively.
* support logging changes so that they can be reapplied in case of a system crash. By augmenting the Command interface with load and store operations, you can keep a persistent log of changes. Recovering from a crash involves reloading logged commands from disk and reexecuting them with the `Execute` operation.
* structure a system around high-level operations built on primitives operations. Such a structure is common in information systems that support transactions. A transaction encapsulates a set of changes to data. The Command pattern offers a way to model transactions. Commands have a common interface, letting you invoke all transactions the same way. The pattern also makes it easy to extend the system with new transactions.
* model the invocations of operations as objects. The Command pattern lets you parameterize clients with different requests, delay or queue a request’s execution, and support undoable operations.
* decouple an object making requests from the one that knows how to perform the requests.
* decouple objects by introducing a layer between the object that invokes a operation and the object that performs it.
* support undo and redo operations.


:clipboard: 
## *How to implement*
1. Declare the command interface with a method signature like `Execute()`.
2. Create one or several concrete commands by extending the command interface. Each command should be bound to one or several receivers. The command must implement the `Execute` method by invoking the corresponding operations on these receivers.
3. Identify classes that will act as senders. In the simplest case, a sender is just a button widget in a graphical user interface. In more complex cases, senders are responsible for creating the command objects and specifying their receivers.
4. Bind specific commands to senders. The simplest way is to store a command as a field in the sender and initialize it with one of the concrete command objects during initialization. Alternatively, you can implement the command binding in the sender’s setter method. The sender will delegate all the work to the command when a user presses a button.
5. Implement optional features by adding more methods to the command interface. Then declare abstract methods in the base command class. The methods should follow the names of the optional features. Finally, modify all concrete command classes, adding the corresponding implementations. There are two ways to add a new feature to the command. The first is to add a new method to the command interface and then implement it in all concrete commands. The second is to add a new abstract method to the base command class and implement it in concrete commands. The latter way is preferable because it allows you to add a new feature to a subset of existing concrete commands without changing their code.
6. Create an invoker class. Its role is to store a reference to one or several commands and send requests to them at the right time. The invoker is responsible for choosing which commands to execute at which points. It’s also responsible for creating and storing commands, either directly or indirectly, in fields. The invoker passes a request to the command to execute the appropriate operations on its receiver.
7. The client must initialize objects in the following order:
    * Create receivers.
    * Create commands, and associate them with receivers.
    * Create an invoker object and associate it with the command objects.
    * The client may bind receivers to commands at this point.
    * Pass commands to the invoker to execute requests.
    * The client may undo commands by calling the `Unexecute` method on the command object.
    * The client may redo commands by calling the `Execute` method on the command object.
    * The client may bind new receivers to the command objects at any point.
8. The client can construct composite commands from simple commands by combining them recursively. The client can execute a composite command like any other command, but its real strength comes from the ability to undo and redo multiple commands at once.
9. The client can create a command object and pass it to a thread to execute the command in parallel with the main thread. This is useful for implementing background tasks in a graphical user interface.
10. The client can serialize commands by implementing the `Load` and `Store` methods. This is useful for implementing logging and undo functionality.
11. The client can implement a macro command by combining several commands into one. The macro command executes each command in the list. The `Execute` and `Unexecute` methods of the macro command are implemented by calling `Execute` and `Unexecute` on each command in the list in turn.
12. The client can implement a command history that stores executed commands. The client can then traverse the history in reverse order to implement undo and redo functionality.

