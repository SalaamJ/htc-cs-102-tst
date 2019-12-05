using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InterfacesIntro
{
    public class Frog : Animal
    {
        public bool IsPoisonous;

        public override void Speak()
        {
            MessageBox.Show("Ribbit");
        }

        public Frog() { }

        public Frog(bool isPoisonous, int height, string name, int numLegs, double strideLength)
        {
            this.Height = height;
            this.Name = name;
            this.NumLegs = numLegs;
            this.StrideLength = strideLength;
            this.IsPoisonous = isPoisonous;
        }
    }
}
