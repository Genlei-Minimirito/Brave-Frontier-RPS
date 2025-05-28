namespace Brave_Frontier_CG
{
    partial class FormSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignUp));
            btnSignUp = new Button();
            txtPword = new TextBox();
            txtName = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            picLogIn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogIn).BeginInit();
            SuspendLayout();
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Transparent;
            btnSignUp.FlatStyle = FlatStyle.Popup;
            btnSignUp.Location = new Point(127, 365);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(151, 42);
            btnSignUp.TabIndex = 11;
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click_1;
            // 
            // txtPword
            // 
            txtPword.BackColor = Color.Tan;
            txtPword.BorderStyle = BorderStyle.None;
            txtPword.Location = new Point(54, 325);
            txtPword.Multiline = true;
            txtPword.Name = "txtPword";
            txtPword.PasswordChar = '*';
            txtPword.Size = new Size(296, 25);
            txtPword.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.BackColor = Color.Tan;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Location = new Point(54, 254);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(296, 25);
            txtName.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.VARGAS_IDLE_ANIMATION_ALTER;
            pictureBox2.Location = new Point(64, 48);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 101);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.MAGRESS_IDLE;
            pictureBox1.Location = new Point(222, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // picLogIn
            // 
            picLogIn.BackColor = Color.Transparent;
            picLogIn.Location = new Point(264, 424);
            picLogIn.Name = "picLogIn";
            picLogIn.Size = new Size(74, 19);
            picLogIn.TabIndex = 12;
            picLogIn.TabStop = false;
            picLogIn.Click += picLogIn_Click;
            // 
            // FormSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(413, 680);
            Controls.Add(picLogIn);
            Controls.Add(btnSignUp);
            Controls.Add(txtPword);
            Controls.Add(txtName);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSignUp";
            Text = "FormSignUp";
            Load += FormSignUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogIn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignUp;
        private TextBox txtPword;
        private TextBox txtName;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox picLogIn;
    }
}