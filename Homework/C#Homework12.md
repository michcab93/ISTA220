#Microsoft Visual C# Ch 12  Inheritance#
###Homework 12###

### Michelle Caballero ###
##### 13 February 2019 #####

1. How does inheritance promote the principle of don’t repeat yourself (DRY) ?

``It prevents you from writing code multiple times, instead you can inherit it
from base class``

2. What is the syntax of a derived class that inherits from a base class?

``class derivedclas : baseclass``

3. Do all user deﬁned types (classes and structs) inherit from some base class?
If so, what is it?

`` Only classes inherit from base class. Structures inherit from an abstract
class named System.ValueType.``

4. What happens if you do not have a default constructor in a base class when
creating a derived class?

``You have to call on the nondefault constructor, and if you don't remember it
exactly then there will be a compile-time error``


5. Can you assign a variable of a derived class to another variable of its base
class? Why or why not?

``Yes because the variable is a type derived from the base type. For example:``

Horse myHorse = new Horse()

Mammal myMammal = myHorse;

`` In this example the myHorse is a type of Horse, and Horse is a type of
Mammal``

6. Can you assign a variable of a derived class to another variable of a derived
class of its base class? Why or why not?

``No because they are different types of variables. For example:``

Horse myHorse = new Horse()

Whale myWale = myHorse, this is not possible because myHorse is a Horse type

and myWale is a wale type.


7. Can you assign a variable of a base class to another variable of a derived
class? Why or why not?

``No because not all types the base class can be types of it's derived class.
For example:``

Mammal myMammal = new Mammal()

Horse myHorse = myMammal

``myMammal could be a Horse Type, but it could also be a wale type, or a
human type. Because we cannot guarrantee the mathcing of types we cannot assign
a Mammal type (base class) to a Horse type (derived class)``

8. Under what circumstances would you want to use the new keyword when deﬁning
a method in a derived class?

``You would use new when a method in base class is name same as method in
the derived class and you want to hide the base method``

9. What is a virtual method ? Why would you want to deﬁne a virtual method?

``A method that is intended to be overwritten.``

10. What does override do? Why does it do it?

Declares another implementation of the virtual method. Because the each derived class might need the method in a different way.

11. How do you deﬁne an extension type?

In a static class and specify the type to which the method applies as the first parameter to the method with the this keyword.

12. Why do you deﬁne an extension type?

To extend a type without affecting existing code.
