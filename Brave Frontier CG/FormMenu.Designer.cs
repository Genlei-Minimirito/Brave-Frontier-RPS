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
            picCard = new PictureBox();
            lblName = new Label();
            btnRight = new Button();
            btnLeft = new Button();
            btnSelect = new Button();
            ((System.ComponentModel.ISupportInitialize)picCard).BeginInit();
            SuspendLayout();
            // 
            // picCard
            // 
            picCard.BackColor = Color.WhiteSmoke;
            picCard.BackgroundImageLayout = ImageLayout.Stretch;
            picCard.Location = new Point(41, 56);
            picCard.Name = "picCard";
            picCard.Size = new Size(333, 423);
            picCard.TabIndex = 0;
            picCard.TabStop = false;
            picCard.Click += picCard_Click;
            // 
            // lblName
            // 
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblName.ForeColor = SystemColors.ButtonHighlight;
            lblName.Location = new Point(134, 482);
            lblName.Name = "lblName";
            lblName.Size = new Size(142, 60);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRight
            // 
            btnRight.Location = new Point(275, 492);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(84, 82);
            btnRight.TabIndex = 3;
            btnRight.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            btnLeft.Location = new Point(53, 492);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(84, 82);
            btnLeft.TabIndex = 4;
            btnLeft.UseVisualStyleBackColor = true;
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
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(413, 680);
            Controls.Add(btnSelect);
            Controls.Add(btnLeft);
            Controls.Add(btnRight);
            Controls.Add(lblName);
            Controls.Add(picCard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenu";
            Text = "FormMenu";
            ((System.ComponentModel.ISupportInitialize)picCard).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picCard;
        private Label lblName;
        private Button btnRight;
        private Button btnLeft;
        private Button btnSelect;
    }
}