namespace Asteroids
{
    partial class StartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.startButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.asteroidPNGBox = new System.Windows.Forms.PictureBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.optionsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.asteroidPNGBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.startButton.Font = new System.Drawing.Font("Impact", 14F);
            this.startButton.Location = new System.Drawing.Point(175, 248);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(150, 64);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            this.startButton.Enter += new System.EventHandler(this.startButton_Enter);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Magneto", 32F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.Maroon;
            this.titleLabel.Location = new System.Drawing.Point(125, 193);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(259, 52);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Asteroids";
            // 
            // asteroidPNGBox
            // 
            this.asteroidPNGBox.Image = ((System.Drawing.Image)(resources.GetObject("asteroidPNGBox.Image")));
            this.asteroidPNGBox.Location = new System.Drawing.Point(175, 37);
            this.asteroidPNGBox.Name = "asteroidPNGBox";
            this.asteroidPNGBox.Size = new System.Drawing.Size(150, 153);
            this.asteroidPNGBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.asteroidPNGBox.TabIndex = 3;
            this.asteroidPNGBox.TabStop = false;
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.instructionLabel.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.instructionLabel.Location = new System.Drawing.Point(110, 367);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(280, 34);
            this.instructionLabel.TabIndex = 4;
            this.instructionLabel.Text = "SPACE - Rotate, C - Shoot";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.countLabel.Location = new System.Drawing.Point(233, 401);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(0, 48);
            this.countLabel.TabIndex = 5;
            // 
            // optionsButton
            // 
            this.optionsButton.Font = new System.Drawing.Font("Impact", 14F);
            this.optionsButton.Location = new System.Drawing.Point(175, 318);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(150, 46);
            this.optionsButton.TabIndex = 6;
            this.optionsButton.Text = "Options";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            this.optionsButton.Enter += new System.EventHandler(this.optionsButton_Enter);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.asteroidPNGBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.startButton);
            this.Name = "StartScreen";
            this.Size = new System.Drawing.Size(500, 500);
            ((System.ComponentModel.ISupportInitialize)(this.asteroidPNGBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox asteroidPNGBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button optionsButton;
    }
}
