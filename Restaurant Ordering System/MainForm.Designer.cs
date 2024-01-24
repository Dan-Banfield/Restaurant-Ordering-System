namespace Restaurant_Ordering_System
{
    partial class MainForm
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
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.selectStarterComboBox = new System.Windows.Forms.ComboBox();
            this.selectMainComboBox = new System.Windows.Forms.ComboBox();
            this.selectSideComboBox = new System.Windows.Forms.ComboBox();
            this.selectDrinkComboBox = new System.Windows.Forms.ComboBox();
            this.starterQuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.mainQuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sideQuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.drinkQuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.calculateTotalButton = new System.Windows.Forms.Button();
            this.resetOrderButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starterQuantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainQuantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideQuantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkQuantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::Restaurant_Ordering_System.Properties.Resources.nandos_logo;
            this.logoPictureBox.Location = new System.Drawing.Point(315, 16);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(287, 81);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // selectStarterComboBox
            // 
            this.selectStarterComboBox.FormattingEnabled = true;
            this.selectStarterComboBox.Location = new System.Drawing.Point(42, 143);
            this.selectStarterComboBox.Name = "selectStarterComboBox";
            this.selectStarterComboBox.Size = new System.Drawing.Size(263, 45);
            this.selectStarterComboBox.TabIndex = 2;
            this.selectStarterComboBox.TabStop = false;
            this.selectStarterComboBox.Text = "Select Starter";
            // 
            // selectMainComboBox
            // 
            this.selectMainComboBox.FormattingEnabled = true;
            this.selectMainComboBox.Location = new System.Drawing.Point(42, 203);
            this.selectMainComboBox.Name = "selectMainComboBox";
            this.selectMainComboBox.Size = new System.Drawing.Size(263, 45);
            this.selectMainComboBox.TabIndex = 3;
            this.selectMainComboBox.TabStop = false;
            this.selectMainComboBox.Text = "Select Main";
            // 
            // selectSideComboBox
            // 
            this.selectSideComboBox.FormattingEnabled = true;
            this.selectSideComboBox.Location = new System.Drawing.Point(42, 263);
            this.selectSideComboBox.Name = "selectSideComboBox";
            this.selectSideComboBox.Size = new System.Drawing.Size(263, 45);
            this.selectSideComboBox.TabIndex = 4;
            this.selectSideComboBox.TabStop = false;
            this.selectSideComboBox.Text = "Select Side";
            // 
            // selectDrinkComboBox
            // 
            this.selectDrinkComboBox.FormattingEnabled = true;
            this.selectDrinkComboBox.Location = new System.Drawing.Point(42, 323);
            this.selectDrinkComboBox.Name = "selectDrinkComboBox";
            this.selectDrinkComboBox.Size = new System.Drawing.Size(263, 45);
            this.selectDrinkComboBox.TabIndex = 5;
            this.selectDrinkComboBox.TabStop = false;
            this.selectDrinkComboBox.Text = "Select Drink";
            // 
            // starterQuantityNumericUpDown
            // 
            this.starterQuantityNumericUpDown.Location = new System.Drawing.Point(342, 144);
            this.starterQuantityNumericUpDown.Name = "starterQuantityNumericUpDown";
            this.starterQuantityNumericUpDown.Size = new System.Drawing.Size(120, 43);
            this.starterQuantityNumericUpDown.TabIndex = 6;
            this.starterQuantityNumericUpDown.TabStop = false;
            // 
            // mainQuantityNumericUpDown
            // 
            this.mainQuantityNumericUpDown.Location = new System.Drawing.Point(342, 205);
            this.mainQuantityNumericUpDown.Name = "mainQuantityNumericUpDown";
            this.mainQuantityNumericUpDown.Size = new System.Drawing.Size(120, 43);
            this.mainQuantityNumericUpDown.TabIndex = 7;
            this.mainQuantityNumericUpDown.TabStop = false;
            // 
            // sideQuantityNumericUpDown
            // 
            this.sideQuantityNumericUpDown.Location = new System.Drawing.Point(342, 264);
            this.sideQuantityNumericUpDown.Name = "sideQuantityNumericUpDown";
            this.sideQuantityNumericUpDown.Size = new System.Drawing.Size(120, 43);
            this.sideQuantityNumericUpDown.TabIndex = 8;
            this.sideQuantityNumericUpDown.TabStop = false;
            // 
            // drinkQuantityNumericUpDown
            // 
            this.drinkQuantityNumericUpDown.Location = new System.Drawing.Point(342, 324);
            this.drinkQuantityNumericUpDown.Name = "drinkQuantityNumericUpDown";
            this.drinkQuantityNumericUpDown.Size = new System.Drawing.Size(120, 43);
            this.drinkQuantityNumericUpDown.TabIndex = 9;
            this.drinkQuantityNumericUpDown.TabStop = false;
            // 
            // calculateTotalButton
            // 
            this.calculateTotalButton.BackColor = System.Drawing.Color.Crimson;
            this.calculateTotalButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateTotalButton.ForeColor = System.Drawing.Color.White;
            this.calculateTotalButton.Location = new System.Drawing.Point(534, 178);
            this.calculateTotalButton.Name = "calculateTotalButton";
            this.calculateTotalButton.Size = new System.Drawing.Size(163, 92);
            this.calculateTotalButton.TabIndex = 10;
            this.calculateTotalButton.TabStop = false;
            this.calculateTotalButton.Text = "Calculate Total";
            this.calculateTotalButton.UseVisualStyleBackColor = false;
            this.calculateTotalButton.Click += new System.EventHandler(this.calculateTotalButton_Click);
            // 
            // resetOrderButton
            // 
            this.resetOrderButton.BackColor = System.Drawing.Color.Crimson;
            this.resetOrderButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetOrderButton.ForeColor = System.Drawing.Color.White;
            this.resetOrderButton.Location = new System.Drawing.Point(703, 178);
            this.resetOrderButton.Name = "resetOrderButton";
            this.resetOrderButton.Size = new System.Drawing.Size(163, 92);
            this.resetOrderButton.TabIndex = 11;
            this.resetOrderButton.TabStop = false;
            this.resetOrderButton.Text = "Reset Order";
            this.resetOrderButton.UseVisualStyleBackColor = false;
            this.resetOrderButton.Click += new System.EventHandler(this.resetOrderButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Crimson;
            this.quitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.ForeColor = System.Drawing.Color.White;
            this.quitButton.Location = new System.Drawing.Point(703, 276);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(163, 92);
            this.quitButton.TabIndex = 13;
            this.quitButton.TabStop = false;
            this.quitButton.Text = "QUIT";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(917, 510);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.resetOrderButton);
            this.Controls.Add(this.calculateTotalButton);
            this.Controls.Add(this.drinkQuantityNumericUpDown);
            this.Controls.Add(this.sideQuantityNumericUpDown);
            this.Controls.Add(this.mainQuantityNumericUpDown);
            this.Controls.Add(this.starterQuantityNumericUpDown);
            this.Controls.Add(this.selectDrinkComboBox);
            this.Controls.Add(this.selectSideComboBox);
            this.Controls.Add(this.selectMainComboBox);
            this.Controls.Add(this.selectStarterComboBox);
            this.Controls.Add(this.logoPictureBox);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Ordering System";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starterQuantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainQuantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideQuantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkQuantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.ComboBox selectStarterComboBox;
        private System.Windows.Forms.ComboBox selectMainComboBox;
        private System.Windows.Forms.ComboBox selectSideComboBox;
        private System.Windows.Forms.ComboBox selectDrinkComboBox;
        private System.Windows.Forms.NumericUpDown starterQuantityNumericUpDown;
        private System.Windows.Forms.NumericUpDown mainQuantityNumericUpDown;
        private System.Windows.Forms.NumericUpDown sideQuantityNumericUpDown;
        private System.Windows.Forms.NumericUpDown drinkQuantityNumericUpDown;
        private System.Windows.Forms.Button calculateTotalButton;
        private System.Windows.Forms.Button resetOrderButton;
        private System.Windows.Forms.Button quitButton;
    }
}

