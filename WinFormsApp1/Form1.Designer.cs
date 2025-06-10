namespace WinFormsApp1
{
    partial class FormAcademicPerformance
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
            listBoxStudents = new ListBox();
            AddStudent = new Button();
            SuspendLayout();
            // 
            // listBoxStudents
            // 
            listBoxStudents.FormattingEnabled = true;
            listBoxStudents.ItemHeight = 15;
            listBoxStudents.Location = new Point(0, 1);
            listBoxStudents.Name = "listBoxStudents";
            listBoxStudents.Size = new Size(594, 454);
            listBoxStudents.TabIndex = 0;
            // 
            // AddStudent
            // 
            AddStudent.Location = new Point(635, 368);
            AddStudent.Name = "AddStudent";
            AddStudent.Size = new Size(144, 49);
            AddStudent.TabIndex = 1;
            AddStudent.Text = "Добавить ученика";
            AddStudent.UseVisualStyleBackColor = true;
            AddStudent.Click += AddStudent_Click;
            // 
            // FormAcademicPerformance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddStudent);
            Controls.Add(listBoxStudents);
            Name = "FormAcademicPerformance";
            Text = "Таблица успеваемости учеников";
            ResumeLayout(false);
        }

        #endregion
        private Button AddStudent;
        public ListBox listBoxStudents;
    }
}
