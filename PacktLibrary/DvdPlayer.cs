using System;
using static System.Console;
using System.Collections.Generic;

namespace Packt.Shared;

public class DvdPlayer : Iplayable
{
    public void Pause()
    {
        WriteLine("DVD player is pausing");
    }

    public void Play()
    {
        WriteLine("DVD player is playing");
    }
}
