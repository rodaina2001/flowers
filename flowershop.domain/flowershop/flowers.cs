using flowershop.domain.flowershop;
using System.Drawing;
using System.Xml.Linq;

namespace flowershop.domain.flowershop
{
    public class flowers
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

        public List<customer> customer { get; set; }

    }

}