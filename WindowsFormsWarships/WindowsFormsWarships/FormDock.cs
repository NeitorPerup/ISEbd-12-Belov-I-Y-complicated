using System;
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
    public partial class FormDock : Form
    {
        private readonly Dock<Ship, TrapezeGunForm> dock;

        public FormDock()
        {
            InitializeComponent();
            dock = new Dock<Ship, TrapezeGunForm>(pictureBoxDock.Width,
                pictureBoxDock.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxDock.Width, pictureBoxDock.Height);
            Graphics gr = Graphics.FromImage(bmp);
            dock.Draw(gr);
            pictureBoxDock.Image = bmp;
        }

        private void buttonSetShip_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var ship = new Ship(100, 1000, dialog.Color);
                if (dock + ship)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не пришвартовано =)");
                }
            }
        }

        private void buttonSetWarship_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var warship = new Warship(100, 1000, dialog.Color, dialogDop.Color);
                    if (dock + warship)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Не пришвартовано =)");
                    }
                }
            }
        }

        private void buttonUndock_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var ship = dock - Convert.ToInt32(maskedTextBox.Text);
                if (ship != null)
                {
                    FormWarship form = new FormWarship();
                    form.SetShip(ship);
                    form.ShowDialog();
                }
                maskedTextBox.Text = "";
                Draw();
            }
        }

        private void ButtonSortWarship_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dock._places.Length - 1; ++i)
            {
                for (int j = 0; j < dock._places.Length - 1; ++j)
                {
                    if (dock < j)
                    {
                        dock.SwapShip(j, j + 1);
                    }
                }
            }
            Draw();
        }

        private void ButtonSortShip_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dock._places.Length - 1; ++i)
            {
                for (int j = 0; j < dock._places.Length - 1; ++j)
                {
                    if (dock > j)
                    {
                        dock.SwapShip(j, j + 1);
                    }
                }
            }
            Draw();
        }

        private void ButtonMore_Click(object sender, EventArgs e)
        {
            int ind;
            if (Compare.Text != "")
            {
                ind = Convert.ToInt32(Compare.Text);
            }
            else { return; }
            if (checkBoxMore.Checked)
            {
                if (dock > ind)
                {
                    MessageBox.Show("Парковка заполнена более, чем на " + ind + " мест(а)");
                }
                else
                {
                    MessageBox.Show("Парковка заполнена не более, чем на " + ind + " мест(а)");
                }
            }

            else if (checkBoxLess.Checked)
            {
                if (dock < ind)
                {
                    MessageBox.Show("Парковка заполнена менее, чем на " + ind + " мест(а)");
                }
                else
                {
                    MessageBox.Show("Парковка заполнена не менее, чем на " + ind + " мест(а)");
                }
            }
        }
    }
}
