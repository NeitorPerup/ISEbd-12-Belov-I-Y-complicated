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
        private Guns linkor;

        IDopElements window = new Window();

        public bool Tube { private set; get; }

        public Warship(int maxSpeed, float weight, Color mainColor, Color dopColor, Color gunColor,
            bool antenna, bool tube, int guns, int gunsForm, int windows) :
            base(maxSpeed, weight, mainColor, 100, 60)
        {
            DopColor = dopColor;
            Antenna = antenna;
            Tube = tube;
            linkor = new Guns(guns, gunsForm, gunColor);
            window.Number = windows;
        }

        public override void DrawTransport(Graphics g)
        {
            base.DrawTransport(g);
            window.DrawElements(g, _startPosX, _startPosY);
            linkor.DrawElements(g, _startPosX, _startPosY);
        }
    }

}
