using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {// This is prep 2!
        Console.WriteLine("What grade did you receive in your course?");
        string response = Console.ReadLine();
        int percentage = int.Parse(response);
        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        } 
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your Grade for the Course is : {letter}");

        if (percentage >= 70)
        {
            Console.WriteLine("You Passed the Course, Congratulations!!!");
        }
        else
        {
            Console.WriteLine("Sorry, but your score was not high enough to pass this course. Better luck next time!");
        }
    }
}  
