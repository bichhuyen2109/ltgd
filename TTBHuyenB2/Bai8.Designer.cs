using System;

namespace TTBHuyenB2
{
    partial class Bai8
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.btThang = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(41, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Security code";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(227, 62);
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '*';
            this.txtCode.Size = new System.Drawing.Size(248, 30);
            this.txtCode.TabIndex = 1;
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.LightGreen;
            this.bt1.ForeColor = System.Drawing.Color.Black;
            this.bt1.Location = new System.Drawing.Point(125, 120);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(57, 47);
            this.bt1.TabIndex = 2;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.Color.LightGreen;
            this.bt2.ForeColor = System.Drawing.Color.Black;
            this.bt2.Location = new System.Drawing.Point(198, 120);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(57, 47);
            this.bt2.TabIndex = 2;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.Color.LightGreen;
            this.bt3.ForeColor = System.Drawing.Color.Black;
            this.bt3.Location = new System.Drawing.Point(271, 120);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(57, 47);
            this.bt3.TabIndex = 2;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.bt1_Click);
            // 
            // btC
            // 
            this.btC.BackColor = System.Drawing.Color.Gold;
            this.btC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btC.ForeColor = System.Drawing.Color.LimeGreen;
            this.btC.Location = new System.Drawing.Point(344, 120);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(57, 47);
            this.btC.TabIndex = 2;
            this.btC.Text = "C";
            this.btC.UseVisualStyleBackColor = false;
            this.btC.Click += new System.EventHandler(this.btC_Click);
            // 
            // bt7
            // 
            this.bt7.BackColor = System.Drawing.Color.LightGreen;
            this.bt7.ForeColor = System.Drawing.Color.Black;
            this.bt7.Location = new System.Drawing.Point(125, 226);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(57, 47);
            this.bt7.TabIndex = 2;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = false;
            this.bt7.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt8
            // 
            this.bt8.BackColor = System.Drawing.Color.LightGreen;
            this.bt8.ForeColor = System.Drawing.Color.Black;
            this.bt8.Location = new System.Drawing.Point(198, 226);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(57, 47);
            this.bt8.TabIndex = 2;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = false;
            this.bt8.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt9
            // 
            this.bt9.BackColor = System.Drawing.Color.LightGreen;
            this.bt9.ForeColor = System.Drawing.Color.Black;
            this.bt9.Location = new System.Drawing.Point(271, 226);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(57, 47);
            this.bt9.TabIndex = 2;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = false;
            this.bt9.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt0
            // 
            this.bt0.AccessibleDescription = "";
            this.bt0.BackColor = System.Drawing.Color.LightGreen;
            this.bt0.ForeColor = System.Drawing.Color.Black;
            this.bt0.Location = new System.Drawing.Point(344, 226);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(57, 47);
            this.bt0.TabIndex = 2;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = false;
            this.bt0.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.Color.LightGreen;
            this.bt4.ForeColor = System.Drawing.Color.Black;
            this.bt4.Location = new System.Drawing.Point(125, 173);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(57, 47);
            this.bt4.TabIndex = 2;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.Color.LightGreen;
            this.bt5.ForeColor = System.Drawing.Color.Black;
            this.bt5.Location = new System.Drawing.Point(198, 173);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(57, 47);
            this.bt5.TabIndex = 2;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt6
            // 
            this.bt6.BackColor = System.Drawing.Color.LightGreen;
            this.bt6.ForeColor = System.Drawing.Color.Black;
            this.bt6.Location = new System.Drawing.Point(271, 173);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(57, 47);
            this.bt6.TabIndex = 2;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = false;
            this.bt6.Click += new System.EventHandler(this.bt1_Click);
            // 
            // btThang
            // 
            this.btThang.BackColor = System.Drawing.Color.Cornsilk;
            this.btThang.ForeColor = System.Drawing.Color.MediumPurple;
            this.btThang.Location = new System.Drawing.Point(344, 173);
            this.btThang.Name = "btThang";
            this.btThang.Size = new System.Drawing.Size(57, 47);
            this.btThang.TabIndex = 2;
            this.btThang.Text = "#";
            this.btThang.UseVisualStyleBackColor = false;
            this.btThang.Click += new System.EventHandler(this.btThang_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Access log:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Pink;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(404, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Save";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 25;
            this.listbox.Location = new System.Drawing.Point(30, 360);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(444, 229);
            this.listbox.TabIndex = 3;
            // 
            // Bai8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 703);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.btThang);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.btC);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Bai8";
            this.Text = "Security code";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button btThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listbox;

        public EventHandler Bai8_Load { get; private set; }
    }
}