namespace MiniChatApp.Client.Forms
{
    partial class LoginForm
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
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            openRegisterFormButton = new Label();
            label4 = new Label();
            loginButton = new Button();
            label3 = new Label();
            passwordTextBox = new TextBox();
            label2 = new Label();
            userNameTextBox = new TextBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(openRegisterFormButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(passwordTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(userNameTextBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(103, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 523);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.search;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(201, 475);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 45);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.twitter;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(259, 475);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 45);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.facebook;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(142, 475);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 45);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // openRegisterFormButton
            // 
            openRegisterFormButton.Font = new Font("Tahoma", 10F);
            openRegisterFormButton.ForeColor = Color.FromArgb(128, 128, 255);
            openRegisterFormButton.Location = new Point(3, 428);
            openRegisterFormButton.Name = "openRegisterFormButton";
            openRegisterFormButton.Size = new Size(444, 35);
            openRegisterFormButton.TabIndex = 7;
            openRegisterFormButton.Text = "Register";
            openRegisterFormButton.TextAlign = ContentAlignment.MiddleCenter;
            openRegisterFormButton.Click += openRegisterFormButton_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Tahoma", 10F);
            label4.Location = new Point(3, 393);
            label4.Name = "label4";
            label4.Size = new Size(444, 35);
            label4.TabIndex = 6;
            label4.Text = "Don't have an account?";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(128, 128, 255);
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.FromArgb(192, 192, 255);
            loginButton.Location = new Point(3, 316);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(444, 41);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Tahoma", 12F);
            label3.Location = new Point(3, 188);
            label3.Name = "label3";
            label3.Size = new Size(444, 43);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(3, 234);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '•';
            passwordTextBox.Size = new Size(444, 41);
            passwordTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("Tahoma", 12F);
            label2.Location = new Point(3, 82);
            label2.Name = "label2";
            label2.Size = new Size(444, 43);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // userNameTextBox
            // 
            userNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            userNameTextBox.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameTextBox.Location = new Point(3, 128);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(444, 41);
            userNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(444, 43);
            label1.TabIndex = 0;
            label1.Text = "Welcome Back!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = Properties.Resources.multiply;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(1223, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(45, 45);
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            BackgroundImage = Properties.Resources.Login_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1280, 720);
            Controls.Add(pictureBox4);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private TextBox passwordTextBox;
        private Label label2;
        private TextBox userNameTextBox;
        private Label label1;
        private Button loginButton;
        private Label openRegisterFormButton;
        private Label label4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
    }
}