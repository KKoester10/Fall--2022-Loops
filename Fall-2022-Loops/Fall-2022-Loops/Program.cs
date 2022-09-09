// Loops
// For Loop, While, Foreach loop, Do While Loop
// varients of our two main types of loops: while & for Loops
// Loop is a block of code that repeats. 

//--------------------------------------------------------------------------------------------------------------------------------------------
// For Loop!
// The most common type of loop.
// For loop is a block of code that runs a certain number of times OR a block of code that repeats for some range of numbers. 
// for(int i = 0 (Initializer); Condition ; increment)
// {
// code to run
// }
// Initializer -> statement that runs before the for loop starts 
// Condition -> Condition we check after each loop to see if we should keep running
// Increment -> statement we run after each loop ends. 

// lets say we want to print out every number 0-100.
// FOR Loops:
for (int i = 0; i <= 100; i++)
{
    Console.WriteLine(i);
	if (i == 47)
	{
		break;
	}
}

// While Loops:(use for when running the code)
// Simplest Loop. 
// Runs WHILE a condition is true. 
//while (condition)
//{
// code to run
// inculde either a change to the condition OR a break statement 
//}

// 'j' -> 'k' naming conventions 
var j = 0;
while (j <= 100)
{
	Console.WriteLine(j);
    if (j == 47)
    {
        break;
    }
    j++;
}

// For Each Loop!
// collection of objects
// specific version of the for loop that repeats FOR EACH item in some Collection
// Example. for each loop on a bag of 5 things will run 5 times. add something to the bag, and it would run 6 times. 

// Do While Loop: (use after running the code )
// A do while loop is just a while loop tha tis guaranteed to run once.
//do
//{
//  code goes here
//} while (Condition);
var k = 250;
do
{
    Console.WriteLine(k);
    k++;
} while (k <= 100);
