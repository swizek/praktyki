﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenie9
{
    class Elephant
    {
        public int EarSize;
        public string Name;
        public void WhoAmI()
        {
            MessageBox.Show("Moje uszy mają" + EarSize + "centymetrów szerokości", Name + "mówi...");
        }
    }
}
