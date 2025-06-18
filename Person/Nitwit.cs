class NitWit : Person
{
    public NitWit(string firstName, string lastName, int Age) : base(firstName, lastName, Age)
    { }

    public override double GetPay()
    {
        return 0.0;
    }


}