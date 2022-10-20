// Set my initial bounds such that the loop works
int lower = 0, upper = 1001;
// Loop while the range is incorrect or lower and upper are not valid
while (upper - lower > 1000 || lower > upper)
{
    // Prints the instructions to the user
    Console.WriteLine("Please enter two numbers with a difference of no more that 1000");
    // Instructs to enter the upper bound
    Console.Write("Upper bound: ");
    // Read a string containting the upper bound 
    string? upperRaw = Console.ReadLine();
    // Instruct user to enter lower bound
    Console.Write("Lower bound: ");
    // Read a string contining the lower bound
    string? lowerRaw = Console.ReadLine();
    // Checks if the strings can be parsed (i.e. string is null, empty, or doesn't contain a number)
    if (!int.TryParse(upperRaw, out upper) || !int.TryParse(lowerRaw, out lower))
    {
        // Ensures bounds are still invalid
        lower = 0;
        // Ensures bounds are still invalid
        upper = 1001;
    }
}

// Sets default grouping number to an invalid state
int lines = -1;
// Loops while the lines are invalid
while (lines < 5 || lines > 30)
{

    // Prints the instuctions for the user as to what they should enter
    Console.WriteLine("Please enter the quantity of numbers to print on each line");
    // Reads the string containing the grouping from the user
    string? linesRaw = Console.ReadLine();
    // attempt to parse the input
    if (!int.TryParse(linesRaw, out lines))
    {
        // Keeps it invalid if failed
        lines = -1;
    }
}

// Initialize all of the counters so that we can calculate all nessary outputs
int lineCounter = 0, sweetCounter = 0, saltyCounter = 0, bothCounter = 0;
// Loops from lower to upper bound
for (int i = lower; i <= upper; i++)
{
    // In this case we have printed as many numbers as the user requested for this line
    if (lineCounter == lines)
    {
        // Create a new line
        Console.WriteLine();
        // Reset counter to zero for the next line
        lineCounter = 0;
    }
    // if this number is dividible by 3
    if (i % 3 == 0)
    {
        // if this number is divisible by 5
        if (i % 5 == 0)
        {
            // Print Sweet'nSalty because this condition has been met
            Console.Write("Sweet'nSalty ");
            // Update the nessasry counter
            bothCounter++;
        }
        // Otherwise
        else
        {
            // Print sweet since it is only divisible by 3
            Console.Write("Sweet ");
            // Update the nessasary counter
            sweetCounter++;
        }
    }
    // If divisible by 5 but not by 3
    else if (i % 5 == 0)
    {
        // Print salty
        Console.Write("Salty ");
        // Update the nessasary counter
        saltyCounter++;
    }
    // None of the conditions are met
    else
    {
        // Just print the number followed by a space
        Console.Write("" + i + " ");
    }
    // Increment the line counter to keep track of how many things have been printed to the line
    lineCounter++;
}

// Ensure that we are on a new line
Console.WriteLine();
// Print out the sweet counter
Console.WriteLine($"Sweet was printed {sweetCounter} times");
// Print out the salty couter
Console.WriteLine($"Salty was printed {saltyCounter} times");
// Print out the sweet and salty counter
Console.WriteLine($"Sweet'nSalty was printed {bothCounter} times");

// End program with an exit code of 0 (No errors)
Environment.Exit(0);