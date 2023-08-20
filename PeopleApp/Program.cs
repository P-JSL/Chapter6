using Packt.Shared;
using static System.Console;

namespace PeopleApp;

public class Program
{
    static void Main(string[] args)
    {
        Person harry = new() { Name = "Harry" };
        Person mary = new() { Name = "Mary" };
        Person jill = new() { Name = "Jill" };

        //instance method call.
        Person baby1 = mary.ProcreateWith(harry);
        baby1.Name = "Gary";

        //static method call
        Person baby2 = Person.Procreate(harry,jill);
        //static method call
        Person baby3 = harry * mary;

        WriteLine($"{harry.Name} has {harry.Children.Count} children.");
        WriteLine($"{mary.Name} has {mary.Children.Count} children.");
        WriteLine($"{jill.Name} has {jill.Children.Count} children.");
        WriteLine(
            format:"{0}`s first child is named \"{1}\".",
            arg0:harry.Name,
            arg1: harry.Children[0].Name
            );

        WriteLine($"5! is {Person.Factorial(5)}");

        static void Harry_Sshout(object? sender, EventArgs e)
        {
            if (sender is null) return;
            Person p = (Person)sender;
            WriteLine($"{p.Name} is this angry : {p.AngerLevel}.");
        }

        harry.Shout += Harry_Sshout;
        harry.Poke();
        harry.Poke();
        harry.Poke();
        harry.Poke();

        // non-generic collection
        System.Collections.Hashtable lookupObject = new();
        lookupObject.Add(key: 1, value: "Alpha");
        lookupObject.Add(key: 2, value: "Beta");
        lookupObject.Add(key: 3, value: "Gamma");
        lookupObject.Add(key: 4, value: "Delta");

        int key = 3;
        WriteLine(
            format: "key {0} has value : {1}",
            arg0: key,
            arg1: lookupObject[key]
            );

        WriteLine(
            format: "key {0} has value : {1}",
            arg0: "harry",
            arg1: lookupObject[harry]
            );

        // generic-collections
        Dictionary<int, string> lookupIntString = new();
        lookupIntString.Add(key: 1, value: "Alpha");
        lookupIntString.Add(key: 2, value: "Beta");
        lookupIntString.Add(key: 3, value: "Gamma");
        lookupIntString.Add(key: 4, value: "Delta");

        WriteLine(
            format: "key {0} has value : {1}",
            arg0: key,
            arg1: lookupIntString[key]
            );
    }
}