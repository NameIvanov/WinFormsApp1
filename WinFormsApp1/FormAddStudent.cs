using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormAddStudent : Form
    {
        public FormAddStudent()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ClassStudent stud = new ClassStudent(textBoxName.Text, listBoxSubject.SelectedItem.ToString(), textBoxGrade.Text);
            FormAcademicPerformance.Students.Add(stud);
            this.Close();
        }
    }
}
