using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class ClassStudent
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Grade { get; set; }
        public ClassStudent(string Name, string Subject, string Grade)
        {
            this.Name = Name;
            this.Subject = Subject;
            this.Grade = Grade;
        }
    }
}
