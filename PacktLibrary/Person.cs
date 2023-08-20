using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared;

public class Person : Object
{
    //fields
    public string? Name;
    public DateTime DateOfBirth;
    public List<Person> Children = new();

    //methods
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {DateOfBirth:dddd}");
    }

    //정적메서드 (static 메서드)
    public static Person Procreate(Person p1, Person p2)
    {
        Person baby = new()
        {
            Name = $"Baby of {p1.Name} and {p2.Name}"
        };
        p1.Children.Add(baby);
        p2.Children.Add(baby);
        return baby;
    }

    //instance method
    public Person ProcreateWith(Person partner)
    {
        return Procreate(this, partner);
    }

    // * 연산자
    public static Person operator *(Person p1, Person p2)
    {
        return Person.Procreate(p1, p2);
    }

    //local method
    public static int Factorial(int number)
    {
        if(number < 0)
        {
            throw new ArgumentException($"{nameof(number)} cannot be less than zero");
        }
        return localFactorial(number);

        int localFactorial(int localNumber)
        {
            if (localNumber == 1) return 1;  
            return localNumber * localFactorial(localNumber - 1);
            
        }
    }

    //delegate 델리게이트 사용
    //이벤트 델리게이트 필드
    public event EventHandler? Shout;

    //데이터 필드
    public int AngerLevel;

    //method
    public void Poke()
    {
        AngerLevel++;
        if(AngerLevel >= 3)
        {
            /*
            if(Shout != null)
            {
                Shout(this, EventArgs.Empty);
            }
            */
            Shout?.Invoke(this,EventArgs.Empty);
        }
    }

    

}