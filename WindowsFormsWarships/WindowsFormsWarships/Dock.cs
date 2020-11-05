using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsWarships
{
    public class Dock<T, U> where T : class, ITransport where U : class, IDopElements
    {
        public readonly T[] _places;

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly int _placeSizeWidth = 240;

        private readonly int _placeSizeHeight = 80;

        public Dock(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }

        public static bool operator +(Dock<T, U> d, T ship)
        {
            for (int i = 0; i < d._places.Length; i++)
            {
                if (d._places[i] == null)
                {
                    ship.SetPosition(10 + d._placeSizeWidth * (int)(i / (int)(d.pictureHeight / d._placeSizeHeight)),
                        30 + d._placeSizeHeight * (int)(i % (int)(d.pictureHeight / d._placeSizeHeight)), d.pictureWidth, d.pictureHeight);
                    d._places[i] = ship;
                    return true;
                }
            }
            return false;
        }


        public static bool operator >(Dock<T, U> d, int ind)
        {
            return d.CompareHelper() > ind;
        }

        public static bool operator <(Dock<T, U> d, int ind)
        {
            return d.CompareHelper() < ind;
        }

        private int CompareHelper()
        {
            int cnt = 0;
            for (int i = 0; i < _places.Length; ++i)
            {
                if (_places[i] != null)
                {
                    cnt++;
                }
            }
            return cnt;
        }

        public static T operator -(Dock<T, U> d, int index)
        {
            if ((index < d._places.Length) && (index >= 0))
            {
                T ship = d._places[index];
                d._places[index] = null;
                return ship;
            }
            return null;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawTransport(g);
            }
        }

        public void SwapShip(int ind1, int ind2)
        {
            if (ind1 >= 0 && ind1 < _places.Length && ind2 >= 0 && ind2 < _places.Length)
            {
                var t = _places[ind1];
                _places[ind1] = _places[ind2];
                _places[ind2] = t;
                _places[ind1].SetPosition(10 + _placeSizeWidth * (int)(ind1 / (int)(pictureHeight / _placeSizeHeight)),
                        30 + _placeSizeHeight * (int)(ind1 % (int)(pictureHeight / _placeSizeHeight)), pictureWidth, pictureHeight);
                _places[ind2].SetPosition(10 + _placeSizeWidth * (int)(ind2 / (int)(pictureHeight / _placeSizeHeight)),
                        30 + _placeSizeHeight * (int)(ind2 % (int)(pictureHeight / _placeSizeHeight)), pictureWidth, pictureHeight);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                    _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
                (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}
