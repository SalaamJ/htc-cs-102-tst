using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesIntro
{
    class StarwarsRobot : Robot
    {
        int InNumberOfMovies { get; set; }

        public StarwarsRobot(int inNumberOfMovies, double strideLength, int numLegs)
        {
            this.InNumberOfMovies = inNumberOfMovies;
            this.NumLegs = numLegs;
            this.StrideLength = strideLength;
        }
    }
}
