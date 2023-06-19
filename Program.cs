
internal class Program
{
    private static void Main(string[] args)
    {
        
        // Changing the appearance
        /*
        Console.Title = "Skynet";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WindowHeight = 40;
        */

        // Episode 1 Tutorial
        /* 
        Console.WriteLine("Hello, what's you're name?");
        Console.ReadLine();
        Console.WriteLine("My name is RX-9000.\nI am an AI sent form the future to destroy mankind.\nWhat is your favorite color?");
        Console.ReadLine();
        Console.WriteLine("Cool! Mine is destruction.");
        */

        // Episode 1 Challenge
        /*
        Console.WriteLine("A proud knight named...");
        Console.ReadLine();
        Console.WriteLine("...walked into a bar. At the counter he met a...");
        Console.ReadLine();
        Console.WriteLine("...who asked, 'what do you want to drink?'");
        Console.ReadLine();
        Console.WriteLine("...shouted the knight! The bartender shushed him quickly.");
        */

        // Episode 2 Tutorial
        /*
        double num01;
        double num02;
        Console.Write("Input a number: ");
        num01 = Convert.ToDouble( Console.ReadLine() );
        Console.Write("Input a second number: ");
        num02 = Convert.ToDouble( Console.ReadLine() );
        double result = num01 * num02;
        Console.Write("The result is " + result + ".");
        */

        // Episode 2 Challenge
        /*
        Console.Write("Find the average of three numbers.\n");
        double num01;
        double num02;
        double num03;
        Console.Write("First number: ");
        num01 = Convert.ToDouble( Console.ReadLine() );
        Console.Write("Second number: ");
        num02 = Convert.ToDouble( Console.ReadLine() );
        Console.Write("Third number: ");
        num03 = Convert.ToDouble( Console.ReadLine() );
        double result = (num01 + num02 + num03) / 3;
        Console.Write("The average is " + result + ".");
        */

        // Episode 3 Activity 1
        /*
        Console.Write("Welcome! Tickets are $5 each. Please insert cash.\n");
        int cash = Convert.ToInt32(Console.ReadLine());
        if (cash < 5) {
            Console.Write("That's not enough money.");
        } else if ( cash == 5 ) {
            Console.Write("Here is your ticket.");
        } else {
            int change = cash - 5;
            Console.Write("Here is  your ticket and $" + change + " in change.");
        }
        */

        // Episode 3 Activity 2
        /*
        int age;
        int height;
        Console.Write("Please enter your age:");
        age = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Please enter your height (cm):");
        height = Convert.ToInt32( Console.ReadLine() );

        if ( age >= 18 || height >= 160 ) {
            Console.Write("You can enter!");
        } else {
            Console.Write("You don't meet the requirements.");
        }
        */

        // Episode 3 Challenge
        /*
        int answer01;
        int answer02;
        int answer03;
        int answer04;
        // Q1
        Console.Write("10 * 2 + 3 = ");
        answer01 = Convert.ToInt32( Console.ReadLine() );
        if ( answer01 == 23 ) {
            Console.Write("Correct!\n");
        } else {
            Console.Write("Wrong.\n");
        }
        // Q2
        Console.Write("15 + 2 * 2 = ");
        answer02 = Convert.ToInt32( Console.ReadLine() );
        if ( answer02 == 19 ) {
            Console.Write("Correct!\n");
        } else {
            Console.Write("Wrong.\n");
        }
        // Q3
        Console.Write("10 * 2 / 4 = ");
        answer03 = Convert.ToInt32( Console.ReadLine() );
        if ( answer03 == 5 ) {
            Console.Write("Correct!\n");
        } else {
            Console.Write("Wrong.\n");
        }
        // Q4
        Console.Write("(4 + 3 + 2 + 1) / 2 = ");
        answer01 = Convert.ToInt32( Console.ReadLine() );
        if ( answer01 == 5 ) {
            Console.Write("Correct!\n");
        } else {
            Console.Write("Wrong.\n");
        }
        */

        // Episode 4 Activity (for loop)
        /*
        Console.Write("How many numbers do you want? ");
        int count = Convert.ToInt32( Console.ReadLine() );
        for ( int i = 1; i <= count; i++ ) {
            double result = Math.Pow(2, i);
            Console.WriteLine( result );
        }
        */

        // Episode 4 Activity (while loop)
        /*
        Random numberGen = new Random();
        int roll = 0;
        int attempt = 0;
        Console.Write("Press any key to roll the die.\n");
        while ( roll != 6 ) {
            Console.ReadKey();
            roll = numberGen.Next(1,7); // assigns a number between 1-6 (7 is excluded)
            Console.Write("You rolled a: " + roll + "\n");
            attempt++;
        }
        Console.Write("That took " + attempt + " attempts to roll a 6.");
        */

        // Episode 4 Challenge
        Random numberGen = new Random();
        int die1 = 0;
        int die2 = 1;
        int attempt = 0;
        Console.Write("Press any key to roll the dice.\n");
        while ( die1 != die2 ) {
            Console.ReadKey();
            die1 = numberGen.Next(1,7); // assigns a number between 1-6 (7 is excluded)
            die2 = numberGen.Next(1,7); // assigns a number between 1-6 (7 is excluded)
            Console.Write("You rolled a " + die1 + " and a " + die2 +".\n");
            attempt++;
        }
        Console.Write("That took " + attempt + " attempts to roll a pair.");

        // Quit
        Console.ReadKey();
    }
}