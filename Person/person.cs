class person
{
    private string _firstname;
    private string _lastname;
    private int _age;

    public person()
    {
        _firstname = "";
        _lastname = "";
        _age = 0;
    }
    public person(string firstname, string lastname, int age)
    {
        _firstname = firstname;
        _lastname = lastname;
        _age = age;
    }
    public string GetPersonInformation()
    {
        return $"{_firstname} {_lastname} age: {_age}";
    }
 }