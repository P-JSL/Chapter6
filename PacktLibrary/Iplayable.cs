using System;
using static System.Console;
using System.Collections.Generic;

namespace Packt.Shared;

public interface Iplayable
{
    void Play();
    void Pause();

    void Stop()
    {
        WriteLine("Default implementation of Stop.");
    }
}
