using System;

public class Job
{
    public string_jobTitle; = "";
    public string_company; = "";
    public int_startYear; = 0;
    public int_endYear; = 0;

    public Job()
    {
    }

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
