#Microsoft Visual C# Ch 04
### Homework 04

### Michelle Caballero
##### 16 January 2019

1. What are all possible values of *Boolean expressions*?
  + All possible values of a *Boolean expression* are true or false

2. List eight *Boolean operators*.
  + (==) equal to
  + (!=) not equal to
  + (>) greater than
  + (>=) greater than or equal to
  + (<) less than
  + (<=) less than or equal to
  + (&&) conditional AND
  + (||) conditional OR

3. What is the general concept of *short circuiting*? This question has a short
and simple answer and you do not need to have a detailed response.
+ Determining whether rest of your expression needs to be evaluated by using a
conditional AND, or conditional OR

4. What are the differences in how *short circuiting* works for && and ||?
+ *Short circuiting* for (&&) conditional AND stops evaluating if the result is
false
+ *Short circuiting* for (||) conditional OR stops evaluating if the result is
true

5. Look at the list of operators. What operator has the highest precedence?
What has the lowest?
+ Primary operators () parentheses, ++ post increment, and -- post decrement
have the highest precedence
+ Assignment operator =, has the lowest precedence.

6. In an *if* or *else* construction using multiple lines of code, what effect
does the use of curly braces have?
+ The curly braces group statements inside a block in order to perform more
than one *if* statement
EXAMPLE:

int results = 0;

  *if* (day == 0);
  {
  day = Sunday;
  }
  else if (day == 1);
  {
  day = Monday;
  }
  else if (day == 2);
  {
  day = Tuesday;
  }

7. In a switch statment what happens if you omit a break
+ it will fall through


8. What is a recursive method? Using language you know (such as English), write
a recursive method that adds up the integers in a list of integers. The input
to the method is a list of integers and the output is a scalar value presenting
a sum.
+ A recursive method is that calls itself.
+
