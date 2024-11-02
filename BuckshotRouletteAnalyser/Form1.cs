using System.Windows.Forms;
using System.IO;
using System.Linq;
using BuckshotRouletteAnalyser.Resources;
using BuckshotRouletteAnalyser.Extensions;
using BuckshotRouletteAnalyser.Items;
namespace BuckshotRouletteAnalyser
{
    public partial class MainForm : Form
    {
        private static Random random = new Random();

        int currentLiveBulletsIndex = 1;
        int currentBlankBulletsIndex = 1;
        int selectedItemSlot = -1;

        bool isItemSlotSelected = false;

        List<ItemSlot> itemSlots = new List<ItemSlot>();
        List<Item> allItems = new List<Item>();
        private Dictionary<Type, int> itemTypeToIndexMap = new Dictionary<Type, int>();

        private ItemComboBox itemComboBox;

        public MainForm()
        {
            InitializeComponent();

            itemComboBox = new ItemComboBox
            {
                Dock = DockStyle.Fill,
                ItemHeight = 50
            };
            itemComboBox.SelectedIndexChanged += itemComboBox_SelectedIndexChanged;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            int liveBullets = currentLiveBulletsIndex + 1;
            int blankBullets = currentBlankBulletsIndex + 1;

            if (liveBullets > blankBullets)
            {
                double probability = ((double)liveBullets / (liveBullets + blankBullets)) * 100;
                MessageBox.Show($"You should shoot the Dealer.\n\nThe probability of success: {probability:F2}%");
            }
            else if (blankBullets > liveBullets)
            {
                if (blankBullets == liveBullets + 1)
                {
                    MessageBox.Show("You should shoot yourself once.\nAfter that, the odds are 50/50.");
                }
                else
                {
                    var diff = blankBullets - liveBullets;
                    MessageBox.Show($"You should shoot yourself {diff} times.\nAfter that, the odds are 50/50.");
                }
            }
            else
            {
                MessageBox.Show("The odds are 50/50 - shoot either yourself or the dealer.");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // default ComboBox values
            LiveBulletsComboBox.SelectedIndex = 1;
            BlankBulletsComboBox.SelectedIndex = 1;
            YourHealthComboBox.SelectedIndex = 1;
            DealersHealthComboBox.SelectedIndex = 1;

            // Putting image from relative path to PictureBox
            #pragma warning disable CS8602 // Dereference of a possibly null reference.
            string projectDirectory = Directory.GetParent(path: AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            #pragma warning restore CS8602 // Dereference of a possibly null reference.
            string imagePath = Path.Combine(projectDirectory, "Resources", "table_resized_fulldim.png");
            MainPictureBox.Image = Image.FromFile(imagePath);

            // Assigning item slots to their x-y coordinates

            // bottom-left 2x2 rectangle
            itemSlots.Add(new ItemSlot(1, 71, 194, 250, 160, 476, 476, 340, 340));
            itemSlots.Add(new ItemSlot(2, 194, 309, 340, 250, 476, 476, 340, 340));
            itemSlots.Add(new ItemSlot(3, 250, 340, 360, 285, 340, 340, 259, 259));
            itemSlots.Add(new ItemSlot(4, 160, 250, 285, 212, 340, 340, 259, 259));

            // bottom-right 2x2 rectangle
            itemSlots.Add(new ItemSlot(5, 563, 680, 623, 533, 473, 473, 340, 340));
            itemSlots.Add(new ItemSlot(6, 680, 800, 717, 623, 473, 473, 340, 340));
            itemSlots.Add(new ItemSlot(7, 623, 717, 665, 590, 340, 340, 259, 259));
            itemSlots.Add(new ItemSlot(8, 533, 623, 665, 517, 340, 340, 259, 259));

            // top-left 2x2 rectangle
            itemSlots.Add(new ItemSlot(9, 240, 305, 324, 267, 215, 215, 172, 172));
            itemSlots.Add(new ItemSlot(10, 305, 369, 378, 324, 215, 215, 172, 172));
            itemSlots.Add(new ItemSlot(11, 324, 378, 387, 339, 172, 172, 135, 135));
            itemSlots.Add(new ItemSlot(12, 267, 324, 339, 289, 172, 172, 135, 135));

            // top-right 2x2 rectangle
            itemSlots.Add(new ItemSlot(13, 507, 570, 553, 498, 215, 215, 172, 172));
            itemSlots.Add(new ItemSlot(14, 570, 636, 608, 553, 215, 215, 172, 172));
            itemSlots.Add(new ItemSlot(15, 553, 608, 588, 539, 172, 172, 135, 135));
            itemSlots.Add(new ItemSlot(16, 498, 553, 539, 491, 172, 172, 135, 135));

            //TestRectangleDetection(0);

            /*for (int i = 0; i < 16; i++)
            {
                TestRectangleDetection(i);
            }*/

            // loading all items to the general item list
            allItems.Add(new Nothing());
            allItems.Add(new Adrenaline());
            allItems.Add(new Beer());
            allItems.Add(new BurnerPhone());
            allItems.Add(new Cigarettes());
            allItems.Add(new ExpiredMedicine());
            allItems.Add(new Handcuffs());
            allItems.Add(new Handsaw());
            allItems.Add(new Inverter());
            allItems.Add(new MagnifyingGlass());

            for(int i = 0; i < allItems.Count; i++)
            {
                itemTypeToIndexMap.Add(allItems[i].GetType(), i);
            }

            //itemComboBox.Items.Add(new Adrenaline("ADRENALINE"));
            itemComboBox.Items.AddRange(allItems.ToArray());
            ItemsLayoutPanel.Controls.Add(itemComboBox, 0, 1);

            itemComboBox.Enabled = false;
        }

        private void LiveBulletsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LiveBulletsComboBox.SelectedIndex + currentBlankBulletsIndex + 2 > 8)
            {
                MessageBox.Show("There cannot be more than 8 shells in the chamber.");
                LiveBulletsComboBox.SelectedIndex = currentLiveBulletsIndex;
            }
            else
            {
                currentLiveBulletsIndex = LiveBulletsComboBox.SelectedIndex;
            }

        }

        private void BlankBulletsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BlankBulletsComboBox.SelectedIndex + currentLiveBulletsIndex + 2 > 8)
            {
                MessageBox.Show("There cannot be more than 8 shells in the chamber.");
                BlankBulletsComboBox.SelectedIndex = currentBlankBulletsIndex;
            }
            else
            {
                currentBlankBulletsIndex = BlankBulletsComboBox.SelectedIndex;
            }
        }

        private void YourHealthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DealersHealthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(itemComboBox.SelectedIndex != -1 && selectedItemSlot != -1)
            {
                itemSlots[selectedItemSlot].Item = allItems[itemComboBox.SelectedIndex];
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset the table?", "Reset the table", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                LiveBulletsComboBox.SelectedIndex = 1;
                BlankBulletsComboBox.SelectedIndex = 1;
                YourHealthComboBox.SelectedIndex = 1;
                DealersHealthComboBox.SelectedIndex = 1;
            }
        }

        private void MainPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = e.X;
                int y = e.Y;
                // MessageBox.Show($"You clicked at coordinates: ({x}, {y})", "Click Coordinates");

                Point clickPoint = new Point(e.X, e.Y);
                bool found = false;

                foreach (var (slot, index) in itemSlots.WithIndex())
                {
                    // Divide the rectangle into two triangles (Corners[0], Corners[1], Corners[2]) and (Corners[0], Corners[2], Corners[3])
                    if (IsPointInTriangle(clickPoint, slot.Corners[0], slot.Corners[1], slot.Corners[2]) ||
                        IsPointInTriangle(clickPoint, slot.Corners[0], slot.Corners[2], slot.Corners[3]))
                    {
                        //MessageBox.Show($"You clicked on rectangle {slot.Id}.");
                        ItemLabel.Text = $"Select item for slot nr {slot.Id}:";
                        selectedItemSlot = index;
                        found = true;
                        itemComboBox.Enabled = true;
                        isItemSlotSelected = true;
                        if(itemTypeToIndexMap.TryGetValue(slot.Item.GetType(), out int idx))
                        {
                            itemComboBox.SelectedIndex = idx;
                        }

                        break;
                    }
                }

                if (!found)
                {
                    //MessageBox.Show("Didn't press any rectangle");
                    ItemLabel.Text = "";
                    itemComboBox.SelectedIndex = -1;
                    isItemSlotSelected = false;
                    selectedItemSlot = -1;
                    itemComboBox.Enabled = false;
                }
            }
        }
        #region Helper Functions
        private bool IsPointInTriangle(Point p, Point p0, Point p1, Point p2)
        {
            var s = (p0.X - p2.X) * (p.Y - p2.Y) - (p0.Y - p2.Y) * (p.X - p2.X);
            var t = (p1.X - p0.X) * (p.Y - p0.Y) - (p1.Y - p0.Y) * (p.X - p0.X);

            if ((s < 0) != (t < 0) && s != 0 && t != 0)
                return false;

            var d = (p2.X - p1.X) * (p.Y - p1.Y) - (p2.Y - p1.Y) * (p.X - p1.X);
            return d == 0 || (d < 0) == (s + t <= 0);
        }
        #endregion

        #region Tests
        private void TestRectangleDetection(int itemSlotIndex)
        {
            // Load the image from the PictureBox
            Bitmap originalBitmap = new Bitmap(MainPictureBox.Image);
            Bitmap testBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);

            // Copy the original image to the test image so we can modify it
            using (Graphics g = Graphics.FromImage(testBitmap))
            {
                g.DrawImage(originalBitmap, 0, 0);
            }

            // Define the rectangle area (update this with your actual rectangle coordinates)
            ItemSlot testRectangle = itemSlots[itemSlotIndex];
            Point[] corners = testRectangle.Corners;

            // select a random color for a given rectangle
            int red = random.Next(0, 256); // Random value for red (0-255)
            int green = random.Next(0, 256); // Random value for green (0-255)
            int blue = random.Next(0, 256); // Random value for blue (0-255)

            // Iterate through each pixel in the image
            for (int y = 0; y < testBitmap.Height; y++)
            {
                for (int x = 0; x < testBitmap.Width; x++)
                {
                    Point currentPoint = new Point(x, y);

                    // Check if the point is within the rectangle
                    if (IsPointInTriangle(currentPoint, corners[0], corners[1], corners[2]) ||
                        IsPointInTriangle(currentPoint, corners[0], corners[2], corners[3]))
                    {
                        // Color the pixel red with 50% opacity
                        Color originalColor = testBitmap.GetPixel(x, y);
                        Color redOverlay = Color.FromArgb(128, red, green, blue); // 50% opacity red
                        Color blendedColor = BlendColors(originalColor, redOverlay);

                        testBitmap.SetPixel(x, y, blendedColor);
                    }
                }
            }

            // Display the modified image in the PictureBox
            MainPictureBox.Image = testBitmap;
        }

        // Blends two colors by applying the overlay color with specified opacity
        private Color BlendColors(Color baseColor, Color overlayColor)
        {
            int r = (overlayColor.R * overlayColor.A / 255) + (baseColor.R * (255 - overlayColor.A) / 255);
            int g = (overlayColor.G * overlayColor.A / 255) + (baseColor.G * (255 - overlayColor.A) / 255);
            int b = (overlayColor.B * overlayColor.A / 255) + (baseColor.B * (255 - overlayColor.A) / 255);

            return Color.FromArgb(baseColor.A, r, g, b);
        }
        #endregion
    }
}
