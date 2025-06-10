namespace WinFormsApp1
{
    public partial class FormAcademicPerformance : System.Windows.Forms.Form
    {
        FormAddStudent fas = new FormAddStudent();
        public FormAcademicPerformance()
        {
            InitializeComponent();
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            fas.Show();
        }
    }
}
