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
    public partial class FormWarship : Form
    {
        private Ship ship;
        
        public FormWarship()
        {
            InitializeComponent();
            comboBoxGuns.Items.AddRange(new string[] { "2 Guns", "4 Guns", "6 Guns" });
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics gr = Graphics.FromImage(bmp);
            ship.DrawTransport(gr);
            pictureBox.Image = bmp;
        }

        private void buttonCreateShip_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ship = new Ship(rnd.Next(100, 200), rnd.Next(1000, 2000), Color.Blue,
            Color.Green, Color.Blue, true, true);
            ship.SetPosition(rnd.Next(50, 120), rnd.Next(50, 120), pictureBox.Width,
            pictureBox.Height);
            Draw();
        }
        private void buttonCreateWarship_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ship = new Warship(rnd.Next(100, 200), rnd.Next(1000, 2000), Color.Blue, Color.Green,
            Color.Red, true, true, (comboBoxGuns.SelectedIndex + 1) * 2, FormOfGun(), WindowForm());
            ship.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBox.Width, pictureBox.Height);

            buttonSecondForm.Enabled = true;
            buttonFirstForm.Enabled = true;
            buttonThirdForm.Enabled = true;

            Draw();
        }

        private void buttonGunsForm_Click(object sender, EventArgs e)
        {
            if (sender == buttonFirstForm)
            {
                buttonSecondForm.Enabled = false;
                buttonThirdForm.Enabled = false;
            }
            else if (sender == buttonSecondForm)
            {
                buttonFirstForm.Enabled = false;
                buttonThirdForm.Enabled = false;
            }
            else
            {
                buttonFirstForm.Enabled = false;
                buttonSecondForm.Enabled = false;
            }
        }

        private int FormOfGun()
        {
            if (buttonFirstForm.Enabled == true) { 
                return 0; 
            }
            else if (buttonSecondForm.Enabled == true) { 
                return 1; 
            }
            else
            {
                return 2;
            }
        }

        private int WindowForm()
        {
            int result = -1;
            if (checkBoxNone.Checked)
            {
                if (checkBoxEllipse.Checked || checkBoxRectangle.Checked)
                {
                    MessageBox.Show("Выберите только один тип окон");
                }
                else { result = 0; }
            }

            else if (checkBoxEllipse.Checked)
            {
                if (checkBoxNone.Checked || checkBoxRectangle.Checked)
                {
                    MessageBox.Show("Выберите только один тип окон");
                }
                else { result = 1; }
            }

            else if (checkBoxRectangle.Checked)
            {
                if (checkBoxEllipse.Checked || checkBoxNone.Checked)
                {
                    MessageBox.Show("Выберите только один тип окон");
                }
                else { result = 2; }
            }

            return result;
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    ship.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    ship.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    ship.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    ship.MoveTransport(Direction.Right);
                    break;
            }

            Draw();
        }
    }
}