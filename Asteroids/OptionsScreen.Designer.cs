namespace Asteroids
{
    partial class OptionsScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.optionsTitleLabel = new System.Windows.Forms.Label();
            this.lazerColourLabel = new System.Windows.Forms.Label();
            this.asteroidColourLabel = new System.Windows.Forms.Label();
            this.shipColourLabel = new System.Windows.Forms.Label();
            this.lazerColourValue = new System.Windows.Forms.NumericUpDown();
            this.asteroidColourValue = new System.Windows.Forms.NumericUpDown();
            this.shipColourValue = new System.Windows.Forms.NumericUpDown();
            this.colourValueLabel = new System.Windows.Forms.Label();
            this.returnMenuButton = new System.Windows.Forms.Button();
            this.startLevelLabel = new System.Windows.Forms.Label();
            this.startLevelValue = new System.Windows.Forms.NumericUpDown();
            this.setSoundLabel = new System.Windows.Forms.Label();
            this.soundChoiceBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.lazerColourValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroidColourValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipColourValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startLevelValue)).BeginInit();
            this.SuspendLayout();
            // 
            // optionsTitleLabel
            // 
            this.optionsTitleLabel.AutoSize = true;
            this.optionsTitleLabel.Font = new System.Drawing.Font("Magneto", 25F);
            this.optionsTitleLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.optionsTitleLabel.Location = new System.Drawing.Point(170, 29);
            this.optionsTitleLabel.Name = "optionsTitleLabel";
            this.optionsTitleLabel.Size = new System.Drawing.Size(161, 41);
            this.optionsTitleLabel.TabIndex = 0;
            this.optionsTitleLabel.Text = "Options";
            // 
            // lazerColourLabel
            // 
            this.lazerColourLabel.AutoSize = true;
            this.lazerColourLabel.Font = new System.Drawing.Font("Impact", 15F);
            this.lazerColourLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lazerColourLabel.Location = new System.Drawing.Point(57, 142);
            this.lazerColourLabel.Name = "lazerColourLabel";
            this.lazerColourLabel.Size = new System.Drawing.Size(115, 25);
            this.lazerColourLabel.TabIndex = 1;
            this.lazerColourLabel.Text = "Lazer Colour:";
            // 
            // asteroidColourLabel
            // 
            this.asteroidColourLabel.AutoSize = true;
            this.asteroidColourLabel.Font = new System.Drawing.Font("Impact", 15F);
            this.asteroidColourLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.asteroidColourLabel.Location = new System.Drawing.Point(57, 213);
            this.asteroidColourLabel.Name = "asteroidColourLabel";
            this.asteroidColourLabel.Size = new System.Drawing.Size(140, 25);
            this.asteroidColourLabel.TabIndex = 2;
            this.asteroidColourLabel.Text = "Asteroid Colour:";
            // 
            // shipColourLabel
            // 
            this.shipColourLabel.AutoSize = true;
            this.shipColourLabel.Font = new System.Drawing.Font("Impact", 15F);
            this.shipColourLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shipColourLabel.Location = new System.Drawing.Point(57, 284);
            this.shipColourLabel.Name = "shipColourLabel";
            this.shipColourLabel.Size = new System.Drawing.Size(108, 25);
            this.shipColourLabel.TabIndex = 3;
            this.shipColourLabel.Text = "Ship Colour:";
            // 
            // lazerColourValue
            // 
            this.lazerColourValue.Location = new System.Drawing.Point(177, 147);
            this.lazerColourValue.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.lazerColourValue.Name = "lazerColourValue";
            this.lazerColourValue.Size = new System.Drawing.Size(33, 20);
            this.lazerColourValue.TabIndex = 4;
            // 
            // asteroidColourValue
            // 
            this.asteroidColourValue.Location = new System.Drawing.Point(199, 218);
            this.asteroidColourValue.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.asteroidColourValue.Name = "asteroidColourValue";
            this.asteroidColourValue.Size = new System.Drawing.Size(33, 20);
            this.asteroidColourValue.TabIndex = 5;
            // 
            // shipColourValue
            // 
            this.shipColourValue.Location = new System.Drawing.Point(171, 289);
            this.shipColourValue.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.shipColourValue.Name = "shipColourValue";
            this.shipColourValue.Size = new System.Drawing.Size(33, 20);
            this.shipColourValue.TabIndex = 6;
            // 
            // colourValueLabel
            // 
            this.colourValueLabel.AutoSize = true;
            this.colourValueLabel.Font = new System.Drawing.Font("Impact", 15F);
            this.colourValueLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.colourValueLabel.Location = new System.Drawing.Point(103, 86);
            this.colourValueLabel.Name = "colourValueLabel";
            this.colourValueLabel.Size = new System.Drawing.Size(295, 25);
            this.colourValueLabel.TabIndex = 7;
            this.colourValueLabel.Text = "Red - 0, Blue - 1, Green - 2, Yellow - 3";
            // 
            // returnMenuButton
            // 
            this.returnMenuButton.Font = new System.Drawing.Font("Impact", 15F);
            this.returnMenuButton.Location = new System.Drawing.Point(177, 369);
            this.returnMenuButton.Name = "returnMenuButton";
            this.returnMenuButton.Size = new System.Drawing.Size(154, 58);
            this.returnMenuButton.TabIndex = 8;
            this.returnMenuButton.Text = "Main Menu";
            this.returnMenuButton.UseVisualStyleBackColor = true;
            this.returnMenuButton.Click += new System.EventHandler(this.returnMenuButton_Click);
            // 
            // startLevelLabel
            // 
            this.startLevelLabel.AutoSize = true;
            this.startLevelLabel.Font = new System.Drawing.Font("Impact", 15F);
            this.startLevelLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startLevelLabel.Location = new System.Drawing.Point(257, 142);
            this.startLevelLabel.Name = "startLevelLabel";
            this.startLevelLabel.Size = new System.Drawing.Size(126, 25);
            this.startLevelLabel.TabIndex = 9;
            this.startLevelLabel.Text = "Starting Level:";
            // 
            // startLevelValue
            // 
            this.startLevelValue.Location = new System.Drawing.Point(389, 147);
            this.startLevelValue.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.startLevelValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startLevelValue.Name = "startLevelValue";
            this.startLevelValue.Size = new System.Drawing.Size(33, 20);
            this.startLevelValue.TabIndex = 10;
            this.startLevelValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // setSoundLabel
            // 
            this.setSoundLabel.AutoSize = true;
            this.setSoundLabel.Font = new System.Drawing.Font("Impact", 15F);
            this.setSoundLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.setSoundLabel.Location = new System.Drawing.Point(257, 213);
            this.setSoundLabel.Name = "setSoundLabel";
            this.setSoundLabel.Size = new System.Drawing.Size(125, 25);
            this.setSoundLabel.TabIndex = 11;
            this.setSoundLabel.Text = "Sound Effects:";
            // 
            // soundChoiceBox
            // 
            this.soundChoiceBox.AutoSize = true;
            this.soundChoiceBox.Checked = true;
            this.soundChoiceBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.soundChoiceBox.Location = new System.Drawing.Point(387, 220);
            this.soundChoiceBox.Name = "soundChoiceBox";
            this.soundChoiceBox.Size = new System.Drawing.Size(15, 14);
            this.soundChoiceBox.TabIndex = 12;
            this.soundChoiceBox.UseVisualStyleBackColor = true;
            // 
            // OptionsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.soundChoiceBox);
            this.Controls.Add(this.setSoundLabel);
            this.Controls.Add(this.startLevelValue);
            this.Controls.Add(this.startLevelLabel);
            this.Controls.Add(this.returnMenuButton);
            this.Controls.Add(this.colourValueLabel);
            this.Controls.Add(this.shipColourValue);
            this.Controls.Add(this.asteroidColourValue);
            this.Controls.Add(this.lazerColourValue);
            this.Controls.Add(this.shipColourLabel);
            this.Controls.Add(this.asteroidColourLabel);
            this.Controls.Add(this.lazerColourLabel);
            this.Controls.Add(this.optionsTitleLabel);
            this.Name = "OptionsScreen";
            this.Size = new System.Drawing.Size(500, 500);
            ((System.ComponentModel.ISupportInitialize)(this.lazerColourValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroidColourValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipColourValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startLevelValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label optionsTitleLabel;
        private System.Windows.Forms.Label lazerColourLabel;
        private System.Windows.Forms.Label asteroidColourLabel;
        private System.Windows.Forms.Label shipColourLabel;
        private System.Windows.Forms.NumericUpDown lazerColourValue;
        private System.Windows.Forms.NumericUpDown asteroidColourValue;
        private System.Windows.Forms.NumericUpDown shipColourValue;
        private System.Windows.Forms.Label colourValueLabel;
        private System.Windows.Forms.Button returnMenuButton;
        private System.Windows.Forms.Label startLevelLabel;
        private System.Windows.Forms.NumericUpDown startLevelValue;
        private System.Windows.Forms.Label setSoundLabel;
        private System.Windows.Forms.CheckBox soundChoiceBox;
    }
}
