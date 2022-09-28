using System;
using System.Collections.Generic;
using System.Text;

namespace cwiczenie15
{
    class Owner
    {
        private Jewels returnedContents;
        public void ReceiveContents(Jewels safeContents)
        {
            returnedContents = safeContents;
            Console.WriteLine("Dziękuje za zwrócenie klejnotowi! " + safeContents.Sparkle());
        }

    }
}
