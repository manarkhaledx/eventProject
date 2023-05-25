using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project
{
    public partial class MainForm : Form
    {

        // Connection string to the database
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""G:\My Drive\Event Project\DataBase.mdf"";Integrated Security=True";



        // Constructor that receives the logged-in user ID
        public MainForm()
        {

            InitializeComponent();

        }

        // Event handler for the main form load event
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load the user's courses when the form is loaded
            LoadUserCourses();
        }

        // Method to load the courses associated with the logged-in user
        private void LoadUserCourses()
        {

        }

        // Event handler for the logout button click event
        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\manar\Downloads\Project\DataBase.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from ProgrammingTable";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listBox.Items.Add(dr["course_name"]);
            }
            con.Close();
            listBox.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void BusinesspictureBox_Click(object sender, EventArgs e)
        {
            // listBox.Items.Clear();
            // cmd = new SqlCommand();
            // con.Open();
            //  cmd.Connection = con;
            //  cmd.CommandText = "select * from BusinessTable";
            //  dr = cmd.ExecuteReader();
            ///  while (dr.Read())
            //  {
            //      listBox.Items.Add(dr["course_name"]);
            //  }
            //  con.Close();
        }

        private void MarektingpictureBox_Click(object sender, EventArgs e)
        {
            //  listBox.Items.Clear();
            // cmd = new SqlCommand();
            // con.Open();
            // cmd.Connection = con;
            // cmd.CommandText = "select * from MarketingTable";
            // dr = cmd.ExecuteReader();
            //  while (dr.Read())
            ///  {
            //      listBox.Items.Add(dr["course_name"]);
            //   }
            //   con.Close();
        }

        private void LanguagepictureBox_Click(object sender, EventArgs e)
        {
            // listBox.Items.Clear();
            //cmd = new SqlCommand();
            //con.Open();
            /// cmd.Connection = con;
            // cmd.CommandText = "select * from LanguageTable";
            //  dr = cmd.ExecuteReader();
            //  while (dr.Read())
            //  {
            //      listBox.Items.Add(dr["course_name"]);
            //  }
            // con.Close();

        }
    } 
    public enum Categories
    {
        Programming=1,
        Business=2,

    }
}

