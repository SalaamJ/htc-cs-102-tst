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
        int CardA;
        int CardB;
        int CardC;
        int CardD;
        int CardE;
        int CardF;
        int CardG;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void DrawCardA_Click(object sender, RoutedEventArgs e)
        {
            CardA = randomCard();
        }
        private void DrawCardB_Click(object sender, RoutedEventArgs e)
        {
            CardB = randomCard();
        }
        private void DrawCardC_Click(object sender, RoutedEventArgs e)
        {
            CardC = randomCard();
        }
        private void DrawCardD_Click(object sender, RoutedEventArgs e)
        {
            CardD = randomCard();
        }
        private void DrawCardE_Click(object sender, RoutedEventArgs e)
        {
            CardE = randomCard();
        }
        private void DrawCardF_Click(object sender, RoutedEventArgs e)
        {
            CardF = randomCard();
        }
        private void DrawCardG_Click(object sender, RoutedEventArgs e)
        {
            CardG = randomCard();
        }
        public int randomCard()
        {
            return rnd.Next(1, 13);
        }
        public void Random()
        {
            Random rnd = new Random();
            int DrawCardA = rnd.Next(1, 13);
            int DrawCardB = rnd.Next(1, 13);
            int DrawCardC = rnd.Next(1, 13);
            int DrawCardD = rnd.Next(1, 13);
            int DrawCardE = rnd.Next(1, 13);
            int DrawCardF = rnd.Next(1, 13);
            int DrawCardG = rnd.Next(1, 13);
        }

        private void Cards_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void Cards_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
