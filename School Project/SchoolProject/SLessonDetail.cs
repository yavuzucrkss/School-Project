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
    public partial class SLessonDetail : Form
    {
        public SLessonDetail(string name)
        {
            InitializeComponent();
            SLoginButton.Text = name;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentPannel fr = new StudentPannel(6, "Cem", "Yılmaz");
            fr.Show();
        }

        private void SLessonDetail_Load(object sender, EventArgs e)
        {
        
        }
    }
}
