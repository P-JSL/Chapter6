using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared;

public class PersonException :Exception
{
    public PersonException() : base() { }
    public PersonException(string message) : base(message) { }
    public PersonException(string message, Exception innerException) : base(message, innerException) { }
}
