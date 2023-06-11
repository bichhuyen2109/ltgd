namespace TTBHuyenB2
{
    partial class Bai2
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
            this.btTong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.btHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btTong
            // 
            this.btTong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btTong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btTong.Location = new System.Drawing.Point(117, 329);
            this.btTong.Name = "btTong";
            this.btTong.Size = new System.Drawing.Size(171, 49);
            this.btTong.TabIndex = 0;
            this.btTong.Text = "Tính Tổng";
            this.btTong.UseVisualStyleBackColor = false;
            this.btTong.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(111, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập N:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(267, 82);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(191, 38);
            this.txtN.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(111, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(267, 158);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(191, 38);
            this.txtTong.TabIndex = 2;
            // 
            // btHuy
            // 
            this.btHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btHuy.Location = new System.Drawing.Point(329, 329);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(171, 49);
            this.btHuy.TabIndex = 0;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = false;
            this.btHuy.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 446);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btTong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Green;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bai2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Button btHuy;
    }
}