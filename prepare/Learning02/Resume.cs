public class Resume
{
    private string _name;
    
    public List<Job> _Job = new List<Job>();

    public void SetName(string name)
    {
        _name = name;
         
    }


    public void DesplayJobs()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _Job)
        {
            job.DesplayJobInfo();
        }
    }
    
         
}