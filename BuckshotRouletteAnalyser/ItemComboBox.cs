using BuckshotRouletteAnalyser.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuckshotRouletteAnalyser
{
    // Custom ComboBox for displaying items with icons and names
    public class ItemComboBox : ComboBox
    {
        public ItemComboBox()
        {
            // Set the combo box to owner-drawn mode
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);

            // Prevent drawing if no item is selected or if index is out of bounds
            if (e.Index < 0 || e.Index >= Items.Count) return;

            // Retrieve the current item (of type Item)
            Item item = Items[e.Index] as Item;
            if (item == null) return;

            // Set up colors for drawing
            e.DrawBackground();
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            RectangleF textRect;
            using (Font font = new Font("Bauhaus 93", 18))
            {
                textRect = new RectangleF(
                e.Bounds.X + 5, // Left alignment with padding
                e.Bounds.Y + (e.Bounds.Height - font.Height) / 2 + 5, // Centered vertically
                e.Bounds.Width, // Width of the text area
                font.Height // Height of the text area
                );
            }

            // Draw item name
            using (Font font = new Font("Bauhaus 93", 17))
            using (Brush textBrush = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString(
                    item.Name,
                    font,
                    textBrush,
                    textRect,
                    StringFormat.GenericDefault
                );
            }

            // Draw item image icon aligned to the right
            if (item.Image != null)
            {
                int iconSize = 40; // Set the desired icon size
                Rectangle iconRect = new Rectangle(
                    e.Bounds.Right - iconSize - 5,
                    e.Bounds.Y + (e.Bounds.Height - iconSize) / 2,
                    iconSize,
                    iconSize
                );
                e.Graphics.DrawImage(item.Image, iconRect);
            }

            e.DrawFocusRectangle();
        }
    }
}
