public class Job
{
    public string _company;
    public string _jobTitle; 
    public int _startYear;
    public int _endYear;
    
    public  void SetEndYear(int endYear)
    {

        _endYear = endYear;
    }
    public  void SetCompany(string company)
    {

        _company = company;
    }
    public  void SetJobTitle(string jobTitle)
    {

        _jobTitle = jobTitle;
    }
    public  void SetStartYear(int startYear)
    {

        _startYear = startYear;
    }
    public void DesplayJobInfo()
    {
        
        Console.Write($"{_jobTitle} ");
        Console.Write($"({_company}) ");
        Console.Write(_startYear);
        Console.WriteLine($"- {_endYear}");
    }
    
}