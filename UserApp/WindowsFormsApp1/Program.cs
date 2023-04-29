using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{ 
    public delegate void AddMovieItemDel(MovieItems item);
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Controller controller = new Controller();
            Login loginForm = new Login();
            ActionSelector form = new ActionSelector(loginForm.user);
            AddAnItem addForm = new AddAnItem(form.currentUser);
            form.SetAddMovieItemDel(addForm.InitializeForm);
            Application.Run(form);
        }
    }
}
