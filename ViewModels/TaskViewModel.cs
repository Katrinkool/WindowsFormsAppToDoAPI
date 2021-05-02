using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using WindowsFormsAppToDoAPI.DTO;
using WinFormsAppToDo;

namespace WindowsFormsAppToDoAPI.ViewModels
{
    class TaskViewModel
    {
        private Task task;
        public TaskControl taskControl;
        public TaskViewModel(Task task)     // võtab TaskListViewga kaasa pandud Taski ja salvestab private taskiks
        {
            this.task = task;
            taskControl = new TaskControl();
            taskControl.titleTBox.Text = task.title;
            taskControl.descTBox.Text = task.desc;
            taskControl.doneCheckBox.Checked = task.marked_as_done;
            taskControl.dateTBox.Text = task.created_at;
            taskControl.deleteButton.Click += new EventHandler(Delete);
            taskControl.editButton.Click += new EventHandler(Save);
        }
        private void Save(object sender, EventArgs e)
        {
            task.title = taskControl.titleTBox.Text; //uuendab andmed ToDoAPi save sisse
            task.desc = taskControl.descTBox.Text;
            task.marked_as_done = taskControl.doneCheckBox.Checked;
            task.created_at = taskControl.dateTBox.Text;
            try
            {
                task = ToDoAPI.SaveTask(task);
                taskControl.messageLbl.Text = "Salvestamine õnnestus";
                taskControl.messageLbl.ForeColor = Color.Green;
            }
            catch (Exception error)
            {
                taskControl.messageLbl.Text = "Salvestamine ebaõnnestus: " + error.Message;
                taskControl.messageLbl.ForeColor = Color.Red;
            }
        }
        public void Delete(object sender, EventArgs e)
        {
            try
            {
                ToDoAPI.DeleteTask(task);
                taskControl.messageLbl.Text = "Kustutamine õnnestus";
                taskControl.messageLbl.ForeColor = Color.Green;
            }
            catch (Exception error)
            {
                taskControl.messageLbl.Text = "Kustutamine ebaõnnestus: " + error.Message;
                taskControl.messageLbl.ForeColor = Color.Red;
            }
        }
    }
}
