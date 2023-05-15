# Singleton Pattern
## *Intent*
Singleton is a creational design pattern that lets you ensure that a class has only one instance, while providing a global access point to this instance.

![Singleton pattern](https://refactoring.guru/images/patterns/diagrams/singleton/structure-en.png)

:mag:
## *Applicability*
Use the Singleton pattern when a class in your program should have just a single instance available to all clients; for example, a single database object shared by different parts of the program.



:clipboard: 
## *How to implement*
1. Add a private static field to the class for storing the singleton instance.
2. Declare a public static creation method for getting the singleton instance.
3. Implement “lazy initialization” inside the static method. It should create a new object on its first call and put it into the static field. The method should always return that instance on all subsequent calls.
4. Make the constructor of the class private. The static method of the class will still be able to call the constructor, but not the other objects.
5. Go over the client code and replace all direct calls to the singleton’s constructor with calls to its static creation method.
6. Clients may call the singleton’s static method to get the access to the same instance.
7. Enjoy a useful instance of a singleton class :smile:
8. If you need to extend the singleton’s behavior, don’t extend its class. Instead, make the improvements to a wrapper class. Create a new singleton class with some useful behavior and delegate all the work to the existing singleton instance. You can use the same approach to replace the singleton instance with a different one when needed.
9. You can always use dependency injection to replace the singleton if the application is still in the development phase. However, you need to refactor a large amount of code if the singleton is used in the mature project. In this case, you can replace the static singleton methods with the instance methods and use inheritance to extend the behavior of the class. Needless to say, the latter approach will require you to change each call to the singleton.

