using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Brave_Frontier_CG
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {   

            InitializeComponent();
            lblName.Text = Session.UserName;
            picQuest.SizeMode = PictureBoxSizeMode.StretchImage;
        }

       
        private void FormMainMenu_Load(object sender, EventArgs e)
        {
          
        }

        private void btnQuest_Click(object sender, EventArgs e)
        {

        }

        private void picQuest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form battlefield = new FormMenu();
            battlefield.StartPosition = FormStartPosition.Manual;
            battlefield.Location = this.Location;
            battlefield.ShowDialog();


        }

        private void picHome_Click(object sender, EventArgs e)
        {
            
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblGems_Click(object sender, EventArgs e)
        {

        }
    }
}
