using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Brave_Frontier_CG
{
    public partial class FormSelect : Form
    {
        // We’ll hold references to all 25 PictureBoxes in this list, in the order you want them to fill.
        private readonly List<PictureBox> _slots;

        public FormSelect()
        {
            InitializeComponent();
            lblName.Text = Session.UserName;
            lblGems.Text = $"{GameState.Gems}";
            


            // 1) Build the list of all 25 PictureBoxes (in the exact order you want them to fill).
            _slots = new List<PictureBox>
            {
                pictureBox1,  pictureBox2,  pictureBox3,  pictureBox4,  pictureBox5,
                pictureBox6,  pictureBox7,  pictureBox8,  pictureBox9,  
               
            };

            // 2) Ensure all slots start empty (no image, no click handler)
            foreach (var pb in _slots)
            {
                pb.Image = null;
                pb.Tag = null;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Click -= Slot_Click; // just in case the Designer wired something
            }

            // 3) Populate them based on what the player has already collected
            PopulateSlots();
        }

        private void FormSelect_Load(object sender, EventArgs e)
        {
            // In case GameState.CollectedStarters changed while this form was hidden,
            // refresh the slots each time the form loads.
            PopulateSlots();
        }

        /// <summary>
        /// Reads GameState.CollectedStarters (List<UnitInfo>) and fills up to 25 pictureboxes.
        /// If there are N collected units, they fill pictureBox1..pictureBoxN. Empty slots remain blank.
        /// Each non‐empty PictureBox also gets its Tag set to the unit’s name and its Click handler wired.
        /// </summary>
        private void PopulateSlots()
        {
            // 1) Clear all 25 slots
            foreach (var pb in _slots)
            {
                pb.Image = null;
                pb.Tag = null;
                pb.Click -= Slot_Click;
            }

            // 2) Fill each slot with a collected unit (up to 25 total)
            int i = 0;
            foreach (var unit in GameState.CollectedStarters)
            {
                if (i >= _slots.Count) break; // don’t exceed 25

                var box = _slots[i];
                box.Image = unit.Image;   // show the unit’s portrait
                box.Tag = unit.Name;      // store the unit’s “logical” name
                box.Click += Slot_Click;  // only clickable if it has an image

                i++;
            }
        }

        /// <summary>
        /// Fires when the player clicks on any PictureBox that has a non-null Image.
        /// We read the clicked box’s Tag (the unit’s name) and Image, then open FormBattleField.
        /// </summary>
        private void Slot_Click(object sender, EventArgs e)
        {
            var clicked = sender as PictureBox;
            if (clicked == null) return;        // should never happen unless mis‐wired
            if (clicked.Image == null) return;  // skip clicks on empty slots

            // 1) Grab the unit’s name from Tag
            string unitName = clicked.Tag as string ?? "";

            // 2) Grab the clicked portrait image
            Image clickedImage = clicked.Image;

            // 3) Open the battlefield with that unit’s Image + Name
            var battlefield = new FormBattleField(clickedImage, unitName);
            battlefield.Show();

            // 4) Hide this selection form
            this.Hide();
        }
    }
}
