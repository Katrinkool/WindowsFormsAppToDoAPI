
using WindowsFormsAppToDoAPI.DTO;

namespace WindowsFormsAppToDoAPI
{
    partial class TaskControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.titleTBox = new System.Windows.Forms.TextBox();
            this.descTBox = new System.Windows.Forms.RichTextBox();
            this.messageLbl = new System.Windows.Forms.Label();
            this.doneCheckBox = new System.Windows.Forms.CheckBox();
            this.dateTBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pealkiri";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(32, 128);
            this.descLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(68, 20);
            this.descLabel.TabIndex = 2;
            this.descLabel.Text = "Kirjeldus";
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.editButton.Location = new System.Drawing.Point(390, 257);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(112, 35);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Salvesta";
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // titleTBox
            // 
            this.titleTBox.Location = new System.Drawing.Point(36, 92);
            this.titleTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.titleTBox.Name = "titleTBox";
            this.titleTBox.Size = new System.Drawing.Size(320, 26);
            this.titleTBox.TabIndex = 6;
            // 
            // descTBox
            // 
            this.descTBox.Location = new System.Drawing.Point(36, 152);
            this.descTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descTBox.Name = "descTBox";
            this.descTBox.Size = new System.Drawing.Size(320, 138);
            this.descTBox.TabIndex = 7;
            this.descTBox.Text = "";
            // 
            // messageLbl
            // 
            this.messageLbl.AutoSize = true;
            this.messageLbl.ForeColor = System.Drawing.Color.Green;
            this.messageLbl.Location = new System.Drawing.Point(32, 18);
            this.messageLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(0, 20);
            this.messageLbl.TabIndex = 8;
            // 
            // doneCheckBox
            // 
            this.doneCheckBox.AutoSize = true;
            this.doneCheckBox.Location = new System.Drawing.Point(390, 93);
            this.doneCheckBox.Name = "doneCheckBox";
            this.doneCheckBox.Size = new System.Drawing.Size(74, 24);
            this.doneCheckBox.TabIndex = 9;
            this.doneCheckBox.Text = "Done";
            this.doneCheckBox.UseVisualStyleBackColor = true;
            this.doneCheckBox.CheckedChanged += new System.EventHandler(this.done_checkBox_CheckedChanged);
            // 
            // dateTBox
            // 
            this.dateTBox.Location = new System.Drawing.Point(488, 92);
            this.dateTBox.Name = "dateTBox";
            this.dateTBox.Size = new System.Drawing.Size(165, 26);
            this.dateTBox.TabIndex = 10;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(489, 69);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(71, 20);
            this.dateLabel.TabIndex = 11;
            this.dateLabel.Text = "Kuupäev";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Salmon;
            this.deleteButton.Location = new System.Drawing.Point(390, 299);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(112, 31);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Kustuta";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // TaskControl
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateTBox);
            this.Controls.Add(this.doneCheckBox);
            this.Controls.Add(this.messageLbl);
            this.Controls.Add(this.descTBox);
            this.Controls.Add(this.titleTBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TaskControl";
            this.Size = new System.Drawing.Size(753, 344);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label descLabel;
        public System.Windows.Forms.Button editButton;
        public System.Windows.Forms.TextBox titleTBox;
        public System.Windows.Forms.RichTextBox descTBox;
        public System.Windows.Forms.Label messageLbl;
        public System.Windows.Forms.CheckBox doneCheckBox;
        public System.Windows.Forms.TextBox dateTBox;
        private System.Windows.Forms.Label dateLabel;
        public System.Windows.Forms.Button deleteButton;
    }
}
