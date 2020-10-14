using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsWarships
{
    class TriangleGunForm : IDopElements
    {
        private EnumElements enumElements;

        public int Number { set => enumElements = (EnumElements)value; }

        public Color DopColor { private set; get; }

        public TriangleGunForm(int gun, Color dopColor)
        {
            Number = gun;
            DopColor = dopColor;
        }

        public void DrawElements(Graphics g, float _startPosX, float _startPosY)
        {
            switch (enumElements)
            {
                case EnumElements.Two:
                    DrawTwoGuns(g, _startPosX, _startPosY);
                    break;

                case EnumElements.Four:
                    DrawFourGuns(g, _startPosX, _startPosY);
                    break;

                case EnumElements.Six:
                    DrawSixGuns(g, _startPosX, _startPosY);
                    break;
            }
        }
        private void DrawTwoGuns(Graphics g, float _startPosX, float _startPosY)
        {
            Brush brDopColor = new SolidBrush(DopColor);

            PointF[] cannon1Points = { new PointF(_startPosX + 180, _startPosY + 5), new PointF(_startPosX + 193, _startPosY - 8),
                                           new PointF(_startPosX + 205, _startPosY + 5) };
            g.FillPolygon(brDopColor, cannon1Points);
            g.FillRectangle(brDopColor, _startPosX + 195, _startPosY - 4, 20, 4);

            PointF[] cannon2Points = { new PointF(_startPosX + 45, _startPosY + 5), new PointF(_startPosX + 35, _startPosY - 8),
                                           new PointF(_startPosX + 25, _startPosY + 5) };
            g.FillPolygon(brDopColor, cannon2Points);
            g.FillRectangle(brDopColor, _startPosX + 13, _startPosY - 4, 20, 4);
        }

        private void DrawFourGuns(Graphics g, float _startPosX, float _startPosY)
        {
            DrawTwoGuns(g, _startPosX, _startPosY);
            Brush brDopColor = new SolidBrush(DopColor);
            PointF[] cannon1Points = { new PointF(_startPosX + 155, _startPosY + 5), new PointF(_startPosX + 168, _startPosY - 18),
                                           new PointF(_startPosX + 180, _startPosY + 5) };
            g.FillPolygon(brDopColor, cannon1Points);
            g.FillRectangle(brDopColor, _startPosX + 167, _startPosY - 12, 27, 4);

            PointF[] cannon2Points = { new PointF(_startPosX + 68, _startPosY + 5), new PointF(_startPosX + 58, _startPosY - 18),
                                           new PointF(_startPosX + 48, _startPosY + 5) };
            g.FillPolygon(brDopColor, cannon2Points);
            g.FillRectangle(brDopColor, _startPosX + 33, _startPosY - 12, 24, 4);
        }

        private void DrawSixGuns(Graphics g, float _startPosX, float _startPosY)
        {
            DrawFourGuns(g, _startPosX, _startPosY);
            Brush brDopColor = new SolidBrush(DopColor);
            
            g.FillRectangle(brDopColor, _startPosX + 195, _startPosY + 20, 23, 5);
            g.FillEllipse(brDopColor, _startPosX + 183, _startPosY + 13, 12, 17);

            g.FillRectangle(brDopColor, _startPosX + 2, _startPosY + 20, 25, 5);
            g.FillEllipse(brDopColor, _startPosX + 23, _startPosY + 13, 12, 17);
        }
    }
}
