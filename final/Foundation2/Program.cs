using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order("john jons", "", "", "", "");
        order1.addProduct("", 1, 1, 1);
        order1.addProduct("", 2, 1, 1);
        order1.addProduct("", 3, 1, 1);
        order1.PackingLabel();
        order1.ShipingLabel();
        order1.printTotalPrice();
        Order order2 = new Order("", "", "", "", "");
        order2.addProduct("", 1, 1, 1);
        order2.addProduct("", 2, 1, 1);
        order2.addProduct("", 3, 1, 1);
        order2.PackingLabel();
        order2.ShipingLabel();
        order2.printTotalPrice();
        
    }
}