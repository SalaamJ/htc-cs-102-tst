using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RiggedBlackjack
{
    public class Blackjack
    {
        public int CardA { get; set; }
        public int CardB { get; set; }
        public int CardC { get; set; }
        public int CardD { get; set; }
        public int CardE { get; set; }

        public List<int> Cards;

        public Blackjack(int cardA, int cardB, int cardC, int cardD, int cardE, int cardF, int cardG)
        {
            CardA = cardA;
            CardB = cardB;
            CardC = cardC;
            CardD = cardD;
            CardE = cardE;
            CardF = cardF;
            CardG = cardG;
        }

        public void DrawCardA()
        {
            MessageBox.Show("Your card is " + cardA + ".");
        }

        public void DrawCardB()
        {
            MessageBox.Show("Your card is " + cardB + ".");
        }

        public void DrawCardC()
        {
            MessageBox.Show("Your card is " + cardC + ".");
        }

        public void DrawCardD()
        {
            MessageBox.Show("Your card is " + cardD + ".");
        }

        public void DrawCardE()
        {
            MessageBox.Show("Your card is " + cardE + ".");
        }

        public void DrawCardF()
        {
            MessageBox.Show("Your card is " + cardF + ".");
        }

        public void DrawCardG()
        {
            MessageBox.Show("Your card is " + cardG + ".");
        }

        public void DisplayInformation()
        {
            MessageBox.Show($"CardA:{CardA} \n CardB:{CardB} \n CardC:{CardC} \n CardD:{CardD} \n CardE:{CardE} \n CardF:{CardF} \n CardG:{CardG}");
        }
    }
}