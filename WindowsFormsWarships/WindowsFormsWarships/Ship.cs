using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static System.Collections.IEnumerable;

namespace WindowsFormsWarships
{
    public class Ship : Vehicle
    {
        protected readonly int shipWidth = 90;

        protected readonly int shipHeight = 50;

        protected readonly char separator = ';';

        public Ship(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        protected Ship(int maxSpeed, float weight, Color mainColor, int shipWidth, int shipHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.shipWidth = shipWidth;
            this.shipHeight = shipHeight;
        }

        public Ship(string info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - WarshipWidth)
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

        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            g.DrawLine(pen, _startPosX, _startPosY + 15, _startPosX + 40, _startPosY + 35);
            g.DrawLine(pen, _startPosX + 40, _startPosY + 35, _startPosX + 190, _startPosY + 35);
            g.DrawLine(pen, _startPosX + 190, _startPosY + 35, _startPosX + 210, _startPosY + 15);
            g.DrawLine(pen, _startPosX + 210, _startPosY + 15, _startPosX, _startPosY + 15);

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

            PointF[] expansionPoints = { new PointF(_startPosX + 110, _startPosY), new PointF(_startPosX + 100, _startPosY),
                                        new PointF(_startPosX + 100, _startPosY + 7), new PointF(_startPosX + 110, _startPosY + 7)};
            g.FillPolygon(brMainColor, expansionPoints);

            PointF[] annexPoints = { new PointF(_startPosX + 135, _startPosY - 6), new PointF(_startPosX + 155, _startPosY - 6),
                                         new PointF(_startPosX + 155, _startPosY + 5), new PointF(_startPosX + 135, _startPosY + 5)};
            g.FillPolygon(brMainColor, annexPoints);

            PointF[] tubePoints = {new PointF(_startPosX + 115, _startPosY + 5), new PointF(_startPosX + 108, _startPosY - 12),
                             new PointF(_startPosX + 126, _startPosY - 18), new PointF(_startPosX + 133, _startPosY + 5) };
            g.FillPolygon(brMainColor, tubePoints);
        }
    }
}