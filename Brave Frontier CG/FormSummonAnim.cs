using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Brave_Frontier_CG
{
    public partial class FormSummonAnim : Form
    {
        SoundPlayer summonSFX = new SoundPlayer(@"C:\BSCS 1B\BFCG\summon sfx.wav");
        public FormSummonAnim()
        {
            InitializeComponent();
            summonSFX.Play();
        }

        private void picSummonAnimation_Click(object sender, EventArgs e)
        {

        }
    }
}
