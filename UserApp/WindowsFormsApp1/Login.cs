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
    public partial class Login : Form
    {
        public Controller controller = new Controller();

        public string username;

        public Users user;

        private ActionSelector form;

        private AddAnItem addForm;

        public Login()
        {
            InitializeComponent();
        }

       
        private void Lo_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //TODO: pull usernames and passwords from db and format into dictionary
        /// <summary>
        /// Handles the event for an attempt to login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UXLoginBtn_Click(object sender, EventArgs e)
        {
            username = UXUserName.Text;
            Users user = controller.GetUser(username);
            if(user != null)
            {
                this.Hide();
                ActionSelector form = new ActionSelector(user);
                form.Show();
            }
            else
            {
                MessageBox.Show("User does not exist");
            }
            this.Close();
        }
    }
}
