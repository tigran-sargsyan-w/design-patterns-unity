# Adapter Pattern
## *Intent*
Adapter used to convert the interface of a class into another interface clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.


![Adapter Pattern](https://refactoring.guru/images/patterns/diagrams/adapter/structure-object-adapter.png)

:mag:
## *Applicability*
Use the Adapter pattern when:
- you want to use an existing class, and its interface does not match the one you need.
- you want to create a reusable class that cooperates with unrelated or unforeseen classes, that is, classes that don't necessarily have compatible interfaces.
- (object adapter only) you need to use several existing subclasses, but it's impractical to adapt their interface by subclassing every one. An object adapter can adapt the interface of its parent class.
- (class adapter only) you need to adapt the interface of an existing class, but its impractical to adapt its interface by subclassing it. A class adapter can adapt the interface of its parent class.
- you need to introduce a reusable class that cooperates with unrelated or unforeseen classes, that is, classes that don't necessarily have compatible interfaces.
- you need to use several existing subclasses, but it's impractical to adapt their interface by subclassing every one. An object adapter can adapt the interface of its parent class.

:clipboard: 
## *How to implement*
1.  Identify the client and the adaptee classes.
2. Declare the client interface and describe how clients communicate with the adaptee.

