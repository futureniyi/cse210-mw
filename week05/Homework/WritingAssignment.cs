public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    // public string GetTextbookSection()
    // {
    //     return _textbookSection;
    // }

    // public void SetTextbookSection(string TextbookSection)
    // {
    //     _textbookSection = TextbookSection;
    // }

    // public string GetProblems()
    // {
    //     return _problems;
    // }

    // public void SetProblems(string problems)
    // {
    //     _problems = problems;
    // }

    // public string GetSummary()
    // {
    //     return $"{_studentName} - {_topic}";
    // }

    public string GetWritingInformation()
    {
        return $"{_title}";
    }


}