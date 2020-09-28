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
        private Warship warship;
        
        public FormWarship()
        {
            InitializeComponent();
            comboBoxGuns.Items.AddRange(new string[] { "2 Guns", "4 Guns", "6 Guns" });
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxWarship.Width, pictureBoxWarship.Height);
            Graphics gr = Graphics.FromImage(bmp);
            warship.DrawTransport(gr);
            pictureBoxWarship.Image = bmp;
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            warship = new Warship(rnd.Next(100, 200), rnd.Next(1000, 2000), Color.Green,
            Color.Black, Color.Blue, true, true, ((comboBoxGuns.SelectedIndex + 1) * 2));
            warship.SetPosition(rnd.Next(50, 120), rnd.Next(50, 120), pictureBoxWarship.Width,
            pictureBoxWarship.Height);
            Draw();
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    warship.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    warship.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    warship.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    warship.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}