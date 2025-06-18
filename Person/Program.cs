using System.Runtime.CompilerServices;

class Progran
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("bob");
        // Person myPerson = new Person("bob", "lemi", 34);
        // Console.WriteLine(myPerson.GetPersonInformation());

        PoliceMan myPoliceMan = new PoliceMan("bob", "Tom", 35, "noting",40, 40.05);
        //Console.WriteLine(myPoliceMan.GetPersonInformation());
        // Console.WriteLine(myPoliceMan.GetPoliceManInformation());
        Doctor mydoctor = new Doctor("bob", "Said", 35, "noting", 12000000);
        //Console.WriteLine(mydoctor.GetPersonInformation());
        // Console.WriteLine(mydoctor.GetPoliceManInformation());

        List<Person> myPeople = new List<Person>();
        // myPeople.Add(myPerson);
        myPeople.Add(myPoliceMan);
        myPeople.Add(mydoctor);

        foreach (Person person in myPeople)
        {
            displaypersoninformation(person);
        }
    }

    private static void displaypersoninformation(Person Person)
    {
        Console.WriteLine(Person.GetPersonInformation());
        Console.WriteLine($"pay :{Person.GetPay()}");
    }
}

