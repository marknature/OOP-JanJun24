using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb; // Microsoft Access Module
using System.Windows.Forms;

namespace Group_assignment_2___Microsoft_Access
{
    public partial class Interface1 : Form
    {
        OleDbConnection con; // Connection string
        OleDbCommand cmd; //Command
        OleDbDataAdapter adapter; //Adapter (what does the button do?)
        DataTable dt; // DataTable method

        void GetStudent() // Display DataTable on gridview method
        {
            try
            {
                con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\markn\onedrive\documents\visual studio 2013\Projects\Group assignment 2 - Microsoft Access\Group assignment 2 - Microsoft Access\CEAS.mdb"); // Connection string
                con.Open(); // open connection
                adapter = new OleDbDataAdapter("SELECT *FROM STUDENTS", con); // Adapter (what does the button do?)
                sTUDENTSBindingSource.DataSource = dataSet.Tables["STUDENTS"];
                dt = new DataTable(); // DataTable
                sTUDENTSBindingSource.DataSource = dt; // Datasource
                adapter.Fill(dt); // use adapter in Data Table
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection
                con.Close();
            }
        }

        void dataviewer()
        {
            try
            {
                con.Open();
                // Query to retrieve data
                string query = "SELECT * FROM STUDENTS";
                // Create a data adapter
                adapter = new OleDbDataAdapter(query, con);
                // Create a new DataSet
                dataSet = new DataSet();
                // Fill the DataSet with the data from the data adapter
                adapter.Fill(dataSet, "STUDENTS");
                // Set the DataSource property of the DataGridView to the DataSet
                sTUDENTSBindingSource1.DataSource = dataSet.Tables["STUDENTS"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            { 
                GetStudent(); // Fetch data from the database
                // Close the database connection
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        
        public Interface1()
        {
            InitializeComponent();
            GetStudent(); // Fetch data from the database
        }
        private void Interface1_Load(object sender, EventArgs e) // Form1 interface
        {
           // TODO: This line of code loads data into the 'dataSet.STUDENTS' table. You can move, or remove it, as needed.
           this.sTUDENTSTableAdapter.Fill(this.dataSet.STUDENTS); // Fill from Dataset
        }

        //methos for checking whether the textboxes are empty or not.
        private bool Validation() // validation method
        {
            string student_id = textBoxID.Text;
            string surname = textBoxsur.Text;
            string first_name = textBoxFN.Text;
            string clas_s = textBoxclass.Text;

            if (student_id == "")
            {
                MessageBox.Show("Enter your Student-ID", "Validation of entries", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxID.Focus();
                return false;
            }

            else if (surname == "")
            {
                MessageBox.Show("Enter your Surname", "Validation of entries", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxsur.Focus();
                return false;
            }

            else if (first_name == "")
            {
                MessageBox.Show("Enter your First-Name", "Validation of entries", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxFN.Focus();
                return false;
            }
            else if (clas_s == "")
            {
                MessageBox.Show("Enter your Class. For example, CIS, or CS or SE", "Validation of entries", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBoxclass.Focus();
                return false;
            }
            return true;
        }

        private bool IsIdExistsInDatabase(int studentno) // check if textboxID = student
        {
            bool exists = false;
            con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\markn\onedrive\documents\visual studio 2013\Projects\Group assignment 2 - Microsoft Access\Group assignment 2 - Microsoft Access\CEAS.mdb"); // Connection string

            try
            {
                // Open the connection
                con.Open();

                // SQL query to check if the ID exists in the database
                string query = "SELECT COUNT(*) FROM STUDENTS WHERE studentno = @studentno";

                // Creating a new OleDbCommand
                cmd = new OleDbCommand(query, con);

                // Adding parameters
                cmd.Parameters.AddWithValue("@studentno", studentno);

                // Execute the query
                int count = (int)cmd.ExecuteScalar();

                // Check if count is greater than 0, meaning the ID exists
                if (count > 0)
                {
                    exists = true;
                    // The ID exists in the database, you can execute your code here
                    MessageBox.Show("Student Number exists in the Database!");
                }
            }
            catch
            {
                MessageBox.Show("Student Number does not exist in the Database!");
            }
            finally
            {
                // Close the connection
                con.Close();
            }

            return exists;
        }

        private void ExecuteIfIdExistsInDatabase(int studentno) // perform an action here
        {
            if (IsIdExistsInDatabase(studentno))
            {
                con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\markn\onedrive\documents\visual studio 2013\Projects\Group assignment 2 - Microsoft Access\Group assignment 2 - Microsoft Access\CEAS.mdb"); // connection string
                try
                {
                    con.Open(); // Open connection
                    string query = "DELETE FROM STUDENTS WHERE studentno = @studentno"; // Adapter (what does the button do?)
                    cmd = new OleDbCommand(query, con); //command
                    cmd.Parameters.AddWithValue("@studentno", Convert.ToInt32(textBoxID.Text)); // Add the key to update (student number), to verify which row you targetting
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("You have been successfully DELETED from Database!"); // Massage
                }
                catch // fetch the validation method
                {
                    Validation();
                }
                finally
                {
                    // Close the connection
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Student Number does not exist in the database!");
            }
        }

        private void URbutton_Click(object sender, EventArgs e) // Update Record Button
        {
            DialogResult urt;
            urt = MessageBox.Show("Confirm if you want to update?", "Student Information System", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //confirm if user wahts to exit

            if (urt == DialogResult.Yes)
            {
                con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\markn\onedrive\documents\visual studio 2013\Projects\Group assignment 2 - Microsoft Access\Group assignment 2 - Microsoft Access\CEAS.mdb"); //Connection string
                try
                {
                    con.Open(); // open connection
                    string query = "UPDATE STUDENTS SET Surname=@Surname, Firstname=@Firstname, Class=@Class WHERE studentno=@studentno"; // Adapter (what does the button do?)
                    cmd = new OleDbCommand(query, con); // command
                    //add textbox value to Database
                    cmd.Parameters.AddWithValue("@Surname", textBoxsur.Text);
                    cmd.Parameters.AddWithValue("@Firstname", textBoxFN.Text);
                    cmd.Parameters.AddWithValue("@Class", textBoxclass.Text);
                    cmd.Parameters.AddWithValue("@studentno", Convert.ToInt32(textBoxID.Text)); // Add the key to update (student number), to verify which row you targetting
                    cmd.Connection = con; // Connection command = connection string
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("You have been successfully updated to the Database!"); // Message
                }
                catch // fetch the validation method
                {
                    Validation();
                }
                finally
                {
                    GetStudent(); // Fetch data from the database
                    // Close the connection
                    con.Close();
                }
                dataviewer();
            }
        }

        private void deletebutton_Click(object sender, EventArgs e) // Delete Button
        {
            DialogResult delt;
            delt = MessageBox.Show("Confirm if you want to DELETE?", "Student Information System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); //confirm if user wahts to exit

            if (delt == DialogResult.Yes)
            {
                string student_id = textBoxID.Text;
                if (student_id == "")
                {
                    Validation(); // fetch the validation method
                }
                else
                {
                    // Get the studentno from the textbox
                    int idToCheck = Convert.ToInt32(textBoxID.Text);
                    // Call the method to check if the ID exists before execution
                    ExecuteIfIdExistsInDatabase(idToCheck);
                    Validation(); // fetch the validation method
                    GetStudent(); // Fetch data from the database
                    dataviewer();
                }
            }
        }

        private void insertbutton_Click(object sender, EventArgs e) // insert button
        {
            DialogResult insert;
            insert = MessageBox.Show("Confirm if you want to insert into database?", "Student Information System", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //confirm if user wahts to exit

            if (insert == DialogResult.Yes)
            {
                con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\markn\onedrive\documents\visual studio 2013\Projects\Group assignment 2 - Microsoft Access\Group assignment 2 - Microsoft Access\CEAS.mdb"); // Connection string
                try
                {
                    con.Open(); // open connection
                    string query = "INSERT INTO STUDENTS (studentno, Surname, Firstname, Class) VALUES" + "(@studentno, @Surname, @Firstname, @Class)"; // Adapter (what does the button do?)
                    cmd = new OleDbCommand(query); // Command
                    //add textbox value to Database
                    cmd.Parameters.AddWithValue("@studentno", textBoxID.Text);
                    cmd.Parameters.AddWithValue("@Surname", textBoxsur.Text);
                    cmd.Parameters.AddWithValue("@Firstname", textBoxFN.Text);
                    cmd.Parameters.AddWithValue("@Class", textBoxclass.Text);
                    cmd.Connection = con; // Connection command = connection string
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("You have been successfully added to the Database!"); //Message after successful insert
                }
                catch // fetch the validtion method
                {
                    Validation();
                }
                finally
                {
                    GetStudent(); // Fetch data from the database
                    // Close the connection
                    con.Close();
                    dataviewer();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // Check if the clicked cell is in the data rows (not in the header or empty rows)
           /*aif (e.RowIndex >= 0 && e.RowIndex < sTUDENTSBindingSource.Rows.Count) 
            {
                DataGridViewRow row = sTUDENTSBindingSource1.Rows[e.RowIndex];
                textBoxclass.Text = row.Cells[0].Value.ToString();
                textBoxclass.Text = row.Cells[1].Value.ToString();
                textBoxclass.Text = row.Cells[2].Value.ToString();
                textBoxclass.Text = row.Cells[3].Value.ToString();
            }
            */
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitbutton_Click(object sender, EventArgs e) // Exit Button
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit?", "Student Information System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); //confirm if user wahts to exit

            if (iExit == DialogResult.Yes)
            {
                Application.Exit(); // Method
            }
        }

        private void SIS_Enter(object sender, EventArgs e)
        {

        }
    }
}
