/*
* Name: Alex White
* Course: CSCI 1250, Section 002
* Assignment: Lab 06, Three Short Problems
* Date: October 21, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/

//Displays menu options 
Console.WriteLine("=== CSCI 1250 Lab06 ===");
Console.WriteLine("1. The Grade Checker");
Console.WriteLine("2. The Dice Table");
Console.WriteLine("3. The Score Report");
Console.WriteLine("4. All Three");
Console.WriteLine("5. Quit");
Console.Write("Choose 1 through 5: ");
int choice = Convert.ToInt32 (Console.ReadLine());

// The if statements decide what to do with the user input
if (choice == 1 || choice == 4)
{
    // User inputs a grade and the program gives back a letter for that grade
    Console.WriteLine();
    Console.WriteLine("=== Exercise 1: The Grade Checker ===");
   
   // This while loop will keep the grade checker running until a valid grade has been entered into the system and the student letter grade has been printed to the screen
    while(1 == 1)
    {
        Console.Write("Enter a grade: ");
        int score = Convert.ToInt32(Console.ReadLine());
        if (score < 60 && score >= 0)
        {
            Console.WriteLine($"{score} earns a F.");
            break;
        }
        if (score >= 60 && score < 70)
        {
            Console.WriteLine($"{score} earns a D.");
            break;
        }
        if (score >= 70 && score < 80)
        {
            Console.WriteLine($"{score} earns a C.");
            break;
        }
        if (score >= 80 && score < 90)
        {
            Console.WriteLine($"{score} earns a B.");
            break;
        }
        if (score >= 90 && score <= 100)
        {
            Console.WriteLine($"{score} earns a A.");
            break;
        }
        else
        {
            Console.WriteLine("A score must be between 0 and 100.");
        }
    }
}

if (choice == 2 || choice == 4)
{
    
}

if (choice == 3 || choice == 4)
{
    
}

if (choice > 1 || choice < 5)
{
    Console.WriteLine("Choose a number from 1 to 5.");
}