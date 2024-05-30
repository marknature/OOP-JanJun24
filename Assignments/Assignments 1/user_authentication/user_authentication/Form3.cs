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
    public partial class Form3 : Form //Create account form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) //Exit button
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e) //reset button
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e) //create an account button
        {
            if (textBox2.Text.Length > 4)
            {
                MessageBox.Show("Your Password should be 4 characters long");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\markn\OneDrive\Documents\Visual Studio 2013\Projects\user_authentication\user_authentication\Database.mdf;Integrated Security=True" + Application.StartupPath + "\\Database.mdf");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO LOGIN (Student_ID, password) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Your Account has been created! Welcome to Afica University.");
            }
        }

        private void button3_Click(object sender, EventArgs e) //Go back to login button
        {
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
