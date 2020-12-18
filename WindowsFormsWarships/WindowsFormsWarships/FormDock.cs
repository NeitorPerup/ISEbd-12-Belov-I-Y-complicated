using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NLog;

namespace WindowsFormsWarships
{
    public partial class FormDock : Form
    {
        private readonly DockCollection dockCollection;

        private readonly Stack<Vehicle> shipStack;

        private readonly Logger logger;

        public FormDock()
        {
            InitializeComponent();
            dockCollection = new DockCollection(pictureBoxDock.Width, pictureBoxDock.Height);
            shipStack = new Stack<Vehicle>();
            logger = LogManager.GetCurrentClassLogger();
            Draw();
        }

        private void ReloadLevels()
        {
            int index = listBoxDock.SelectedIndex;
            listBoxDock.Items.Clear();
            for (int i = 0; i < dockCollection.Keys.Count; i++)
            {
                listBoxDock.Items.Add(dockCollection.Keys[i]);
            }
            if (listBoxDock.Items.Count > 0 && (index == -1 || index >=
            listBoxDock.Items.Count))
            {
                listBoxDock.SelectedIndex = 0;
            }
            else if (listBoxDock.Items.Count > 0 && index > -1 && index <
            listBoxDock.Items.Count)
            {
                listBoxDock.SelectedIndex = index;
            }
        }

        private void Draw()
        {
            if (listBoxDock.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxDock.Width, pictureBoxDock.Height);
                Graphics gr = Graphics.FromImage(bmp);
                dockCollection[listBoxDock.SelectedItem.ToString()].Draw(gr);
                pictureBoxDock.Image = bmp;
            }
        }

        private void buttonAddDock_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название дока", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dockCollection.AddDock(textBoxNewLevelName.Text);
            logger.Info($"Добавили док {textBoxNewLevelName.Text}");
            textBoxNewLevelName.Text = "";
            ReloadLevels();
        }

        private void buttonDelDock_Click(object sender, EventArgs e)
        {
            if (listBoxDock.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить док { listBoxDock.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dockCollection.DelDock(listBoxDock.Text);
                    logger.Info($"Удалили док{ listBoxDock.SelectedItem.ToString()}");
                    ReloadLevels();
                }
            }
        }

        private void buttonSetShip_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var ship = new Ship(100, 1000, dialog.Color);
                if (dockCollection[listBoxDock.SelectedItem.ToString()] + ship)
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
                    if (dockCollection[listBoxDock.SelectedItem.ToString()] + warship)
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
            if (listBoxDock.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                try
                {
                    var ship = dockCollection[listBoxDock.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                    if (ship != null)
                    {
                        logger.Info($"Изъят корабль {ship} с места { maskedTextBox.Text}");
                        shipStack.Push(ship);
                    }
                    Draw();
                }
                catch (DockNotFoundException ex)
                {
                    logger.Warn("Вызвана ошибка DockNotFoundException");
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Fatal("Вызвана неизвестная ошибка при удалении корабля");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void listBoxDock_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на док { listBoxDock.SelectedItem.ToString()}");
            Draw();
        }


        private void ButtonUndockingShips_Click(object sender, EventArgs e)
        {
            if (shipStack.Count() > 0)
            {
                FormWarship form = new FormWarship();
                form.SetShip(shipStack.Pop());
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Все корабли просмотрены");
            }
        }

        private void ButtonAddShip_Click(object sender, EventArgs e)
        {
            var formShipConfig = new FormShipConfig();
            formShipConfig.AddEvent(AddShip);
            formShipConfig.Show();
        }

        private void AddShip(Vehicle ship)
        {
            if (ship != null && listBoxDock.SelectedIndex > -1)
            {
                try
                {
                    if ((dockCollection[listBoxDock.SelectedItem.ToString()]) + ship)
                    {
                        Draw();
                        logger.Info($"Добавлен корабль {ship}");
                    }
                    else
                    {
                        MessageBox.Show("Корабль не удалось пришвартовать");
                    }
                    Draw();
                }
                catch (DockOverflowException ex)
                {
                    logger.Warn("Вызвано исключение переполнения дока");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Fatal("Вызвана неизвестная ошибка");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void СохранитьВсеДокиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dockCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    logger.Fatal("Вызвана неизвестная ошибка при сохранении");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ЗагрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dockCollection.LoadDockCollection(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (FileNotFoundException ex)
                {
                    logger.Error("Вызвана ошибка NullReferenceException");
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                catch (FormatException ex)
                {
                    logger.Error(ex.Message);
                    MessageBox.Show(ex.Message, "Ошибка при загрузке",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (NullReferenceException ex)
                {
                    logger.Error("Вызвана ошибка NullReferenceException");
                    MessageBox.Show(ex.Message, "Обращение к null объекту", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Fatal("Вызвана неизвестная ошибка при загрузке");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ТолькоВыбранныйToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dockCollection.SaveData(saveFileDialog.FileName, listBoxDock.SelectedItem.ToString());
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (FormatException ex)
                {
                    logger.Error(ex.Message);
                    MessageBox.Show(ex.Message, "Ошибка при загрузке",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Fatal("Вызвана неизвестная ошибка при сохранении");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ОдинДокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dockCollection.LoadDock(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (FileNotFoundException ex)
                {
                    logger.Error("Вызвана ошибка NullReferenceException");
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                catch (NullReferenceException ex)
                {
                    logger.Error("Вызвана ошибка NullReferenceException");
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                catch (FormatException ex)
                {
                    logger.Error(ex.Message);
                    MessageBox.Show(ex.Message, "Ошибка при загрузке",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Fatal("Вызвана неизвестная ошибка при загрузке");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
