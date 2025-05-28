namespace Brave_Frontier_CG
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnTouch = new Button();
            SuspendLayout();
            // 
            // btnTouch
            // 
            btnTouch.BackColor = Color.Transparent;
            btnTouch.FlatStyle = FlatStyle.Popup;
            btnTouch.Font = new Font("Century Schoolbook", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnTouch.ForeColor = Color.Khaki;
            btnTouch.Location = new Point(-45, -24);
            btnTouch.Name = "btnTouch";
            btnTouch.Size = new Size(519, 712);
            btnTouch.TabIndex = 0;
            btnTouch.Text = "TOUCH SCREEN";
            btnTouch.TextAlign = ContentAlignment.BottomCenter;
            btnTouch.UseVisualStyleBackColor = false;
            btnTouch.Click += btnTouch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(413, 680);
            Controls.Add(btnTouch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "BFCG";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnTouch;
    }
}
