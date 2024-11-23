using System;
using System.Collections.Generic;
using System.IO;

public abstract class BaseGoal
{
    public string Name { get; set; }
    public int PointsPerCompletion { get; set; }
    public bool IsComplete { get; set; }

    public abstract void RecordCompletion();
    public abstract int GetPoints();
}

public class SimpleGoal : BaseGoal
{
    public override void RecordCompletion()
    {
        IsComplete = true;
    }

    public override int GetPoints()
    {
        return IsComplete ? PointsPerCompletion : 0;
    }
}

public class EternalGoal : BaseGoal
{
    public override void RecordCompletion()
    {
        // No specific action, points are awarded each time
    }

    public override int GetPoints()
    {
        return PointsPerCompletion;
    }
}

public class ChecklistGoal : BaseGoal
{
    public int TargetCompletions { get; set; }
    public int CurrentCompletions { get; set; }

    public override void RecordCompletion()
    {
        CurrentCompletions++;
        if (CurrentCompletions >= TargetCompletions)
        {
            IsComplete = true;
        }
    }

    public override int GetPoints()
    {
        return CurrentCompletions * PointsPerCompletion + (IsComplete ? 100 : 0); // Bonus for completion
    }
}

public class User
{
    public string Name { get; set; }
    public int Score { get; set; }
    public List<BaseGoal> Goals { get; set; }

    public void AddGoal(BaseGoal goal)
    {
        Goals.Add(goal);
    }

    public void RecordGoalCompletion(int index)
    {
        Goals[index].RecordCompletion();
        Score += Goals[index].GetPoints();
    }

    public void Save()
    {
        // Implement saving user data to a file
    }

    public void Load()
    {
        // Implement loading user data from a file
    }
}

public class Program
{
    static void Main(string[] args)
    {
        User user = new User();
        // ... (rest of the program logic)
    }
}