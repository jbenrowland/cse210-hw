using System;

// Abstract class defining the structure for user interactions
public abstract class UserInteraction
{
    public abstract void DisplayWelcomeMessage();
    public abstract string PromptUserName();
    public abstract int PromptUserNumber();
    public abstract void DisplayResult(string name, int square);
}

// Concrete implementation of UserInteraction
public class ConsoleUserInteraction : UserInteraction
{
    public override void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    public override string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    public override int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    public override void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        UserInteraction userInteraction = new ConsoleUserInteraction();

        userInteraction.DisplayWelcomeMessage();

        string userName = userInteraction.PromptUserName();
        int userNumber = userInteraction.PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        userInteraction.DisplayResult(userName, squaredNumber);
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }
}
