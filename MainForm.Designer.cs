namespace Project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            WelcomePanel = new Panel();
            label1 = new Label();
            programmingpictureBox = new PictureBox();
            label2 = new Label();
            listBox = new ListBox();
            BusinesspictureBox = new PictureBox();
            MarektingpictureBox = new PictureBox();
            LanguagepictureBox = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Buybutton = new Button();
            Exitbutton = new Button();
            WelcomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)programmingpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BusinesspictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MarektingpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LanguagepictureBox).BeginInit();
            SuspendLayout();
            // 
            // WelcomePanel
            // 
            WelcomePanel.BackColor = Color.FromArgb(165, 64, 213);
            WelcomePanel.Controls.Add(label1);
            WelcomePanel.Dock = DockStyle.Top;
            WelcomePanel.Location = new Point(0, 0);
            WelcomePanel.Margin = new Padding(1, 2, 1, 2);
            WelcomePanel.Name = "WelcomePanel";
            WelcomePanel.Size = new Size(997, 94);
            WelcomePanel.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(415, 32);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 29);
            label1.TabIndex = 0;
            label1.Text = "Our Courses";
            // 
            // programmingpictureBox
            // 
            programmingpictureBox.Image = (Image)resources.GetObject("programmingpictureBox.Image");
            programmingpictureBox.Location = new Point(91, 120);
            programmingpictureBox.Margin = new Padding(3, 4, 3, 4);
            programmingpictureBox.Name = "programmingpictureBox";
            programmingpictureBox.Size = new Size(120, 120);
            programmingpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            programmingpictureBox.TabIndex = 8;
            programmingpictureBox.TabStop = false;
            programmingpictureBox.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(165, 64, 213);
            label2.Location = new Point(79, 266);
            label2.Name = "label2";
            label2.Size = new Size(160, 29);
            label2.TabIndex = 9;
            label2.Text = "Programming";
            // 
            // listBox
            // 
            listBox.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            listBox.ForeColor = Color.FromArgb(165, 64, 213);
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 29;
            listBox.Location = new Point(290, 346);
            listBox.Margin = new Padding(3, 4, 3, 4);
            listBox.Name = "listBox";
            listBox.Size = new Size(286, 178);
            listBox.TabIndex = 10;
            listBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // BusinesspictureBox
            // 
            BusinesspictureBox.Image = (Image)resources.GetObject("BusinesspictureBox.Image");
            BusinesspictureBox.Location = new Point(309, 120);
            BusinesspictureBox.Margin = new Padding(3, 4, 3, 4);
            BusinesspictureBox.Name = "BusinesspictureBox";
            BusinesspictureBox.Size = new Size(131, 120);
            BusinesspictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            BusinesspictureBox.TabIndex = 12;
            BusinesspictureBox.TabStop = false;
            BusinesspictureBox.Click += BusinesspictureBox_Click;
            // 
            // MarektingpictureBox
            // 
            MarektingpictureBox.Image = (Image)resources.GetObject("MarektingpictureBox.Image");
            MarektingpictureBox.Location = new Point(537, 120);
            MarektingpictureBox.Margin = new Padding(3, 4, 3, 4);
            MarektingpictureBox.Name = "MarektingpictureBox";
            MarektingpictureBox.Size = new Size(109, 120);
            MarektingpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            MarektingpictureBox.TabIndex = 13;
            MarektingpictureBox.TabStop = false;
            MarektingpictureBox.Click += MarektingpictureBox_Click;
            // 
            // LanguagepictureBox
            // 
            LanguagepictureBox.Image = (Image)resources.GetObject("LanguagepictureBox.Image");
            LanguagepictureBox.Location = new Point(743, 120);
            LanguagepictureBox.Margin = new Padding(3, 4, 3, 4);
            LanguagepictureBox.Name = "LanguagepictureBox";
            LanguagepictureBox.Size = new Size(106, 120);
            LanguagepictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            LanguagepictureBox.TabIndex = 14;
            LanguagepictureBox.TabStop = false;
            LanguagepictureBox.Click += LanguagepictureBox_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(165, 64, 213);
            label3.Location = new Point(323, 266);
            label3.Name = "label3";
            label3.Size = new Size(109, 29);
            label3.TabIndex = 15;
            label3.Text = "Business";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(165, 64, 213);
            label4.Location = new Point(537, 266);
            label4.Name = "label4";
            label4.Size = new Size(121, 29);
            label4.TabIndex = 16;
            label4.Text = "Marketing";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(165, 64, 213);
            label5.Location = new Point(743, 266);
            label5.Name = "label5";
            label5.Size = new Size(118, 29);
            label5.TabIndex = 17;
            label5.Text = "Language";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(165, 64, 213);
            label6.Location = new Point(79, 346);
            label6.Name = "label6";
            label6.Size = new Size(188, 29);
            label6.TabIndex = 18;
            label6.Text = "Choose courses:";
            // 
            // Buybutton
            // 
            Buybutton.BackColor = Color.FromArgb(165, 64, 213);
            Buybutton.FlatStyle = FlatStyle.Flat;
            Buybutton.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Buybutton.ForeColor = Color.White;
            Buybutton.Location = new Point(678, 406);
            Buybutton.Margin = new Padding(3, 4, 3, 4);
            Buybutton.Name = "Buybutton";
            Buybutton.Size = new Size(129, 52);
            Buybutton.TabIndex = 19;
            Buybutton.Text = "Buy";
            Buybutton.UseVisualStyleBackColor = false;
            // 
            // Exitbutton
            // 
            Exitbutton.BackColor = Color.FromArgb(165, 64, 213);
            Exitbutton.FlatStyle = FlatStyle.Flat;
            Exitbutton.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Exitbutton.ForeColor = Color.White;
            Exitbutton.Location = new Point(678, 484);
            Exitbutton.Margin = new Padding(3, 4, 3, 4);
            Exitbutton.Name = "Exitbutton";
            Exitbutton.Size = new Size(129, 52);
            Exitbutton.TabIndex = 20;
            Exitbutton.Text = "Exit";
            Exitbutton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(997, 650);
            Controls.Add(Exitbutton);
            Controls.Add(Buybutton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(LanguagepictureBox);
            Controls.Add(MarektingpictureBox);
            Controls.Add(BusinesspictureBox);
            Controls.Add(listBox);
            Controls.Add(label2);
            Controls.Add(programmingpictureBox);
            Controls.Add(WelcomePanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load_1;
            WelcomePanel.ResumeLayout(false);
            WelcomePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)programmingpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BusinesspictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)MarektingpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)LanguagepictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel WelcomePanel;
        private Label label1;
        private PictureBox programmingpictureBox;
        private Label label2;
        private ListBox listBox;
        private PictureBox BusinesspictureBox;
        private PictureBox MarektingpictureBox;
        private PictureBox LanguagepictureBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button Buybutton;
        private Button Exitbutton;
    }
}