namespace TTBHuyenB2
{
    partial class Bai4
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
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.btTotal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDiv = new System.Windows.Forms.RadioButton();
            this.rdMod = new System.Windows.Forms.RadioButton();
            this.rdMul = new System.Windows.Forms.RadioButton();
            this.rdSub = new System.Windows.Forms.RadioButton();
            this.rdAdd = new System.Windows.Forms.RadioButton();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbKq = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÁC PHÉP TÍNH ĐƠN GIẢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtN1
            // 
            this.txtN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN1.Location = new System.Drawing.Point(232, 117);
            this.txtN1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(127, 30);
            this.txtN1.TabIndex = 1;
            // 
            // btTotal
            // 
            this.btTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTotal.Location = new System.Drawing.Point(151, 412);
            this.btTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btTotal.Name = "btTotal";
            this.btTotal.Size = new System.Drawing.Size(209, 68);
            this.btTotal.TabIndex = 2;
            this.btTotal.Text = "Tính";
            this.btTotal.UseVisualStyleBackColor = true;
            this.btTotal.Click += new System.EventHandler(this.btTotal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDiv);
            this.groupBox1.Controls.Add(this.rdMod);
            this.groupBox1.Controls.Add(this.rdMul);
            this.groupBox1.Controls.Add(this.rdSub);
            this.groupBox1.Controls.Add(this.rdAdd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(135, 208);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(563, 89);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép tính";
            // 
            // rbDiv
            // 
            this.rbDiv.AutoSize = true;
            this.rbDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDiv.Location = new System.Drawing.Point(357, 47);
            this.rbDiv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDiv.Name = "rbDiv";
            this.rbDiv.Size = new System.Drawing.Size(41, 33);
            this.rbDiv.TabIndex = 4;
            this.rbDiv.TabStop = true;
            this.rbDiv.Text = "/";
            this.rbDiv.UseVisualStyleBackColor = true;
            this.rbDiv.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdMod
            // 
            this.rdMod.AutoSize = true;
            this.rdMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMod.Location = new System.Drawing.Point(479, 47);
            this.rdMod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdMod.Name = "rdMod";
            this.rdMod.Size = new System.Drawing.Size(56, 33);
            this.rdMod.TabIndex = 4;
            this.rdMod.TabStop = true;
            this.rdMod.Text = "%";
            this.rdMod.UseVisualStyleBackColor = true;
            this.rdMod.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdMul
            // 
            this.rdMul.AutoSize = true;
            this.rdMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMul.Location = new System.Drawing.Point(236, 47);
            this.rdMul.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdMul.Name = "rdMul";
            this.rdMul.Size = new System.Drawing.Size(44, 33);
            this.rdMul.TabIndex = 4;
            this.rdMul.TabStop = true;
            this.rdMul.Text = "*";
            this.rdMul.UseVisualStyleBackColor = true;
            this.rdMul.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdSub
            // 
            this.rdSub.AutoSize = true;
            this.rdSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSub.Location = new System.Drawing.Point(131, 47);
            this.rdSub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdSub.Name = "rdSub";
            this.rdSub.Size = new System.Drawing.Size(42, 33);
            this.rdSub.TabIndex = 4;
            this.rdSub.TabStop = true;
            this.rdSub.Text = "-";
            this.rdSub.UseVisualStyleBackColor = true;
            this.rdSub.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdAdd
            // 
            this.rdAdd.AutoSize = true;
            this.rdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAdd.Location = new System.Drawing.Point(37, 47);
            this.rdAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdAdd.Name = "rdAdd";
            this.rdAdd.Size = new System.Drawing.Size(48, 33);
            this.rdAdd.TabIndex = 4;
            this.rdAdd.TabStop = true;
            this.rdAdd.Text = "+";
            this.rdAdd.UseVisualStyleBackColor = true;
            this.rdAdd.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtN2
            // 
            this.txtN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN2.Location = new System.Drawing.Point(595, 117);
            this.txtN2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(127, 30);
            this.txtN2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số Thứ 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số Thứ 2:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(469, 412);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbKq
            // 
            this.lbKq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbKq.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKq.Location = new System.Drawing.Point(175, 326);
            this.lbKq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKq.Name = "lbKq";
            this.lbKq.Size = new System.Drawing.Size(547, 45);
            this.lbKq.TabIndex = 0;
            this.lbKq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 860);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btTotal);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.lbKq);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Bai4";
            this.Text = "Bai4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Button btTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdAdd;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbDiv;
        private System.Windows.Forms.RadioButton rdMod;
        private System.Windows.Forms.RadioButton rdMul;
        private System.Windows.Forms.RadioButton rdSub;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbKq;
    }
}