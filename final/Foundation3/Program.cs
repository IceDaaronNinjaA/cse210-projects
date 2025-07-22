using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures newEvent1 = new Lectures("", 1, "", "", "", 1, "");
        OutdoorGathering newEvent2 = new OutdoorGathering("", "", "", "", 1, "");
        Reception newEvent3 = new Reception("", "", "", "", 1, "");
        newEvent1.standardDetails();
        newEvent1.FullDetails();
        newEvent1.ShortDetails();
        newEvent2.standardDetails();
        newEvent2.FullDetails();
        newEvent2.ShortDetails();
        newEvent3.standardDetails();
        newEvent3.FullDetails();
        newEvent3.ShortDetails();

    }
}