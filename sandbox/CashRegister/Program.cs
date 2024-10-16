using System;

class Program
{
    static void main(string[] args)
    {
        Console.WriteLine("Hello, Cash Register!");

        Bin myBin = new("quarters",0.25,40);
        myBin.ModifyQuantity(+6);
        Console.WriteLine(myBin.CountValue());
    }
}
