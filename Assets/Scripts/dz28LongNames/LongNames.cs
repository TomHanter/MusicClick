using System;
using System.Linq;

public class LongNames
{
    public static void Main()
    {
        string[] names = { "Miles", "Luis", "Iris", "Olivia", "Emma" , "Amelia", "Isabella", "Ava", "Charlotte",};

        var endS = from name in names
            where name.EndsWith("s")
            select name;
        
        foreach (var name in endS)
        {
            Console.Write(name + " ");
        }

        var maxLength = names.Max(name => name.Length);
        
        Console.WriteLine(maxLength);
        Console.ReadKey();
    }
}
