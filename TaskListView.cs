using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppToDoAPI.ViewModels;
using WinFormsAppToDo;

namespace WindowsFormsAppToDoAPI
{
    public partial class TaskListView : Form
    {
        public TaskListView()
        {
            InitializeComponent();
        }

        private void TaskList_Load(object sender, EventArgs e)
        {
            var tasks = ToDoAPI.GetTasks();
            foreach (var task in tasks)
            {
                var taskView = new TaskViewModel(task);  // igakord kui teeme TaskViewModelei anname Taski kaasa
                flowLayoutPanel1.Controls.Add(taskView.taskControl); // vt tegime selle kontrolli TaskViewModels's publicuks
            }
        }
        private void AddTaskBtn_Click(object sender, EventArgs e)
        {
            var taskView = new TaskViewModel(new DTO.Task());  // teeme uue tühja taski ja pane flowpanelile
            flowLayoutPanel1.Controls.Add(taskView.taskControl);
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            TaskFormClosed(TaskList_Load);

            var taskView = new TaskListView();
            taskView.Show();
        }
        private void TaskFormClosed(Action<object, EventArgs> taskList_Load)
        {
            Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {                    
           Application.Exit();            
        }
    }
}
