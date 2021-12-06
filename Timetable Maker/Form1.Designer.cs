
namespace Timetable_Maker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.NameLable = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DescriptionLable = new System.Windows.Forms.Label();
            this.CreateTaskLabel = new System.Windows.Forms.Label();
            this.RequiredTime = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.StartLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.DeadLineLabel = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.AddedTasksList = new System.Windows.Forms.ListBox();
            this.AddedTasksLabel = new System.Windows.Forms.Label();
            this.GenerateTimetableButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText;
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 282);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 27);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2021, 5, 1, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameLable.Location = new System.Drawing.Point(36, 88);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(52, 20);
            this.NameLable.TabIndex = 1;
            this.NameLable.Text = "Name:";
            this.NameLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Location = new System.Drawing.Point(155, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DescriptionLable
            // 
            this.DescriptionLable.AutoSize = true;
            this.DescriptionLable.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DescriptionLable.Location = new System.Drawing.Point(36, 137);
            this.DescriptionLable.Name = "DescriptionLable";
            this.DescriptionLable.Size = new System.Drawing.Size(88, 20);
            this.DescriptionLable.TabIndex = 4;
            this.DescriptionLable.Text = "Description:";
            this.DescriptionLable.Click += new System.EventHandler(this.DescriptionLable_Click);
            // 
            // CreateTaskLabel
            // 
            this.CreateTaskLabel.AutoSize = true;
            this.CreateTaskLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateTaskLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CreateTaskLabel.Location = new System.Drawing.Point(74, 23);
            this.CreateTaskLabel.Name = "CreateTaskLabel";
            this.CreateTaskLabel.Size = new System.Drawing.Size(239, 38);
            this.CreateTaskLabel.TabIndex = 5;
            this.CreateTaskLabel.Text = "Create New Task";
            this.CreateTaskLabel.Click += new System.EventHandler(this.CreateTaskLabel_Click);
            // 
            // RequiredTime
            // 
            this.RequiredTime.AutoSize = true;
            this.RequiredTime.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RequiredTime.Location = new System.Drawing.Point(36, 231);
            this.RequiredTime.Name = "RequiredTime";
            this.RequiredTime.Size = new System.Drawing.Size(105, 20);
            this.RequiredTime.TabIndex = 6;
            this.RequiredTime.Text = "RequiredTime:";
            this.RequiredTime.Click += new System.EventHandler(this.RequiredTime_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.numericUpDown1.Location = new System.Drawing.Point(155, 229);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(198, 27);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.StartLabel.Location = new System.Drawing.Point(36, 287);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(80, 20);
            this.StartLabel.TabIndex = 8;
            this.StartLabel.Text = "Start Time:";
            this.StartLabel.Click += new System.EventHandler(this.StartLabel_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.richTextBox1.Location = new System.Drawing.Point(155, 134);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(198, 76);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // DeadLineLabel
            // 
            this.DeadLineLabel.AutoSize = true;
            this.DeadLineLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DeadLineLabel.Location = new System.Drawing.Point(36, 340);
            this.DeadLineLabel.Name = "DeadLineLabel";
            this.DeadLineLabel.Size = new System.Drawing.Size(72, 20);
            this.DeadLineLabel.TabIndex = 11;
            this.DeadLineLabel.Text = "Deadline:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText;
            this.dateTimePicker2.Location = new System.Drawing.Point(155, 335);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(198, 27);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.AddTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddTaskButton.Location = new System.Drawing.Point(36, 401);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(317, 44);
            this.AddTaskButton.TabIndex = 12;
            this.AddTaskButton.Text = "Add Task";
            this.AddTaskButton.UseVisualStyleBackColor = false;
            // 
            // AddedTasksList
            // 
            this.AddedTasksList.BackColor = System.Drawing.SystemColors.HighlightText;
            this.AddedTasksList.FormattingEnabled = true;
            this.AddedTasksList.ItemHeight = 20;
            this.AddedTasksList.Location = new System.Drawing.Point(440, 85);
            this.AddedTasksList.Name = "AddedTasksList";
            this.AddedTasksList.Size = new System.Drawing.Size(288, 284);
            this.AddedTasksList.TabIndex = 13;
            this.AddedTasksList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AddedTasksLabel
            // 
            this.AddedTasksLabel.AutoSize = true;
            this.AddedTasksLabel.BackColor = System.Drawing.Color.SlateGray;
            this.AddedTasksLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddedTasksLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddedTasksLabel.Location = new System.Drawing.Point(492, 23);
            this.AddedTasksLabel.Name = "AddedTasksLabel";
            this.AddedTasksLabel.Size = new System.Drawing.Size(184, 38);
            this.AddedTasksLabel.TabIndex = 14;
            this.AddedTasksLabel.Text = "Added Tasks";
            // 
            // GenerateTimetableButton
            // 
            this.GenerateTimetableButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GenerateTimetableButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GenerateTimetableButton.Location = new System.Drawing.Point(440, 401);
            this.GenerateTimetableButton.Name = "GenerateTimetableButton";
            this.GenerateTimetableButton.Size = new System.Drawing.Size(288, 44);
            this.GenerateTimetableButton.TabIndex = 15;
            this.GenerateTimetableButton.Text = "Generate Timetable";
            this.GenerateTimetableButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(768, 480);
            this.Controls.Add(this.GenerateTimetableButton);
            this.Controls.Add(this.AddedTasksLabel);
            this.Controls.Add(this.AddedTasksList);
            this.Controls.Add(this.AddTaskButton);
            this.Controls.Add(this.DeadLineLabel);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.RequiredTime);
            this.Controls.Add(this.CreateTaskLabel);
            this.Controls.Add(this.DescriptionLable);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NameLable);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label NameLable;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label DescriptionLable;
        private System.Windows.Forms.Label CreateTaskLabel;
        private System.Windows.Forms.Label RequiredTime;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label DeadLineLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button AddTaskButton;
        private System.Windows.Forms.ListBox AddedTasksList;
        private System.Windows.Forms.Label AddedTasksLabel;
        private System.Windows.Forms.Button GenerateTimetableButton;
    }
}

