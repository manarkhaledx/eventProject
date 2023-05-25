namespace Project
{
    partial class SignUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            pictureBox1 = new PictureBox();
            button3 = new Button();
            label1 = new Label();
            WelcomePanel = new Panel();
            button2 = new Button();
            button5 = new Button();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            txtconfirmpassword = new TextBox();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            WelcomePanel.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(337, 56);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(165, 64, 213);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(337, 434);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(167, 32);
            button3.TabIndex = 19;
            button3.Text = "Login";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(284, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(300, 23);
            label1.TabIndex = 0;
            label1.Text = "Welcome To Our Courses Platform";
            // 
            // WelcomePanel
            // 
            WelcomePanel.BackColor = Color.FromArgb(165, 64, 213);
            WelcomePanel.Controls.Add(label1);
            WelcomePanel.Dock = DockStyle.Top;
            WelcomePanel.Location = new Point(0, 0);
            WelcomePanel.Margin = new Padding(2);
            WelcomePanel.Name = "WelcomePanel";
            WelcomePanel.Size = new Size(889, 71);
            WelcomePanel.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(165, 64, 213);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(578, 434);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(167, 32);
            button2.TabIndex = 18;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(165, 64, 213);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(119, 434);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(167, 32);
            button5.TabIndex = 20;
            button5.Text = "SignUp";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // txtusername
            // 
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtusername.ForeColor = Color.FromArgb(165, 64, 213);
            txtusername.Location = new Point(342, 274);
            txtusername.Margin = new Padding(2);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(206, 24);
            txtusername.TabIndex = 14;
            txtusername.Text = "Username";
            txtusername.TextChanged += textBox1_TextChanged;
            // 
            // txtpassword
            // 
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtpassword.ForeColor = Color.FromArgb(165, 64, 213);
            txtpassword.Location = new Point(342, 326);
            txtpassword.Margin = new Padding(2);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(206, 23);
            txtpassword.TabIndex = 15;
            txtpassword.Text = "Password";
            txtpassword.TextChanged += textBox2_TextChanged_1;
            // 
            // txtconfirmpassword
            // 
            txtconfirmpassword.BorderStyle = BorderStyle.None;
            txtconfirmpassword.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtconfirmpassword.ForeColor = Color.FromArgb(165, 64, 213);
            txtconfirmpassword.Location = new Point(342, 372);
            txtconfirmpassword.Margin = new Padding(2);
            txtconfirmpassword.Name = "txtconfirmpassword";
            txtconfirmpassword.Size = new Size(206, 23);
            txtconfirmpassword.TabIndex = 21;
            txtconfirmpassword.Text = "Confirm Password";
            txtconfirmpassword.TextChanged += textBox3_TextChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(57, 8);
            panel4.Margin = new Padding(1);
            panel4.Name = "panel4";
            panel4.Size = new Size(147, 126);
            panel4.TabIndex = 23;
            panel4.Paint += panel4_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(147, 126);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(165, 64, 213);
            label5.Location = new Point(364, 237);
            label5.Name = "label5";
            label5.Size = new Size(130, 36);
            label5.TabIndex = 24;
            label5.Text = "SIGN UP";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(312, 277);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(218, 167, 234);
            panel1.Location = new Point(312, 304);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 1);
            panel1.TabIndex = 26;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(312, 326);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 25;
            pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(218, 167, 234);
            panel2.Location = new Point(312, 353);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 1);
            panel2.TabIndex = 26;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(312, 373);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(25, 25);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 25;
            pictureBox5.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(218, 167, 234);
            panel3.Location = new Point(312, 400);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 1);
            panel3.TabIndex = 26;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(889, 512);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label5);
            Controls.Add(panel4);
            Controls.Add(pictureBox1);
            Controls.Add(txtconfirmpassword);
            Controls.Add(WelcomePanel);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Margin = new Padding(2);
            Name = "SignUpForm";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            WelcomePanel.ResumeLayout(false);
            WelcomePanel.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button button3;
        private Label label1;
        private Panel WelcomePanel;
        private Button button2;
        private Button button5;
        private TextBox txtusername;
        private TextBox txtpassword;
        private TextBox txtconfirmpassword;
        private Panel panel4;
        private PictureBox pictureBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label5;
        private PictureBox pictureBox3;
        private Panel panel1;
        private PictureBox pictureBox4;
        private Panel panel2;
        private PictureBox pictureBox5;
        private Panel panel3;
    }
}