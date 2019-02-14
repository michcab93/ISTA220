#Chapter 01, Microsoft Visual C#

--Name: Michelle Caballero
--File: Homework C# 01
--Date: 8 January 2019



--1 What is a console app?
A console app is an application that runs in a Command Prompt Window,
instead of a GUI

--2 What does Main() (the main method) do in a console application?
Main() designates the programs entry point.

--3 What is the purpose of a namespace?
The purpose of a namespace is to give clashing names and identifier and therefor
they will not be confused with each other. The book calls it, creating a container
for items.

EX:

namespace TestHello
{
	class Greeting
	{
	...
	}
}

Then this class can be refrenced as TestHello.Greeting

If there is another Greeting class, such as NewNamespace, and you want to
refrence it you must specify it as NewNamespace.Greeting

*Packing up everything in a packet that the program needs to do.

--4 Describe specifically what using statements do.
Using statements automatically places items in your code in a "container".
In other words it gives items a namespace every time you create a new project.

*how you pack modules in a program.

--5 What is an assembly?
Assembly groups various classes together by the functional areas to which they
relate. This is done in order to make maintains easier. Example (If Microsoft
were to update a single method in a single class, it would have to distribute
the entire class library to developers!)

--6 What is the relationship between an assembly and a namespace?
There is no relationship between assembly and namespace. A single assembly can
contain calsses defined in many namespaces and a single namespace can span over
multiple assemblies.

--7 What is a graphical app?
A graphical  app is  the templete that function on any device that runs windows.
It has a user interface in the design view, and also has a code view, where you
can maintain code and program.
* an application with a GUI, graphical user interface

--8 What is the starting point in a graphical application?
The starting point in a graphical application is when the App.xaml file provides
the entry point at which the applicaton starts running.

* there is no main method

--9 What does Build do?
Build verifies that the project builds successfully

*build compliles the code
humans understand
console.write("Hello")
computers understand
10110000101001011011

build takes our code and translates it into computer speak

--10 What does Debug do?
Debug displays two pair of numbers which indicate frame rate. This information
is used to determine if the application starts to become less responsive, which
could be a sign of performance issues

*runs program step by step by step, checking each step.
