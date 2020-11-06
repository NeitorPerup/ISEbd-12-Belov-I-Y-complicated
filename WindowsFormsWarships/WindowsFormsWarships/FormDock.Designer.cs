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
            this.buttonDockShip = new System.Windows.Forms.Button();
            this.buttonDockWarship = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDock)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDock
            // 
            this.pictureBoxDock.Location = new System.Drawing.Point(-1, -2);
            this.pictureBoxDock.Name = "pictureBoxDock";
            this.pictureBoxDock.Size = new System.Drawing.Size(741, 450);
            this.pictureBoxDock.TabIndex = 0;
            this.pictureBoxDock.TabStop = false;
            // 
            // buttonDockShip
            // 
            this.buttonDockShip.Location = new System.Drawing.Point(747, 258);
            this.buttonDockShip.Name = "buttonDockShip";
            this.buttonDockShip.Size = new System.Drawing.Size(58, 53);
            this.buttonDockShip.TabIndex = 1;
            this.buttonDockShip.Text = "Корабль";
            this.buttonDockShip.UseVisualStyleBackColor = true;
            this.buttonDockShip.Click += new System.EventHandler(this.buttonSetShip_Click);
            // 
            // buttonDockWarship
            // 
            this.buttonDockWarship.Location = new System.Drawing.Point(811, 258);
            this.buttonDockWarship.Name = "buttonDockWarship";
            this.buttonDockWarship.Size = new System.Drawing.Size(63, 53);
            this.buttonDockWarship.TabIndex = 2;
            this.buttonDockWarship.Text = "Военный корабль";
            this.buttonDockWarship.UseVisualStyleBackColor = true;
            this.buttonDockWarship.Click += new System.EventHandler(this.buttonSetWarship_Click);
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
            // FormDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 483);
            this.Controls.Add(this.labelDockName);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.buttonAddDock);
            this.Controls.Add(this.buttonDelDock);
            this.Controls.Add(this.listBoxDock);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonDockWarship);
            this.Controls.Add(this.buttonDockShip);
            this.Controls.Add(this.pictureBoxDock);
            this.Name = "FormDock";
            this.Text = "FormDock";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDock)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDock;
        private System.Windows.Forms.Button buttonDockShip;
        private System.Windows.Forms.Button buttonDockWarship;
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
    }
}