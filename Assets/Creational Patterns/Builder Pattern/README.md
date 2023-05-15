# Builder Pattern
## *Intent*
Separate the construction of a complex object from its representation so that the same construction process can create different representations.

![Builder Pattern](https://refactoring.guru/images/patterns/diagrams/builder/structure.png)

:mag: 
## *Applicability*
Use the Builder pattern to get rid of a “telescopic constructor”.

 :clipboard: 
## *How to implement*
1. Make sure that you can clearly define the common construction steps for building all available product representations. Otherwise, you won’t be able to proceed with implementing the pattern.
2. Declare these steps in the base builder interface.
3. Create a concrete builder class for each of the product representations and implement their construction steps.
4. Think about creating a director class. It may encapsulate various ways to construct a product using the same builder object.
5. The client code creates both the builder and the director objects. Before construction starts, the client must pass a builder object to the director. Usually, the client does this only once, via parameters of the director’s constructor. The director uses the builder object in all further construction. There’s an alternative approach, where the builder is passed directly to the construction method of the director.
6. The construction result can be obtained directly from the director only if all products follow the same interface. Otherwise, the client should fetch the result from the builder.
7. The client should be aware of the used builder’s specifics to fetch results correctly.
8. It’s OK to call the building steps directly from the client code only when constructing simple products.

