using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsWarships
{
    public class Warship : Ship
    {
        private IDopElements gun;

        public Warship(int maxSpeed, float weight, Color mainColor, Color dopColor, Color gunColor,
            int guns, int gunsForm) :
            base(maxSpeed, weight, mainColor, 100, 60)
        {
            DopColor = dopColor;

            if (gunsForm == 0)
            {
                gun = new TrapezeGunForm(guns, gunColor);
            }
            else if (gunsForm == 1)
            {
                gun = new TriangleGunForm(guns, gunColor);
            }
            else if (gunsForm == 2)
            {
                gun = new RectangleGunForm(guns, gunColor);
            }
        }

        public override void DrawTransport(Graphics g)
        {
            base.DrawTransport(g);
            gun.DrawElements(g, _startPosX, _startPosY);
        }
    }
}
