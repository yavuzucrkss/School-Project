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
using System.Net;
using System.IO;
using RestSharp;
using System.Net.Http;
using Newtonsoft.Json;

namespace SchoolProject
{

    public partial class TeacherLogin : Form
    {

        public TeacherLogin()
        {
            InitializeComponent();


        }
        SqlConnection connection = new SqlConnection(@"Data Source=YAVUZ;Initial Catalog=School_Project;Integrated Security=True");


        private async void SLoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://192.168.8.136:1337");
                var jObject = "{\"id\": \"" + textBox1.Text + "\", \"password\": \"" + Hash.sha256(textBox2.Text) + "\", \"userType\": \"teacher\"}";
                var stringContent = new StringContent(jObject);
                HttpResponseMessage response = await client.PostAsync("api/login", stringContent);
                //HttpResponseMessage response = await client.GetAsync("api/students");

                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine(result);
                var logInResponse = JsonConvert.DeserializeObject<LogInResponse>(result);
                Console.WriteLine(logInResponse.responseMessage + logInResponse.name + logInResponse.id);
                
                

                if (logInResponse.responseMessage == "Accepted")
                {
                
                    // redirect to Teacher Panel
                    this.Hide();
                    TeacherPannel myForm = new TeacherPannel(logInResponse.id,logInResponse.name,logInResponse.surname);

                    myForm.ShowDialog();
                    this.Close();
                }
                else if (logInResponse.responseMessage == "Unauthorized")
                {
                    MessageBox.Show("Error! Wrong ID and password combination!!!", "Incorrect Credentials!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            };
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SchoolStart fr = new SchoolStart();
            fr.Show();
        }
    }
}