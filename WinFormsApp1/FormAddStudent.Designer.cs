namespace WinFormsApp1
{
    partial class FormAddStudent
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxSubject = new ListBox();
            labelSubject = new Label();
            labelName = new Label();
            textBoxName = new TextBox();
            textBoxGrade = new TextBox();
            labelGrade = new Label();
            buttonAdd = new Button();
            SuspendLayout();
            // 
            // listBoxSubject
            // 
            listBoxSubject.FormattingEnabled = true;
            listBoxSubject.ItemHeight = 15;
            listBoxSubject.Items.AddRange(new object[] { "Математика", "Русский язык", "Английский язык", "История", "Информатика", "Обществознание", "География", "Биология", "Химия", "Физика" });
            listBoxSubject.Location = new Point(25, 89);
            listBoxSubject.Name = "listBoxSubject";
            listBoxSubject.Size = new Size(137, 154);
            listBoxSubject.TabIndex = 0;
            // 
            // labelSubject
            // 
            labelSubject.AutoSize = true;
            labelSubject.Location = new Point(38, 71);
            labelSubject.Name = "labelSubject";
            labelSubject.Size = new Size(116, 15);
            labelSubject.TabIndex = 1;
            labelSubject.Text = "Выберите предмет: ";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(192, 71);
            labelName.Name = "labelName";
            labelName.Size = new Size(194, 15);
            labelName.TabIndex = 2;
            labelName.Text = "Введите фамилию и имя ученика:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(188, 89);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(198, 23);
            textBoxName.TabIndex = 3;
            // 
            // textBoxGrade
            // 
            textBoxGrade.Location = new Point(411, 89);
            textBoxGrade.Name = "textBoxGrade";
            textBoxGrade.Size = new Size(177, 23);
            textBoxGrade.TabIndex = 4;
            // 
            // labelGrade
            // 
            labelGrade.AutoSize = true;
            labelGrade.Location = new Point(426, 71);
            labelGrade.Name = "labelGrade";
            labelGrade.Size = new Size(143, 15);
            labelGrade.TabIndex = 5;
            labelGrade.Text = "Введите оценку ученика:";
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAdd.Location = new Point(188, 284);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(224, 58);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Добавить ученика:";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // FormAddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 411);
            Controls.Add(buttonAdd);
            Controls.Add(labelGrade);
            Controls.Add(textBoxGrade);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Controls.Add(labelSubject);
            Controls.Add(listBoxSubject);
            Name = "FormAddStudent";
            Text = "FormAddStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxSubject;
        private Label labelSubject;
        private Label labelName;
        private TextBox textBoxName;
        private TextBox textBoxGrade;
        private Label labelGrade;
        private Button buttonAdd;
    }
}