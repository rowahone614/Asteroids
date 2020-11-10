namespace Asteroids
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            this.gameLoop = new System.Windows.Forms.Timer(this.components);
            this.levelLabel = new System.Windows.Forms.Label();
            this.levelUpLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameLoop
            // 
            this.gameLoop.Interval = 20;
            this.gameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Impact", 15F);
            this.levelLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.levelLabel.Location = new System.Drawing.Point(26, 25);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(62, 25);
            this.levelLabel.TabIndex = 0;
            this.levelLabel.Text = "Level :";
            // 
            // levelUpLabel
            // 
            this.levelUpLabel.AccessibleDescription = "Label";
            this.levelUpLabel.AutoSize = true;
            this.levelUpLabel.BackColor = System.Drawing.Color.Transparent;
            this.levelUpLabel.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelUpLabel.ForeColor = System.Drawing.Color.Lime;
            this.levelUpLabel.Location = new System.Drawing.Point(173, 78);
            this.levelUpLabel.Name = "levelUpLabel";
            this.levelUpLabel.Size = new System.Drawing.Size(154, 45);
            this.levelUpLabel.TabIndex = 1;
            this.levelUpLabel.Text = "Level Up!";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Impact", 15F);
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.scoreLabel.Location = new System.Drawing.Point(26, 59);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(67, 25);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "Score :";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.levelUpLabel);
            this.Controls.Add(this.levelLabel);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(500, 500);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameLoop;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label levelUpLabel;
        private System.Windows.Forms.Label scoreLabel;
    }
}
