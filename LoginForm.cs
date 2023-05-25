using System.Data.SqlClient;
using System;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Data;
using Microsoft.VisualBasic.ApplicationServices;

namespace Project
{
   
       


    public partial class LoginForm : Form
    {  //declare the fields as nullable
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public LoginForm()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
            {
                try
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open(); // Open the connection if it's not already open

                    cmd = new SqlCommand("select * from userTable where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'", cn);
                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        dr.Close();
                        this.Hide();
                        cn.Close(); // Close the connection after use
                        this.Hide(); // Hide the current form

                        MainForm mainForm = new MainForm(); // Provide the UserId value
                        mainForm.Show();
                        // Show the SandwichesForm
                        // Add code here for the desired action when an account is found
                    }
                    else
                    {
                        dr.Close();
                        cn.Close(); // Close the connection after use
                        MessageBox.Show("No Account available with this username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    cn.Close(); // Close the connection in case of an error
                    MessageBox.Show("An error occurred while executing the query: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false; // Hide the current form

            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show(); // Show the SignUpForm
        }

        private void DrinksButton_Click(object sender, EventArgs e)
        {

        }

        private void dessertsbutton_Click(object sender, EventArgs e)
        {

        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        { //used to establish a connection to a Microsoft SQL Server database
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\manar\Downloads\Project\DataBase.mdf;Integrated Security=True");
            cn.Open();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}