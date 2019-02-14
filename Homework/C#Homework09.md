#Microsoft Visual C# Ch 09  Enumerations and Structure
###Homework 09

### Michelle Caballero
##### 5 February 2019


1. Declare an enum for military ranks, either oﬃcer or enlisted. Name it
Ranks. What are the symbols, like Private, PFD, Corporal, or 1stLt, 2ndLt,
Capt?

``enum Rank { PVT = 1, PV2, PFC, SPC, SGT, SSG, SFC, MSG, CSM }``

2. Using the Ranks enum, assign a rank to yourself or a friend.

``Rank Michelle = Rank.SGT;``

3. Determine the numeric index of particular ranks, using the Ranks enum.

``{ PVT = 1, PV2, PFC, SPC, SGT, SSG, SFC, MSG, CSM }``

``= { 1, 2, 3, 4, 5, 6, 7, 8, 9}``

``Rank Michelle = Rank.SGT; Console.WriteLine((int)Michelle); // writes '5'``

4. How do you select the type of an enum?

``You write out the data type in front of the values. For example:
enum Rank : short { PVT = 1, PV2, PFC, SPC, SGT, SSG, SFC, MSG, CSM }``

5. Are structs stored on the stack or on the heap? What about enums?

`` Structures instances are values and are stored on the stack.
Class instances are objects and are stored in the heap. Enums are stored
in the stack.``

6. Declare a struct named DOD with four branches.

``struct DOD
{

    private string Defense Logistics Agency, Military Health System, Reserves
    Affairs, Armed Forces;

}

7. Why can’t you create a default constructor for a struct?

`` You cannot create a default constructor because a default constructor is
always generates a struct. ``

8. What is CIL? What does the CLR do to the CIL?

``CIL is Common Intermediate Language. Your code is converted to CIL and then
CLR compiles CIL to produce actual program. `` 
