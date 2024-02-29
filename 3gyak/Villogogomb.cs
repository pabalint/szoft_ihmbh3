using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace _3gyak
{
    internal class Villogogomb : Button
    {
        public Villogogomb()
        {
            MouseEnter += Villogogomb_MouseEnter;
            MouseLeave += Villogogomb_MouseLeave;
            Random rnd = new Random();
            BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            Height = rnd.Next(50);
            Width = rnd.Next(50);


        }

        private void Villogogomb_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = Color.Transparent;
        }

        private void Villogogomb_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}
