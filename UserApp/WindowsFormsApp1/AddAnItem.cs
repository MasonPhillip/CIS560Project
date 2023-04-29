using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class AddAnItem : Form
    {
        public Controller controller = new Controller();
        private Users currentUser;
        private MovieItems currentMovieItem;

        public AddAnItem(Users user)
        {
            currentUser = user;
            InitializeComponent();
            uxGenreComboBox.DataSource = controller.GetGenres();
            uxStudioComboBox.DataSource = controller.GetStudios();
        }

        public void InitializeForm(MovieItems item)
        {
            ClearDisplay();
            currentMovieItem = item;

            uxGenreComboBox.DataSource = controller.GetGenres();
            uxMoviesComboBox.DataSource = controller.GetMovies();
            uxPersonComboBox.DataSource = controller.GetPeople();
            uxStudioComboBox.DataSource = controller.GetStudios();
            uxUsersComboBox.DataSource = controller.GetUsers();

            switch (item)
            {
                case MovieItems.Movie:
                    uxAudienceRatingLabel.Visible = true;
                    uxAudienceTextBox.Visible = true;
                    uxCriticLabel.Visible = true;
                    uxCriticTextBox.Visible = true;
                    uxDomesticRevenueLabel.Visible = true;
                    uxDomesticRevenueTextBox.Visible = true;
                    uxGenreComboBox.Visible = true;
                    uxGenreLabel.Visible = true;
                    uxIMDBLabel.Visible = true;
                    uxIMDBTextBox.Visible = true;
                    uxInternationalRevenueLabel.Visible = true;
                    uxInternationalRevenueTextBox.Visible = true;
                    uxMovieTitleLabel.Visible = true;
                    uxMovieTitleTextBox.Visible = true;
                    uxProductionCostLabel.Visible = true;
                    uxProductionCostTextBox.Visible = true;
                    uxReleaseYearLabel.Visible = true;
                    uxReleaseYearTextBox.Visible = true;
                    uxStudioComboBox.Visible = true;
                    uxStudioLabel.Visible = true;
                    break;
                case MovieItems.PersonalRating:
                    uxMoviesComboBox.Visible = true;
                    uxMoviesComboBox.Visible = true;
                    uxPersonalRatingLabel.Visible = true;
                    uxPersonalRatingTextBox.Visible = true;
                    uxRatingDescriptionLabel.Visible = true;
                    uxRatingDescriptionTextBox.Visible = true;
                    uxUserLabel.Visible = true;
                    uxUsersComboBox.Visible = true;
                    break;
                case MovieItems.Role:
                    uxMovieTitleLabel.Visible = true;
                    uxMoviesComboBox.Visible = true;
                    uxIsDirectorLabel.Visible = true;
                    uxDirectorComboBox.Visible = true;
                    uxActorComboBox.Visible = true;
                    uxActorLabel.Visible = true;
                    uxAmountPaid.Visible = true;
                    uxAmountPaidTextBox.Visible = true;
                    uxPersonLabel.Visible = true;
                    uxPersonComboBox.Visible = true;
                    break;
                case MovieItems.User:
                    uxUserNameLabel.Visible = true;
                    uxUserNameTextBox.Visible = true;
                    uxPasswordLabel.Visible = true;
                    uxPasswordTextBox.Visible = true;
                    uxNameLabel.Visible = true;
                    uxNameTextBox.Visible = true;
                    uxEmailLabel.Visible = true;
                    uxEmailTextBox.Visible = true;
                    break;
                default:
                    break;
            }
            ShowDialog();
        }

        private void uxOKButton_Click(object sender, EventArgs e)
        {
            switch (currentMovieItem)
            {
                case MovieItems.Movie:
                    string movieName = uxMovieTitleTextBox.Text;
                    int studioId = ((Studios)uxStudioComboBox.SelectedValue).StudioId;
                    int genreId = ((Genres)uxGenreComboBox.SelectedValue).GenreId;
                    Int16 releaseDate = Convert.ToInt16(uxReleaseYearTextBox.Text);
                    int cost = Convert.ToInt32(uxProductionCostTextBox.Text);
                    int domestic = Convert.ToInt32(uxDomesticRevenueTextBox.Text);
                    int international = Convert.ToInt32(uxInternationalRevenueTextBox.Text);
                    decimal imdb = Convert.ToDecimal(uxIMDBTextBox.Text);
                    int audience = Convert.ToInt32(uxAudienceTextBox.Text);
                    int critic = Convert.ToInt32(uxCriticTextBox.Text);
                    controller.CreateMovie(studioId, movieName, releaseDate, imdb, audience, domestic, international, cost, genreId, critic);
                    break;
                case MovieItems.PersonalRating:
                    int movieId = ((Movies)uxMoviesComboBox.SelectedValue).MovieId;
                    int userId = ((Users)uxUsersComboBox.SelectedValue).UserId;
                    int personalRating = Convert.ToInt32(uxPersonalRatingTextBox.Text);
                    string ratingDescription = uxRatingDescriptionTextBox.Text;
                    controller.CreatePersonalRating(movieId, userId, personalRating, ratingDescription);
                    break;
                case MovieItems.Role:
                    int personId = ((People)uxPersonComboBox.SelectedItem).PersonId;
                    int movieID = ((Movies)uxMoviesComboBox.SelectedValue).MovieId;
                    bool isDirector = Convert.ToBoolean(uxDirectorComboBox.SelectedValue);
                    bool isActor = Convert.ToBoolean(uxActorComboBox.SelectedValue);
                    int amountPaid = Convert.ToInt32(uxAmountPaidTextBox.Text);
                    controller.CreateRole(personId, movieID, isDirector, isActor, amountPaid);
                    break;
                case MovieItems.User:
                    string username = uxUserNameTextBox.Text;
                    string password = uxPasswordTextBox.Text;
                    string name = uxNameTextBox.Text;
                    string email = uxEmailTextBox.Text;
                    controller.CreateUser(username, password, name, email);
                    break;
                default:
                    return;
            }
            this.Close();
        }

        private void uxCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearDisplay()
        {
            uxAudienceRatingLabel.Visible = false;
            uxAudienceTextBox.Visible = false;
            uxCriticLabel.Visible = false;
            uxCriticTextBox.Visible = false;
            uxDomesticRevenueLabel.Visible = false;
            uxDomesticRevenueTextBox.Visible = false;
            uxGenreComboBox.Visible = false;
            uxGenreLabel.Visible = false;
            uxIMDBLabel.Visible = false;
            uxIMDBTextBox.Visible = false;
            uxInternationalRevenueLabel.Visible = false;
            uxInternationalRevenueTextBox.Visible = false;
            uxMovieTitleLabel.Visible = false;
            uxMovieTitleTextBox.Visible = false;
            uxPersonalRatingLabel.Visible = false;
            uxPersonalRatingTextBox.Visible = false;
            uxProductionCostLabel.Visible = false;
            uxProductionCostTextBox.Visible = false;
            uxRatingDescriptionLabel.Visible = false;
            uxRatingDescriptionTextBox.Visible = false;
            uxReleaseYearLabel.Visible = false;
            uxReleaseYearTextBox.Visible = false;
            uxStudioComboBox.Visible = false;
            uxStudioLabel.Visible = false;
            uxActorComboBox.Visible = false;
            uxActorLabel.Visible = false;
            uxAmountPaid.Visible = false;
            uxAmountPaidTextBox.Visible = false;
            uxDirectorComboBox.Visible = false;
            uxIsDirectorLabel.Visible = false;
            uxMoviesComboBox.Visible = false;
            uxPersonComboBox.Visible = false;
            uxPersonLabel.Visible = false;
            uxUserLabel.Visible = false;
            uxUsersComboBox.Visible = false;
            uxUserNameLabel.Visible = false;
            uxUserNameTextBox.Visible = false;
            uxPasswordLabel.Visible = false;
            uxPasswordTextBox.Visible = false;
            uxNameLabel.Visible = false;
            uxNameTextBox.Visible = false;
            uxEmailLabel.Visible = false;
            uxEmailTextBox.Visible = false;
        }
    }
}