# Template Method Pattern
## *Intent*
Template Method Pattern used to define the skeleton of an algorithm in a method, deferring some steps to subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.

![Template Method Pattern](https://refactoring.guru/images/patterns/diagrams/template-method/structure.png)

:mag:
## *Applicability*
Use the Template Method pattern when you want to let clients extend only particular steps of an algorithm, but not the whole algorithm or its structure.

:clipboard: 
## *How to implement*
1. Make all of the algorithm steps except for one or a few of them abstract.
2. The parent class calls the abstract methods at the necessary points of the algorithm's execution.
3. The concrete subclasses implement the abstract methods of the parent class. Each subclass can override all steps of the algorithm, but not the structure of the algorithm itself.
4. The client must create an object of a particular subclass of the parent class and call its template method.
5. The client can override some, but not all, operations of the parent class.

