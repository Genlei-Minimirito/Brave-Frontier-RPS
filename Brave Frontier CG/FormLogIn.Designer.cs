namespace Brave_Frontier_CG
{
    partial class FormLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtName = new TextBox();
            txtPword = new TextBox();
            btnLogIn = new Button();
            picSign = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSign).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.MAGRESS_IDLE;
            pictureBox1.Location = new Point(216, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.VARGAS_IDLE_ANIMATION_ALTER;
            pictureBox2.Location = new Point(58, 49);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 101);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // txtName
            // 
            txtName.BackColor = Color.Tan;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Location = new Point(58, 254);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(296, 25);
            txtName.TabIndex = 4;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtPword
            // 
            txtPword.BackColor = Color.Tan;
            txtPword.BorderStyle = BorderStyle.None;
            txtPword.Location = new Point(58, 325);
            txtPword.Multiline = true;
            txtPword.Name = "txtPword";
            txtPword.PasswordChar = '*';
            txtPword.Size = new Size(296, 25);
            txtPword.TabIndex = 5;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.Transparent;
            btnLogIn.FlatStyle = FlatStyle.Popup;
            btnLogIn.Location = new Point(121, 366);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(156, 42);
            btnLogIn.TabIndex = 6;
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // picSign
            // 
            picSign.BackColor = Color.Transparent;
            picSign.Location = new Point(268, 424);
            picSign.Name = "picSign";
            picSign.Size = new Size(74, 19);
            picSign.TabIndex = 7;
            picSign.TabStop = false;
            picSign.Click += picSign_Click;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(413, 680);
            Controls.Add(picSign);
            Controls.Add(btnLogIn);
            Controls.Add(txtPword);
            Controls.Add(txtName);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogIn";
            Text = "FormLogIn";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSign).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtName;
        private TextBox txtPword;
        private Button btnLogIn;
        private PictureBox picSign;
    }
}