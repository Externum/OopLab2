using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OopLab2._2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new StudentForm().ShowDialog();
        }

        private void TeacherMenuButton_Click(object sender, EventArgs e)
        {
            new TeacherForm().ShowDialog();
        }

        private void GroupMenuButton_Click(object sender, EventArgs e)
        {
            new GroupForm().ShowDialog();
        }

        private void SubjectMenuButton_Click(object sender, EventArgs e)
        {
            new SubjectForm().ShowDialog();
        }
    }
}
