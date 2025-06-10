namespace WinFormsApp1
{
    public partial class FormAcademicPerformance : System.Windows.Forms.Form
    {
        public static List<ClassStudent> Students = new List<ClassStudent>();
        public FormAcademicPerformance()
        {
            InitializeComponent();
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            FormAddStudent fas = new FormAddStudent();
            fas.ShowDialog();
            listBoxStudents.Items.Clear();
            for (int i = 0; i < Students.Count; i++)
            {
                string strok = $"{Students[i].Name}, {Students[i].Subject}, {Students[i].Grade}.";
                listBoxStudents.Items.Add(strok);
            }
        }
    }
}
