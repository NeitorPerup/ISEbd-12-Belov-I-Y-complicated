using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static System.Collections.IEnumerable;

namespace WindowsFormsWarships
{
    class Warship
    {
        private Linkor linkor;

        private float _startPosX; // левая координата отрисовки

        private float _startPosY; // верхняя координата отрисовки

        private int _pictureWidth; // ширина окна отрисовки

        private int _pictureHeight; // высота окна отрисовки

        private readonly int WarshiprWidth = 220;

        private readonly int WarshipHeightDown = 31;

        private readonly int WarshipHeightUp = 15;

        public int MaxSpeed { private set; get; }

        public float Weight { private set; get; }

        public Color MainColor { private set; get; }

        public Color DopColor { private set; get; }

        public bool Addition { private set; get; }

        public bool Antenna { private set; get; }

        public Warship(int maxSpeed, float weight, Color mainColor, Color dopColor, Color cannonColor, bool addition, bool antenna, int guns)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Addition = addition;
            Antenna = antenna;
            linkor = new Linkor(guns, cannonColor);
        }

        // установка позиции линкора
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - WarshiprWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step - WarshipHeightUp > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - WarshipHeightDown)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            // рисуем зелёную область
            g.DrawLine(pen, _startPosX, _startPosY + 15, _startPosX + 40, _startPosY + 35);
            g.DrawLine(pen, _startPosX + 40, _startPosY + 35, _startPosX + 190, _startPosY + 35);
            g.DrawLine(pen, _startPosX + 190, _startPosY + 35, _startPosX + 210, _startPosY + 15);
            g.DrawLine(pen, _startPosX + 210, _startPosY + 15, _startPosX, _startPosY + 15);
            // закрашиваем зелёную область
            Brush brMainColor = new SolidBrush(MainColor);
            PointF p1 = new PointF(_startPosX, _startPosY + 15);
            PointF p2 = new PointF(_startPosX + 40, _startPosY + 35);
            PointF p3 = new PointF(_startPosX + 190, _startPosY + 35);
            PointF p4 = new PointF(_startPosX + 210, _startPosY + 15);
            PointF[] points = { p1, p2, p3, p4 };
            g.FillPolygon(brMainColor, points);

            // рисуем серую часть корабля
            g.DrawLine(pen, _startPosX, _startPosY + 15, _startPosX + 10, _startPosY + 5);
            g.DrawLine(pen, _startPosX + 10, _startPosY + 5, _startPosX + 218, _startPosY + 5);
            g.DrawLine(pen, _startPosX + 218, _startPosY + 5, _startPosX + 210, _startPosY + 15);
            // закрашиваем
            Brush brGray = new SolidBrush(Color.Gray);
            PointF grp1 = new PointF(_startPosX, _startPosY + 15);
            PointF grp2 = new PointF(_startPosX + 10, _startPosY + 5);
            PointF grp3 = new PointF(_startPosX + 218, _startPosY + 5);
            PointF grp4 = new PointF(_startPosX + 210, _startPosY + 15);
            PointF[] grPoints = { grp1, grp2, grp3, grp4 };
            g.FillPolygon(brGray, grPoints);

            // теперь рисуем всякие приколюхи(труба + что-то рядом с ней)

            Brush brDopColor = new SolidBrush(DopColor);
            PointF[] tubePoints = {new PointF(_startPosX + 115, _startPosY + 5), new PointF(_startPosX + 108, _startPosY - 12),
                             new PointF(_startPosX + 126, _startPosY - 18), new PointF(_startPosX + 133, _startPosY + 5) };
            g.FillPolygon(brDopColor, tubePoints);

            if (Addition)
            {
                PointF[] expansionPoints = { new PointF(_startPosX + 110, _startPosY), new PointF(_startPosX + 100, _startPosY),
                                         new PointF(_startPosX + 100, _startPosY + 7), new PointF(_startPosX + 110, _startPosY + 7)};
                g.FillPolygon(brDopColor, expansionPoints);

                PointF[] annexPoints = { new PointF(_startPosX + 135, _startPosY - 6), new PointF(_startPosX + 155, _startPosY - 6),
                                         new PointF(_startPosX + 155, _startPosY + 5), new PointF(_startPosX + 135, _startPosY + 5)};
                g.FillPolygon(brDopColor, annexPoints);
            }
            if (Antenna)
            {
                g.FillRectangle(brDopColor, _startPosX + 70, _startPosY, 15, 7);
                g.FillRectangle(brDopColor, _startPosX + 81, _startPosY - 15, 2 , 15);
            }
            linkor.Draw(g, _startPosX, _startPosY);
        }
    }
}