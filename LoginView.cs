using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppToDoAPI.DTO;
using WinFormsAppToDo;

namespace WindowsFormsAppToDoAPI
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            errorLabel.Text = ""; //sisselogides error tyhi
            User user = ToDoAPI.Login(usernameInput.Text, passwordInput.Text);
            if (user.access_token != null && user.message==null)

            {
                Program.currentUser = user;
                //Close();
                var taskView = new TaskListView();
                taskView.Show();
            }
            else
            {
                errorLabel.Text = user.message;
            }
        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }
    }
}
