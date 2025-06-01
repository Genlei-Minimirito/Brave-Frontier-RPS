using System;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace Brave_Frontier_CG
{
    public partial class FormMenu : Form
    {
        SoundPlayer touch = new SoundPlayer(@"C:\BSCS 1B\BFCG\touch sfx.wav");
        // Holds the name and image of each starter card
        public class CardInfo
        {
            public string Name { get; }
            public Image Image { get; }

            public CardInfo(string name, Image image)
            {
                Name = name;
                Image = image;
            }
        }

        private readonly List<CardInfo> _cards;
        private int _currentIndex;

        // Expose the selected card
        public CardInfo SelectedCard => _cards[_currentIndex];

        public FormMenu()
        {
            InitializeComponent();

            // Populate with your starter images
            _cards = new List<CardInfo>
            {
                new CardInfo("Vargas",   Properties.Resources.VARGAS),
                new CardInfo("Selena",   Properties.Resources.SELENA),
                new CardInfo("Lance",    Properties.Resources.LANCE),
                new CardInfo("Eze",      Properties.Resources.EZE),
                new CardInfo("Magress",  Properties.Resources.MAGRESS),
                new CardInfo("Atro",     Properties.Resources.ATRO),
            };

            // Wire up navigation and selection
            picLeft.Click += picLeft_Click;
            picRIght.Click += BtnRight_Click;
            btnSelect.Click += BtnSelect_Click;

            // Initial display
            UpdateCardDisplay();
        }

        private void picLeft_Click(object sender, EventArgs e)
        {
            touch.Play();
            _currentIndex = (_currentIndex - 1 + _cards.Count) % _cards.Count;
            UpdateCardDisplay();
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            touch.Play();
            _currentIndex = (_currentIndex + 1) % _cards.Count;
            UpdateCardDisplay();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            touch.Play();
            // 1) Grab the currently highlighted card
            var starter = SelectedCard;  // has Name + Image

            // 2) Add it to GameState.CollectedStarters as a UnitInfo
           GameState.AddStarter(new UnitInfo(starter.Name, starter.Image));

            // 3) Launch FormBattleField with the chosen name + image
            var battlefield = new FormBattleField(starter.Image, starter.Name);
            battlefield.Show();

            // 4) Hide this menu
            this.Hide();
        }

        private void UpdateCardDisplay()
        {
            var card = _cards[_currentIndex];
            picCard.Image = card.Image;
            picCard.SizeMode = PictureBoxSizeMode.StretchImage;
            lblName.Text = card.Name;
        }

        private void FormMenu_Load(object sender, EventArgs e) { }

        private void picCard_Click(object sender, EventArgs e) { }




    }
}
