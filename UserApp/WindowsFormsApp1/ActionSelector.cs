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
        string connectionString = @"(localdb)\MSSQLLocalDb; Initial Catalog = Movie; Integrated Security=True;";

        public ActionSelector(string user)
        {
            InitializeComponent();
            curUser = user;
        }

        /// <summary>
        /// TODO: this needs to populate uxPersonalReviews with the name of the movies the curUser has rated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActionSelector_Load(object sender, EventArgs e)
        {
            UXPersonalReviews.Items.Add("New Review");
            //populate here
            UXPersonalReviews.SelectedItem = UXPersonalReviews.Items.IndexOf("New Review");
        }

        /// <summary>
        /// TODO: populate items when a new review is selected
        /// note if its a new review it all needs to be set to blank and UXAddBtn needs to be enabled (all other cases the button needs to be diabled)
        /// items to populate
        ///     UXMoviename - textbox
        ///     UXRatingNumber - numeric up down (from personal rating field should be number 1-10)
        ///     UXComments - textbox multiline (from rating description)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UXPersonalReviews_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        /// <summary>
        /// TODO: update the review with any new datas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Update_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// TODO: Adds review to db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UXAddBtn_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// TODO: Should delete the review from the database (after a yes no dialog confirms it was intentional)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxDeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UXPersonalReviewLabel_Click(object sender, EventArgs e)
        {

        }

        private void UxAddMovies_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ux_populateMoviesButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * FROM Movies", sqlcon);
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
                SqlDataAdapter sqlDa = new SqlDataAdapter("Delete From Movies Where ",sqlcon);
            }
        }

        private void ux_GenrePopulateButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * FROM Genres", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                ux_GenresDataView.DataSource = dtbl;
            }
        }

        private void ux_GenresDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
