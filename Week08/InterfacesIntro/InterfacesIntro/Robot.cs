using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InterfacesIntro
{
    class Robot : IWalker
    {
        public int NumLegs { get; set; }

        public double StrideLength { get; set; }

        public string Name { get; set; }

        public string Height { get; set; }

        public Robot()
        {

        }

        public void walk()
        {
            MessageBox.Show("Beep Boop " + NumLegs + " legs.");
        }
    }
}
