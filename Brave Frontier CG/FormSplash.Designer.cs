namespace Brave_Frontier_CG
{
    partial class FormSplash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSplash));
            prgBarLoading = new ProgressBar();
            picSplash = new PictureBox();
            lblConnecting = new Label();
            tmrSplash = new System.Windows.Forms.Timer(components);
            btnTouch = new Button();
            ((System.ComponentModel.ISupportInitialize)picSplash).BeginInit();
            SuspendLayout();
            // 
            // prgBarLoading
            // 
            prgBarLoading.ForeColor = Color.Khaki;
            prgBarLoading.Location = new Point(-1, 647);
            prgBarLoading.Name = "prgBarLoading";
            prgBarLoading.Size = new Size(432, 29);
            prgBarLoading.Style = ProgressBarStyle.Continuous;
            prgBarLoading.TabIndex = 0;
            prgBarLoading.Visible = false;
            prgBarLoading.Click += prgBarLoading_Click;
            // 
            // picSplash
            // 
            picSplash.BackgroundImageLayout = ImageLayout.Stretch;
            picSplash.Image = (Image)resources.GetObject("picSplash.Image");
            picSplash.Location = new Point(137, 243);
            picSplash.Name = "picSplash";
            picSplash.Size = new Size(154, 143);
            picSplash.TabIndex = 1;
            picSplash.TabStop = false;
            // 
            // lblConnecting
            // 
            lblConnecting.AutoSize = true;
            lblConnecting.BackColor = Color.Transparent;
            lblConnecting.ForeColor = SystemColors.ButtonHighlight;
            lblConnecting.Location = new Point(172, 389);
            lblConnecting.Name = "lblConnecting";
            lblConnecting.Size = new Size(93, 20);
            lblConnecting.TabIndex = 2;
            lblConnecting.Text = "Connecting...";
            // 
            // tmrSplash
            // 
            tmrSplash.Enabled = true;
            tmrSplash.Tick += tmrSplash_Tick;
            // 
            // btnTouch
            // 
            btnTouch.BackColor = Color.Transparent;
            btnTouch.FlatStyle = FlatStyle.Popup;
            btnTouch.Font = new Font("Century Schoolbook", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnTouch.ForeColor = Color.Khaki;
            btnTouch.Location = new Point(-43, -14);
            btnTouch.Name = "btnTouch";
            btnTouch.Size = new Size(509, 709);
            btnTouch.TabIndex = 3;
            btnTouch.TextAlign = ContentAlignment.BottomCenter;
            btnTouch.UseVisualStyleBackColor = false;
            btnTouch.Click += btnTouch_Click;
            // 
            // FormSplash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(413, 680);
            Controls.Add(lblConnecting);
            Controls.Add(picSplash);
            Controls.Add(prgBarLoading);
            Controls.Add(btnTouch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSplash";
            Text = "FormSplash";
            ((System.ComponentModel.ISupportInitialize)picSplash).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox picSplash;
        private Label lblConnecting;
        private System.Windows.Forms.Timer tmrSplash;
        public ProgressBar prgBarLoading;
        private Button btnTouch;
    }
}