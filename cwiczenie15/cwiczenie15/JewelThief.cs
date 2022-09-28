using System;
using System.Collections.Generic;
using System.Text;

namespace cwiczenie15
{
    class JewelThief : Locksmith { 
    
    
        private Jewels stolenJewels = null;
      new  public void ReturnContents(Jewels safeContents, Owner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine("kradnę zawartość sejfu! " + stolenJewels.Sparkle());
        }
    }
}
