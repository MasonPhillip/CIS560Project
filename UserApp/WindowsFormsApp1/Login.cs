using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        private Dictionary<string, string> passwords = new Dictionary<string, string>();
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
            passwords.Add("a", "1");
            passwords.Add("b", "2");
            string userName = UXUserName.Text;
            string password = UXPassword.Text;
            string curPass;
            if (passwords.TryGetValue(userName, out curPass))
            {
                if(curPass == password)
                {
                    ActionSelector actionSelector = new ActionSelector(userName);
                    actionSelector.Show();
                }
                else
                {
                    MessageBox.Show("Password is incorrect");
                }
            }
            else
            {
                MessageBox.Show("Could not find user");
            }
        }
    }
}
