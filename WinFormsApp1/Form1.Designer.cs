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
            listBox1 = new ListBox();
            AddStudent = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 1);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(594, 454);
            listBox1.TabIndex = 0;
            // 
            // AddStudent
            // 
            AddStudent.Location = new Point(635, 368);
            AddStudent.Name = "AddStudent";
            AddStudent.Size = new Size(144, 49);
            AddStudent.TabIndex = 1;
            AddStudent.Text = "Добавить ученика";
            AddStudent.UseVisualStyleBackColor = true;
            // 
            // FormAcademicPerformance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddStudent);
            Controls.Add(listBox1);
            Name = "FormAcademicPerformance";
            Text = "Таблица успеваемости учеников";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button AddStudent;
    }
}
