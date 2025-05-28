using System.Media;
using System;

namespace Brave_Frontier_CG
{
    public partial class Form1 : Form
    { SoundPlayer sound = new SoundPlayer(@"C:\Users\Lei\source\repos\Brave Frontier CG\Brave Frontier CG\bin\Debug\BF Title Screen BGM.wav");

        SoundPlayer touch = new SoundPlayer(@"C:\BSCS 1B\BFCG\touch sfx.wav");
        public Form1()
        {
            InitializeComponent();
            sound.PlayLooping();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTouch_Click(object sender, EventArgs e)
        {
            

           
            touch.Play();
           
           
            this.Hide();
            FormSplash formSplash = new FormSplash();
            formSplash.StartPosition = FormStartPosition.Manual;
            formSplash.Location = this.Location;
            formSplash.ShowDialog();
           
        }
    }
}
