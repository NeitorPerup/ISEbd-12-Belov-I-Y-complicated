using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsWarships
{
    public class ShipComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is Warship && y is Warship)
            {
                return ComparerWarship((Warship)x, (Warship)y);
            }
            if (x is Warship && y is Ship)
            {
                return -1;
            }
            if (x is Ship && y is Warship)
            {
                return 1;
            }
            if (x is Ship && y is Ship)
            {
                return ComparerShip((Ship)x, (Ship)y);
            }
            return 0;
        }

        private int ComparerShip(Ship x, Ship y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerWarship(Warship x, Warship y)
        {
            var res = ComparerShip(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Antenna != y.Antenna)
            {
                return x.Antenna.CompareTo(y.Antenna);
            }
            if (x.Guns != y.Guns)
            {
                return x.Guns.CompareTo(y.Guns);
            }
            if (x.GunsForm != y.GunsForm)
            {
                return x.Guns.CompareTo(y.Guns);
            }
            if (x.DopBuilding != y.DopBuilding)
            {
                return x.DopBuilding.CompareTo(y.DopBuilding);
            }
            return 0;
        }
    }
}
