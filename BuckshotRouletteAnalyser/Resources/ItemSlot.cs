using BuckshotRouletteAnalyser.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuckshotRouletteAnalyser.Resources
{
    public class ItemSlot
    {
        public int Id { get; set; }
        public Point[] Corners { get; set; }
        public Item Item { get; set; }

        public ItemSlot(int id, int x1, int x2, int x3, int x4, int y1, int y2, int y3, int y4)
        {
            Id = id;

            Corners = new Point[4];
            Corners[0] = new Point(x1, y1);
            Corners[1] = new Point(x2, y2);
            Corners[2] = new Point(x3, y3);
            Corners[3] = new Point(x4, y4);

            Item = new Nothing("NOTHING");
        }
    }
}
