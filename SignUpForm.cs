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

namespace Project
{
    public partial class SignUpForm : Form
    {
        SqlCommand? cmd; // Declare cmd variable nullable
        SqlConnection cn; // Declare cn variable
        SqlDataReader? dr; // Declare dr variable nullable
        //By keeping dr as a non-nullable SqlDataReader,
        //you indicate that it will always have a non-null value when it is accessed,

        public SignUpForm()
        {
            InitializeComponent();
            //This code creates a database connection and opens it.
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\manar\Downloads\Project\DataBase.mdf;Integrated Security=True");
            cn.Open();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtconfirmpassword.Text != string.Empty || txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
            {
                if (txtpassword.Text == txtconfirmpassword.Text)
                { //to execute a SQL query. The query selects records from the "LoginTable"
                    cmd = new SqlCommand("select * from userTable where username='" + txtusername.Text + "'", cn);
                    dr = cmd.ExecuteReader(); // to execute the query and retrieve the results as a SqlDataReader
                    if (dr.Read()) //If a record is found, it means that the username already exists in the "LoginTable",
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                        SignUpForm signUpForm = new SignUpForm();
                        signUpForm.Show(); // Show the SignUpForm
                    }
                    else
                    {
                        dr.Close(); //If ( the username doesn't exist), the SqlDataReader is closed, 
                        cmd = new SqlCommand("insert into userTable values(@username,@password)", cn); //created to perform an insert operation
                        cmd.Parameters.AddWithValue("username", txtusername.Text);//inserts the username
                        cmd.Parameters.AddWithValue("password", txtpassword.Text);//" " Password

                        cmd.ExecuteNonQuery(); //execute the insert query and make changes to the database.
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        LoginForm loginForm = new LoginForm();
                        loginForm.ShowDialog(); // Show the LoginForm



                    }
                }
                else
                { // if passwords entered wrong
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    SignUpForm signUpForm = new SignUpForm();
                    signUpForm.Show(); // Show the SignUpForm
                }
            }
            else
            { // missing field
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Visible = false; // Hide the current form

                SignUpForm signUpForm = new SignUpForm();
                signUpForm.Show(); // Show the SignUpForm
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mealbutton_Click(object sender, EventArgs e)
        {
        }

        private void sandwichesbutton_Click(object sender, EventArgs e)
        {

        }

        private void DrinksButton_Click(object sender, EventArgs e)
        {
        }

        private void dessertsbutton_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false; // Hide the current form

            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog(); // Show the LoginForm

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
