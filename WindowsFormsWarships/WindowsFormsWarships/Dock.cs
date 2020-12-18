using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace WindowsFormsWarships
{
    public class Dock<T, U> : IEnumerator<T>, IEnumerable<T> 
        where T : class, ITransport where U : class, IDopElements
    {
        private readonly List<T> _places;

        private readonly int _maxCount;

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly int _placeSizeWidth = 240;

        private readonly int _placeSizeHeight = 80;

        private int _currentIndex;

        public T Current => _places[_currentIndex];

        object IEnumerator.Current => _places[_currentIndex];

        public Dock(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
            _currentIndex = -1;
    }

        public static bool operator +(Dock<T, U> d, T ship)
        {
            if (d._places.Count >= d._maxCount)
            {
                throw new DockOverflowException();
            }
            if (d._places.Contains(ship))
            {
                throw new DockAlreadyHaveException();
            }
            d._places.Add(ship);
            return true;
        }

        public static T operator -(Dock<T, U> d, int index)
        {
            if (index <= -1 || index >= d._places.Count)
            {
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

        public void Sort() => _places.Sort((IComparer<T>)new ShipComparer());

        public void Dispose() { }

        public bool MoveNext()
        {
            _currentIndex++;
            return _currentIndex < _places.Count;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}
