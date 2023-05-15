# Prototype Pattern
## *Intent*
Prototype is a creational design pattern that lets you copy existing objects without making your code dependent on their classes.

![Prototype Pattern](https://refactoring.guru/images/patterns/diagrams/prototype/structure.png)

:mag:
## *Applicability*
Use the Prototype pattern when your code shouldn’t depend on the concrete classes of objects that you need to copy.
Use the pattern when you want to reduce the number of subclasses that only differ in the way they initialize their respective objects. Somebody could have created these subclasses to be able to create objects with a specific configuration.
Use the Prototype when you need to save copies of the objects, as each object is unique and their number is unknown.


:clipboard: 
## *How to implement*
1. Add a clone method to the existing class.
2. Implement the method by copying the original object’s data fields to the corresponding fields of the clone. If the field is an object reference, then clone the referenced object and assign the clone to the field. If the field is an immutable value, then just copy the value to the field.
3. Replace all direct calls to the object’s constructor with calls to the clone method, except for the calls to the constructor of the class that defines the clone method.
4. Alternatively, you can create a centralized Prototype Registry to store a catalog of frequently used prototypes. The registry can return a copy of the stored prototype.
5. To make a Prototype Factory optional, you can implement it as a Singleton.

