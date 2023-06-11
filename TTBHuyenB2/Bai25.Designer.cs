namespace TTBHuyenB2
{
    partial class Bai25
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
            this.treefolder = new System.Windows.Forms.TreeView();
            this.picview = new System.Windows.Forms.PictureBox();
            this.flowThum = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picview)).BeginInit();
            this.SuspendLayout();
            // 
            // treefolder
            // 
            this.treefolder.Location = new System.Drawing.Point(10, 7);
            this.treefolder.Name = "treefolder";
            this.treefolder.Size = new System.Drawing.Size(354, 647);
            this.treefolder.TabIndex = 0;
            this.treefolder.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treefolder_BeforeExpand);
            this.treefolder.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treefolder_AfterSelect);
            // 
            // picview
            // 
            this.picview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picview.Location = new System.Drawing.Point(370, 12);
            this.picview.Name = "picview";
            this.picview.Size = new System.Drawing.Size(450, 311);
            this.picview.TabIndex = 1;
            this.picview.TabStop = false;
            this.picview.Click += new System.EventHandler(this.Pic_Click);
            // 
            // flowThum
            // 
            this.flowThum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowThum.Location = new System.Drawing.Point(370, 335);
            this.flowThum.Name = "flowThum";
            this.flowThum.Size = new System.Drawing.Size(450, 309);
            this.flowThum.TabIndex = 2;
            // 
            // Bai25
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 656);
            this.Controls.Add(this.flowThum);
            this.Controls.Add(this.picview);
            this.Controls.Add(this.treefolder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Bai25";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai25";
            this.Load += new System.EventHandler(this.Bai25_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picview)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.TreeView treefolder;
        private System.Windows.Forms.PictureBox picview;
        private System.Windows.Forms.FlowLayoutPanel flowThum;
    
    }
}