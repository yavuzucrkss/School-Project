using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolProject
{
    public partial class StudentPannel : Form
    {
        private int id { get; set; }
        private string name { get; set; } 
        private string surname { get; set; }
        public StudentPannel()
        {
            InitializeComponent();
        }
        // SqlConnection connection = new SqlConnection(@"Data Source=YAVUZ;Initial Catalog=School_Project;Integrated Security=True");
        public StudentPannel(int id, string name , string surname)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.surname = surname;
        }


        private void StudentPannel_Load(object sender, EventArgs e)
        {
            //SqlCommand cmd = new SqlCommand("Select LessonName , Exam1 , Exam2, Exam3 , Project , AvaregeNote, NoteState From Table_Notes  INNER JOIN Table_Lesson on Table_Notes.NotesBranch = Table_Lesson.LessonId where StudentId = @p1",connection);
            //cmd.Parameters.AddWithValue("@p1", SID);

            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //connection.Close();
            label6.Text = id.ToString();
            label1.Text = name + " " + surname;
        }

        private void SLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SLessonDetail myForm = new SLessonDetail("Turkish");

            myForm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SLessonDetail myForm = new SLessonDetail("Math");

            myForm.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            SLessonDetail myForm = new SLessonDetail("Science");

            myForm.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            SLessonDetail myForm = new SLessonDetail("LiberalArts");

            myForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SNote myForm = new SNote(name,id.ToString());

            myForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Messages myForm = new Messages();

            myForm.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentLogin fr = new StudentLogin();
            fr.Show();
        }
    }
}
