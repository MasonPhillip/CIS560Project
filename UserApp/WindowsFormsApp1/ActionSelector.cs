using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class ActionSelector : Form
    {
        public AddMovieItemDel AddMovieItem;

        private Movies selectedMovie;
        private Movies movieForReviews;
        public Users currentUser;
        public Controller controller = new Controller();

        public ActionSelector(Users user)
        {
            InitializeComponent();
            currentUser = user;
            uxMoviesList.DataSource = controller.GetMovies();
            uxMovieListComboBox.DataSource = controller.GetMovies();
            uxMoviesList.SelectedIndex = -1;
        }

        private void UxAddMovies_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void uxGetAllMovies_Click(object sender, EventArgs e)
        {
            uxMoviesList.DataSource = controller.GetMovies();
            uxMoviesList.SelectedIndex = -1;
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            if (title != "")
            {
                uxMoviesList.DataSource = controller.GetMoviesByName(title);
            }
            else
            {
                uxMoviesList.DataSource = controller.GetMovies();
            }
        }

        private void uxAddMovie_Click(object sender, EventArgs e)
        {
            AddMovieItem(MovieItems.Movie);
        }

        public void SetAddMovieItemDel(AddMovieItemDel del)
        {
            AddMovieItem = del;
        }

        private void uxAddPersonalRatingButton_Click(object sender, EventArgs e)
        {
            AddMovieItem(MovieItems.PersonalRating);
        }

        private void uxAddRoleButton_Click(object sender, EventArgs e)
        {
            AddMovieItem(MovieItems.Role);
        }

        private void uxMoviesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(uxMoviesList.SelectedItem != null && uxMoviesList.SelectedIndex >= 0 && uxMoviesList.SelectedItem is Movies movie)
            {
                selectedMovie = controller.FetchMovie(movie.MovieId);
                Studios selectedStudio = controller.FetchStudio(selectedMovie.StudioId);
                Genres selectedGenre = controller.FetchGenre(selectedMovie.GenreId);

                uxStudioTextBox.Text = selectedStudio.StudioName;
                uxGenreTextBox.Text = selectedGenre.Genre;
                uxDomesticTextBox.Text = selectedMovie.DomesticRevenue.ToString();
                uxInternationalTextBox.Text = selectedMovie.InternationalRevenue.ToString();
                uxCostTextBox.Text = selectedMovie.Cost.ToString();
            }
            else
            {
                uxMoviesList.SelectedIndex = -1;
                uxStudioTextBox.Text = "";
                uxGenreTextBox.Text = "";
                uxDomesticTextBox.Text = "";
                uxInternationalTextBox.Text = "";
                uxCostTextBox.Text = "";
            }
        }

        private void uxMovieListComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (uxMovieListComboBox.SelectedItem != null && uxMovieListComboBox.SelectedItem is Movies movie)
            {
                int movieId = movie.MovieId;
                uxReviewsForMovieListBox.DataSource = controller.GetReviewsForMovie(movieId);
            }
            
        }
    }
}
