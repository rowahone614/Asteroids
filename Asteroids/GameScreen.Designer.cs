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
            this.countDownLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameLoop
            // 
            this.gameLoop.Interval = 20;
            this.gameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
            // 
            // countDownLabel
            // 
            this.countDownLabel.BackColor = System.Drawing.Color.Transparent;
            this.countDownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold);
            this.countDownLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.countDownLabel.Location = new System.Drawing.Point(212, 118);
            this.countDownLabel.Name = "countDownLabel";
            this.countDownLabel.Size = new System.Drawing.Size(76, 76);
            this.countDownLabel.TabIndex = 0;
            this.countDownLabel.Text = "3";
            this.countDownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.countDownLabel);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(500, 500);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameLoop;
        private System.Windows.Forms.Label countDownLabel;
    }
}
