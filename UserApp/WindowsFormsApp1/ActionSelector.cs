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
        private int selectedMovieId;
        private Movies selectedMovie;
        private Movies movieForReviews;
        public Users currentUser;
        public Controller controller = new Controller();
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDb;Initial Catalog=MovieDatabase;Integrated Security=True";

        public ActionSelector(Users user)
        {
            InitializeComponent();
            currentUser = user;
            uxMoviesList.DataSource = controller.GetMovies();
            uxMovieListComboBox.DataSource = controller.GetMovies();
            uxMoviesList.SelectedIndex = -1;
            ux_MovieBox.DataSource = controller.GetMovies();
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

        private void ux_GenrePopulateButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * FROM Movie.Genres", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                ux_GenresDataView.DataSource = dtbl;
            }
        }

        private void ux_CalcHighestPaidWithin_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("Movie.HighestPaidWithin", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StartDate", ux_StartDatePicker.Value);
                cmd.Parameters.AddWithValue("@EndDate", ux_EndDatePicker.Value);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                ux_HighestPaidWithinData.DataSource = dtbl;
            }
        }

        private void ux_ASPbGButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("Movie.AverageStudioProfitByGenre", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@GenreId", ux_GenrePicker.Value);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                ux_ASPbGDataGrid.DataSource = dtbl;
            }
        }

        private void ux_APCbGButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("Movie.AverageCostProductionByGenre", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@GenreId", ux_APCbGGenrePicker.Value);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                ux_APCbGDataGrid.DataSource = dtbl;
            }
        }

        private void uxAddUserButton_Click(object sender, EventArgs e)
        {
            AddMovieItem(MovieItems.User);
        }

        private void ux_MovieCompareButton_Click(object sender, EventArgs e)
        {
                using (SqlConnection sqlcon = new SqlConnection(connectionString))
                {
                    sqlcon.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand("Movie.RatingCompareByMovieName", sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MovieId", selectedMovieId);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    ux_MovieCompareDataGrid.DataSource = dtbl;
                }
        }

        private void ux_MovieBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ux_MovieBox.SelectedItem != null && ux_MovieBox.SelectedIndex >= 0 && ux_MovieBox.SelectedItem is Movies movie)
            {
                selectedMovie = controller.FetchMovie(movie.MovieId);
                selectedMovieId = selectedMovie.MovieId;
            }
        }
    }
}
