class PoliceMan : Person
{
    private string _weapons;
    public PoliceMan(string firstName, string lastName, int Age, string weapons) :
    base(firstName, lastName, Age)
    {
        _weapons = weapons;
    }

    public string GetPoliceManInformation()
    {
        return $"Weapons: {_weapons} :: {GetPersonInformation()}";
    }
    public override string GetPersonInformation()
    {
        return $"I am a Police Man. Weapons: {_weapons} { base.GetPersonInformation()}";
    }
}