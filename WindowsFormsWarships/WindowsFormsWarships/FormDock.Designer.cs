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
            this.ButtonUndock = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label = new System.Windows.Forms.Label();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.checkBoxMore = new System.Windows.Forms.CheckBox();
            this.checkBoxLess = new System.Windows.Forms.CheckBox();
            this.Compare = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDock)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDock
            // 
            this.pictureBoxDock.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDock.Name = "pictureBoxDock";
            this.pictureBoxDock.Size = new System.Drawing.Size(725, 539);
            this.pictureBoxDock.TabIndex = 0;
            this.pictureBoxDock.TabStop = false;
            // 
            // buttonDockShip
            // 
            this.buttonDockShip.Location = new System.Drawing.Point(731, 31);
            this.buttonDockShip.Name = "buttonDockShip";
            this.buttonDockShip.Size = new System.Drawing.Size(99, 53);
            this.buttonDockShip.TabIndex = 1;
            this.buttonDockShip.Text = "Пришвартовать корабль";
            this.buttonDockShip.UseVisualStyleBackColor = true;
            this.buttonDockShip.Click += new System.EventHandler(this.buttonSetShip_Click);
            // 
            // buttonDockWarship
            // 
            this.buttonDockWarship.Location = new System.Drawing.Point(731, 111);
            this.buttonDockWarship.Name = "buttonDockWarship";
            this.buttonDockWarship.Size = new System.Drawing.Size(99, 56);
            this.buttonDockWarship.TabIndex = 2;
            this.buttonDockWarship.Text = "Пришвартовать военный корабль";
            this.buttonDockWarship.UseVisualStyleBackColor = true;
            this.buttonDockWarship.Click += new System.EventHandler(this.buttonSetWarship_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.ButtonUndock);
            this.groupBox.Controls.Add(this.maskedTextBox);
            this.groupBox.Controls.Add(this.label);
            this.groupBox.Location = new System.Drawing.Point(731, 191);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(99, 104);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Отшвартовать корабль";
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
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(731, 483);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(89, 44);
            this.buttonCompare.TabIndex = 8;
            this.buttonCompare.Text = "Сравнить";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.ButtonMore_Click);
            // 
            // checkBoxMore
            // 
            this.checkBoxMore.Location = new System.Drawing.Point(731, 380);
            this.checkBoxMore.Name = "checkBoxMore";
            this.checkBoxMore.Size = new System.Drawing.Size(104, 52);
            this.checkBoxMore.TabIndex = 9;
            this.checkBoxMore.Text = "Больше";
            this.checkBoxMore.UseVisualStyleBackColor = true;
            // 
            // checkBoxLess
            // 
            this.checkBoxLess.AutoSize = true;
            this.checkBoxLess.Location = new System.Drawing.Point(731, 438);
            this.checkBoxLess.Name = "checkBoxLess";
            this.checkBoxLess.Size = new System.Drawing.Size(67, 17);
            this.checkBoxLess.TabIndex = 10;
            this.checkBoxLess.Text = "Меньше";
            this.checkBoxLess.UseVisualStyleBackColor = true;
            // 
            // Compare
            // 
            this.Compare.Location = new System.Drawing.Point(731, 461);
            this.Compare.Name = "Compare";
            this.Compare.Size = new System.Drawing.Size(100, 20);
            this.Compare.TabIndex = 11;
            // 
            // FormDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 539);
            this.Controls.Add(this.Compare);
            this.Controls.Add(this.checkBoxLess);
            this.Controls.Add(this.checkBoxMore);
            this.Controls.Add(this.buttonCompare);
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
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.CheckBox checkBoxMore;
        private System.Windows.Forms.CheckBox checkBoxLess;
        private System.Windows.Forms.MaskedTextBox Compare;
    }
}