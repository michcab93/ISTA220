#Microsoft Visual C# Ch 17
###Homework 17

### Michelle Caballero
##### 4 March 2019


1. What is a type parameter?

 ``A type parameter is <T> after a class name.``

2. What does a type parameter do?

``It allows a class/struct/interface to be defined as any type, and tells the compiler to create a new temporary class/struct/interface of that type on demand.``

3. How many type parameters can a generic class have?

``no limit``

4. What is the difference between a generic class and a generalized class?

``A generic class is cast into a new class of a specified type by the complier. A generalized class is instantiated as the same object type as the base class.``

5. What is a constraint? How do you specify a constraint?

``A constraint specifies a filtered list of possible types using the "where" keyword.``

6. What is a generic method? How do you define a generic method?

``A generic method can take some or any types as parameters. Defined using <T> like generic classes.``

7. What do we mean when we cay that a generic type interface is invariant?

`` IAlpha cannot reference IBravo even if IBravo is derived from IAplha.``

8. What do we mean when we cay that a generic type interface is covariant?

``IAlpha can reference IBravo because IBravo is derived from IAplha.``

9. Does covariance work with value types? Does it work with reference types?

10. What do we mean when we cay that a generic type interface is contravariant?
