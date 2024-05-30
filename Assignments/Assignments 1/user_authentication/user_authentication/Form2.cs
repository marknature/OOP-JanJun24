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

namespace user_authentication
{
    public partial class Form2 : Form //Change Password form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) //Exit button
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e) //clear button
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e) // return to login form
        {
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }

        private void UpdateUserInfo(string Student_ID, string newPassword) //change password button with error messages
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\markn\OneDrive\Documents\Visual Studio 2013\Projects\user_authentication\user_authentication\Database.mdf;Integrated Security=True" + Application.StartupPath + "\\Database.mdf")) //link database
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE LOGIN SET password = @NewPassword WHERE Student_ID = @Username";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", Student_ID);
                    command.Parameters.AddWithValue("@NewPassword", newPassword);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User information updated successfully."); //successful
                    }
                    else
                    {
                        MessageBox.Show("User not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e) // Error message when Password is longer then 4 characters long
        {
            if (textBox2.Text.Length > 4 || textBox3.Text.Length > 4 || textBox4.Text.Length > 4)
            {
                MessageBox.Show("Your Password should be 4 characters long"); //error message
            }
            else
            {
                string Student_ID = textBox1.Text;
                string newPassword = textBox4.Text;

                if (!string.IsNullOrEmpty(Student_ID) && !string.IsNullOrEmpty(newPassword))
                {
                    UpdateUserInfo(Student_ID, newPassword);
                }
                else
                {
                    MessageBox.Show("Please enter all fields!"); //ERROR messsage
                }
            } 
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
