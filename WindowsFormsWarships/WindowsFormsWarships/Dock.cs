using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using NLog;

namespace WindowsFormsWarships
{
    public class Dock<T, U> where T : class, ITransport where U : class, IDopElements
    {
        public readonly List<T> _places;

        private readonly int _maxCount;

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly int _placeSizeWidth = 240;

        private readonly int _placeSizeHeight = 80;

        private readonly Logger logger = LogManager.GetCurrentClassLogger();

        public Dock(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
        }

        public static bool operator +(Dock<T, U> d, T ship)
        {
            if (d._places.Count >= d._maxCount)
            {
                d.logger.Warn("Вызвано исключение DockOverflowException");
                throw new DockOverflowException();
            }
            d._places.Add(ship);
            return true;
        }

        public static T operator -(Dock<T, U> d, int index)
        {
            if (index <= -1 || index >= d._places.Count)
            {
                d.logger.Warn("Вызвано исключение DockNotFoundException");
                throw new DockNotFoundException(index);
            }
            T ship = d._places[index];
            d._places.RemoveAt(index);
            return ship;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; i++)
            {
                _places[i].SetPosition(5 + i / 5 * _placeSizeWidth + 5, i % 5 *
                    _placeSizeHeight + 25, pictureWidth, pictureHeight);
                _places[i]?.DrawTransport(g);
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

        public T this[int ind]
        {
            get
            {
                if (ind >= 0 && ind < _places.Count)
                {
                    return _places[ind];
                }
                return null;
            }
        }

        public void ClearPlaces()
        {
            _places.Clear();
        }
    }
}
