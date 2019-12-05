using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Rigged_Blackjack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void cardDraw1_Click(object sender, RoutedEventArgs e)
        {
            int card1 = randomCard();
        }
        private void cardDraw2_Click(object sender, RoutedEventArgs e)
        {

        }
        private void cardDraw3_Click(object sender, RoutedEventArgs e)
        {

        }
        private void cardDraw4_Click(object sender, RoutedEventArgs e)
        {

        }
        private void cardDrawD1_Click(object sender, RoutedEventArgs e)
        {

        }
        private void cardDrawD2_Click(object sender, RoutedEventArgs e)
        {

        }
        private void cardDrawD3_Click(object sender, RoutedEventArgs e)
        {

        }
        public int randomCard()
        {
            int cardDraw1 = rnd.Next(2, 12);
            return cardDraw1;
        }
        public void Random()
        {
            Random rnd = new Random();
            int cardDraw1 = rnd.Next(2, 12);
            int cardDraw2 = rnd.Next(2, 12);
            int cardDraw3 = rnd.Next(2, 12);
            int cardDraw4 = rnd.Next(2, 12);
            int dealerCard1 = cardDraw1 + 1;
            int dealerCard2 = cardDraw2 + 1;
            int dealerCard3 = cardDraw3 - 1;
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
