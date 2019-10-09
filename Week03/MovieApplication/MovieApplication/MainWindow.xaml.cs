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

namespace MovieApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Movie submitedMovie = new Movie();

            submitedMovie.Title = TitleTextBox.Text;
            submitedMovie.Genre = GenreTextBox.Text;
            submitedMovie.ReviewScore = Convert.ToDouble(ReviewScoreTextBox.Text);
            submitedMovie.ReviewScore = Double.Parse(ReviewScoreTextBox.Text);
        }
    }
}
