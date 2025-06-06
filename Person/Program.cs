class Progran
{
    public static void Main(string[] args)
    {
        Console.WriteLine("bob");
        person myPerson = new person("bob", "lemi", 34);
        Console.WriteLine(myPerson.GetPersonInformation());

        PoliceMan myPoliceMan = new PoliceMan("bob", "Lemi", 35, "noting");
        //Console.WriteLine(myPoliceMan.GetPersonInformation());
        Console.WriteLine(myPoliceMan.GetPoliceManInformation());

    }
}