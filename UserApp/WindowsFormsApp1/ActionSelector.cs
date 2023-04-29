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

namespace WindowsFormsApp1
{
    public partial class ActionSelector : Form
    {
        private string curUser;
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDb;Initial Catalog=MovieDatabase;Integrated Security=True";

        public ActionSelector(string user)
        {
            InitializeComponent();
            curUser = user;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActionSelector_Load(object sender, EventArgs e)
        {

        }


        private void UxAddMovies_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("Movie.CreateMovie", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MovieId", ux_MovieMovieId.Value);
                cmd.Parameters.AddWithValue("@StudioId", ux_StudioIdValue.Value);
                cmd.Parameters.AddWithValue("@MovieName", ux_MovieNameValue.Text);
                cmd.Parameters.AddWithValue("@ReleaseDate", ux_ReleaseDateValue.Value);
                cmd.Parameters.AddWithValue("@IMDBRating", ux_IMDBRatingValue.Value);
                cmd.Parameters.AddWithValue("@RottenTomatoesAudienceRating", ux_RottenTomatoesAudienceRatingValue.Value);
                cmd.Parameters.AddWithValue("@DomesticRevenue", ux_DomesticRevenueValue.Value);
                cmd.Parameters.AddWithValue("@InternationlRevenue", ux_InternationalRevenueValue.Value);
                cmd.Parameters.AddWithValue("@Cost", ux_CostValue.Value);
                cmd.Parameters.AddWithValue("@GenreId", ux_GenreIdValue.Value);
                cmd.Parameters.AddWithValue("@RottenTomatoesCriticRating", ux_RottenTomatoesCriticRatingValue.Value);
                cmd.ExecuteNonQuery();
            }
        }

        private void ux_populateMoviesButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * FROM Movie.Movies", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                ux_MovieDataGrid.DataSource = dtbl;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Delete From Movies Where",sqlcon);
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

        private void ux_GenresDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void ux_CompareButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("Movie.RatingCompareByMovieName", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MovieId", ux_CompareMovieIdPicker.Value);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                ux_CompareDataGrid.DataSource = dtbl;
            }
        }

        private void UXRatingLabel_Click(object sender, EventArgs e)
        {

        }

        private void ux_AddPersonalReview_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("Movie.CreatePersonalRatings", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RatingId", ux_PRRatingId.Value);
                cmd.Parameters.AddWithValue("@MovieId", ux_PersonalReviewMovieId.Value);
                cmd.Parameters.AddWithValue("@AuthorUserId", ux_PersonalReviewUserId.Value);
                cmd.Parameters.AddWithValue("@PersonalRating", ux_PersonalReviewRatingNumber.Value);
                cmd.Parameters.AddWithValue("@RatingDescription", ux_PRComments.Text);
                cmd.ExecuteNonQuery();
            }
        }

        private void ux_DeletePersonalReview_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("Movie.DeletePersonalRating", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RatingId", ux_PRRatingId.Value);
                cmd.ExecuteNonQuery();
            }
        }

        private void ux_UserButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("Movie.CreateUsers", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", ux_UserUserId.Value);
                cmd.Parameters.AddWithValue("@UserName", ux_UserUserName.Text);
                cmd.Parameters.AddWithValue("@Password", ux_UserPassword.Text);
                cmd.Parameters.AddWithValue("@Name", ux_UserName.Text);
                cmd.Parameters.AddWithValue("@RecoveryEmail", ux_UserRecoveryEmail.Text);
                cmd.ExecuteNonQuery();
            }
        }

        private void ux_UsersPopulateButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * FROM Movie.Users", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                ux_UsersDataGrid.DataSource = dtbl;
            }
        }

        private void ux_UserDeleteButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("Movie.DeleteUser", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", ux_UserUserId.Value);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
