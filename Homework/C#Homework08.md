#Microsoft Visual C# Ch 08  Values and references
###Homework 08

### Michelle Caballero
##### 30 January 2019


1. What is the diﬀerence between deep copy and shallow copy?
`` A SHALLOW copy provides copy of a class and all of it's data, private or not, that consist of values, and references A DEEP copy provides copy of a class, all of it's data that are values, and the value of data that are references ``

2. What is the value of a reference after you declare and initialize it?
`` The value of the reference is the address of original copy.``

3. How do you declare a value type?
`` You declare a value by declaring a variable and assigning it a value.``

4. How do you declare a reference type?
`` You declare a reference by declaring an instance of an object. Then you assign
that instance to a reference``

5. Does C# allow you to assign NULL to a value type?
`` C# does not allow you to assign NULL to a value type.``

6. Can you assign a nullable value type to a non-nullable variable of the same type? Why or why not?
`` You cannot assign a nullable value type to a variable of the same type because
the variable is not nullable. ``

7. What is the diﬀerence between the stack and the heap?
`The stack contains value types and the heap contains reference types`

8. What does it mean when we say that all classes are specialized types?
`` It means that all classes are a type of object in the Objects class``

9. What does ref do?
`` It allows the method to modify the argument(parameters) of a reference type,
by returning the original argument(parameter) to the method rather than a copy. ``

10. What does out do?
`` Out allows the original argument(parameter) to be changed to something new.``

11. Describe boxing and unboxing in your own words.
`` Boxing is copying the value stored in the stack to the heap in order to create
an instance of it and utilize it. Unboxing compares types, if types match it
converts it to a value in the stack.``

12. What does cast do?
``Checks whether converting an item of one type to another is safe before actually making the copy.``
