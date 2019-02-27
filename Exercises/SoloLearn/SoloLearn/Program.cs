using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Michelle Caballero";
            //int myAge = 25; I first wrote this as part of my introduction but I wanted to make myself close to users age to be more relatable 
            string myNat = "Mexican";
            string myJob = "X-ray tech";
            string myCurCity = "Columbus";
            string myCurState = "Georgia";
            Console.WriteLine("Welcome to the Coding World");
            Console.WriteLine($"My name is {myName}");
            /*Console.WriteLine($"I am {myAge} years old and I am {myNat}");*/
            Console.WriteLine($"I work as {myJob}");
            Console.WriteLine($"I currently live in {myCurCity}, {myCurState}");
            Console.WriteLine("Let's get started!");

            string yourName;
            Console.WriteLine("What is your name");
            yourName = Console.ReadLine();
            Console.WriteLine($"Nice to meet you {yourName}");
            string yourAge;
            Console.WriteLine("How old are you?");
            yourAge = Console.ReadLine();
            int intyourAge = int.Parse(yourAge);
            Console.WriteLine($"My brother is {intyourAge + 1}. He is only a year older then you"); //this line uses a raddition operator
            int myAge = 5;
            myAge =+ intyourAge; // this is a compound assignment operator  x = x + inputvalue
            Console.WriteLine($"I am {myAge}");
            string reason;
            Console.WriteLine("Why do you want to learn to code?");
            reason = Console.ReadLine();
            Console.WriteLine("I learned to code because I was transitioning out of the army and needed a job!");

            Console.WriteLine("Testing code out.");
            Console.WriteLine("\nThis text should be on new line"); // \n starts text on new line instead of pacing all Console.Write() together like it did in the intro 
            Console.WriteLine("I'm testing int x = 42; \n x += 2; // equivalent to x = x + 2 \n answer should be 44");
            int x = 42;
            x += 2;
            Console.WriteLine($"Result is {x} \n yay that worked");
            Console.WriteLine("What about backwards? \n Testing x =+ 2 // equivalent to x + x = 2  \n the answer should be 2");
            x =+ 2;
            Console.WriteLine($"Result is {x} \n yay that worked");
            Console.WriteLine(" \n Testing x *= 2 // equivalent to x * 2 = x  \n the answer should be 84");
            x *= 2;
            Console.WriteLine($"Result is {x} \n well it does not seam to work with multiplication");
            Console.WriteLine("What about backwards? \n Testing x =* 2 // equivalent to x = 2 * x  \n the answer should be 84");
            //x =* 2;
            Console.WriteLine($"That code gave me an error. So it definatly does not work.");
            Console.WriteLine("What about x /= 2? \nequivalent to  x / 2 = x \n it should equal 21");
            x /= 2;
            Console.WriteLine($"Result is {x} \n well it does not seam to work with division");
            Console.WriteLine("When I tested backwards it gave me an error like the multiplication did.");
            Console.WriteLine("What about x -= 2? \n equivalent to  x - 2 = x \n it should equal 40");
            x -= 2;
            Console.WriteLine($"Result is {x}, \n it does not seam to work either. =(");
            Console.WriteLine("How about backwards? \n Testing x =- 2 \n equivalent to x = 2 - x \n notice the diffarence you are subtracting x from 2 \n It should equal to -40");
            x = -2;
            Console.WriteLine($"Result is {x} \n it does not seam to work either.");

            Console.WriteLine("\n OMG I just realized that the compound assignment operators only works for +,*, and %. and that the reson those were not working in my code was" +
                "because I was changing the value of x every time I used a compound assignment operator it changed the value of my variable in this case (x) so the" +
                "multiplication and division did work, but they evaluated for the new value of (x) not the first value x = 42");

            Console.WriteLine("\nOk next excersise");
            Console.WriteLine("\npress enter");
            Console.ReadLine();
            Console.WriteLine("\nIncrement Operators");
            Console.WriteLine("\nkeep pressing enter to move on to next step");
            Console.ReadLine();
            Console.WriteLine("\nx++ is equivilante to x = x + 1 \nfor example \n int a = 10; \n a++; \n Console.WriteLine(a) is going to give result 11" +
                "\n testing");
            Console.ReadLine();
            int a = 10;
            a++;
            Console.WriteLine(a);
            Console.ReadLine();
            Console.WriteLine("\nx++ is a Prefix. \n ++x is a Postfix. \n ++x works like this int a = 11; \n int b = ++a;" +
                "\n when called back a = 12 and b = 11. \n Why you ask?");
            Console.ReadLine();
            Console.WriteLine("this is because x++ assigns the value to the variable first, \nso b = 11 " +
                "\nthen increments it, so then it does 11 + 1 and assigns it back to a");
            Console.ReadLine();
            int b = a++;
            Console.WriteLine("int b = a++;");
            Console.ReadLine();
            Console.WriteLine($"value of a = {a}, value of b = {b}");







        }
    }
}
