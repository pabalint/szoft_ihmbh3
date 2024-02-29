using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _3gyak
{
    internal class Szamologomb : Villogogomb
    {
        int szam = 1;
        public Szamologomb()
        {
            MouseClick += Szamologomb_MouseClick;

        }

        private void Szamologomb_MouseClick(object? sender, MouseEventArgs e)
        {
            szam++;
            if (szam > 6)
            {
                szam = 1;
            }
            Text = szam.ToString();
        }
    }
}
