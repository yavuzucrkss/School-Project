using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject
{
    public partial class Messages : Form
    {
        public Messages()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherPannel fr = new TeacherPannel(2, "Kelebek", "Türkçe");
            fr.Show();
        }
    }
}
