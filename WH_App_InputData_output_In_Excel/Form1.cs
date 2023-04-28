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
using System.Text.RegularExpressions;


namespace WH_App_InputData_output_In_Excel
{
    public partial class Form1 : Form
    {
        public string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=EmployeeManagement;Integrated Security=True";
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
           
            this.Text = $"Insert into DB and Get Result in Excel";

            _idText.TextChanged += _idText_TextChanged;
            _salary.TextChanged += _salary_TextChanged;
            _nameText.TextChanged += _nameText_TextChanged;
            _addBtn.Click += _addBtn_Click;
            _show.Click += _show_Click;
           
            

        }

      

        private void _show_Click(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Employee";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    dt.Clear();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void _nameText_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(_nameText.Text, "^[a-zA-Z]+$"))
            {
                MessageBox.Show("Please enter only Letter characters.");
                _nameText.Text = "";
            }
        }

        private void _salary_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(_salary.Text, "^[0-9]+$"))
            {
                MessageBox.Show("Please enter only numeric characters.");
                _salary.Text = "";
            }
        }





        private void _idText_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(_idText.Text, "^[0-9]+$"))
            {
                MessageBox.Show("Please enter only numeric characters.");
                _idText.Text = "";
            }
        }



        private void _addBtn_Click(object sender, EventArgs e)
        {
            // Define the query to insert data into a table
            string query = "INSERT INTO Employee (ID, name, startDate, salary) VALUES (@ID, @name, @startDate,@salary)";

            // Open a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a command object
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Set the parameter values

                    command.Parameters.AddWithValue("@ID", _idText.Text);
                    command.Parameters.AddWithValue("@name", _nameText.Text);
                    command.Parameters.AddWithValue("@startDate", _caldenr.Value);
                    command.Parameters.AddWithValue("@salary", _salary.Text);

                    int rowAResult = command.ExecuteNonQuery();

                    Console.WriteLine($"Affected Line : {rowAResult}");



                }
            }

        }




    }
}
