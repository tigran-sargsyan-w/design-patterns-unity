# Iterator Pattern
## *Intent*
Iterator Pattern used to provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.

![Iterator Pattern](https://refactoring.guru/images/patterns/diagrams/iterator/structure.png)

:mag:
## *Applicability*
Iterator Pattern should be used when:
* You need to access the elements of an aggregate object sequentially without exposing its underlying representation.
* You need to support multiple types of iterators for the same collection.
* You want to provide a uniform interface for traversing different structures (that is, to support polymorphic iteration).

:clipboard: 
## *How to implement*
1. Make the `Iterator` interface to declare the operations for traversing the collection.
2. Make the `ConcreteIterator` class to implement the `Iterator` interface. Store the current traversal position at all times.
3. Make the `Collection` interface with an `iterator` method that returns a new instance of the `Iterator` class.
4. Make the `ConcreteCollection` class to implement the `Collection` interface. The method should return a new instance of the `ConcreteIterator` class.
5. Clients should work with iterators only through the interface. This will let you change the collection classes and iterator classes independently.
6. Enumerating collections is usually a lot more convenient with the `foreach` method. Add this method to the collection interface and implement it in all concrete collection classes.

