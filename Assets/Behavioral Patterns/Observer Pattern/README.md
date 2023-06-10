# Observer Pattern
## *Intent*


![Observer Pattern](https://refactoring.guru/images/patterns/diagrams/observer/structure.png)

:mag:
## *Applicability*
Observer Pattern should be used when:
* When an abstraction has two aspects, one dependent on the other. Encapsulating these aspects in separate objects lets you vary and reuse them independently.
* When a change to one object requires changing others, and you don’t know how many objects need to be changed.
* When an object should be able to notify other objects without making assumptions about who these objects are. In other words, you don’t want these objects tightly coupled.

:clipboard: 
## *How to implement*
1. Declare the subject and observer interfaces.
2. Declare the concrete subject and concrete observer classes.
3. In the subject class, add a list of subscribers for storing references to concrete observers. Implement subscription management methods.
4. In the subject class, define a notification method. Call it each time something important happens inside the subject. This method should go through the subscriber list and call the notification method on each subscriber.
5. The subscriber interface should declare the notification method. In most cases, this method only needs to have one parameter — the reference to the subject. However, the subscriber can retrieve any additional information through other methods of the subject.
6. The concrete subscriber classes must implement the notification method in a way that fits that particular class.
7. The client must create all necessary subscribers and register them with the subject before launching the subscription process.
8. The client may trigger several updates on the same subject object. But it can also work with several subjects at the same time. In this case, the client should track the subjects’ types to understand what’s going on.
9. The client can initiate and control subscription duration. The subscription may be canceled inside the notification method of a subscriber.
10. The client should be able to remove subscribers from the list and completely stop notifications without affecting other subscribers.
11. The client should be able to implement the subscription logic in a subclass.
12. The client should be able to partially update the object state without triggering a notification.
13. The client should be able to ignore notifications coming from a particular subject.
14. The client should be able to broadcast notifications to all subscribers without keeping references to their objects.
15. The client should be able to resend notifications to the same subscriber.