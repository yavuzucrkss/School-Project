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
using System.Net.Http;
using Newtonsoft.Json;

namespace SchoolProject
{
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SchoolStart fr = new SchoolStart();
            fr.Show();
        }

        

        private async void SLoginButton_ClickAsync(object sender, EventArgs e)
        {

            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://192.168.8.136:1337");
                var jObject = "{\"id\": \"" + textBox1.Text + "\", \"password\": \"" + Hash.sha256(textBox2.Text) + "\", \"userType\": \"student\"}";
                var stringContent = new StringContent(jObject);
                HttpResponseMessage response = await client.PostAsync("api/login", stringContent);
                //HttpResponseMessage response = await client.GetAsync("api/students");

                string result = await response.Content.ReadAsStringAsync();
                var logInResponse = JsonConvert.DeserializeObject<LogInResponse>(result);

                Console.WriteLine(result);

                if (logInResponse.responseMessage == "Accepted")
                {
                    // redirect to Teacher Panel
                    this.Hide();
                    StudentPannel myForm = new StudentPannel(logInResponse.id,logInResponse.name,logInResponse.surname);

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
    }
}