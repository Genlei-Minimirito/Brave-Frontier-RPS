namespace Brave_Frontier_CG
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            picCard = new PictureBox();
            lblName = new Label();
            btnSelect = new Button();
            picRIght = new PictureBox();
            picLeft = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRIght).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLeft).BeginInit();
            SuspendLayout();
            // 
            // picCard
            // 
            picCard.BackColor = Color.Transparent;
            picCard.BackgroundImageLayout = ImageLayout.Stretch;
            picCard.Image = Properties.Resources.ATRO;
            picCard.Location = new Point(12, 106);
            picCard.Name = "picCard";
            picCard.Size = new Size(389, 373);
            picCard.SizeMode = PictureBoxSizeMode.StretchImage;
            picCard.TabIndex = 0;
            picCard.TabStop = false;
            picCard.Click += picCard_Click;
            // 
            // lblName
            // 
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblName.ForeColor = SystemColors.ButtonHighlight;
            lblName.Location = new Point(139, 482);
            lblName.Name = "lblName";
            lblName.Size = new Size(137, 60);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(156, 545);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(94, 29);
            btnSelect.TabIndex = 5;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            // 
            // picRIght
            // 
            picRIght.BackColor = Color.Transparent;
            picRIght.Image = (Image)resources.GetObject("picRIght.Image");
            picRIght.Location = new Point(282, 492);
            picRIght.Name = "picRIght";
            picRIght.Size = new Size(92, 82);
            picRIght.SizeMode = PictureBoxSizeMode.StretchImage;
            picRIght.TabIndex = 6;
            picRIght.TabStop = false;
            // 
            // picLeft
            // 
            picLeft.BackColor = Color.Transparent;
            picLeft.Image = (Image)resources.GetObject("picLeft.Image");
            picLeft.Location = new Point(41, 492);
            picLeft.Name = "picLeft";
            picLeft.Size = new Size(92, 82);
            picLeft.SizeMode = PictureBoxSizeMode.StretchImage;
            picLeft.TabIndex = 7;
            picLeft.TabStop = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(413, 680);
            Controls.Add(picLeft);
            Controls.Add(picRIght);
            Controls.Add(btnSelect);
            Controls.Add(lblName);
            Controls.Add(picCard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenu";
            Text = "FormMenu";
            ((System.ComponentModel.ISupportInitialize)picCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRIght).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLeft).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picCard;
        private Label lblName;
        private Button btnSelect;
        private PictureBox picRIght;
        private PictureBox picLeft;
    }
}