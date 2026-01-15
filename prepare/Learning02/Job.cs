using System;

public class Job
{
    public string _jobRole;
    public string _companyName;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobRole} at {_companyName} ({_startYear} - {_endYear})");
    }
}