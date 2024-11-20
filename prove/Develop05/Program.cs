using System;
using System.IO; //For StreamWriter
class Program
{
    private static int _totalScore = 0;
    private static Goal[] _goals = new Goal[10];
    private static int _goalCount = 0;

    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("\nEternal Quest Program");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Select an option: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    RecordGoalEvent();
                    break;
                case 3:
                    DisplayGoals();
                    break;
                case 4:
                    Console.WriteLine("Total Score: " + _totalScore);
                    break;
                case 5:
                    SaveGoals();
                    break;
                case 6:
                    LoadGoals();
                    break;
            }
        } while (choice != 7);
    }
    static void CreateGoal()
    {
        Console.WriteLine("\nSelect Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choice: ");
        int goalType = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = Convert.ToInt32(Console.ReadLine());

        if (goalType == 1)
        {
            _goals[_goalCount++] = new SimpleGoal(name, description, points);
        }
        else if (goalType == 2)
        {
            _goals[_goalCount++] = new EternalGoal(name, description, points);
        }
        else if (goalType == 3)
        {
            Console.Write("Enter target count: ");
            int targetCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonusPoints = Convert.ToInt32(Console.ReadLine());
            _goals[_goalCount++] = new ChecklistGoal(name, description, points, targetCount, bonusPoints);
        }
    }
    static void RecordGoalEvent()
    {
        Console.WriteLine("\nSelect a goal to record:");
        for (int i = 0; i < _goalCount; i++)
        {
            Console.WriteLine((i + 1) + ". " + _goals[i].GetInfo());
        }
        Console.Write("Choice: ");
        int choice = Convert.ToInt32(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < _goalCount)
        {
            int pointsEarned = _goals[choice].RecordEvent();
            _totalScore += pointsEarned;
            Console.WriteLine("Points earned: " + pointsEarned);
        }
    }
    static void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goalCount; i++)
        {
            Console.WriteLine(_goals[i].GetInfo());
        }
    }
static void SaveGoals()
{
    Console.Write("Enter filename to save goals: ");
    string fileName = Console.ReadLine();
    
    try
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            for (int i = 0; i < _goalCount; i++)
            {
                Goal goal = _goals[i];
                string goalData = goal.GetType().Name + "|" + goal.GetInfo() + "|" + goal.GetPoints() + "|" + goal.IsCompleted.ToString();
                writer.WriteLine(goalData);
            }
        }

        Console.WriteLine("Goals have been saved to " + fileName);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error saving goals: " + ex.Message);
    }
}
static void LoadGoals()
{
    Console.Write("Enter filename to load goals: ");
    string fileName = Console.ReadLine();
    
    try
    {
        string[] lines = File.ReadAllLines(fileName);
        _goalCount = 0; 

        foreach (string line in lines)
        {
            if (!string.IsNullOrEmpty(line))
            {
                string[] goalData = line.Split('|');
                if (goalData.Length < 5)
                {
                    Console.WriteLine($"Skipping invalid goal data: {line}");
                    continue;
                }
                string goalType = goalData[0];
                string goalName = goalData[1];
                string goalDescription = goalData[2];
                int goalPoints = int.Parse(goalData[3]);
                bool isCompleted = false;
                if (!bool.TryParse(goalData[4], out isCompleted))
                {
                    Console.WriteLine($"Error parsing IsCompleted for goal '{goalName}'. Setting it to false.");
                }
                if (goalType == "SimpleGoal")
                {
                    _goals[_goalCount++] = new SimpleGoal(goalName, goalDescription, goalPoints) { IsCompleted = isCompleted };
                }
                else if (goalType == "EternalGoal")
                {
                    _goals[_goalCount++] = new EternalGoal(goalName, goalDescription, goalPoints) { IsCompleted = isCompleted };
                }
                else if (goalType == "ChecklistGoal")
                {
                    _goals[_goalCount++] = new ChecklistGoal(goalName, goalDescription, goalPoints, 5, 10) { IsCompleted = isCompleted };
                }
            }
        }

        Console.WriteLine("Goals have been loaded from " + fileName);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error loading goals: " + ex.Message);
    }
}
}