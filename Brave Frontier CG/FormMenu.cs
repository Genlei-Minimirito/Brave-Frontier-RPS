using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Brave_Frontier_CG
{
    public partial class FormMenu : Form
    {
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

            // Populate with your resource images (replace with your actual resource names)
            _cards = new List<CardInfo>
            {
                new CardInfo("Vargas", Properties.Resources.VARGAS),
                new CardInfo("Selena",    Properties.Resources.SELENA),
                new CardInfo("Lance",  Properties.Resources.LANCE),
                new CardInfo("Eze",  Properties.Resources.EZE),
                new CardInfo("Magress",  Properties.Resources.MAGRESS),
                new CardInfo("Atro",  Properties.Resources.ATRO),

            };

            // Wire up navigation and selection
            btnLeft.Click += BtnLeft_Click;
            btnRight.Click += BtnRight_Click;
            btnSelect.Click += BtnSelect_Click;

            // Initial display
            UpdateCardDisplay();
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            _currentIndex = (_currentIndex - 1 + _cards.Count) % _cards.Count;
            UpdateCardDisplay();
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            _currentIndex = (_currentIndex + 1) % _cards.Count;
            UpdateCardDisplay();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            var starter = SelectedCard;
            var battlefield = new FormBattleField(starter.Image, starter.Name);
            battlefield.Show();
            this.Hide();
        }


        private void UpdateCardDisplay()
        {
            var card = _cards[_currentIndex];
            picCard.Image = card.Image;
            picCard.SizeMode = PictureBoxSizeMode.StretchImage;
            lblName.Text = card.Name;

        }
        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void picCard_Click(object sender, EventArgs e)
        {

        }
    }
}
