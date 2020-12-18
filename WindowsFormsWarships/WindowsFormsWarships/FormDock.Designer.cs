namespace WindowsFormsWarships
{
    partial class FormDock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxDock = new System.Windows.Forms.PictureBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonUndockingShips = new System.Windows.Forms.Button();
            this.ButtonUndock = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label = new System.Windows.Forms.Label();
            this.listBoxDock = new System.Windows.Forms.ListBox();
            this.buttonDelDock = new System.Windows.Forms.Button();
            this.buttonAddDock = new System.Windows.Forms.Button();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.labelDockName = new System.Windows.Forms.Label();
            this.buttonAddShip = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеДокиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.толькоВыбранныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеДокиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.одинДокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDock)).BeginInit();
            this.groupBox.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDock
            // 
            this.pictureBoxDock.Location = new System.Drawing.Point(4, 26);
            this.pictureBoxDock.Name = "pictureBoxDock";
            this.pictureBoxDock.Size = new System.Drawing.Size(736, 422);
            this.pictureBoxDock.TabIndex = 0;
            this.pictureBoxDock.TabStop = false;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonUndockingShips);
            this.groupBox.Controls.Add(this.ButtonUndock);
            this.groupBox.Controls.Add(this.maskedTextBox);
            this.groupBox.Controls.Add(this.label);
            this.groupBox.Location = new System.Drawing.Point(759, 317);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(99, 128);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Отшвартовать корабль";
            // 
            // buttonUndockingShips
            // 
            this.buttonUndockingShips.Location = new System.Drawing.Point(6, 98);
            this.buttonUndockingShips.Name = "buttonUndockingShips";
            this.buttonUndockingShips.Size = new System.Drawing.Size(93, 23);
            this.buttonUndockingShips.TabIndex = 3;
            this.buttonUndockingShips.Text = "Просмотреть";
            this.buttonUndockingShips.UseVisualStyleBackColor = true;
            this.buttonUndockingShips.Click += new System.EventHandler(this.ButtonUndockingShips_Click);
            // 
            // ButtonUndock
            // 
            this.ButtonUndock.Location = new System.Drawing.Point(6, 71);
            this.ButtonUndock.Name = "ButtonUndock";
            this.ButtonUndock.Size = new System.Drawing.Size(93, 23);
            this.ButtonUndock.TabIndex = 2;
            this.ButtonUndock.Text = "Отшвартовать";
            this.ButtonUndock.UseVisualStyleBackColor = true;
            this.ButtonUndock.Click += new System.EventHandler(this.buttonUndock_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(53, 39);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(40, 20);
            this.maskedTextBox.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(7, 39);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(39, 13);
            this.label.TabIndex = 0;
            this.label.Text = "Место";
            // 
            // listBoxDock
            // 
            this.listBoxDock.FormattingEnabled = true;
            this.listBoxDock.Location = new System.Drawing.Point(747, 103);
            this.listBoxDock.Name = "listBoxDock";
            this.listBoxDock.Size = new System.Drawing.Size(120, 95);
            this.listBoxDock.TabIndex = 4;
            this.listBoxDock.Click += new System.EventHandler(this.listBoxDock_SelectedIndexChanged);
            // 
            // buttonDelDock
            // 
            this.buttonDelDock.Location = new System.Drawing.Point(747, 204);
            this.buttonDelDock.Name = "buttonDelDock";
            this.buttonDelDock.Size = new System.Drawing.Size(120, 23);
            this.buttonDelDock.TabIndex = 5;
            this.buttonDelDock.Text = "Удалить док";
            this.buttonDelDock.UseVisualStyleBackColor = true;
            this.buttonDelDock.Click += new System.EventHandler(this.buttonDelDock_Click);
            // 
            // buttonAddDock
            // 
            this.buttonAddDock.Location = new System.Drawing.Point(747, 74);
            this.buttonAddDock.Name = "buttonAddDock";
            this.buttonAddDock.Size = new System.Drawing.Size(120, 23);
            this.buttonAddDock.TabIndex = 6;
            this.buttonAddDock.Text = "Добавить док";
            this.buttonAddDock.UseVisualStyleBackColor = true;
            this.buttonAddDock.Click += new System.EventHandler(this.buttonAddDock_Click);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(747, 42);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(120, 20);
            this.textBoxNewLevelName.TabIndex = 7;
            // 
            // labelDockName
            // 
            this.labelDockName.AutoSize = true;
            this.labelDockName.Location = new System.Drawing.Point(786, 26);
            this.labelDockName.Name = "labelDockName";
            this.labelDockName.Size = new System.Drawing.Size(34, 13);
            this.labelDockName.TabIndex = 8;
            this.labelDockName.Text = "Доки";
            // 
            // buttonAddShip
            // 
            this.buttonAddShip.Location = new System.Drawing.Point(759, 271);
            this.buttonAddShip.Name = "buttonAddShip";
            this.buttonAddShip.Size = new System.Drawing.Size(99, 40);
            this.buttonAddShip.TabIndex = 9;
            this.buttonAddShip.Text = "Добавить корабль";
            this.buttonAddShip.UseVisualStyleBackColor = true;
            this.buttonAddShip.Click += new System.EventHandler(this.ButtonAddShip_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(880, 24);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.всеДокиToolStripMenuItem,
            this.толькоВыбранныйToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // всеДокиToolStripMenuItem
            // 
            this.всеДокиToolStripMenuItem.Name = "всеДокиToolStripMenuItem";
            this.всеДокиToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.всеДокиToolStripMenuItem.Text = "Все доки";
            this.всеДокиToolStripMenuItem.Click += new System.EventHandler(this.СохранитьВсеДокиToolStripMenuItem_Click);
            // 
            // толькоВыбранныйToolStripMenuItem
            // 
            this.толькоВыбранныйToolStripMenuItem.Name = "толькоВыбранныйToolStripMenuItem";
            this.толькоВыбранныйToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.толькоВыбранныйToolStripMenuItem.Text = "Только выбранный";
            this.толькоВыбранныйToolStripMenuItem.Click += new System.EventHandler(this.ТолькоВыбранныйToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.всеДокиToolStripMenuItem1,
            this.одинДокToolStripMenuItem});
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // всеДокиToolStripMenuItem1
            // 
            this.всеДокиToolStripMenuItem1.Name = "всеДокиToolStripMenuItem1";
            this.всеДокиToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.всеДокиToolStripMenuItem1.Text = "Все доки";
            this.всеДокиToolStripMenuItem1.Click += new System.EventHandler(this.ЗагрузитьToolStripMenuItem_Click);
            // 
            // одинДокToolStripMenuItem
            // 
            this.одинДокToolStripMenuItem.Name = "одинДокToolStripMenuItem";
            this.одинДокToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.одинДокToolStripMenuItem.Text = "Один док";
            this.одинДокToolStripMenuItem.Click += new System.EventHandler(this.ОдинДокToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(759, 242);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(99, 23);
            this.buttonSort.TabIndex = 11;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // FormDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 483);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonAddShip);
            this.Controls.Add(this.labelDockName);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.buttonAddDock);
            this.Controls.Add(this.buttonDelDock);
            this.Controls.Add(this.listBoxDock);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.pictureBoxDock);
            this.Controls.Add(this.menuStrip);
            this.Name = "FormDock";
            this.Text = "FormDock";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDock)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDock;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button ButtonUndock;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ListBox listBoxDock;
        private System.Windows.Forms.Button buttonDelDock;
        private System.Windows.Forms.Button buttonAddDock;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Label labelDockName;
        private System.Windows.Forms.Button buttonUndockingShips;
        private System.Windows.Forms.Button buttonAddShip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem всеДокиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem толькоВыбранныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеДокиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem одинДокToolStripMenuItem;
        private System.Windows.Forms.Button buttonSort;
    }
}