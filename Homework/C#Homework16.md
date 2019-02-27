#Microsoft Visual C# Ch 16
###Homework 16

### Michelle Caballero
##### 26 February 2019


1. Give five examples (using valid C# code) of the five bitwise operators
listed in the text.

The NOT(~) operator: 11001100(204 decimal) ~ 00110011(51 decimal)
the Left-Shift (<<) operator: 204 << 2 returns the value 48; 11001100 << 2 returns 00110000|
the OR (|) operator: 204|24 = 220 (204 is 11001100, 24 is 00011000, and 220 is 11011100|
the AND (&) operator; 204 & 24 is 8 (204 is 11001100, 24 is 00011000, and 8 is 00001000|
the XOR(^) operator: 204 ^ 24 is 212 (11001100 ^ 00011000 is 11010100).

2. Does C# implement the right-shift (>>) operator? If so, give an example of its operation using valid C# code.


3. Explain in detail this code: bits & (1 << index);.
4. Explain in detail this code: bits |= (1 << index);.
5. Explain in detail this code: bits &= (1 << index);.
6. How does C# interpret this? bool peek = bits[n]; it retrieves the bool at index [n]
7. How does C# interpret this? bits[n] = true; sets the bit at index [n] to true
8. How does C# interpret this? bits[n] =^ true; inverts the value of index [n] and sets it to true
9. Assume that users were assigned read, write, and execute permissions according to this scheme: read= 1, write = 2, execute = 4. How would you interpret the following user permissions: (a) permission = 0 none (b) permission = 1 read (c) permission = 2 write (d) permission = 3 read and write (e) permission = 4 execute (f) permission = 5 execute and read (g) permission = 6 execute and write (h) permission = 7 execute, read and write
10. Answer the previous question by converting the decimal permissions into binary permissions. What does this tell you about using this scheme of permissions?
