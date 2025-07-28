using System;

public class Assigment
{
    private string _studentName;
    private string _topic;

    public string GetName()
    {
        return _studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public Assigment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}