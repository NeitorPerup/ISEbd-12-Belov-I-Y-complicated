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

        public Color DopColor { private set; get; }

        public bool Antenna { private set; get; }

        public bool DopBuilding { private set; get; }

        public int Guns { private set; get; }

        public string GunsForm { private set; get; }

        public void SetDopColor(Color color)
        {
            DopColor = color;
            SetGun();
        }

        public void SetGun(IDopElements guns)
        {
            gun = guns;
            GunsForm = gun.GetType().Name;
        }

        public void SetGunNumber(int gunNumber)
        {
            Guns = gunNumber;
        }

        private void SetGun()
        {
            if (GunsForm == "TrapezeGunForm")
            {
                gun = new TrapezeGunForm(Guns, DopColor);
            }
            else if (GunsForm == "TriangleGunForm")
            {
                gun = new TriangleGunForm(Guns, DopColor);
            }
            else if (GunsForm == "RectangleGunForm")
            {
                gun = new RectangleGunForm(Guns, DopColor);
            }
        }

        public Warship(int maxSpeed, float weight, Color mainColor, Color dopColor, 
            bool antenna, bool dopBuilding, int guns, string gunsForm) :
            base(maxSpeed, weight, mainColor, 100, 60)
        {
            DopColor = dopColor;
            Antenna = antenna;
            DopBuilding = dopBuilding;
            GunsForm = gunsForm;
            Guns = guns;
            SetGun();
        }

        public Warship(int maxSpeed, float weight, Color mainColor, Color dopColor) :
            base(maxSpeed, weight, mainColor, 100, 60)
        {
            DopColor = dopColor;
        }

        public Warship(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 8)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Antenna = Convert.ToBoolean(strs[4]);                
                DopBuilding = Convert.ToBoolean(strs[5]);
                Guns = Convert.ToInt32(strs[6]);
                GunsForm = strs[7];
                SetGun();
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}{Antenna}{separator}{DopBuilding}{separator}{Guns}" +
                   $"{separator}{GunsForm}";
        }

        public override void DrawTransport(Graphics g)
        {
            base.DrawTransport(g);
            if (gun != null)
            {
                gun.DrawElements(g, _startPosX, _startPosY);
            }
            Brush brDopColor = new SolidBrush(DopColor);

            if (DopBuilding)
            {
                g.FillRectangle(brDopColor, _startPosX + 70, _startPosY, 15, 7);
            }

            if (Antenna)
            {
                g.FillRectangle(brDopColor, _startPosX + 81, _startPosY - 15, 2, 20);
            }
        }
    }
}
