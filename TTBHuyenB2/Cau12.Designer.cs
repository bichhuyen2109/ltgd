namespace TTBHuyenB2
{
    partial class Cau12
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
            this.components = new System.ComponentModel.Container();
            this.PicBall = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicBall)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBall
            // 
            this.PicBall.Image = global::TTBHuyenB2.Properties.Resources.ball;
            this.PicBall.Location = new System.Drawing.Point(494, 162);
            this.PicBall.Margin = new System.Windows.Forms.Padding(4);
            this.PicBall.Name = "PicBall";
            this.PicBall.Size = new System.Drawing.Size(199, 174);
            this.PicBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBall.TabIndex = 0;
            this.PicBall.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Cau12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 703);
            this.Controls.Add(this.PicBall);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cau12";
            this.Text = "Cau12";
            this.Load += new System.EventHandler(this.Cau12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBall;
        private System.Windows.Forms.Timer timer1;
    }
}