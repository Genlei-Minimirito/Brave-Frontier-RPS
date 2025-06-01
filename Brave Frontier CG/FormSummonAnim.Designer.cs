namespace Brave_Frontier_CG
{
    partial class FormSummonAnim
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
            picSummonAnimation = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picSummonAnimation).BeginInit();
            SuspendLayout();
            // 
            // picSummonAnimation
            // 
            picSummonAnimation.Image = Properties.Resources.SUMMON_ANIMATION;
            picSummonAnimation.Location = new Point(-2, 4);
            picSummonAnimation.Name = "picSummonAnimation";
            picSummonAnimation.Size = new Size(415, 678);
            picSummonAnimation.SizeMode = PictureBoxSizeMode.StretchImage;
            picSummonAnimation.TabIndex = 0;
            picSummonAnimation.TabStop = false;
            
            // 
            // FormSummonAnim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(413, 680);
            Controls.Add(picSummonAnimation);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSummonAnim";
            Text = "FormSummonAnim";
            ((System.ComponentModel.ISupportInitialize)picSummonAnimation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picSummonAnimation;
    }
}