namespace Project
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            WelcomePanel = new Panel();
            label1 = new Label();
            Exitbutton = new Button();
            LogInButton = new Button();
            SignUpbutton = new Button();
            txtpassword = new TextBox();
            txtusername = new TextBox();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            WelcomePanel.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // WelcomePanel
            // 
            WelcomePanel.BackColor = Color.FromArgb(165, 64, 213);
            WelcomePanel.Controls.Add(label1);
            WelcomePanel.Dock = DockStyle.Top;
            WelcomePanel.Location = new Point(0, 0);
            WelcomePanel.Margin = new Padding(1);
            WelcomePanel.Name = "WelcomePanel";
            WelcomePanel.Size = new Size(1016, 95);
            WelcomePanel.TabIndex = 2;
            WelcomePanel.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(325, 27);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(380, 29);
            label1.TabIndex = 0;
            label1.Text = "Welcome To Our Courses Platform";
            label1.Click += label1_Click;
            // 
            // Exitbutton
            // 
            Exitbutton.BackColor = Color.FromArgb(165, 64, 213);
            Exitbutton.FlatStyle = FlatStyle.Flat;
            Exitbutton.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Exitbutton.ForeColor = Color.White;
            Exitbutton.Location = new Point(544, 583);
            Exitbutton.Margin = new Padding(1);
            Exitbutton.Name = "Exitbutton";
            Exitbutton.Size = new Size(191, 43);
            Exitbutton.TabIndex = 8;
            Exitbutton.Text = "Exit";
            Exitbutton.UseVisualStyleBackColor = false;
            Exitbutton.Click += Exitbutton_Click;
            // 
            // LogInButton
            // 
            LogInButton.BackColor = Color.FromArgb(165, 64, 213);
            LogInButton.FlatStyle = FlatStyle.Flat;
            LogInButton.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LogInButton.ForeColor = Color.White;
            LogInButton.Location = new Point(385, 507);
            LogInButton.Margin = new Padding(1);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(191, 43);
            LogInButton.TabIndex = 9;
            LogInButton.Text = "Login";
            LogInButton.UseVisualStyleBackColor = false;
            LogInButton.Click += button3_Click;
            // 
            // SignUpbutton
            // 
            SignUpbutton.BackColor = Color.FromArgb(165, 64, 213);
            SignUpbutton.FlatStyle = FlatStyle.Flat;
            SignUpbutton.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            SignUpbutton.ForeColor = Color.White;
            SignUpbutton.Location = new Point(215, 583);
            SignUpbutton.Margin = new Padding(1);
            SignUpbutton.Name = "SignUpbutton";
            SignUpbutton.Size = new Size(191, 43);
            SignUpbutton.TabIndex = 10;
            SignUpbutton.Text = "SignUp";
            SignUpbutton.UseVisualStyleBackColor = false;
            SignUpbutton.Click += button5_Click;
            // 
            // txtpassword
            // 
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtpassword.ForeColor = Color.FromArgb(165, 64, 213);
            txtpassword.Location = new Point(391, 432);
            txtpassword.Margin = new Padding(1);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(235, 32);
            txtpassword.TabIndex = 17;
            txtpassword.Text = "Password";
            // 
            // txtusername
            // 
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtusername.ForeColor = Color.FromArgb(165, 64, 213);
            txtusername.Location = new Point(391, 365);
            txtusername.Margin = new Padding(1);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(235, 32);
            txtusername.TabIndex = 16;
            txtusername.Text = "Username";
            txtusername.TextChanged += textBox4_TextChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(127, 9);
            panel4.Margin = new Padding(1);
            panel4.Name = "panel4";
            panel4.Size = new Size(168, 168);
            panel4.TabIndex = 18;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-10, -8);
            pictureBox2.Margin = new Padding(1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(177, 175);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(385, 75);
            pictureBox1.Margin = new Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(165, 64, 213);
            label5.Location = new Point(416, 316);
            label5.Name = "label5";
            label5.Size = new Size(141, 45);
            label5.TabIndex = 25;
            label5.Text = "LOG IN";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(357, 369);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(218, 167, 234);
            panel1.Location = new Point(357, 405);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 1);
            panel1.TabIndex = 27;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(357, 433);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(29, 33);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 26;
            pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(218, 167, 234);
            panel2.Location = new Point(357, 469);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 1);
            panel2.TabIndex = 27;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1016, 683);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label5);
            Controls.Add(panel4);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(SignUpbutton);
            Controls.Add(LogInButton);
            Controls.Add(Exitbutton);
            Controls.Add(pictureBox1);
            Controls.Add(WelcomePanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "Form1";
            Load += LoginForm_Load;
            WelcomePanel.ResumeLayout(false);
            WelcomePanel.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Panel WelcomePanel;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button5;
        private TextBox txtpassword;
        private TextBox txtusername;
        private Button Exitbutton;
        private Button LogInButton;
        private Button SignUpbutton;
        private Panel panel4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label5;
        private PictureBox pictureBox3;
        private Panel panel1;
        private PictureBox pictureBox4;
        private Panel panel2;
    }
}