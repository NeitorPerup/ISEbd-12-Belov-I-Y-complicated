using System.Drawing;

namespace WindowsFormsWarships
{
    class Guns : IDopElements
    {
        //private GunsNumber gunsEnum;

        private EnumElements enumElements;

        public int Number { set => enumElements = (EnumElements)value; }

        public Color DopColor { private set; get; }

        public int GunForm { private set; get; }

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

        public Guns(int gun, int gunForm, Color dopColor)
        {
            Number = gun;
            DopColor = dopColor;
            GunForm = gunForm;
        }

        private void DrawTwoGuns(Graphics g, float _startPosX, float _startPosY)
        {
            Brush brDopColor = new SolidBrush(DopColor);

            if (GunForm == 0) // первая обычная форма
            {               
                PointF[] cannon1Points = { new PointF(_startPosX + 180, _startPosY + 5), new PointF(_startPosX + 185, _startPosY - 7),
                                           new PointF(_startPosX + 200, _startPosY - 7), new PointF(_startPosX + 205, _startPosY + 5) };
                g.FillPolygon(brDopColor, cannon1Points);
                g.FillRectangle(brDopColor, _startPosX + 195, _startPosY - 4, 20, 4);

                PointF[] cannon2Points = { new PointF(_startPosX + 45, _startPosY + 5), new PointF(_startPosX + 40, _startPosY - 7),
                                           new PointF(_startPosX + 30, _startPosY - 7), new PointF(_startPosX + 25, _startPosY + 5) };
                g.FillPolygon(brDopColor, cannon2Points);
                g.FillRectangle(brDopColor, _startPosX + 9, _startPosY - 4, 20, 4);
            }
            else if (GunForm == 1)
            {
                PointF[] cannon1Points = { new PointF(_startPosX + 180, _startPosY + 5), new PointF(_startPosX + 193, _startPosY - 8),
                                           new PointF(_startPosX + 205, _startPosY + 5) };
                g.FillPolygon(brDopColor, cannon1Points);
                g.FillRectangle(brDopColor, _startPosX + 195, _startPosY - 4, 20, 4);

                PointF[] cannon2Points = { new PointF(_startPosX + 45, _startPosY + 5), new PointF(_startPosX + 35, _startPosY - 8),
                                           new PointF(_startPosX + 25, _startPosY + 5) };
                g.FillPolygon(brDopColor, cannon2Points);
                g.FillRectangle(brDopColor, _startPosX + 13, _startPosY - 4, 20, 4);
            }
        }

        private void DrawFourGuns(Graphics g, float _startPosX, float _startPosY)
        {
            Brush brDopColor = new SolidBrush(DopColor);
            DrawTwoGuns(g, _startPosX, _startPosY);

            if (GunForm == 0)
            {
                PointF[] cannon1Points = { new PointF(_startPosX + 155, _startPosY + 5), new PointF(_startPosX + 160, _startPosY - 15),
                                           new PointF(_startPosX + 175, _startPosY - 15), new PointF(_startPosX + 180, _startPosY + 5) };
                g.FillPolygon(brDopColor, cannon1Points);
                g.FillRectangle(brDopColor, _startPosX + 170, _startPosY - 12, 27, 3);

                PointF[] cannon2Points = { new PointF(_startPosX + 68, _startPosY + 5), new PointF(_startPosX + 63, _startPosY - 15),
                                           new PointF(_startPosX + 53, _startPosY - 15), new PointF(_startPosX + 48, _startPosY + 5) };
                g.FillPolygon(brDopColor, cannon2Points);
                g.FillRectangle(brDopColor, _startPosX + 29, _startPosY - 12, 24, 3);
            }
            else if (GunForm == 1)
            {
                PointF[] cannon1Points = { new PointF(_startPosX + 155, _startPosY + 5), new PointF(_startPosX + 168, _startPosY - 18),
                                           new PointF(_startPosX + 180, _startPosY + 5) };
                g.FillPolygon(brDopColor, cannon1Points);
                g.FillRectangle(brDopColor, _startPosX + 167, _startPosY - 12, 27, 4);

                PointF[] cannon2Points = { new PointF(_startPosX + 68, _startPosY + 5), new PointF(_startPosX + 58, _startPosY - 18),
                                           new PointF(_startPosX + 48, _startPosY + 5) };
                g.FillPolygon(brDopColor, cannon2Points);
                g.FillRectangle(brDopColor, _startPosX + 33, _startPosY - 12, 24, 4);
            }
        }

        private void DrawSixGuns(Graphics g, float _startPosX, float _startPosY)
        {
            Brush brDopColor = new SolidBrush(DopColor);
            DrawFourGuns(g, _startPosX, _startPosY);

            if (GunForm == 0)
            {
                g.FillRectangle(brDopColor, _startPosX + 195, _startPosY + 20, 23, 5);
                g.FillRectangle(brDopColor, _startPosX + 185, _startPosY + 15, 10, 15);

                g.FillRectangle(brDopColor, _startPosX + 2, _startPosY + 20, 25, 5);
                g.FillRectangle(brDopColor, _startPosX + 25, _startPosY + 15, 10, 15);
            }
            else if (GunForm == 1)
            {
                g.FillRectangle(brDopColor, _startPosX + 195, _startPosY + 20, 23, 5);
                g.FillEllipse(brDopColor, _startPosX + 183, _startPosY + 13, 12, 17);

                g.FillRectangle(brDopColor, _startPosX + 2, _startPosY + 20, 25, 5);
                g.FillEllipse(brDopColor, _startPosX + 23, _startPosY + 13, 12, 17);
            }
        }
    }
}
