﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsWarships
{
    public partial class FormShipConfig : Form
    {
        Vehicle ship = null;

        private event Action<Vehicle> eventActionAddShip;

        public FormShipConfig()
        {
            InitializeComponent();

            panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            panelFuchsia.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawShip()
        {
            if (ship != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
                Graphics gr = Graphics.FromImage(bmp);
                ship.SetPosition(5, 25, pictureBoxShip.Width, pictureBoxShip.Height);
                ship.DrawTransport(gr);
                pictureBoxShip.Image = bmp;
            }
        }

        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventActionAddShip == null)
            {
                eventActionAddShip = new Action<Vehicle>(ev);
            }
            else
            {
                eventActionAddShip += ev;
            }
        }

        private void LabelShip_MouseDown(object sender, MouseEventArgs e)
        {
            labelShip.DoDragDrop(labelShip.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void LabelWarship_MouseDown(object sender, MouseEventArgs e)
        {
            labelWarship.DoDragDrop(labelWarship.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void PanelShip_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычный":
                    ship = new Ship((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "Военный":
                    ship = new Warship((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value,
                        Color.White, Color.Black, checkBoxAntenna.Checked, checkBoxDopBuilding.Checked, 2, "TrapezeGunForm");
                    break;
            }
            DrawShip();
        }

        private void PanelShip_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            ((Panel)sender).DoDragDrop(((Panel)sender).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            ship.SetMainColor((Color)e.Data.GetData(typeof(Color)));
            DrawShip();
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship is Warship)
            {
                (ship as Warship).SetDopColor((Color)(e.Data.GetData(typeof(Color))));
                DrawShip();
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventActionAddShip.Invoke(ship);
            Close();
        }

        private void LabelChangeGuns_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TrapezeGunForm)) || e.Data.GetDataPresent(typeof(TriangleGunForm))
                || e.Data.GetDataPresent(typeof(RectangleGunForm)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void LabelChangeGuns_DragDrop(object sender, DragEventArgs e)
        {
            if (ship is Warship w)
            {
                if (e.Data.GetData(typeof(TrapezeGunForm)) != null)
                {
                    w.SetGun((TrapezeGunForm)e.Data.GetData(typeof(TrapezeGunForm)));
                }
                else if (e.Data.GetData(typeof(TriangleGunForm)) != null)
                {
                    w.SetGun((TriangleGunForm)e.Data.GetData(typeof(TriangleGunForm)));
                }
                else if (e.Data.GetData(typeof(RectangleGunForm)) != null)
                {
                    w.SetGun((RectangleGunForm)e.Data.GetData(typeof(RectangleGunForm)));
                }
                DrawShip();
            }
        }

        private void LabelGunForm_MouseDown(object sender, MouseEventArgs e)
        {
            IDopElements gun = null;
            if (ship is Warship w)
            {
                switch (((Label)sender).Text)
                {
                    case "Трапеция":
                        gun = new TrapezeGunForm(w.Guns, w.DopColor);
                        break;
                    case "Треугольник":
                        gun = new TriangleGunForm(w.Guns, w.DopColor);
                        break;
                    case "Квадрат":
                        gun = new RectangleGunForm(w.Guns, w.DopColor);
                        break;
                }
                if (gun != null)
                {
                    ((Label)sender).DoDragDrop(gun, DragDropEffects.Move | DragDropEffects.Copy);
                }
            }

        }

        private void LabelNumberGuns_MouseDown(object sender, MouseEventArgs e)
        {
            if (ship is Warship w)
            {
                IDopElements gun = null;
                int gunsNumber = Convert.ToInt32(((Label)sender).Text);
                switch (w.GunsForm)
                {
                    case "TrapezeGunForm":
                        gun = new TrapezeGunForm(gunsNumber, w.DopColor);
                        break;
                    case "TriangleGunForm":
                        gun = new TriangleGunForm(gunsNumber, w.DopColor);
                        break;
                    case "RectangleGunForm":
                        gun = new RectangleGunForm(gunsNumber, w.DopColor);
                        break;
                }
                if (gun != null)
                {
                    ((Label)sender).DoDragDrop(gun, DragDropEffects.Move | DragDropEffects.Copy);
                    w.SetGunNumber(gunsNumber);
                }
            }
        }
    }
}

