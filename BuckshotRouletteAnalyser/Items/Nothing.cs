using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuckshotRouletteAnalyser.Items
{
    public class Nothing : Item
    {
        public Nothing()
        {
            Name = "NOTHING";
            #pragma warning disable CS8602 // Dereference of a possibly null reference.
            string projectDirectory = Directory.GetParent(path: AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            #pragma warning restore CS8602 // Dereference of a possibly null reference.
            string imagePath = Path.Combine(projectDirectory, "Resources", "nothing.png");
            Image = Image.FromFile(imagePath);
        }
    }
}
