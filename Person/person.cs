abstract class Person
{
    private string _firstname;
    private string _lastname;
    private int _age;

    public Person()
    {
        _firstname = "";
        _lastname = "";
        _age = 0;
    }
    public Person(string firstname, string lastname, int age)
    {
        _firstname = firstname;
        _lastname = lastname;
        _age = age;
    }
    public virtual string GetPersonInformation()
    {
        return $"{_firstname} {_lastname} age: {_age}";
    }
    public abstract double GetPay();
 }