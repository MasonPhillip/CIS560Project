using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ActionSelector : Form
    {
        private string curUser;

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
    }
}
