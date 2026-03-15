public class MathAssignment :Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName,string textbookSection, string problems, string topic )
    :base(studentName,topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
       public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}




