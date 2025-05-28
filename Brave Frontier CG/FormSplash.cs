using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Brave_Frontier_CG
{

    public partial class FormSplash : Form
    {
        SoundPlayer touch = new SoundPlayer(@"C:\BSCS 1B\BFCG\touch sfx.wav");
        public FormSplash()
        {
            InitializeComponent();
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {

            tmrSplash.Enabled = true;
            prgBarLoading.Width += 2;
            if (prgBarLoading.Width >= 599)
            {
                this.Hide();
                tmrSplash.Stop();
                Form form = new FormLogIn();
                form.StartPosition = FormStartPosition.Manual;
                form.Location = this.Location;
                form.Show();

            }
        }

        private void prgBarLoading_Click(object sender, EventArgs e)
        {

        }

        private void btnTouch_Click(object sender, EventArgs e)
        {
            touch.Play();
        }
    }
}
