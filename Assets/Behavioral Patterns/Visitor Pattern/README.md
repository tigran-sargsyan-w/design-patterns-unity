# Visitor Pattern
## *Intent*
Visitor Pattern used when we have to perform an operation on a group of similar kind of Objects. With the help of visitor pattern, we can move the operational logic from the objects to another class.

![Visitor Pattern](https://refactoring.guru/images/patterns/diagrams/visitor/structure-ru.png)

:mag:
## *Applicability*
Visitor Pattern is used when we have to perform an operation on a group of similar kind of Objects. With the help of visitor pattern, we can move the operational logic from the objects to another class.


:clipboard: 
## *How to implement*
1. Create a Visitor Class to perform operations on data.
2. Create Concrete Visitor class by implementing above Visitor Interface.
3. Create a Visitable class.
4. Create Concrete Visitable classes extending the above class.

