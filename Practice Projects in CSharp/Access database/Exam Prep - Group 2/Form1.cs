using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Exam_Prep___Group_2
{
    public partial class MainForm : Form
    {
        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataAdapter ad;
        DataSet dataSet;
        string connstring = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\markn\OneDrive\Documents\Visual Studio 2013\Projects\Exam prep\Access database\Exam Prep - Group 2\CEAS.mdb";
        // string connstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\CEAS.mdb";

        void getstudent()
        {
            con = new OleDbConnection(connstring);
            con.Open();
            ad = new OleDbDataAdapter("SELECT * FROM STUDENTS", con);
            dataSet = new DataSet();
            ad.Fill(dataSet, "STUDENTS");
            sTUDENTSBindingSource.DataSource = dataSet.Tables["STUDENTS"];
            con.Close();
        }

        //methos for checking whether the textboxes are empty or not.
        bool Validation()
        {
            string student_id = SIBox.Text;
            string surname = snBox.Text;
            string first_name = fnBox.Text;
            string clas_s = cBox.Text;

            if (student_id == "")
            {
                MessageBox.Show("Enter your Student-ID", "Validation of entries", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                SIBox.Focus();
                return false;
            }

            else if (surname == "")
            {
                MessageBox.Show("Enter your Surname", "Validation of entries", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                snBox.Focus();
                return false;
            }

            else if (first_name == "")
            {
                MessageBox.Show("Enter your First-Name", "Validation of entries", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                fnBox.Focus();
                return false;
            }
            else if (clas_s == "")
            {
                MessageBox.Show("Enter your Class. For example, CIS, or CS or SE", "Validation of entries", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cBox.Focus();
                return false;
            }
            return true;
        }
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validation() == true)
            {
                con = new OleDbConnection(connstring);
                con.Open();
                cmd = new OleDbCommand("INSERT into STUDENTS values(@studentno, @Surname, @Firstname, @Class)", con);
                cmd.Parameters.AddWithValue("studentno", int.Parse(SIBox.Text));
                cmd.Parameters.AddWithValue("Surname", snBox.Text);
                cmd.Parameters.AddWithValue("Firstname", fnBox.Text);
                cmd.Parameters.AddWithValue("Class", cBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted successfully");
                con.Close();
                getstudent();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cEASDataSet2.STUDENTS' table. You can move, or remove it, as needed.
            this.sTUDENTSTableAdapter.Fill(this.cEASDataSet2.STUDENTS);
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            if (Validation() == true)
            {
                con = new OleDbConnection(connstring);
                con.Open();
                cmd = new OleDbCommand("UPDATE STUDENTS SET Surname=@Surname, Firstname=@Firstname, Class=@Class WHERE studentno=@studentno", con);
                cmd.Parameters.AddWithValue("Surname", snBox.Text);
                cmd.Parameters.AddWithValue("Firstname", fnBox.Text);
                cmd.Parameters.AddWithValue("Class", cBox.Text);
                cmd.Parameters.AddWithValue("studentno", Convert.ToInt32(int.Parse(SIBox.Text)));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated!");
                con.Close();
                getstudent();
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (Validation() == true)
            {
                con = new OleDbConnection(connstring);
                con.Open();
                cmd = new OleDbCommand("DELETE from STUDENTS WHERE studentno=@studentno", con);
                cmd.Parameters.AddWithValue("studentno", int.Parse(SIBox.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted!");
                con.Close();
                getstudent();
            }
        }

        private void SISgb_Enter(object sender, EventArgs e)
        {

        }
    }
}