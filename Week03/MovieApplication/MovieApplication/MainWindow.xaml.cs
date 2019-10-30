using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
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

        ObservableCollection<Movie> movieList = new ObservableCollection<Movie>();

        //List<Movie> movieList = new List<Movie>();

        public MainWindow()
        {
            InitializeComponent();
            movieListView.ItemsSource = movieList;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Movie submittedMovie = new Movie(TitleTextBox.Text, 
                                            GenreTextBox.Text, 
                                            Double.Parse(ReviewScoreTextBox.Text),
                                            DirectorTextBox.Text,
                                            LengthTextBox.Text);

            movieList.Add(submittedMovie);
            //submittedMovie.Title = TitleTextBox.Text;
            //submittedMovie.Genre = GenreTextBox.Text;
            //submitedMovie.ReviewScore = Convert.ToDouble(ReviewScoreTextBox.Text);
            //submittedMovie.ReviewScore = Double.Parse(ReviewScoreTextBox.Text);

            //submittedMovie.DisplayInformation();

            TitleTextBox.Clear();
            GenreTextBox.Clear();
            ReviewScoreTextBox.Clear();
            DirectorTextBox.Clear();
            LengthTextBox.Clear();

        }

        private void movieListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Movie selectedMovie = movieListView.SelectedItem as Movie;

            selectedMovie.DisplayInformation();
        }
    }
}
