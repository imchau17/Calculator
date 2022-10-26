
namespace Calculator
{
    partial class Form1
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
            this.lbSoA = new System.Windows.Forms.Label();
            this.lbKq = new System.Windows.Forms.Label();
            this.lbSoB = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.btCong = new System.Windows.Forms.Button();
            this.btTru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSoA
            // 
            this.lbSoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoA.Location = new System.Drawing.Point(30, 41);
            this.lbSoA.Name = "lbSoA";
            this.lbSoA.Size = new System.Drawing.Size(87, 42);
            this.lbSoA.TabIndex = 0;
            this.lbSoA.Text = "Số a";
            this.lbSoA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbKq
            // 
            this.lbKq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKq.Location = new System.Drawing.Point(30, 148);
            this.lbKq.Name = "lbKq";
            this.lbKq.Size = new System.Drawing.Size(87, 42);
            this.lbKq.TabIndex = 1;
            this.lbKq.Text = "Kết quả";
            this.lbKq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSoB
            // 
            this.lbSoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoB.Location = new System.Drawing.Point(30, 93);
            this.lbSoB.Name = "lbSoB";
            this.lbSoB.Size = new System.Drawing.Size(87, 42);
            this.lbSoB.TabIndex = 2;
            this.lbSoB.Text = "Số b";
            this.lbSoB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(123, 46);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(239, 30);
            this.txtA.TabIndex = 3;
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(123, 98);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(239, 30);
            this.txtB.TabIndex = 3;
            // 
            // txtKq
            // 
            this.txtKq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKq.Location = new System.Drawing.Point(123, 153);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(239, 30);
            this.txtKq.TabIndex = 3;
            // 
            // btCong
            // 
            this.btCong.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btCong.Location = new System.Drawing.Point(272, 213);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(90, 35);
            this.btCong.TabIndex = 4;
            this.btCong.Text = "Cộng";
            this.btCong.UseVisualStyleBackColor = false;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // btTru
            // 
            this.btTru.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btTru.Location = new System.Drawing.Point(163, 213);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(91, 35);
            this.btTru.TabIndex = 5;
            this.btTru.Text = "Trừ";
            this.btTru.UseVisualStyleBackColor = false;
            this.btTru.Click += new System.EventHandler(this.btTru_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 276);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lbSoB);
            this.Controls.Add(this.lbKq);
            this.Controls.Add(this.lbSoA);
            this.Name = "Form1";
            this.Text = "Tính toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSoA;
        private System.Windows.Forms.Label lbKq;
        private System.Windows.Forms.Label lbSoB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btTru;
    }
}

