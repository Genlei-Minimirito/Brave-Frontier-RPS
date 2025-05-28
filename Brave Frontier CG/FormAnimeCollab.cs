using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brave_Frontier_CG
{
    public partial class FormAnimeCollab : Form
    {
        public FormAnimeCollab()
        {
            InitializeComponent();
            lblName.Text = Session.UserName;
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formhome = new FormMainMenu();
            formhome.StartPosition = FormStartPosition.Manual;
            formhome.Location = this.Location;
            formhome.ShowDialog();
        }

        private void picUnit_Click(object sender, EventArgs e)
        {

        }

        private void picTown_Click(object sender, EventArgs e)
        {

        }

        private void picShop_Click(object sender, EventArgs e)
        {

        }

        private void picSummon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formsumm = new FormSummon();
            formsumm.StartPosition = FormStartPosition.Manual;
            formsumm.Location = this.Location;
            formsumm.ShowDialog();
        }

        private void picArrowRight_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formsumm = new FormSummon();
            formsumm.StartPosition = FormStartPosition.Manual;
            formsumm.Location = this.Location;
            formsumm.ShowDialog();
        }

        private void pictArrowLeft_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formsumm = new FormSummon();
            formsumm.StartPosition = FormStartPosition.Manual;
            formsumm.Location = this.Location;
            formsumm.ShowDialog();
        }
    }
}
