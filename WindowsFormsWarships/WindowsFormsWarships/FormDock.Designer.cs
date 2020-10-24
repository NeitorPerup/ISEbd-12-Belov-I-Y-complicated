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
            this.groupBoxSort = new System.Windows.Forms.GroupBox();
            this.buttonSortShip = new System.Windows.Forms.Button();
            this.buttonSortWarship = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDock)).BeginInit();
            this.groupBox.SuspendLayout();
            this.groupBoxSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDock
            // 
            this.pictureBoxDock.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDock.Name = "pictureBoxDock";
            this.pictureBoxDock.Size = new System.Drawing.Size(725, 450);
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
            // groupBoxSort
            // 
            this.groupBoxSort.Controls.Add(this.buttonSortShip);
            this.groupBoxSort.Controls.Add(this.buttonSortWarship);
            this.groupBoxSort.Location = new System.Drawing.Point(731, 312);
            this.groupBoxSort.Name = "groupBoxSort";
            this.groupBoxSort.Size = new System.Drawing.Size(99, 126);
            this.groupBoxSort.TabIndex = 4;
            this.groupBoxSort.TabStop = false;
            this.groupBoxSort.Text = "Отсортировать док";
            // 
            // buttonSortShip
            // 
            this.buttonSortShip.Location = new System.Drawing.Point(6, 85);
            this.buttonSortShip.Name = "buttonSortShip";
            this.buttonSortShip.Size = new System.Drawing.Size(83, 35);
            this.buttonSortShip.TabIndex = 1;
            this.buttonSortShip.Text = "Сначала обычные";
            this.buttonSortShip.UseVisualStyleBackColor = true;
            this.buttonSortShip.Click += new System.EventHandler(this.ButtonSortShip_Click);
            // 
            // buttonSortWarship
            // 
            this.buttonSortWarship.Location = new System.Drawing.Point(7, 36);
            this.buttonSortWarship.Name = "buttonSortWarship";
            this.buttonSortWarship.Size = new System.Drawing.Size(75, 43);
            this.buttonSortWarship.TabIndex = 0;
            this.buttonSortWarship.Text = "Сначала военные";
            this.buttonSortWarship.UseVisualStyleBackColor = true;
            this.buttonSortWarship.Click += new System.EventHandler(this.ButtonSortWarship_Click);
            // 
            // FormDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.groupBoxSort);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonDockWarship);
            this.Controls.Add(this.buttonDockShip);
            this.Controls.Add(this.pictureBoxDock);
            this.Name = "FormDock";
            this.Text = "FormDock";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDock)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBoxSort.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDock;
        private System.Windows.Forms.Button buttonDockShip;
        private System.Windows.Forms.Button buttonDockWarship;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button ButtonUndock;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox groupBoxSort;
        private System.Windows.Forms.Button buttonSortShip;
        private System.Windows.Forms.Button buttonSortWarship;
    }
}