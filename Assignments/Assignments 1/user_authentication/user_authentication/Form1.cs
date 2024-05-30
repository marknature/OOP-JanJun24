using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_authentication
{
    public partial class Form1 : Form //login interface (first window page)
    {
        private const int MaxAttempts = 3; // maximum attempts varible
        private int attemptsCount = 0; // attempt count varible
        private bool accountLocked = false; //state of page
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //Go to change password interface(form2)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e) //exit button
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e) //clear button
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private bool Valid() //a class called "Valid"
        {
            if (textBox1.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("enter vaild Student Identification", "error"); //ERROR massage
                return false;

            } else if (textBox2.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("enter vaild Password", "error"); //ERROR massage
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e) //login button
        {
            if (textBox2.Text.Length > 4) // Error message when Password is longer then 4 characters long
            {
                MessageBox.Show("Your Password should be 4 characters long, password: " + textBox2.Text + " is not.");
            }

            if (!accountLocked) // Block or Unblocked account
            {

                if (Valid()) //use of class
                {
                    using (System.Data.SqlClient.SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\markn\OneDrive\Documents\Visual Studio 2013\Projects\user_authentication\user_authentication\Database.mdf;Integrated Security=True" + Application.StartupPath + "\\Database.mdf"))
                    {
                        string query = "SELECT * FROM LOGIN WHERE Student_ID = '" + textBox1.Text.Trim() + "' AND password = '" + textBox2.Text.Trim() + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                        DataTable dta = new DataTable();
                        sda.Fill(dta);
                        if (dta.Rows.Count == 1) // login successful
                        {
                            mainbord mainbord = new mainbord();
                            this.Hide();
                            mainbord.Show();
                            MessageBox.Show("Login successful!"); //successful message 
                        }
                        else
                        {
                            attemptsCount++; // +1 on attempt count

                            if (attemptsCount == MaxAttempts) //block page
                            {
                                MessageBox.Show("Maximum login attempts reached. Account locked."); //Blocked message
                                accountLocked = true; //blocked
                                textBox1.Enabled = false;
                                textBox2.Enabled = false;
                                button1.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Login failed. You have " + (MaxAttempts - attemptsCount) + " attempts left."); //incorrect pin
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Your account is locked. Please contact support."); // account locked
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //go to create account interface
        {
            Form3 f3 = new Form3();
            f3.Show();
            Visible = false;
        }  
    }
}
