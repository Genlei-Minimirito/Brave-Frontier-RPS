using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
namespace Brave_Frontier_CG
{
    public partial class FormObtained : Form
    {
        SoundPlayer obtainSFX = new SoundPlayer(@"C:\BSCS 1B\BFCG\obtain sfx.wav");
        SoundPlayer MainMenuOST = new SoundPlayer(@"C:\BSCS 1B\BFCG\Summoner BF OST.wav");
        private readonly string _unitName;
        private readonly Image _unitImage;

        public FormObtained(string unitName, Image unitImage)
        {
            InitializeComponent();
            lblName.Text = Session.UserName;
            lblGems.Text = $"{GameState.Gems}";
            obtainSFX.Play();
            _unitName = unitName;
            _unitImage = unitImage;

            // Display them immediately
            picPortrait.Image = _unitImage;
            picPortrait.SizeMode = PictureBoxSizeMode.StretchImage;
            lblCharName.Text = _unitName;

            btnContinue.Click += BtnContinue_Click;
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {

        }

        public void btnContinue_Click_1(object sender, EventArgs e)
        {
            MainMenuOST.PlayLooping();

            GameState.AddStarter(new UnitInfo(_unitName, _unitImage));

            // 2) If FormCharacters is already open, refresh it:
            var charsForm = Application.OpenForms
                .OfType<FormCharacters>()
                .FirstOrDefault();
            if (charsForm != null)
            {
                // Call its public refresh method directly:
                charsForm.RefreshCollectionDisplay();
            }

            // 3) Close this FormObtained
            this.Close();
            this.Hide();
            Form formsumm = new FormAnimeCollab();
            formsumm.StartPosition = FormStartPosition.Manual;
            formsumm.Location = this.Location;
            formsumm.ShowDialog();
        }

        private void lblCharName_Click(object sender, EventArgs e)
        {

        }
    }
}
