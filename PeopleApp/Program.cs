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
        Person baby2 = Person.Procreate(harry, jill);
        //static method call
        Person baby3 = harry * mary;

        WriteLine($"{harry.Name} has {harry.Children.Count} children.");
        WriteLine($"{mary.Name} has {mary.Children.Count} children.");
        WriteLine($"{jill.Name} has {jill.Children.Count} children.");
        WriteLine(
            format: "{0}`s first child is named \"{1}\".",
            arg0: harry.Name,
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

        Person[] people =
        {
            new(){Name="Simon"},
            new(){Name="Jenny"},
            new(){Name="Adam"},
            new(){Name="Richard"}
        };

        WriteLine("Initial list of people.");
        foreach (Person p in people)
        {
            WriteLine($"    {p.Name}");
        }
        WriteLine("Use Person`s IComparable implementation to sort: ");
        Array.Sort(people);
        foreach (Person p in people)
        {
            WriteLine($"    {p.Name}");
        }

        WriteLine("Usa PersonComplarer`s IComparer implementation to sort : ");
        Array.Sort(people, new PersonComparer());
        foreach (var p in people)
        {
            WriteLine($"    {p.Name}");
        }

        DisplacementVector dv1 = new(3, 5);
        DisplacementVector dv2 = new(-2, 7);
        DisplacementVector dv3 = dv1 + dv2;

        WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X}, {dv3.Y})");

        Employee john = new()
        {
            Name = "John Jones",
            DateOfBirth = new(year: 1990, month: 7, day: 28)
        };
        john.WriteToConsole();

        john.EmployeeCode = "JJ001";
        john.HireDate = new(year: 2014, month: 11, day: 23);
        WriteLine($"{john.Name} was hired on {john.HireDate:dd/MM/yy}");

        Employee aliceInEmployee = new()
        {
            Name = "Alice",
            EmployeeCode = "AA123"
        };
        Person aliceInPerson = aliceInEmployee;
        aliceInEmployee.WriteToConsole();
        aliceInPerson.WriteToConsole();
        WriteLine(aliceInEmployee.ToString());
        WriteLine(aliceInPerson.ToString());

        //명시적 캐스팅
        //Employee explicitAlice =(Employee) aliceInPerson;

        //캐스팅 예외
        if (aliceInPerson is Employee explicitAlice)
        {
            WriteLine($"{nameof(aliceInPerson)} IS an Employee");
            //Employee explicitAlice = (Employee)aliceInPerson;

            //explicitAlice  사용
        }

        Employee? aliceAsEmployee = aliceInPerson as Employee;
        //if(aliceInEmployee != null)
        if (aliceAsEmployee is not Employee)
        {
            WriteLine($"{nameof(aliceInEmployee)} AS an Employee");
        }

        try
        {
            john.TimeTravel(when: new(1999, 12, 31));
            john.TimeTravel(when: new(1950, 12, 25));
        }
        catch (PersonException ex)
        {
            WriteLine(ex.Message);
        }

        string email1 = "pamela@test.com";
        string email2 = "ian&test.com";
        WriteLine("{0} is a  vaild e-mail address : {1}",
            arg0: email1,
            arg1: email1.IsVaildEmail());
        WriteLine("{0} is a  vaild e-mail address : {1}",
            arg0: email2,
            arg1: email2.IsVaildEmail());


    }
}