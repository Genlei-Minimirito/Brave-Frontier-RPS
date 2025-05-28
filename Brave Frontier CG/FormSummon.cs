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
    public partial class FormSummon : Form
    {
        public FormSummon()
        {
            InitializeComponent();
            lblName.Text = Session.UserName;
        }

        private void picSummon5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!", "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void picSummon10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!", "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void picSocial_Click(object sender, EventArgs e)
        {

        }

        private void picArrowLeft_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formsumm = new FormAnimeCollab();
            formsumm.StartPosition = FormStartPosition.Manual;
            formsumm.Location = this.Location;
            formsumm.ShowDialog();
        }

        private void picArrowRight_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formsumm = new FormAnimeCollab();
            formsumm.StartPosition = FormStartPosition.Manual;
            formsumm.Location = this.Location;
            formsumm.ShowDialog();
        }
    }
}
