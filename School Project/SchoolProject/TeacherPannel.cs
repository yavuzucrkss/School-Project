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
    public partial class TeacherPannel : Form
    {
        private int id { get; set; }
        private string name { get; set; }
        private string branch { get; set; }
        public TeacherPannel()
        {
            InitializeComponent();
        }

        public TeacherPannel(int id, string name, string branch) {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.branch = branch;
        }
        public string tıd1;
        private void ClubButton(object sender, EventArgs e)
        {
            
        }

        private void LessonButton(object sender, EventArgs e)
        {
            //
            TLessonDetail fr = new TLessonDetail();
            fr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MStudent fr = new MStudent();

            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TNote fr = new TNote();
            fr.tId = tıd1;
            fr.Show();
        }

        private void TeacherPannel_Load(object sender, EventArgs e)
        {
            label6.Text = name.ToString();
            label1.Text = id.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherLogin fr = new TeacherLogin();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Messages fr = new Messages();
            fr.Show();
        }
    }
}
