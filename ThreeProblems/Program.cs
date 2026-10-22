/*
* Name: Alex White
* Course: CSCI 1250, Section 002
* Assignment: Lab 06, Three Short Problems
* Date: October 21, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/

// Makes a new Random object needed for the Dice Table and set choice to 0

Random rng = new Random(4000);
int choice =0;

// This Do While loop cover almost the whole file and the keeps the menu running untill the user press 5 to Quit in the menu 
do
{
    //Displays menu options 
    Console.WriteLine();
    Console.WriteLine("=== CSCI 1250 Lab06 ===");
    Console.WriteLine("1. The Grade Checker");
    Console.WriteLine("2. The Dice Table");
    Console.WriteLine("3. The Score Report");
    Console.WriteLine("4. All Three");
    Console.WriteLine("5. Quit");
    Console.Write("Choose 1 through 5: ");
    choice = Convert.ToInt32 (Console.ReadLine());

    // The if statements decide what to do with the user input

    if (choice <= 0 || choice >= 6)
    {
        Console.WriteLine("Choose a number from 1 to 5.");
        Console.Write("Choose 1 through 5: ");
        choice = Convert.ToInt32 (Console.ReadLine());
    }

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
        //Intro text before setting variables to empty or 0 before use in the dice table game

        Console.WriteLine();
        Console.WriteLine("=== Exercise 2: The Dice Table ===");
        int rolls = 0;
        int win = 0;
        char rollAgain;

        // This loop run untill the user press n at the end of the first roll to end it untill then it will go thoght the game of dice table The code will also play at least one round when started
    
        do
        {
            rolls++;
            int roll1 = rng.Next(1,7);
            int roll2 = rng.Next(1,7);
            int total = roll1+roll2;
            if (roll1 == 1 && roll2 == 1)
            {
                Console.WriteLine($"Roll {rolls}: {roll1} and {roll2}, total {total}. Snake eyes.");
            }
            else if (roll1 == roll2)
            {
                Console.WriteLine($"Roll {rolls}: {roll1} and {roll2}, total {total}. Doubles!");
            }
            else if (total == 7 || total == 11)
            {
                Console.WriteLine($"Roll {rolls}: {roll1} and {roll2}, total {total}. A winner.");
                win ++;
            }
            else
            {
                Console.WriteLine($"Roll {rolls}: {roll1} and {roll2}, total {total}.");
            }
            Console.Write("Roll again? (y/n): ");
            rollAgain = char.ToUpper(Convert.ToChar(Console.ReadLine()));
        }while(rollAgain == 'Y');

        // exit massage for the game set outside the loop so that is only shows once when leveling the game
        
        Console.WriteLine($"You rolled {rolls} times and won {win}.");
    }

    if (choice == 3 || choice == 4)
    {

        // Set up header and variables needed for the loops

        Console.WriteLine();
        Console.WriteLine("=== Exercise 3: The Score Report ===");
        int[] scoreReport = new int[5];
        int scoreCount = 0;

        //This loop uses the scoreCount to keep track of the score number and print it the loop adds one ever time the loop runs after the the user is ask for the score and the score number is added to the array scoreReport
        //The loop end after 5 score report are enterd based on the i variable 

        for (int i=0; i<=4; i++)
        {
            scoreCount++;
            Console.Write($"What is Score {scoreCount}: ");
            scoreReport[i] = Convert.ToInt32(Console.ReadLine());
        }

        //Values needed for counting as the foreach loop loops
        int totalSum = 0;
        int passCount = 0;
        int indexCount = 0;
        Array.Sort(scoreReport);

        // This loop goes thogh each value in the array ans output sats in the final loop 

        foreach(int n in scoreReport)
        {
            indexCount ++;
            double lengthScore = scoreReport.Length;
            totalSum += n;
            int highestScore = scoreReport[4];

            if( n >= 70 )
            {
                passCount++; 
            }

            if(indexCount == 5)
            {
                Console.WriteLine();
                Console.WriteLine($"Scores entered: {lengthScore}");
                Console.WriteLine($"Total: {totalSum}");
                double scoreAvg = totalSum/lengthScore;
                Console.WriteLine($"Average: {scoreAvg}");
                Console.WriteLine($"Highest: {highestScore}");
                Console.WriteLine($"Passing: {passCount} of {lengthScore}");
            }
        }
    }
}while(choice != 5);
//prints goodbye 
Console.WriteLine();
Console.WriteLine("Goodbye.");