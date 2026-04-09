public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points)
        : base(name, description, points) // This sends data to the base Goal class
    {
    }

    public override int RecordEvent()
    {
        // This returns a negative value to subtract from the score
        return -_points; 
    }

    public override bool IsComplete()
    {
        return false; // Negative goals are never "finished"
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{_name},{_description},{_points}";
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_name} ({_description}) -- Lose points if you do this!";
    }
}




    